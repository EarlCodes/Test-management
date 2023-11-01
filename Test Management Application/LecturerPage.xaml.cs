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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_Management_Application
{
    /// <summary>
    /// Interaction logic for LecturerPage.xaml
    /// </summary>
    public partial class LecturerPage : Page
    {
        //Declaring a dropShadow effect
        DropShadowEffect shadowEffect = new DropShadowEffect();
        int loopController = 0;
        int x = 0;

        Test test = new Test();

        public LecturerPage()
        {
            InitializeComponent();
            //Assign value to shadow Effect depth
            shadowEffect.ShadowDepth = 10;
        }

        private void BtnViewMarks_Click(object sender, RoutedEventArgs e)
        {
            //setting drop shadow effect to the viewMarks button as selected button
            btnViewMarks.Effect = shadowEffect;

            //dropping a(setting values to null)the shadow effect for other buttons
            btnSetTest.Effect = null;
            btnManageTest.Effect = null;

            //setting set test grid and manage test grid visibility to collapsed
            set_Test_Grid.Visibility = Visibility.Collapsed;
            manage_Test_Grid.Visibility = Visibility.Collapsed;

            //Setting the View_Marks grid to visible so that it can be displayed when button clicked
            view_Marks_Grid.Visibility = Visibility.Visible;

            
        }

        private void BtnSetTest_Click(object sender, RoutedEventArgs e)
        {
            //setting drop shadow effect to the viewMarks button as selected button
            btnSetTest.Effect = shadowEffect;

            //dropping (setting values to null)the shadow effect for other buttons
            btnViewMarks.Effect = null;
            btnManageTest.Effect = null;

            MessageBox.Show(messageBoxText:"Please enter the name of the test you would like to create");

            //Setting the view marks grid and the manage grid visibilty to collapsed
            view_Marks_Grid.Visibility = Visibility.Collapsed;
            manage_Test_Grid.Visibility = Visibility.Collapsed;

            //Setting the set test grid visibility to visible
            set_Test_Grid.Visibility = Visibility.Visible;
        }

        private void BtnManageTest_Click(object sender, RoutedEventArgs e)
        {
            //setting drop shadow effect to the viewMarks button as selected button
            btnManageTest.Effect = shadowEffect;

            //dropping a(setting values to null)the shadow effect for other buttons
            btnSetTest.Effect = null;
            btnSetTest.Effect = null;

            //Setting the view marks grid and set test visibilty to collapsed
            view_Marks_Grid.Visibility = Visibility.Collapsed;
            set_Test_Grid.Visibility = Visibility.Collapsed;

            //Setting the set test grid visibility to visible
            manage_Test_Grid.Visibility = Visibility.Visible;
        }

        private void BtnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            String test_Name = textTestName.Text;
            string textQuestion = this.textQuestion.Text;
            string[] possibleQ = new string[4];
              possibleQ[0] ="A."+ textPossibleA.Text;
              possibleQ[1] ="B." + textPossibleB.Text;
              possibleQ[2] ="C." + textPossibleC.Text;
              possibleQ[3] ="D." + textPossibleD.Text;
            string correctAnswer = cbCorrectAnswer.Text;
            int mark = int.Parse(textMark.Text);

            
            Question question = new Question(textQuestion ,possibleQ,correctAnswer,mark);
            test.AddQuestion(question);

            //Preview question
           
            while ( x < test.GetListSize())
            {
                /*
                question_placeholder.Text = test.getQuestions()[0].GetQuestion;
                answer_A_Placeholder.Text = test.getQuestions()[0].PossibleAnswers[0];
                answer_B_Placeholder.Text = test.getQuestions()[0].PossibleAnswers[1];
                answer_C_Placeholder.Text = test.getQuestions()[0].PossibleAnswers[2];
                answer_D_Placeholder.Text = test.getQuestions()[0].PossibleAnswers[3];
                */
                stac_p.Children.Add(Question_Stack(test.getQuestions()[loopController].GetQuestion , test.getQuestions()[loopController].PossibleAnswers,loopController));
                loopController++;
                x++;
            }
        }
        public StackPanel Question_Stack(string textQ, string[] possibleQ ,int qNum)
        {
            //Creating new stack panel to display on preview
            StackPanel qT = new StackPanel();
            TextBlock questionN = new TextBlock();
            questionN.Margin = new Thickness(15,10,0,0);
            qNum = qNum + 1;
            questionN.Text = "Question "+ qNum;

            TextBlock question = new TextBlock();
            question.Margin = new Thickness(15, 5, 0, 0);
            question.Text = textQ;
            
            TextBlock possibleQ_placeholder1 = new TextBlock();
            possibleQ_placeholder1.Margin = new Thickness(35, 5, 0, 0);
            possibleQ_placeholder1.Text = possibleQ[0];

            TextBlock possibleQ_placeholder2 = new TextBlock();
            possibleQ_placeholder2.Margin = new Thickness(35, 5, 0, 0);
            possibleQ_placeholder2.Text = possibleQ[1];

            TextBlock possibleQ_placeholder3 = new TextBlock();
            possibleQ_placeholder3.Margin = new Thickness(35, 5, 0, 0);
            possibleQ_placeholder3.Text = possibleQ[2];

            TextBlock possibleQ_placeholder4 = new TextBlock();
            possibleQ_placeholder4.Margin = new Thickness(35, 5, 0, 0);
            possibleQ_placeholder4.Text = possibleQ[3];

            qT.Children.Add(questionN);
            qT.Children.Add(question);
            qT.Children.Add(possibleQ_placeholder1);
            qT.Children.Add(possibleQ_placeholder2);
            qT.Children.Add(possibleQ_placeholder3);
            qT.Children.Add(possibleQ_placeholder4);

            return qT;
        }
    }
}
