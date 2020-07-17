using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_Pjct_02
{
    public partial class Form1 : Form
    {
        //To control form's moving
        private bool b_FormIsMoving = false;
        private int i_OrgFormLoct_X = 0, i_OrgFormLoct_Y = 0, i_OrgMouseLoct_X = 0, i_OrgMouseLoct_Y = 0;
        //
        public Form1()
        {
            InitializeComponent();
        }
        


        //To control form's moving
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            b_FormIsMoving = true;
            i_OrgFormLoct_X = this.Location.X;
            i_OrgFormLoct_Y = this.Location.Y;
            i_OrgMouseLoct_X = MousePosition.X;
            i_OrgMouseLoct_Y = MousePosition.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            b_FormIsMoving = false;
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            b_FormIsMoving = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (b_FormIsMoving) {
                this.SetDesktopLocation(i_OrgFormLoct_X + MousePosition.X - i_OrgMouseLoct_X, i_OrgFormLoct_Y + MousePosition.Y - i_OrgMouseLoct_Y);
            }
        }

        //Not important stuffs
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.FromArgb(74, 74, 74), 1), new Rectangle(1, 1, 798, 598));
            }
        }
    }
}
