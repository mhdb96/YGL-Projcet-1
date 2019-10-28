﻿using CMSLibrary;
using CMSLibrary.Models;
using CMSUI.Requesters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMSUI.UserControls
{
    /// <summary>
    /// Interaction logic for DepartmentDashboardControl.xaml
    /// </summary>
    public partial class DepartmentDashboardUserControl : UserControl, IDepartmentRequester
    {
        List<DepartmentModel> Departments;
        //List<DepartmentOutcomeModel> DepartmentOutcomes;
        public DepartmentDashboardUserControl()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            Departments = GlobalConfig.Connection.GetDepartment_All();
            depatmentsList.ItemsSource = Departments;
        }

        private void WireUpLists()
        {
            depatmentsList.ItemsSource = null;
            depatmentsList.Items.Clear();
            depatmentsList.ItemsSource = Departments;
        }

        private void DeleteDepartmentBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            DepartmentModel model = new DepartmentModel();
            model = (DepartmentModel)btn.Tag;
            // TODO - Delete the selected department
        }

        private void UpdateDepartmentBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            DepartmentModel model = new DepartmentModel();
            model = (DepartmentModel)btn.Tag;
            // TODO - Update the selected department
        }

        private void DepatmentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(depatmentsList.ItemsSource != null)
            {
                DepartmentModel model = (DepartmentModel)depatmentsList.SelectedItem;
                GlobalConfig.Connection.GetDepartmentOutcomes_ById(model);
                depatmentsList.SelectedItem = model;
                depatmentOutcomesList.ItemsSource = model.Outcomes;
            }
            
        }

        private void AddDepartmentBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateDepartmentWindow win = new CreateDepartmentWindow(this);
            win.ShowDialog();
        }

        public void DepartmentComplete(DepartmentModel model)
        {            
            Departments.Add(model);
            WireUpLists();
            depatmentsList.SelectedIndex = depatmentsList.Items.Count-1;
        }
    }
}