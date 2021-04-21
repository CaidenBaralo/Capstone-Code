﻿using System;
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
    public partial class RoomInput51 : Form
    {


        //Names the string "Length51" to be used later
        public string Length51;
        //Names the string "Width51" to be used later
        public string Width51;
        //Names the string "Distance" to be used later
        //public static string DistanceIn51;
        public string DistanceIn51;
        public string Zero;
        public static object Units51;
        public RoomInput51()
        {
            InitializeComponent();
        }


        //When Button2, "Back", is clicked, it takes the user back to "SysSelect"
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysSelect f3 = new SysSelect();
            f3.Show();
        }

        //When Button1, "Next", is clicked, it takes the user to "RoomOut51"
        private void Button1_Click(object sender, EventArgs e)
        {



            //Defines "Length51" as the text in "RoomLengthIn"
            Length51 = RoomLengthIn.Text;
            Width51 = RoomWidthIn.Text;
            DistanceIn51 = DistanceIn.Text;
            Units51 = Units.SelectedItem;
            Zero = "0";



            if (string.IsNullOrEmpty((Width51)) & string.IsNullOrEmpty(DistanceIn51) & string.IsNullOrEmpty(Length51))
            {
                MessageBox.Show("Empty Text Field (ALL VALUES)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (string.IsNullOrEmpty((DistanceIn51)) & string.IsNullOrEmpty(Width51))
            {
                MessageBox.Show("Empty Text Field (Distance & Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((DistanceIn51)) & string.IsNullOrEmpty(Length51))
            {
                MessageBox.Show("Empty Text Field (Distance & Length)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Length51)) & string.IsNullOrEmpty(Width51))
            {
                MessageBox.Show("Empty Text Field (Length & Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Length51)))
            {
                MessageBox.Show("Empty Text Field (Length)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((DistanceIn51)))
            {
                MessageBox.Show("Empty Text Field (Distance)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty((Width51)))
            {
                MessageBox.Show("Empty Text Field (Width)", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(Length51, Zero))
            {
                MessageBox.Show("Length Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(Width51, Zero))
            {
                MessageBox.Show("Width Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.Equals(DistanceIn51, Zero))
            {
                MessageBox.Show("Distance Cannot Equal 0", "Equals Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Convert.ToInt32(DistanceIn51) >= Convert.ToInt32(Length51))
            {
                MessageBox.Show("Distance Cannot Be Greater Than Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty(Convert.ToString(Units51)))
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

                this.Close();
                RoomOutput51 f5 = new RoomOutput51();
                f5.Show();

            }



        }

        //Limits the user to only numeric input in the text box
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

        //Limits the user to only numeric input in the text box
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

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        //Limits the user to only numeric input in the text box
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

            
        }
    }
