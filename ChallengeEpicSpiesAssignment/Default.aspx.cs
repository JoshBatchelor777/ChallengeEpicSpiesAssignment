using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Setup the default date selections per calendar when the page loads.
            if (!Page.IsPostBack)
            {
                endOfOldCalendar.SelectedDate = DateTime.Today;
                newCalendar.SelectedDate = DateTime.Today.AddDays(14);
                endOfNewCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }
        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            // This concept was not used, but I want to keep it in place.
            /*
            // Assign the value of each selected calendar date to a DateTime variable...
            DateTime one = endOfOldCalendar.SelectedDate;
            DateTime two = newCalendar.SelectedDate;
            DateTime three = endOfNewCalendar.SelectedDate;
            */

            // I tried this aproach to accruing $500.00/day at first but I think
            // the problem with this method is the button click event only allows
            // for one check through the for loop. 'assignmentLength.Days' is not
            // enough to iterate through in order to generate a proper basis to add to.
            /*
                // Run through each day and add on $500 for each day in the length of the job
                for (double i = assignmentLength.Days; i <= 21; i += 500.0)
                {
                    // Check if length of job exceeds 21 days, if so award a bonus of $1,000.
                    if (i > 21)
                        budget += 1000.0;
                }
            */


            /*
             * Budget Check
             */
                // Get the value for the length of new assignment.
                TimeSpan assignmentLength = endOfNewCalendar.SelectedDate.Subtract(newCalendar.SelectedDate);

                // Initialize budget, then multiply by the length of the job, 500.
                double budget = assignmentLength.TotalDays * 500.0;
                // Check if the job is longer than 3 weeks, if so, award spy $1k extra.
                if (assignmentLength.TotalDays > 22)
                    budget += 1000.0;

            /*
             * String.Format Setup
             */
                // Setup all the variables to pass into the String.Format method.
                string name = spyNameTextBox.Text;
                string jobName = assignmentTextBox.Text;
                //double cost = 
                string result = String.Format("Assignment of:  {0} to: Project " +
                    "{1} is authorized." +
                    "<br />Budget Total:{2}",
                    name, jobName, budget);

            /*
             * Vacation Check
             */
                // Get the value of the difference between the two calendar selections.
                TimeSpan vacationCheck = newCalendar.SelectedDate.Subtract(endOfOldCalendar.SelectedDate);

                // Store the difference in days in 'n' and return the difference in terms of days.
                int n = vacationCheck.Days;
                // Check if 14 days have passed before the new assignment date.
                if (n <= 14)
                    resultLabel.Text = "Error: Must allow at least 2 weeks between previous assignments and new ones.";

            // End Program with printing to the result label.
            resultLabel.Text = result;
        }
    }
}