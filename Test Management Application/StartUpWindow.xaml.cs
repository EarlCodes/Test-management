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

namespace Test_Management_Application
{
    /// <summary>
    /// Interaction logic for StartUpWindow.xaml
    /// </summary>
    public partial class StartUpWindow : Window
    {
        MainWindow mainWindow = new MainWindow();
        public StartUpWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            
        }

        private void BtnStudent_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.main_Frame.Content = new StudentPage();
            this.Close();
            mainWindow.ShowDialog();
            
        }

        private void BtnLecture_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.main_Frame.Content = new LecturerPage();
            this.Hide();
            mainWindow.ShowDialog();
        }
    }
}
