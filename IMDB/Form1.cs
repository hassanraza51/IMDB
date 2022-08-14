using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Msg()
        {
            MessageBox.Show("Movie not avaiable","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.Visible =true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(pic1.Visible==true)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = false;
            }
            else if (pic2.Visible == true)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = true;
                pic4.Visible = false;
            }
            else if (pic3.Visible == true)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = true;
            }
            else
            {
                pic1.Visible = true;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (pic1.Visible == true)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = true;
            }
            else if (pic2.Visible == true)
            {
                pic1.Visible = true;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
            }
            else if (pic3.Visible == true)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = false;
            }
            else
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = true;
                pic4.Visible = false;
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            Msg();
        }

        private void All_Click(object sender, EventArgs e)
        {
            if (Categories.Visible == true)
                Categories.Visible = false;
            else
                Categories.Visible = true;
        }

        private void En_Click(object sender, EventArgs e)
        {
            if (Languages.Visible == true)
                Languages.Visible = false;
            else
                Languages.Visible = true;
        }
    }
}
