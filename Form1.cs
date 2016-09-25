using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fractals_Cross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Initialize i_actual
        int i_actual = 0;
        //Intialize K, which prevents other parts of the shaoe to be coloured white
        int k = 0;
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //Intialize Variable n
                int n = Convert.ToInt32(numUpDownLevel.Text);

                //Sets points for Original Cross
                Point p1, p2, p3, p4, p5;

                p1 = new Point();
                p2 = new Point();
                p3 = new Point();
                p4 = new Point();
                p5 = new Point();

                p1.X = 400;
                p1.Y = 300;

                p2.X = 400;
                p2.Y = 450;

                p3.X = 400;
                p3.Y = 600;

                p4.X = 250;
                p4.Y = 450;

                p5.X = 550;
                p5.Y = 450;

                Graphics g = Graphics.FromHwnd(pbxFractal.Handle);

                //Set background color
                g.Clear(Color.Black);

                //Draw original cross
                Pen myPen = new Pen(Color.White, 2);

                g.DrawLine(myPen, p1, p3);
                g.DrawLine(myPen, p4, p5);

                //Call recursive loop
                Generate_Neil(n, g, p1, p2, p3, p4, p5);

            }
            catch
            {
                MessageBox.Show("Error: PLesae talk to your nearest customer service representative.");
            }
        }

        //Generate Neil Method
        public void Generate_Neil(int n, Graphics g, Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            //Terminates recursion when n equals 0
            if (n == 0)

                return;

            else
            {
                //Checks if i_actual and K needs to be reset
                if (n == Convert.ToInt32(numUpDownLevel.Text) && i_actual != 0)
                {
                    i_actual = 0;
                    k = 0;
                }

                //Initialize and Declare Points and Variable
                Point CTL1, CTL3, CTL4, CTL5, TLp2, ORGp2, CTR1, CTR3, CTR4, CTR5, TRp2;

                ORGp2 = new Point();

                CTL1 = new Point();
                CTL3 = new Point();
                CTL4 = new Point();
                CTL5 = new Point();
                TLp2 = new Point();

                CTR1 = new Point();
                CTR3 = new Point();
                CTR4 = new Point();
                CTR5 = new Point();
                TRp2 = new Point();
                var i = i_actual % 2099;
                
                Pen myPen = new Pen(Color.White, 1);
                //Only mmake the orignial cross white
                if (i < 12 && k == 0)
                {
                    myPen = new Pen(Color.White, 1);
                    k = 1;
                }
                //Change Colors 
                else if (i < 150)
                    myPen = new Pen(Color.Red, 1);
                else if (i < 300)
                    myPen = new Pen(Color.Orange, 1);
                else if (i < 450)
                    myPen = new Pen(Color.Yellow, 1);
                else if (i < 600)
                    myPen = new Pen(Color.Green, 1);
                else if (i < 750)
                    myPen = new Pen(Color.Blue, 1);
                else if (i < 900)
                    myPen = new Pen(Color.Indigo, 1);
                else if (i < 1050)
                    myPen = new Pen(Color.Violet, 1);
                else if (i < 1200)
                    myPen = new Pen(Color.Violet, 1);
                else if (i < 1350)
                    myPen = new Pen(Color.Indigo, 1);
                else if (i < 1500)
                    myPen = new Pen(Color.Blue, 1);
                else if (i < 1650)
                    myPen = new Pen(Color.Green, 1);
                else if (i < 1800)
                    myPen = new Pen(Color.Yellow, 1);
                else if (i < 1950)
                    myPen = new Pen(Color.Orange, 1);
                else if (i < 2100)
                    myPen = new Pen(Color.Red, 1);

                //Draw Cross
                g.DrawLine(myPen, p1, p3);
                g.DrawLine(myPen, p4, p5);

                //Store Centre Point of Old Cross
                ORGp2.X = p2.X;
                ORGp2.Y = p2.Y;
                //Calculate Points for TOP LEFT Quadrant of Cross
                TLp2.X = (p1.X + p4.X) / 2;
                TLp2.Y = (p1.Y + p4.Y) / 2;

                CTL1.X = TLp2.X - (ORGp2.X - TLp2.X);
                CTL1.Y = TLp2.Y - (ORGp2.Y - TLp2.Y);

                CTL3.X = ORGp2.X;
                CTL3.Y = ORGp2.Y;

                CTL4.X = p4.X;
                CTL4.Y = p4.Y;

                CTL5.X = TLp2.X * 2 - p4.X;
                CTL5.Y = TLp2.Y * 2 - p4.Y;

                //Calculate Points for TOP RIGHT Quadrant of Cross
                TRp2.X = (p1.X + p5.X) / 2;
                TRp2.Y = (p1.Y + p5.Y) / 2;

                CTR1.X = TRp2.X - (ORGp2.X - TRp2.X);
                CTR1.Y = TRp2.Y - (ORGp2.Y - TRp2.Y);

                CTR3.X = ORGp2.X;
                CTR3.Y = ORGp2.Y;

                CTR4.X = TRp2.X * 2 - p5.X;
                CTR4.Y = TRp2.Y * 2 - p5.Y;

                CTR5.X = p5.X;
                CTR5.Y = p5.Y;
                //Update i_actual
                i_actual++;
                //Recurse
                Generate_Neil(n - 1, g, CTL1, TLp2, CTL3, CTL4, CTL5);
                Generate_Neil(n - 1, g, CTR1, TRp2, CTR3, CTR4, CTR5);
            }

        }

    }
}


