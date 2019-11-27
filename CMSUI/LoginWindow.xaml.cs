﻿using CMSLibrary;
using CMSLibrary.DataAccess;
using CMSLibrary.Enums;
using CMSLibrary.Models;
using CMSUI.Panels;
using CMSUI.Requesters;
using MahApps.Metro.Controls.Dialogs;
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
using System.Windows.Shapes;
using CMSUI.LoginWindows;
using CMSUI.EvaluationWindows;

namespace CMSUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : IAdminPanelRequester, ITeacherPanelRequester
    {
        UserModel User;
        public LoginWindow()
        {
            InitializeComponent();
        }

        public AdminModel GetAdminInfo()
        {
            AdminModel model = new AdminModel();
            model = GlobalConfig.Connection.GetAdmin_ByUserId(User.Id);
            model.User = User;
            return model;
        }

        public TeacherModel GetTeacherInfo()
        {
            TeacherModel model = new TeacherModel();
            model = GlobalConfig.Connection.GetTeacher_ByUserId(User.Id);
            model.User = User;
            return model;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            errorUserName.Visibility = Visibility.Collapsed;
            errorPassword.Visibility = Visibility.Collapsed;
            User = new UserModel
            {
                UserName = usernameText.Text,
                Password = passwordText.Password
            };
            AuthenticationState authState = Login.Check(User);
            if (authState == AuthenticationState.UserNotFound)
            {
                errorUsernameText.Text = "User not found";
                errorUserName.Visibility = Visibility.Visible;
            }
            else if (authState == AuthenticationState.WrongPassword)
            {
                errorPasswordText.Text = "You've entered a wrong password";
                errorPassword.Visibility = Visibility.Visible;
            }
            else if (authState == AuthenticationState.Authenticated)
            {
                if (User.Role.Name == "Admin")
                {
                    AdminPanelWindow win = new AdminPanelWindow(this);
                    win.Show();
                    this.Close();
                } else
                {
                    TeacherPanelWindow win = new TeacherPanelWindow(this);
                    win.Show();
                    this.Close();
                }
            }
        }

        private async Task ShowProgressDialogAsync()
        {
            var mySettings = new MetroDialogSettings()
            {
                AnimateShow = false,
                AnimateHide = false,
                ColorScheme = this.MetroDialogOptions.ColorScheme,
                MaximumBodyHeight = 100
            };
            var controller = await this.ShowProgressAsync("Please wait...", "Connectting to the database", settings: mySettings);
            controller.SetIndeterminate();                        
            string errMsg =  await Task.Run(() => GlobalConfig.Connection.CheckConniction()) ;
            await Task.Delay(1000);
            await controller.CloseAsync();
            if (errMsg == "")
            {            
                await this.ShowMessageAsync("Success", "You have succesfully connected to the database.");
            }
            else
            {
                await this.ShowMessageAsync("Failure", $"A connection couldn't be established to the database. {Environment.NewLine}Error Message: {Environment.NewLine}{errMsg}",MessageDialogStyle.Affirmative,mySettings);
            }
        }

        private async void MetroWindow_ContentRendered(object sender, EventArgs e)
        {
            await ShowProgressDialogAsync();            
        }

        private void DatabaseBtn_Click(object sender, RoutedEventArgs e)
        {
            DatabaseSettingWindow win = new DatabaseSettingWindow();
            win.ShowDialog();
        }

        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            DevelopersInfoWindow win = new DevelopersInfoWindow();
            win.ShowDialog();
        }
    }
}
