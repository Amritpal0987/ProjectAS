using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Amritpal_727469_A3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        

      //  public int Total { get; private set; }
       // public object TxtGrade { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalc_Click(object sender, EventArgs e)
        {
            double test1, test2, test3,total = 0;
            double Assignment = 0, A1, A2, A3, A4, A5;
            test1 = double.Parse(TxtTest1.Text);
            test2 = double.Parse(TxtTest2.Text);
            test3 = double.Parse(TxtTest3.Text);
            total = test1 * 0.25 + test2 * 0.25 + test3 * 0.25;
            TxtTotal.Text = total.ToString();
            //Finding 5% of aasignment
            A1 = double.Parse(TxtA1.Text);
            A2 = double.Parse(TxtA2.Text);
            A3 = double.Parse(TxtA3.Text);
            A4 = double.Parse(TxtA4.Text);
            A5 = double.Parse(TxtA5.Text);

            String Grade = "";

            Assignment = A1 * 0.05 + A2 * 0.05 + A3 * 0.05 + A4 * 0.05 + A5 * 0.05;
            total = total + Assignment;
            TxtTotal.Text = total.ToString();

            if (total >= 94 && total <= 100)
                Grade = "A+";
            else if (total >= 87.00 && total <= 93.99)
                Grade = "A";
            else if (total >= 80.00 && total <= 86.99)
                Grade = "A-";
            else if (total >= 77.00 && total <= 79.99)
                Grade = "B+";
            else if (total >= 73.00 && total <= 76.99)
                Grade = "B";
            else if (total >= 70.00 && total <= 72.99)
                Grade = "B-";
            else if (total >= 67.00 && total <= 69.99)
                Grade = "C+";
            else if (total >= 63.00 && total <= 66.99)
                Grade = "C";
            else if (total >= 60.00 && total <= 62.99)
                Grade = "C-";
            else if (total >= 50.00 && total <= 59.99)
                Grade = "D";
            else if (total >= 00.00 && total <= 49.99)
                Grade = "F";

            TextGrade.Text = Grade;

        }

        protected void TxtName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}