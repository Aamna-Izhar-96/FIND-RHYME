using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gamenfa
{
    public partial class win : Form
    {
        public win(int i,int score,int rno)
        {
            InitializeComponent();
            if (i==rno)
            {
                label_WIN.Visible = true;
                label_out_of.Text = rno.ToString()+ "/" + i.ToString();
                label_score_.Text = score.ToString();
                button_NEXT_LEVEL.Visible = true;
                button_NEXT_LEVEL.Visible = true;
            }
            else
               
            {
                label_score_.Text = score.ToString();
                label_out_of.Text = rno.ToString() + "/" + i.ToString();
                label_over.Visible = true;
                label_lose.Visible = true;
                button_restart.Visible = true;
            }
        }

        private void win_Load(object sender, EventArgs e)
        {

        }
       
       

        private void button9_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

      

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void win__Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LABEL_SCORE_Click(object sender, EventArgs e)
        {

        }

        private void button_mainmenu_Click(object sender, EventArgs e)
        {
            
            Form1 l1 = new Form1();
            l1.Show();
            this.Hide();
        }

        private void button_newgame_Click(object sender, EventArgs e)
        {
            
            LEVEL_1 l1 = new LEVEL_1();
            l1.writenfa();
            l1.Show();
            this.Hide();
        }

    }
}
