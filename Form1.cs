/*
 This program is used to solve simple uniform acceleration problems.
 The program uses the 5 equations of uniform acceleration found here: https://bit.ly/2S9YMV3
 I personally rearranged the 5 equations to solve for each case of the 5 variables.
 For the program to work, 3 variables must be given and the numerical 
 values must also make sense for the equation to be solvable. 
 For example if velocity is in m/s then acceleration must be m/s^2.

 The only special function that was unique in the program was the function
 of the amount of significant digits that the answers provided. The process
 of significant digits is different than simple rounding and required some 
 research to figure out how to code it.
 Source: https://bit.ly/2SvQt5b
 
 Another thing to note was that for one of my controls/tools I used
 a tooltip to display some text when you hover over text/buttons
 like the 5 textboxes to the right, the button "Calculate", and the text "# of significant digits" 

 What I found the most interesting about this project is how easy it was to add GUI 
 with controls and tools using c#. Last year when we were using Greenfoot it took a lot
 more work to add and maneuver the actors, whereas in c# forms application you can easily
 add controls and access a plethora of properties.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwenZhuPhysicsCalculator
{
    public partial class Form1 : Form
    {
        // idx: 0 = initial velocity, 1 = final velocity, 2 = acceleration, 3 = displacement, 4 = change in time
        double[] var = new double[5]; // Stores the input variables in an array

        // Output requires 3 more variables because there might be 2 answers for a given variable
        // idx: 0 = initial velocity, 1 = final velocity, 2 = acceleration, 3 = displacement, 4 = change in time
        //      5 = 2nd inital velocty, 6 2nd final velocty, 7 = 2nd change in time
        double[] newvar = new double[8]; // Stores the output variables in an array

        bool[] check = new bool[6]; // To check if the values in the inputted values are actually numbers
        int digits = 4; // Set default significant digits to 4

        public Form1()
        {
            InitializeComponent();
            sigFig.Text = "4"; // Default significant digits
            this.BackColor = Color.FromArgb(100, 200, 255); // Making the background a light-blue color
        }
        private void inivel_TextChanged(object sender, EventArgs e)
        {
            // Test if the input is a number, saving the result in a bool
            // It also saves the input in the var[] array if it is a number
            check[0] = double.TryParse(inivel.Text, out var[0]);
        }

        private void finvel_TextChanged(object sender, EventArgs e)
        {
            // Test if the input is a number, saving the result in a bool
            // It also saves the input in the var[] array if it is a number
            check[1] = double.TryParse(finvel.Text, out var[1]);
        }

        private void accel_TextChanged(object sender, EventArgs e)
        {
            // Test if the input is a number, saving the result in a bool
            // It also saves the input in the var[] array if it is a number
            check[2] = double.TryParse(accel.Text, out var[2]);
        }

        private void displace_TextChanged(object sender, EventArgs e)
        {
            // Test if the input is a number, saving the result in a bool
            // It also saves the input in the var[] array if it is a number
            check[3] = double.TryParse(displace.Text, out var[3]);
        }

        private void ctime_TextChanged(object sender, EventArgs e)
        {
            // Test if the input is a number, saving the result in a bool
            // It also saves the input in the var[] array if it is a number
            check[4] = double.TryParse(ctime.Text, out var[4]);
        }
        
        private void sigFig_ValueChanged(object sender, EventArgs e)
        {
            digits = (int)sigFig.Value;
        }

        //Set the amount of significant digits
        private double sigFigs(double d)
        {
            if (d == 0) return 0;
            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1 - digits);
            return scale * Math.Round(d / scale);
        }

        private void compute_Click(object sender, EventArgs e)
        {
            //temporary values for easier calculations
            double vi=0, vf=0, a=0, d=0, t=0;
        
            //Checking if the equation is actually solvable
            int cnt = 0; //To save number of unknown variables

            for (int i = 0; i < 5; i++) {
                if (!check[i]) cnt++;
                // Also saving varibales for easy access later
                else if (i == 0) vi = var[i];  
                else if (i == 1) vf = var[i];
                else if (i == 2) a = var[i];
                else if (i == 3) d = var[i];
                else if (i == 4) t = var[i];
            }

            if (cnt!=2) { // If there are more or less than 2 unknowns the question may be invalid or unsolavable
                ninivel.Text = "Provide";
                nfinvel.Text = "Exactly";
                naccel.Text = "3";
                ndisplace.Text = "Variables";
                nctime.Text = "Please :)";
                return;
            }
            
            //Displaying known values
            if (check[0]) ninivel.Text = var[0] + "";
            if (check[1]) nfinvel.Text = var[1] + "";
            if (check[2]) naccel.Text = var[2] + "";
            if (check[3]) ndisplace.Text = var[3] + "";
            if (check[4]) nctime.Text = var[4] + "";

            //I rearranged the 5 equations of uniform acceleration to solve for each variable.
            //If you want to check out the equations, https://bit.ly/2S9YMV3

            if (!check[0]) // Initial velocity is unknown
            {
                bool ans2 = false; // Checking if there is a 2nd solution

                //Givens: Final velocity, Acceleration and Displacement
                if (check[1] && check[2] && check[3])
                {
                    if (2 * a * d <= vf * vf) // Checking if there is a solution
                    {
                        newvar[0] = Math.Sqrt(vf * vf - 2 * a * d);
                        newvar[5] = -1 * Math.Sqrt(vf * vf - 2 * a * d);
                    }
                    else // No solution, set varibles to infinity 
                    {
                        newvar[0] = 0x3f3f3f3f;
                        newvar[5] = 0x3f3f3f3f;
                    }
                    ans2 = true;
                }

                //Givens: Final velocity, Acceleration and Time 
                if (check[1] && check[2] && check[4])
                    newvar[0] = vf - a * t;        

                //Givens: Final velocity, Displacement and Time 
                if (check[1] && check[3] && check[4])
                    newvar[0] = 2 * d / t - vf;           

                //Givens: Acceleration, Displacement and Time 
                if (check[2] && check[3] && check[4])
                    newvar[0] = (d - 0.5 * a * t * t) / t;

                //Output accordingly. Either 0,1, or 2 solutions
                if (ans2 && newvar[0]==0x3f3f3f3f) ninivel.Text = "No Solution!";
                else if (ans2) ninivel.Text = sigFigs(newvar[0]) + " or " + sigFigs(newvar[5]);
                else ninivel.Text = sigFigs(newvar[0]) + "";
            }

            if (!check[1]) //  Final velocity is unknown
            {
                bool ans2 = false; // Checking if there is a 2nd solution

                //Givens: Initial velocity, Acceleration and Displacement
                if (check[0] && check[2] && check[3])
                {
                    if (vi * vi + 2 * a * d >= 0) // Checking if there is a solution
                    {
                        newvar[1] = Math.Sqrt(vi * vi + 2 * a * d);
                        newvar[6] = -1 * Math.Sqrt(vi * vi + 2 * a * d);
                    }
                    else // No solution, set varibles to infinity
                    {
                        newvar[1] = 0x3f3f3f3f;
                        newvar[6] = 0x3f3f3f3f;
                    }
                    ans2 = true;
                }

                //Givens: Initial velocity, Acceleration and Time 
                if (check[0] && check[2] && check[4])
                    newvar[1] = vi + a * t;

                //Givens: Initial velocity, Displacement and Time 
                if (check[0] && check[3] && check[4])
                    newvar[1] = 2 * d / t - vi;

                //Givens: Acceleration, Displacement and Time 
                if (check[2] && check[3] && check[4])
                    newvar[1] = (d + 0.5 * a * t * t) / t;

                //Output accordingly. Either 0,1, or 2 solutions
                if (ans2 && newvar[1] == 0x3f3f3f3f) nfinvel.Text = "No Solution!";
                else if (ans2) nfinvel.Text = sigFigs(newvar[1]) + " or " + sigFigs(newvar[6]);
                else nfinvel.Text = sigFigs(newvar[1]) + "";
            }

            if (!check[2]) //  Acceleration is unknown
            {
                //Givens: Initial velocity, Final velocity and Displacement
                if (check[0] && check[1] && check[3])
                    newvar[2] = (vf * vf - vi * vi) / (2 * d);

                //Givens: Initial velocity, Final velocity and Time 
                if (check[0] && check[1] && check[4])
                    newvar[2] = (vf - vi) / t;

                //Givens: Initial velocity, Displacement and Time 
                if (check[0] && check[3] && check[4])
                    newvar[2] = (2 * d - 2 * vi * t) / (t * t);

                //Givens: Acceleration, Displacement and Time 
                if (check[2] && check[3] && check[4])
                    newvar[2] = (2 * vf * t - 2 * d) / (t * t);

                //Output the only solution
                naccel.Text = sigFigs(newvar[2]) + "";
            }

            if (!check[3]) //  Displacement is unknown
            {
                //Givens: Initial velocity, Final velocity and Acceleration
                if (check[0] && check[1] && check[2])
                    newvar[3] = (vf * vf - vi * vi) / (2 * a);

                //Givens: Initial velocity, Final velocity and Time 
                if (check[0] && check[1] && check[4])
                    newvar[3] = 0.5 * t * (vf + vi);

                //Givens: Initial velocity, Acceleration and Time 
                if (check[0] && check[2] && check[4])
                    newvar[3] = vi * t + 0.5 * a * t * t;

                //Givens: Final velocity, Acceleration and Time 
                if (check[2] && check[1] && check[4])
                    newvar[3] = vf * t - 0.5 * a * t * t;

                //Output the only solution
                ndisplace.Text = sigFigs(newvar[3]) + "";
            }

            if (!check[4]) // Time is unknown
            {
                bool ans2 = false; // Checking if there is a 2nd solution

                //Givens: Initial velocity, Acceleration and Displacement
                if (check[0] && check[2] && check[3])
                {
                    if (vi * vi + 2 * a * d >= 0) // Checking if there is a solution
                    {
                        newvar[4] = (-vi + Math.Sqrt(vi * vi + 2 * a * d)) / a;
                        newvar[7] = (-vi - Math.Sqrt(vi * vi + 2 * a * d)) / a;
                    }
                    else // No solution, set varibles to infinity
                    {
                        newvar[4] = 0x3f3f3f3f;
                        newvar[7] = 0x3f3f3f3f;
                    }
                    ans2 = true;
                }

                //Givens: Acceleration, Displacement and Final velocity 
                if (check[2] && check[3] && check[1])
                {
                    if (vf * vf - 2 * a * d >= 0) // Checking if there is a solution
                    {
                        newvar[4] = (vf + Math.Sqrt(vf * vf - 2 * a * d)) / a;
                        newvar[7] = (vf - Math.Sqrt(vf * vf - 2 * a * d)) / a;
                    }
                    else // No solution, set varibles to infinity
                    {
                        newvar[4] = 0x3f3f3f3f; 
                        newvar[7] = 0x3f3f3f3f;
                    }
                    ans2 = true;
                }

                //Givens: Initial velocity, Acceleration and Final velocity 
                if (check[0] && check[2] && check[1])
                    newvar[4] = (vf-vi)/a;

                //Givens: Initial velocity, Displacement and Final velocity 
                if (check[0] && check[3] && check[1])
                    newvar[4] = 2*d/(vi+vf);

                //Output accordingly. Either 0,1, or 2 solutions
                if (ans2 && newvar[4]==0x3f3f3f3f) nctime.Text = "No Solution!";
                else if (ans2) nctime.Text = sigFigs(newvar[4]) + " or " + sigFigs(newvar[7]);
                else nctime.Text = sigFigs(newvar[4]) + "";
            }
        }

        //Clears all the input and output on the textboxs and resets thems
        private void clean_Click(object sender, EventArgs e)
        {
            inivel.Text = "";
            finvel.Text = "";
            accel.Text = "";
            displace.Text = "";
            ctime.Text = "";
            
            ninivel.Text = "";
            nfinvel.Text = "";
            naccel.Text = "";
            ndisplace.Text = "";
            nctime.Text = "";
        }
    }
}
