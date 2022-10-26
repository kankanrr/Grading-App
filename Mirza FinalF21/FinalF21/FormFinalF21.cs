using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Purposes of the project:
 *   To obtain data for application and presentation score to calculate project score and project grade and 
 *   To obtain the average project score for the data entered
 */   
namespace FinalF21
{
    public partial class FormFinalF21 : Form
    {
        public FormFinalF21()
        {
            InitializeComponent();
        }

        string cap = "Grading App";
        string line2 = "********************"; // you can use this for the second line of all the listboxes

        /* Add button: (36 points)
        *    Application score and Presentation score are entered
        *    Both scores must be numbers between 0 and 100
        *    Project score is calculated as 70% of(Application Score) and 30% of(Presentation Score)
        *    If Bonus is applied, 5% of the calculated project score is added to the project score
        *    Project grade is calculated as follows:
        *        Project Score       Project Grade
        *        < 60                  F
        *        >= 60 but< 70         D
        *        >= 70 but< 80         C
        *        >= 80 but< 90         B
        *        >= 90                 A
        *     Add the scores and grade to the output listboxes (scores are displayed to 1 decimal place)
        *     For the Bonus listbox, Y is added if bonus is applied and N otherwise
        *     After adding the information to the output listboxes, reset the input textboxes and checkbox and set focus on the application score textbox
        */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double Appinput, Presinput;

            if(double.TryParse(textBoxAppScore.Text, out Appinput))
            {

            }
            else
            {
                MessageBox.Show("Please enter a App score number.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAppScore.SelectAll();
                textBoxAppScore.Focus();
                return;
            }

            if (double.TryParse(textBoxPresentationScore.Text, out Presinput))
            {

            }
            else
            {
                MessageBox.Show("Please enter a Presentation number.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPresentationScore.SelectAll();
                textBoxPresentationScore.Focus();
                return;
            }



            if (Appinput < 0 || Appinput > 100)
            {
                MessageBox.Show("Only enter a App number ranging from 0 to 100.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAppScore.SelectAll();
                textBoxAppScore.Focus();
                return;
            }

            if (Presinput < 0 || Presinput > 100)
            {
                MessageBox.Show("Only enter a Presentation number ranging from 0 to 100.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPresentationScore.SelectAll();
                textBoxPresentationScore.Focus();
                return;
            }

            double bonusapp=.05,projscore,fprojscore;

            projscore = Appinput * .7 + (Presinput * .3);

            if(checkBoxBonus.Checked==true)
            {
                fprojscore = (projscore * bonusapp) + projscore;
            }
            else
            {
                fprojscore = projscore;
            }

            if(fprojscore <60 && checkBoxBonus.Checked==false)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("N");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("F");
            }
            else if(fprojscore < 60 && checkBoxBonus.Checked == true)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("Y");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("F");
            }
            else if(fprojscore >=60 && fprojscore <70 && checkBoxBonus.Checked==false)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("N");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("D");
            }
            else if(fprojscore >= 60 && fprojscore < 70 && checkBoxBonus.Checked == true)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("Y");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("D");
            }
            else if(fprojscore>=70 && fprojscore <80 && checkBoxBonus.Checked ==false)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("N");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("C");
            }
            else if(fprojscore >= 70 && fprojscore < 80 && checkBoxBonus.Checked == true)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("Y");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("C");
            }
            else if(fprojscore >=80 && fprojscore <90 && checkBoxBonus.Checked==false)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("N");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("B");
            }
            else if(fprojscore >= 80 && fprojscore < 90 && checkBoxBonus.Checked == true)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("Y");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("B");
            }
            else if(fprojscore>=90 && checkBoxBonus.Checked==false)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("N");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("A");
            }
            else if(fprojscore >= 90 && checkBoxBonus.Checked == true)
            {
                listBoxAppScore.Items.Add(Appinput.ToString("n1"));
                listBoxPresScore.Items.Add(Presinput.ToString("n1"));
                listBoxBonus.Items.Add("Y");
                listBoxProjectScore.Items.Add(fprojscore.ToString("n1"));
                listBoxProjectGrade.Items.Add("A");
            }

            textBoxAppScore.Clear();
            textBoxPresentationScore.Clear();
            checkBoxBonus.Checked = false;
            textBoxAppScore.Focus();

        }

        /* Get Average Score button: (24 points)
        *    Check that project score is already added to the listbox before proceeding to calculate average
        *    If the listbox has only the headings, let the user know that there is no data to analyze
        *    If there is data, get the total average score by adding all the scores and dividing by the number of scores
        *    Display the average score in a message box with the score and the number of projects in two lines as follows:
        *              Average Project Score:  XXX.XX (displayed to 2 decimal places)
        *              Number of Projects:     YY (displayed to 0 decimal places)
        */
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            if(listBoxProjectScore.Items.Count==2)
            {
                MessageBox.Show("There is no data to summarize. Please add your scores first.", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int counter = 2;
            double totalscore = listBoxProjectScore.Items.Count;
            double lastindexscore = totalscore - 1;
            double sumscore = 0, iscore = 0,avgscore=0;

            while(counter <= lastindexscore)
            {
                iscore = double.Parse(listBoxProjectScore.Items[counter].ToString());
                sumscore = iscore + sumscore;

                counter++;
            }

            double numproj = listBoxProjectScore.Items.Count - 2;

            avgscore = sumscore / numproj;

            MessageBox.Show("Average Project Score: " + avgscore.ToString("n2") + "\n\n" + "Number of Projects: " + numproj.ToString("n"), cap, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /* Reset button: (13 points)
        *     Use a messagebox to confirm that the user want to reset the form
        *     If yes,
        *       Clear the input textboxes
        *       Reset the checkbox
        *       Clear the output listboxes and add the headings to each listbox
        *       Set focus to the application textbox
        */
        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult rform = new DialogResult();

            rform = MessageBox.Show("Are you sure you want to reset the form?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(rform==DialogResult.Yes)
            {
                textBoxAppScore.Clear();
                textBoxPresentationScore.Clear();
                checkBoxBonus.Checked = false;

                listBoxAppScore.Items.Clear();
                listBoxAppScore.Items.Add("App Score");
                listBoxAppScore.Items.Add(line2);

                listBoxPresScore.Items.Clear();
                listBoxPresScore.Items.Add("Pres. Score");
                listBoxPresScore.Items.Add(line2);

                listBoxBonus.Items.Clear();
                listBoxBonus.Items.Add("Bonus");
                listBoxBonus.Items.Add(line2);

                listBoxProjectScore.Items.Clear();
                listBoxProjectScore.Items.Add("Project Score");
                listBoxProjectScore.Items.Add(line2);

                listBoxProjectGrade.Items.Clear();
                listBoxProjectGrade.Items.Add("Project Grade");
                listBoxProjectGrade.Items.Add(line2);

                textBoxAppScore.Focus();
            }
        }
        /* Exit button: (2 points)
        *     Exit the application.
        */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
