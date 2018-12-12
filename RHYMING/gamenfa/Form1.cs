using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace gamenfa
{
    public partial class Form1 : Form
    {
        Button []temp;
        static int u;
        public Form1()
        {
            InitializeComponent();
           
            
            
            button_start.Visible = true;
            button_RULES.Visible = true;
            button_EXIT.Visible = true;
            
            button_user.Visible = true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            button_easy.Visible = true;
            button_medium.Visible = true;
            button_hard.Visible = true;
            button_start.Visible = false;
            button_RULES.Visible = false;
            button_EXIT.Visible = true;
            button_mainmenu.Visible = true;
            button_user.Visible = false;
        }

       

       

        

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void start_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button_easy_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            LEVEL_1 l1 = new LEVEL_1("nfa1");
            l1.Show();
            this.Hide();
            
        }

        private void button_medium_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            LEVEL_1 l1 = new LEVEL_1("nfa2");
            l1.Show();
            this.Hide();
        }

        private void button_RULES_Click(object sender, EventArgs e)
        {
            label_rules.Visible = true;
            button_mainmenu.Visible = true;
            button_start.Visible = false;
            button_RULES.Visible = false;
            button_EXIT.Visible = false;
            button_user.Visible = false;
        }

        private void button_hard_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            LEVEL_1 l1 = new LEVEL_1("nfa3");
            l1.Show();
            this.Hide();
        }

        private void button_mainmenu_Click(object sender, EventArgs e)
        {
            label_rules.Visible = false;
            button_mainmenu.Visible = false;
            button_medium.Visible = false;
            button_easy.Visible = false;
            button_hard.Visible = false;
            button_start.Visible = true;
            button_RULES.Visible = true;
            button_EXIT.Visible = true;
            button_user.Visible = true;
            label_no_game.Visible = false;
            if (temp != null)
            {
                foreach (Button b in temp)
                {
                    b.Visible = false;
                }
            }
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            button_mainmenu.Visible = true;
            button_start.Visible = false;
            button_RULES.Visible = false;
            button_EXIT.Visible = true;
            button_user.Visible = false;
            if (Directory.GetFiles("levels").Length>3)
            {
                int len = Directory.GetFiles("levels").Length;
                int user = len - 3;
                temp = new Button[user];
                int locy = 200;
                for (u = 0; u < user; u++ )
                {
                    
                    Button b = new Button();
                    b.Font = new Font(new FontFamily("Showcard Gothic"), 16);
                    b.BackColor = Color.Moccasin;
                    b.ForeColor = Color.Red;
                    b.Size = new Size(190, 60);
                    b.Location = new Point(101,locy);
                    locy = locy + 50;
                    int temp1 = u + 1;
                    b.Text = "USER"+temp1.ToString();
                    b.Name = "b";
                    temp[u] = b;
                //  b.Visible = true;
                    
                    

                    start.Controls.Add(b);
                    b.Click += new System.EventHandler(b_Click);
                    
                }
                
            }
            else
            {
                label_no_game.Visible = true;
                
            }
           
        }


        protected void b_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            
            LEVEL_1 l1 = new LEVEL_1("USER"+u.ToString());
            l1.Show();
            this.Hide();
           
        }
        
       
       

        
        
    }
}
