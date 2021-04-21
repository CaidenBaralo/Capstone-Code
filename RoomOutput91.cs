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
    public partial class RoomOutput91 : Form
    {



        public RoomOutput91()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RoomInput91 f2 = new RoomInput91();
            f2.Show();

        }
        private void RoomOutput91_Load(object sender, EventArgs e)
        {

            if (Variables.ACalculated <= 0 | Variables.BCalculated <= 0 | Variables.CCalculated <= 0 | Variables.DCalculated <= 0 | Variables.FCalculated <= 0 | Variables.DistIn <= 0)

            {

                DialogResult result = MessageBox.Show("Values cannot be computed because the listener is too far from the front of the room. Can the listener be moved closer?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    RoomInput91 f2 = new RoomInput91();
                    f2.Show();

                }
                else
                {
                    DialogResult Result1 = MessageBox.Show("Would you like to calculate values based on the ideal placement for your room?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result1 == DialogResult.Yes)
                    {
                        if (Variables.AIdeal <= 0 | Variables.BIdeal <= 0 | Variables.CIdeal <= 0 | Variables.DIdeal <= 0 | Variables.FIdeal <= 0 | Variables.ListenerIdeal <= 0 | Variables.HIdeal <= 0 | Variables.JIdeal <= 0 | Variables.IIdeal <= 0)
                        {
                            DialogResult Result2 = MessageBox.Show("The dimensions of your room are not compatible with this software at this time, try modifying your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            RoomInput51 f2 = new RoomInput51();
                            f2.Show();
                        }

                        else
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
                            RearJ.Text = Variables.JIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                            RearJ2.Text = Variables.JIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                            RearH.Text = Variables.HIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                            RearH2.Text = Variables.HIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                            SideI.Text = Variables.IIdeal.ToString("#.##") + Variables.UnitsIn.ToString();
                            SideI2.Text = Variables.IIdeal.ToString("#.##") + Variables.UnitsIn.ToString();

                        }
                    }
                    else
                    {
                        this.Close();
                        RoomInput91 f2 = new RoomInput91();
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
                RearJ.Text = Variables.JCalculated.ToString("#.##") + Variables.UnitsIn.ToString();
                RearJ2.Text = Variables.JCalculated.ToString("#.##") + Variables.UnitsIn.ToString();
                RearH.Text = Variables.HCalculated.ToString("#.##") + Variables.UnitsIn.ToString();
                RearH2.Text = Variables.HCalculated.ToString("#.##") + Variables.UnitsIn.ToString();
                SideI.Text = Variables.ICalculated.ToString("#.##") + Variables.UnitsIn.ToString();
                SideI2.Text = Variables.ICalculated.ToString("#.##") + Variables.UnitsIn.ToString();
            }

        }


    }
}
