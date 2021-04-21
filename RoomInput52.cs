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
    public partial class RoomInput52 : Form
    {
        //Names the string "Length51" to be used later
        public static string Length52;
        //Names the string "Width51" to be used later
        public static string Width52;
        //Names the string "Distance" to be used later
        public static string DistanceIn52;
        public static string Zero;
        public static object Units52;
        public RoomInput52()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysSelect f3 = new SysSelect();
            f3.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            //Defines "Length51" as the text in "RoomLengthIn"
            Length52 = RoomLengthIn.Text;
            Width52 = RoomWidthIn.Text;
            DistanceIn52 = DistanceIn.Text;
            Units52 = Units.SelectedItem;
            Zero = "0";

            if (string.IsNullOrEmpty((Width52)) & string.IsNullOrEmpty(DistanceIn52) & string.IsNullOrEmpty(Length52))
            {
                MessageBox.Show("Empty Text Field (ALL VALUES)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (string.IsNullOrEmpty((DistanceIn52)) & string.IsNullOrEmpty(Width52))
            {
                MessageBox.Show("Empty Text Field (Distance & Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((DistanceIn52)) & string.IsNullOrEmpty(Length52))
            {
                MessageBox.Show("Empty Text Field (Distance & Length)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Length52)) & string.IsNullOrEmpty(Width52))
            {
                MessageBox.Show("Empty Text Field (Length & Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Length52)))
            {
                MessageBox.Show("Empty Text Field (Length)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((DistanceIn52)))
            {
                MessageBox.Show("Empty Text Field (Distance)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Width52)))
            {
                MessageBox.Show("Empty Text Field (Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(Length52, Zero))
            {
                MessageBox.Show("Length Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(Width52, Zero))
            {
                MessageBox.Show("Width Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(DistanceIn52, Zero))
            {
                MessageBox.Show("Distance Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Convert.ToInt32(DistanceIn52) >= Convert.ToInt32(Length52))
            {
                MessageBox.Show("Distance Cannot Be Greater Than Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Convert.ToString(Units52)))
            {
                MessageBox.Show("Please Chose Units", "Units", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                Variables.CalculateA(int.Parse(DistanceIn.Text));
                Variables.CalculateB(int.Parse(RoomWidthIn.Text));
                Variables.CalculateC(int.Parse(RoomWidthIn.Text), (Variables.ACalculated));
                Variables.CalculateD(int.Parse(RoomLengthIn.Text), int.Parse(DistanceIn.Text));
                Variables.CalculateF((Variables.DCalculated), (Variables.BCalculated));
                Variables.CalculateJ((Variables.DCalculated));
                Variables.CalculateH(int.Parse(RoomWidthIn.Text), (Variables.JCalculated));
                Variables.CalculateDistIn(int.Parse(DistanceIn.Text));
                Variables.CalculateI(int.Parse(RoomWidthIn.Text));

                Variables.CalcList(decimal.Parse(RoomLengthIn.Text));
                Variables.CalcA(Variables.ListenerIdeal);
                Variables.CalcB(decimal.Parse(RoomWidthIn.Text));
                Variables.CalcC(decimal.Parse(RoomWidthIn.Text), (Variables.AIdeal));
                Variables.CalcD(decimal.Parse(RoomLengthIn.Text), Variables.ListenerIdeal);
                Variables.CalcF((Variables.DIdeal), (Variables.BIdeal));
                Variables.CalcJ((Variables.DIdeal));
                Variables.CalcH(decimal.Parse(RoomWidthIn.Text), (Variables.JIdeal));
                Variables.CalcI(decimal.Parse(RoomWidthIn.Text));

                Variables.Units(Convert.ToString(Units.SelectedItem));

                this.Hide();
                RoomOutput52 f5 = new RoomOutput52();
                f5.Show();

            }

        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void DistanceIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
