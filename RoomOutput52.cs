using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1
{
    public partial class RoomOutput52 : Form
    {



        public RoomOutput52()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RoomInput52 f2 = new RoomInput52();
            f2.Show();

        }
        private void RoomOutput52_Load(object sender, EventArgs e)
        {

            if (Variables.ACalculated <= 0 | Variables.BCalculated <= 0 | Variables.CCalculated <= 0 | Variables.DCalculated <= 0 | Variables.FCalculated <= 0 | Variables.DistIn <= 0)

            {

                DialogResult result = MessageBox.Show("Values cannot be computed because the listener is too far from the front of the room. Can the listener be moved closer?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    RoomInput52 f2 = new RoomInput52();
                    f2.Show();

                }
                else
                {
                    DialogResult Result1 = MessageBox.Show("Would you like to calculate values based on the ideal placement for your room?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result1 == DialogResult.Yes)
                    {


                        FrontA.Text = Variables.AIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        FrontA2.Text = Variables.AIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        SideB.Text = Variables.BIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        SideB2.Text = Variables.BIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        FrontC.Text = Variables.CIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        FrontC2.Text = Variables.CIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        DistanceD.Text = Variables.DIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        DistanceOut.Text = Variables.ListenerIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        SideF.Text = Variables.FIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                        SideF2.Text = Variables.FIdeal.ToString("#.##") + Variables.UnitsIn.ToString();


                    }
                    else
                    {
                        this.Close();
                        RoomInput52 f2 = new RoomInput52();
                        f2.Show();

                    }

                }
            }

            else
            {
                FrontA.Text = Variables.ACalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                FrontA2.Text = Variables.ACalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                SideB.Text = Variables.BCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                SideB2.Text = Variables.BCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                FrontC.Text = Variables.CCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                FrontC2.Text = Variables.CCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                DistanceD.Text = Variables.DCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                DistanceOut.Text = Variables.DistIn.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                SideF.Text = Variables.FCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
                SideF2.Text = Variables.FCalculated.ToString("#.##") + " " + Variables.UnitsIn.ToString();
            }

        }


    }
}
