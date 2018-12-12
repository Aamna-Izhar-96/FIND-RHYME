namespace gamenfa
{
    partial class win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button_NEXT_LEVEL = new System.Windows.Forms.Button();
            this.label_WIN = new System.Windows.Forms.Label();
            this.LABEL_SCORE = new System.Windows.Forms.Label();
            this.label_score_ = new System.Windows.Forms.Label();
            this.label_over = new System.Windows.Forms.Label();
            this.label_lose = new System.Windows.Forms.Label();
            this.panel_win = new System.Windows.Forms.Panel();
            this.button_newgame = new System.Windows.Forms.Button();
            this.button_mainmenu = new System.Windows.Forms.Button();
            this.label_out_of = new System.Windows.Forms.Label();
            this.label_correct = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.panel_win.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_EXIT
            // 
            this.button_EXIT.BackColor = System.Drawing.Color.Moccasin;
            this.button_EXIT.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EXIT.ForeColor = System.Drawing.Color.Red;
            this.button_EXIT.Location = new System.Drawing.Point(65, 547);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(194, 60);
            this.button_EXIT.TabIndex = 0;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = false;
            this.button_EXIT.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button_NEXT_LEVEL
            // 
            this.button_NEXT_LEVEL.BackColor = System.Drawing.Color.Moccasin;
            this.button_NEXT_LEVEL.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NEXT_LEVEL.ForeColor = System.Drawing.Color.Red;
            this.button_NEXT_LEVEL.Location = new System.Drawing.Point(295, 547);
            this.button_NEXT_LEVEL.Name = "button_NEXT_LEVEL";
            this.button_NEXT_LEVEL.Size = new System.Drawing.Size(194, 60);
            this.button_NEXT_LEVEL.TabIndex = 2;
            this.button_NEXT_LEVEL.Text = "NEXT LEVEL";
            this.button_NEXT_LEVEL.UseVisualStyleBackColor = false;
            this.button_NEXT_LEVEL.Visible = false;
            this.button_NEXT_LEVEL.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_WIN
            // 
            this.label_WIN.AutoSize = true;
            this.label_WIN.BackColor = System.Drawing.Color.Moccasin;
            this.label_WIN.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WIN.ForeColor = System.Drawing.Color.Red;
            this.label_WIN.Location = new System.Drawing.Point(232, 36);
            this.label_WIN.Name = "label_WIN";
            this.label_WIN.Size = new System.Drawing.Size(548, 98);
            this.label_WIN.TabIndex = 3;
            this.label_WIN.Text = "YOU WIN !!!!";
            this.label_WIN.Visible = false;
            // 
            // LABEL_SCORE
            // 
            this.LABEL_SCORE.AutoSize = true;
            this.LABEL_SCORE.BackColor = System.Drawing.Color.Moccasin;
            this.LABEL_SCORE.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_SCORE.ForeColor = System.Drawing.Color.Red;
            this.LABEL_SCORE.Location = new System.Drawing.Point(308, 407);
            this.LABEL_SCORE.Name = "LABEL_SCORE";
            this.LABEL_SCORE.Size = new System.Drawing.Size(281, 47);
            this.LABEL_SCORE.TabIndex = 4;
            this.LABEL_SCORE.Text = "YOUR SCORE  :";
            this.LABEL_SCORE.Click += new System.EventHandler(this.LABEL_SCORE_Click);
            // 
            // label_score_
            // 
            this.label_score_.AutoSize = true;
            this.label_score_.BackColor = System.Drawing.Color.Moccasin;
            this.label_score_.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_.ForeColor = System.Drawing.Color.Red;
            this.label_score_.Location = new System.Drawing.Point(591, 407);
            this.label_score_.Name = "label_score_";
            this.label_score_.Size = new System.Drawing.Size(146, 47);
            this.label_score_.TabIndex = 5;
            this.label_score_.Text = "label2";
            // 
            // label_over
            // 
            this.label_over.AutoSize = true;
            this.label_over.BackColor = System.Drawing.Color.Moccasin;
            this.label_over.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_over.ForeColor = System.Drawing.Color.Red;
            this.label_over.Location = new System.Drawing.Point(200, 36);
            this.label_over.Name = "label_over";
            this.label_over.Size = new System.Drawing.Size(599, 98);
            this.label_over.TabIndex = 2;
            this.label_over.Text = "GAME OVER !!!";
            this.label_over.Visible = false;
            // 
            // label_lose
            // 
            this.label_lose.AutoSize = true;
            this.label_lose.BackColor = System.Drawing.Color.Moccasin;
            this.label_lose.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lose.ForeColor = System.Drawing.Color.Red;
            this.label_lose.Location = new System.Drawing.Point(303, 165);
            this.label_lose.Name = "label_lose";
            this.label_lose.Size = new System.Drawing.Size(396, 74);
            this.label_lose.TabIndex = 25;
            this.label_lose.Text = "YOU LOSE !!!";
            this.label_lose.Visible = false;
            // 
            // panel_win
            // 
            this.panel_win.BackgroundImage = global::gamenfa.Properties.Resources._17909527_1131178577011091_251010287_n;
            this.panel_win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_win.Controls.Add(this.button_newgame);
            this.panel_win.Controls.Add(this.button_mainmenu);
            this.panel_win.Controls.Add(this.label_out_of);
            this.panel_win.Controls.Add(this.label_correct);
            this.panel_win.Controls.Add(this.button_restart);
            this.panel_win.Controls.Add(this.label_lose);
            this.panel_win.Controls.Add(this.label_over);
            this.panel_win.Controls.Add(this.label_score_);
            this.panel_win.Controls.Add(this.LABEL_SCORE);
            this.panel_win.Controls.Add(this.label_WIN);
            this.panel_win.Controls.Add(this.button_NEXT_LEVEL);
            this.panel_win.Controls.Add(this.button_EXIT);
            this.panel_win.Location = new System.Drawing.Point(1, 0);
            this.panel_win.Name = "panel_win";
            this.panel_win.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_win.Size = new System.Drawing.Size(1028, 711);
            this.panel_win.TabIndex = 23;
            this.panel_win.Paint += new System.Windows.Forms.PaintEventHandler(this.win__Paint);
            // 
            // button_newgame
            // 
            this.button_newgame.BackColor = System.Drawing.Color.Moccasin;
            this.button_newgame.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newgame.ForeColor = System.Drawing.Color.Red;
            this.button_newgame.Location = new System.Drawing.Point(742, 547);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(194, 60);
            this.button_newgame.TabIndex = 30;
            this.button_newgame.Text = "OWN GAME";
            this.button_newgame.UseVisualStyleBackColor = false;
            this.button_newgame.Click += new System.EventHandler(this.button_newgame_Click);
            // 
            // button_mainmenu
            // 
            this.button_mainmenu.BackColor = System.Drawing.Color.Moccasin;
            this.button_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mainmenu.ForeColor = System.Drawing.Color.Red;
            this.button_mainmenu.Location = new System.Drawing.Point(528, 547);
            this.button_mainmenu.Name = "button_mainmenu";
            this.button_mainmenu.Size = new System.Drawing.Size(194, 60);
            this.button_mainmenu.TabIndex = 29;
            this.button_mainmenu.Text = "MAIN MENU";
            this.button_mainmenu.UseVisualStyleBackColor = false;
            this.button_mainmenu.Click += new System.EventHandler(this.button_mainmenu_Click);
            // 
            // label_out_of
            // 
            this.label_out_of.AutoSize = true;
            this.label_out_of.BackColor = System.Drawing.Color.Moccasin;
            this.label_out_of.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_of.ForeColor = System.Drawing.Color.Red;
            this.label_out_of.Location = new System.Drawing.Point(550, 292);
            this.label_out_of.Name = "label_out_of";
            this.label_out_of.Size = new System.Drawing.Size(162, 53);
            this.label_out_of.TabIndex = 28;
            this.label_out_of.Text = "outof";
            // 
            // label_correct
            // 
            this.label_correct.AutoSize = true;
            this.label_correct.BackColor = System.Drawing.Color.Moccasin;
            this.label_correct.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correct.ForeColor = System.Drawing.Color.Red;
            this.label_correct.Location = new System.Drawing.Point(327, 292);
            this.label_correct.Name = "label_correct";
            this.label_correct.Size = new System.Drawing.Size(213, 53);
            this.label_correct.TabIndex = 27;
            this.label_correct.Text = "CORRECT";
            // 
            // button_restart
            // 
            this.button_restart.BackColor = System.Drawing.Color.Moccasin;
            this.button_restart.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_restart.ForeColor = System.Drawing.Color.Red;
            this.button_restart.Location = new System.Drawing.Point(295, 547);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(194, 60);
            this.button_restart.TabIndex = 26;
            this.button_restart.Text = "RESTART";
            this.button_restart.UseVisualStyleBackColor = false;
            this.button_restart.Visible = false;
            // 
            // win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 711);
            this.Controls.Add(this.panel_win);
            this.Name = "win";
            this.Text = "win";
            this.Load += new System.EventHandler(this.win_Load);
            this.panel_win.ResumeLayout(false);
            this.panel_win.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Button button_NEXT_LEVEL;
        private System.Windows.Forms.Label label_WIN;
        private System.Windows.Forms.Label LABEL_SCORE;
        private System.Windows.Forms.Label label_score_;
        private System.Windows.Forms.Label label_over;
        private System.Windows.Forms.Label label_lose;
        private System.Windows.Forms.Panel panel_win;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label_out_of;
        private System.Windows.Forms.Label label_correct;
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.Button button_mainmenu;

    }
}