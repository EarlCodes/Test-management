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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void BtnTakeTest_Click(object sender, RoutedEventArgs e)
        {
            //Setting the view marks and  view memo grids to collapsed
            view_Marks_Grid.Visibility = Visibility.Collapsed;
            view_Memo_Grid.Visibility = Visibility.Collapsed;


            //Setting the test grid property value to visibile 
            take_Test_Grid.Visibility = Visibility.Visible;
            
            
        }

        private void BtnViewMarks_Click(object sender, RoutedEventArgs e)
        {
            //Setting the Take test and view memo grids to collapsed
            //before displaying the View marks grid
            take_Test_Grid.Visibility = Visibility.Collapsed;
            view_Memo_Grid.Visibility = Visibility.Collapsed;


            //Setting the view marks grid property value to visibile 
            view_Marks_Grid.Visibility = Visibility.Visible;
         
        }

        private void BtnViewMemo_Click(object sender, RoutedEventArgs e)
        {
            //Setting the view marks and  take test grids to collapsed
            view_Marks_Grid.Visibility = Visibility.Collapsed;
            take_Test_Grid.Visibility = Visibility.Collapsed;

            //Setting the test grid property value to visibile 
            view_Memo_Grid.Visibility = Visibility.Visible;
        }
    }
}
