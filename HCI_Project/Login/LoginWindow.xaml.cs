using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace HCI_Project
{
    //brisanje tipa -> treba ponuditi da obrise sve landmarkove, preveze na neki drugi tip, rucno ispravi, obrise
    //dodaj combo box u search
    //pretraga po numerickom polju (<50,>50,==,!=)
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    /// 

    public partial class LoginWindow : Window, INotifyPropertyChanged
    {
        private LoginModel model;

        private bool doNotShow = false;

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (!value.Equals( _username))
                {
                    _username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!value.Equals(_password))
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }


        public LoginWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            model = new LoginModel();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow sw = new SignInWindow(model);
            doNotShow = true;
            sw.Show();
            this.Close();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (model.checkLoginData(UN_Field_LW.Text, PS_Field_LW.Password))
            {
                User u = model.getUser(UN_Field_LW.Text);
                MapWindow mp = new MapWindow(u);
                doNotShow = true;
                mp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your credentials.", "Log In Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ChangeTheBloodyText(object sender, RoutedEventArgs e)
        {
            User u = null;
            if ((u = model.getUser(UN_Field_LW.Text)) != null && !PS_Field_LW.Password.Equals(""))
            {
                if (!u.EqualPassword(PS_Field_LW.Password))
                {
                    this.ErrorBlock.Text = "Please check your password.";
                }
                else
                {
                    this.ErrorBlock.Text = "";
                }
            }
            else if (PS_Field_LW.Password.Equals(""))
            {
                this.ErrorBlock.Text = "";
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!SignInWindow.shutdown)
            {
                if (!doNotShow)
                {
                    MessageBoxResult mbr = MessageBox.Show("Are you sure you want to exit?",
                        "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (mbr == MessageBoxResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        App.Current.Shutdown();
                    }
                }
            }
        }

        private void HelpCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str);
            }
        }

    }
}
