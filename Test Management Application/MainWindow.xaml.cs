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

namespace Test_Management_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LecturerPage lecturePage;
        StudentPage studentPage;
        public MainWindow()
        {
            InitializeComponent();

            //Creating a Lecture page instance and the student page
            lecturePage = new LecturerPage();
            studentPage = new StudentPage();
            
        }

        private void MenuItem_LecturerPort_Click(object sender, RoutedEventArgs e)
        {
            main_Frame.Content = lecturePage;
        }

        private void Menu_StudentPort_Click(object sender, RoutedEventArgs e)
        {
            main_Frame.Content = studentPage;
        }
    }
}
