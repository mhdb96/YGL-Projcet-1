﻿using CMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSLibrary.Evaluation
{
    public class Evaluate
    {
        public List<StudentAnswersModel> StudentsAnswers = new List<StudentAnswersModel>();
        public List<StudentAnswersModel> StudentsAnswersWithErrors = new List<StudentAnswersModel>();

        public List<AnswerKeyModel> AnswerKeys = new List<AnswerKeyModel>();
        string StudentListPath;
        string AnswersKeyPath;
        string[] answerKeys;
        string[] results;
        public List<AnswerKeyModel> GetAnswersKeys(string answerPath)
        {
            AnswersKeyPath = answerPath;
            answerKeys = File.ReadAllLines(AnswersKeyPath, Encoding.GetEncoding("iso-8859-9"));
            foreach (string answersString in answerKeys)
            {
                AnswerKeyModel a = new AnswerKeyModel();
                a.Group.Name = answersString.Substring(0, 1);
                a.QuestionCount = answersString.Length - 1;
                a.AnswersList = answersString.Substring(1, a.QuestionCount);
                AnswerKeys.Add(a);
            }
            return AnswerKeys;
        }

        public void FixingErrors()
        {
            List<StudentAnswersModel> err = new List<StudentAnswersModel>();
            foreach(StudentAnswersModel ans in StudentsAnswersWithErrors)
            {
                StudentModel model = GlobalConfig.Connection.GetStudent_ByRegNo(ans.Student.RegNo);
                if (model == null)
                {
                    err.Add(ans);
                }
                else
                {
                    ans.Student = model;
                    StudentsAnswers.Add(ans);
                }
            }
            StudentsAnswersWithErrors = err;
        }

        public List<StudentAnswersModel> GetStudentsAnswers(string studentListPath)
        {
            StudentsAnswersWithErrors.Clear();
            StudentListPath = studentListPath;
            results = File.ReadAllLines(StudentListPath, Encoding.GetEncoding("iso-8859-9"));
            foreach (string listString in results)
            {
                StudentAnswersModel studentAnswers = new StudentAnswersModel();
                StudentModel model;
                int regNo = 0;
                if (Int32.TryParse(listString.Substring(24, 9), out regNo))
                {
                    model = GlobalConfig.Connection.GetStudent_ByRegNo(regNo);
                }
                else
                {
                    model = null;
                }
                if (model == null)
                {
                    studentAnswers.Student.FirstName = listString.Substring(0, 12);
                    studentAnswers.Student.LastName = listString.Substring(12, 12);
                    studentAnswers.Student.RegNo = regNo;
                    studentAnswers.Group.Name = listString.Substring(33, 1);
                    foreach (AnswerKeyModel answerKey in AnswerKeys)
                    {
                        if (answerKey.Group.Name == studentAnswers.Group.Name)
                        {
                            studentAnswers.AnswersList = listString.Substring(34, answerKey.QuestionCount);
                            break;
                        }
                    }
                    StudentsAnswersWithErrors.Add(studentAnswers);
                }
                else
                {
                    studentAnswers.Student = model;
                    //studentAnswers.Student.FirstName = listString.Substring(0, 12);
                    //studentAnswers.Student.LastName = listString.Substring(12, 12);
                    //studentAnswers.Student.RegNo = Int32.Parse(listString.Substring(24, 9));
                    studentAnswers.Group.Name = listString.Substring(33, 1);
                    foreach (AnswerKeyModel answerKey in AnswerKeys)
                    {
                        if (answerKey.Group.Name == studentAnswers.Group.Name)
                        {
                            studentAnswers.AnswersList = listString.Substring(34, answerKey.QuestionCount);
                            break;
                        }
                    }
                    StudentsAnswers.Add(studentAnswers);
                }
                
            }
            if(StudentsAnswersWithErrors.Count > 0)
            {
                return null;
            }
            return StudentsAnswers;
        }
        public List<StudentAnswersModel> GetRightAnswers()
        {
            int correct;
            int counter;
            foreach (StudentAnswersModel studentAnswers in StudentsAnswers)
            {
                correct = 0;
                counter = 0;
                foreach (AnswerKeyModel answerKey in AnswerKeys)
                {
                    if (studentAnswers.Group.Name == answerKey.Group.Name)
                    {
                        while (counter != answerKey.QuestionCount)
                        {
                            if (studentAnswers.AnswersList[counter].ToString() == answerKey.AnswersList.Substring(counter, 1))
                            {
                                correct++;
                            }
                            counter++;
                        }
                        break;
                    }
                }
                studentAnswers.CorrectAnswersCount = correct;
            }
            return StudentsAnswers;
        }
    }
}