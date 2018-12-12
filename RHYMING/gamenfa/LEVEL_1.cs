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
    public partial class LEVEL_1 : Form
    {
        static int t = 0;
        NFA_ g = new NFA_();
        NFA_ n ;
        DFA dfa;
        int i = 0;
        int c = 0;
        int score=0;
        static int rnclick=0;
        static int rn;
        static string tocheck;
        static int rno;
        static string[] rhymelist;
        static int IS;
        static int nfst;
        static int[] FS;
        static int TS;
        static string characters;
        static int[] how_many_trans;
        static List<string> sublist;
        static List<List<string>> list=new List<List<string>>();
        public LEVEL_1()
        {

        }
        public void writenfa()
        {
            InitializeComponent();
            //button_confirm.Visible = true;
            tableLayoutPanel_user.Visible = true;
            

            

            
            
            //g.WriteNFA(filename);
        }
        public LEVEL_1(string filename)
        {

            InitializeComponent();
            
            n = g.READNFA(filename);
            dfa = n.NFAtoDFA(n);
            label_out_of.Text = n.rhymeno.ToString() + "/" + i.ToString();
          //lables title
            string tocheck = n.rhyme;
            label_search.Visible = true;
            textBox_word.Visible = true;
            label_correct.Visible = true;
            label_out_of.Visible = true;
            LABEL_SCORE.Visible = true;
            label_score_.Visible = true;
            label_word.Text = tocheck;
            label_word.Visible = true;
            label_text_enter.Visible= true;

          //tablelayoutpanel create
            tableLayoutPanel_chars.Visible = true;
            tableLayoutPanel_chars.BackColor = Color.Moccasin;

            
          //lablescreated for transitions
            for (int k = 0; k < n.TS; k++)
            {
                for (int j = 0; j < n.TT[k].Count; j++)
                {
                   
                    Label l = new Label();
                    l.BackColor = Color.Moccasin;
                    l.ForeColor = Color.Red;
                    l.Font = new Font(new FontFamily("Showcard Gothic"), 14);
                    l.Size = new Size(96,60);
                    l.Location = new Point(4, 1);
                    l.Text = n.TT[k][j].getString().ToString();
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    l.Visible = true;
                    
                   tableLayoutPanel_chars.Controls.Add(l);
                }
            }
          /*  for (int i = 0; i < n.rhymeno;i++ )
            {
                Button button = new Button();
                button.BackColor = Color.Moccasin;
                button.ForeColor = Color.Red;
                button.Text = "check";

            }*/
            button_check.Visible = true;

         
            
        }


       
       

        private void states_Paint(object sender, PaintEventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            //button_check.Visible = false;
            c++;
            bool v = dfa.validate(textBox_word.Text.ToLower());
            string word = textBox_word.Text.ToUpper();
            
            if (v == true && n.listofrhyme.Contains(word))
            {
                i++;
                score += 5;
                label_out_of.Text=n.rhymeno.ToString() + "/" + i.ToString();
                label_score_.Text=score.ToString();
               
                removeword(word);
                textBox_word.Text = "";
               
            }
            else
            {
                label_out_of.Text = n.rhymeno.ToString() + "/" + i.ToString();
                label_score_.Text = score.ToString();
                
                textBox_word.Text = "";

                
            }
            
          
            if (c == n.rhymeno)
            {
                end();
            }
        }

        public void removeword(string word)
        {
            for (int i = 0; i < n.listofrhyme.Length;i++ )
            {
                if (n.listofrhyme[i] == word)
                {
                    n.listofrhyme[i] = "-";
                    break;
                }
            }
        }
       
       
        public void end()
        {
            states.Visible = false;

            
                win l = new win(i,score,n.rhymeno);
                l.Show();
                this.Hide();
            

            
        }

        private void tableLayoutPanel_chars_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_mainmenu_Click(object sender, EventArgs e)
        {
            states.Visible = false;
            Form1 l1 = new Form1();
            l1.Show();
            this.Hide();
        }

        private void button_write1_Click(object sender, EventArgs e)
        {
            tocheck = textBox_rhyme.Text.ToUpper();
            textBox_rhyme.Enabled = false;
            button_write1.Enabled = false;
        }

        private void button_write2_Click(object sender, EventArgs e)
        {
            rno = int.Parse(textBox_how_many_rhymes.Text);
            textBox_how_many_rhymes.Enabled = false;
            button_write2.Enabled = false;
            rhymelist = new string[rno];
            for (rn = 0; rn < rnclick; rn++)
            {
                
                button_write3_Click(null, null);
                
            }
        }

        private void button_write3_Click(object sender, EventArgs e)
        {



            rnclick++;
            if (rnclick == rhymelist.Length)
            {
                textBox_rhymes.Enabled = false;
                button_write3.Enabled = false;
                rnclick = 0;
                rn = 0;
            }
              

            else
            {


                rhymelist[rn] = textBox_rhymes.Text.ToUpper();
                textBox_rhymes.Text = "";
            }
            
        }
        private void button_write4_Click(object sender, EventArgs e)
        {
            IS = int.Parse(textBox_IS.Text);
            textBox_IS.Enabled = false;
            button_write4.Enabled = false;

        }
       
        private void button_write5_Click(object sender, EventArgs e)
        {
            nfst = int.Parse(textBox_how_many_FS.Text);
            textBox_how_many_FS.Enabled = false;
            button_write5.Enabled = false;
            FS = new int[nfst];
            for (rn = 0; rn < rnclick; rn++)
            {
                button_write6_Click(null,null);
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            int len = Directory.GetFiles("levels").Length;
            int user = len - 3;
            int newfile = user + 1;
            string filename = "USER" + newfile.ToString();
            g.WriteNFA(filename,IS,FS,characters,list,tocheck,TS,rno,rhymelist,how_many_trans);
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button_write6_Click(object sender, EventArgs e)
        {
            rnclick++;
            if (rnclick == FS.Length)
            {
                textBox_FS.Enabled = false;
                button_write6.Enabled = false;
                rnclick = 0;
                rn = 0;
            }
            else
            {
               
                
                    FS[rn] = int.Parse(textBox_FS.Text);
                    textBox_FS.Text = "";
                
            }
        }

        private void button_write7_Click(object sender, EventArgs e)
        {
            TS = int.Parse(textBox_TS.Text);
            textBox_TS.Enabled = false;
            button_write7.Enabled = false;
            how_many_trans = new int[TS];
        }

        private void button_write8_Click(object sender, EventArgs e)
        {
            characters = textBox_domains.Text.ToLower();
            textBox_domains.Enabled = false;
            button_write8.Enabled = false;

            for (rn = 0; rn < rnclick; rn++)
            {
               
                button_write9_Click(null, null);
                
            }
        }
        //this for total transitions for each state
        private void button_write9_Click(object sender, EventArgs e)
        {
            rnclick++;
            if (rnclick == how_many_trans.Length)
            {
                how_many_trans[rnclick - 1] = int.Parse(textBox_total_trans_for_each.Text);
                totalTr += how_many_trans[rnclick - 1];
                textBox_total_trans_for_each.Enabled = false;
                button_write9.Enabled = false;
                rnclick = 0;
                rn = 0;
                //button_null.Visible = true;

            }
            else
            {

                how_many_trans[rnclick - 1] = int.Parse(textBox_total_trans_for_each.Text);
                totalTr += how_many_trans[rnclick - 1];
                label_trans_total_for_each_state.Text = "ENTER TOTAL TRANSITION FOR " + rnclick.ToString();
                textBox_total_trans_for_each.Text = "";

            }
            
            
            
        }
        int tr = 0;
        int totalTr = 0;
        int trNo = 0;
        int j = 0;
        private void button_write10_Click(object sender, EventArgs e)
        {

            tr++;
            j++;
            

            label_trans.Text = "ENTER EACH TRANSITION FOR " + rn.ToString() + "(e.g:- p1)";
            sublist.Add(textBox_each_trans_for_state.Text);
            if (how_many_trans[trNo] == j)
            {
                j = 0;
                list.Add(sublist);
                sublist = new List<string>();
                trNo++;
            }
            textBox_each_trans_for_state.Text = "";
            if (tr == totalTr)
            {


                textBox_each_trans_for_state.Enabled = false;
                button_write10.Enabled = false;
                button_confirm.Visible = true;
            }
           /* Button btnSender = (Button)sender;
            
            for (rn = 0; rn < TS; rn++)
            {
                
                sublist = new List<string>();
                label_trans.Text = "ENTER EACH TRANSITION FOR " + rn.ToString() + "(e.g:- p1)";
                for (int r = 0; r < how_many_trans[rn]; r++)
                {
                    
                   if(btnSender==button_write10)
                    {
                        sublist.Add(textBox_each_trans_for_state.Text);
                        textBox_each_trans_for_state.Text = "";
                        rnclick++;
                        
                    }
                   
                }
                
                list.Add(sublist);
               
            }
            
            if (rnclick == t)
            {

                button_write10.Enabled = false;
                button_confirm.Visible = true;
                textBox_each_trans_for_state.Enabled = false;


                rn = 0;
                rnclick = 0;
            }
          // rnclick++;

             
                 /*
             else
             if (rnclick == how_many_trans[rn])
             {
                 label_trans.Text = "ENTER EACH TRANSITION FOR " + rn.ToString() + "(e.g:- p1)";
                 rnclick = 0;
             }
            
             else
             {

                
                 textBox_each_trans_for_state.Text = "";

             }*/



        }

        


    }
}
