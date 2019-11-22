﻿using CMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSLibrary.DataAccess
{
    public interface IDataConnection
    {
        string CheckConniction();

        void CreateActiveTerm(ActiveTermModel model);
        List<YearModel> GetYear_ALL();
        List<TermModel> GetTerm_ALL();

        void CreateAssignment(AssignmentModel model);
        List<DepartmentModel> GetDepartment_All();
        List<ActiveTermModel> GetActiveTerm_All();
        List<CourseModel> GetCourse_All();
        List<TeacherModel> GetTeacher_All();

        void CreateCourse(CourseModel model);
        void CreateCourseOutcome(CourseOutcomeModel model);
        List<EducationalYearModel> GetEducationalYear_ALL();
        void GetCourseOutcomes_ById(CourseModel model);

        void CreateDepartment(DepartmentModel model);
        void CreateDepartmentOutcome(DepartmentOutcomeModel model);
        void GetDepartmentOutcomes_ById(DepartmentModel model);

        void CreateExam(ExamModel model);
        List<ExamTypeModel> GetExamType_All();

        void CreteQuestionOutcome(QuestionOutcomeModel model);

        void CreateExamGroup(ExamGroupModel model);

        void CreateQuestion(QuestionModel model);
        void CreateResult(ResultModel model);

        StudentModel GetStudent_ByRegNo(int regNo);

        void CreateTeacher(TeacherModel model);

        List<TeacherModel> GetFullTeacher_All();
        List<AssignmentModel> GetAssignment_All();

        UserModel GetUser_ByUserName(string userName);

        AdminModel GetAdmin_ByUserId(int userId);
        TeacherModel GetTeacher_ByUserId(int userId);
        List<AssignmentModel> GetAssignment_ByTeacherId(int techerId);

        List<GroupModel> GetGroup_All();

    }
}
