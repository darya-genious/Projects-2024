using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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
using Path = System.IO.Path;

namespace Registration
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string log_in;
        private string pass_word;
        static string path = "C:\\Users\\AseR\\Desktop\\files\\Registration\\users.txt";
        private string[] authoPair = new string[2];
        private bool show = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            log_in=login.Text;
        }

        private void Registration()
        {
            pass_word = password.Password;
            if (!CheckPassword(pass_word))
                MessageBox.Show("Пароль должен содержать минимум 1 спец символ, заглавную букву и цифру");
            else
            {
                if (!CheckUserExists(log_in))
                    MessageBox.Show("Пользователь с таким именем уже существует");
                else
                {
                    using (StreamWriter sw = new StreamWriter(path, true)) //для автоматического закрытия потоков
                    {
                        sw.WriteLine($"{log_in}-{pass_word}");
                    }

                    MessageBox.Show("Вы успешно зарегистрированы!");
                }
            }
           
        }

        private bool CheckUserExists(string username)
        {
            bool checkExisting = false;
            string line;

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] loginPassword = line.Split('-');
                    if (username == loginPassword[0])
                    {
                        authoPair=loginPassword;
                        checkExisting = true;
                        break;
                    }
                }

                if (checkExisting)
                    return false;
                return true;
            }

        }

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            Registration();
        }
        
        private bool CheckPassword(string new_password)
        {
            string pattern = @"[!@#$%^&*(),.?:{}\|<>]";

            if (new_password.Any(char.IsUpper) && Regex.IsMatch(new_password, pattern) && new_password.Any(char.IsDigit))
                return true;
            else return false;
        }

        private void Authorization()
        {
            pass_word = password.Password;

            if (!CheckUserExists(log_in))
            {
                if (authoPair[1] == pass_word)
                    MessageBox.Show("Вы успешно вошли в систему");
                else MessageBox.Show("Пароль неверный");
            }
            else MessageBox.Show("Пользователя с таким логином не сущестсвует");
        }
        

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            Authorization();
         
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (!show)
            {
                show_password.Source =
                    new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\Registration\\close.png"));
                txtBlock.Text = password.Password;
                txtBlock.Visibility=Visibility.Visible;
                password.Visibility =Visibility.Hidden;
                show = true;
            }
            else
            {
                show_password.Source =
                    new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\Registration\\open.png"));
                password.PasswordChar = '●';
                txtBlock.Visibility = Visibility.Hidden;
                password.Visibility = Visibility.Visible;
                show = false;
            }
        }
    }
}
