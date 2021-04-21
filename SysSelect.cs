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
    public partial class SysSelect : Form
    {
        public SysSelect()
        {
            InitializeComponent();
        }

        private void Tip51_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Help(object sender, DrawToolTipEventArgs e)
        {

        }
        // Displaying tips for buttons when hovered over 
        private void Set51_MouseHover(object sender, EventArgs e)
        {
            Tip51.Show("L, R, C, SL, SR, Sub", Set51);
        }

        private void Set71_MouseHover(object sender, EventArgs e)
        {
            Tip71.Show("L, R, C, SL, SR, RL, RR, Sub", Set71);
        }

        private void Set91_MouseHover(object sender, EventArgs e)
        {
            Tip91.Show("L, R, C, WL, WR, SL, SR, RL, RR, Sub", Set91);
        }

        private void Set52_MouseHover(object sender, EventArgs e)
        {
            Tip52.Show("L, R, C, SL, SR, Sub, Sub", Set52);
        }

        private void Set72_MouseHover(object sender, EventArgs e)
        {
            Tip72.Show("L, R, C, SL, SR, RL, RR, Sub, Sub", Set72);
        }

        private void Set92_MouseHover(object sender, EventArgs e)
        {
            Tip92.Show("L, R, C, WL, WR, SL, SR, RL, RR, Sub, Sub", Set92);
        }
        private void Set51_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput51 f3 = new RoomInput51();
            f3.Show();
        }
        private void Set52_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput52 f4 = new RoomInput52();
            f4.Show();
        }
        private void Set71_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput71 f5 = new RoomInput71();
            f5.Show();
        }
        private void Set72_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput72 f6 = new RoomInput72();
            f6.Show();
        }
        private void Set91_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput91 f7 = new RoomInput91();
            f7.Show();
        }
        private void Set92_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInput92 f8 = new RoomInput92();
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When Button1, "Back", is clicked, it takes the user back to "Welcome"
            {
                this.Hide();
                Welcome f3 = new Welcome();
                f3.Show();
            }
        }
    }
}
