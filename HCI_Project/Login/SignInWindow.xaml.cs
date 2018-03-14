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
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    /// 
    public partial class SignInWindow : Window, INotifyPropertyChanged
    {
        private bool doNotShow = false;
        private LoginModel model;
        public static bool shutdown;

        public SignInWindow(LoginModel lm)
        {
            InitializeComponent();
            this.DataContext = this;
            shutdown = false;

            model = lm;
        }

        private string _name;
        public string Name_Username
        {
            get
            {
                return _name;
            }
            set
            {
                if (!value.Equals(_name))
                {
                    _name = value;
                    OnPropertyChanged("Name_Username");
                }
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Equals(_email))
                {
                    _email = value;
                    OnPropertyChanged("Email");
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

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            User u;
            if (!UN_Field_SW.Text.Equals("") && !EM_Field_SW.Text.Equals("") && !PS_Field_SW.Password.Equals(""))
            {
                if ((u = model.addUser(EM_Field_SW.Text, UN_Field_SW.Text, PS_Field_SW.Password)) != null)
                {
                    MessageBox.Show("Welcome, " + UN_Field_SW.Text + "!\nHave a great time!", "Welcome", MessageBoxButton.OK);
                    MapWindow mp = new MapWindow(u);

                    doNotShow = true;
                    mp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username " + UN_Field_SW.Text + " already exists.\nPlease choose different username", "Sign In Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check if you filled in all information.", "Sign In Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel creating your account?\nIf you click Yes, all created changes won't be saved.", "Cancel Sign In", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                doNotShow = true;
                this.Close();
                LoginWindow lw = new LoginWindow();
                lw.Show();
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
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
                    shutdown = true;
                    App.Current.Shutdown();
                }
            }
        }

    }
}
