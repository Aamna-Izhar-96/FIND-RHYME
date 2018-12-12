namespace gamenfa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.LABEL_TITLE = new System.Windows.Forms.Label();
            this.button_RULES = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Panel();
            this.label_no_game = new System.Windows.Forms.Label();
            this.button_user = new System.Windows.Forms.Button();
            this.button_mainmenu = new System.Windows.Forms.Button();
            this.label_rules = new System.Windows.Forms.Label();
            this.button_hard = new System.Windows.Forms.Button();
            this.button_medium = new System.Windows.Forms.Button();
            this.button_easy = new System.Windows.Forms.Button();
            this.start.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Moccasin;
            this.button_start.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.Red;
            this.button_start.Location = new System.Drawing.Point(397, 227);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(194, 60);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // LABEL_TITLE
            // 
            this.LABEL_TITLE.AutoSize = true;
            this.LABEL_TITLE.BackColor = System.Drawing.Color.Moccasin;
            this.LABEL_TITLE.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITLE.ForeColor = System.Drawing.Color.Red;
            this.LABEL_TITLE.Location = new System.Drawing.Point(36, 32);
            this.LABEL_TITLE.Name = "LABEL_TITLE";
            this.LABEL_TITLE.Size = new System.Drawing.Size(951, 74);
            this.LABEL_TITLE.TabIndex = 0;
            this.LABEL_TITLE.Text = "FIND THE RHYME OF THE WORD";
            this.LABEL_TITLE.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_RULES
            // 
            this.button_RULES.BackColor = System.Drawing.Color.Moccasin;
            this.button_RULES.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RULES.ForeColor = System.Drawing.Color.Red;
            this.button_RULES.Location = new System.Drawing.Point(397, 353);
            this.button_RULES.Name = "button_RULES";
            this.button_RULES.Size = new System.Drawing.Size(194, 60);
            this.button_RULES.TabIndex = 1;
            this.button_RULES.Text = "RULES";
            this.button_RULES.UseVisualStyleBackColor = false;
            this.button_RULES.Click += new System.EventHandler(this.button_RULES_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.BackColor = System.Drawing.Color.Moccasin;
            this.button_EXIT.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EXIT.ForeColor = System.Drawing.Color.Red;
            this.button_EXIT.Location = new System.Drawing.Point(793, 617);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(194, 60);
            this.button_EXIT.TabIndex = 2;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = false;
            this.button_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            // 
            // start
            // 
            this.start.BackgroundImage = global::gamenfa.Properties.Resources._17909527_1131178577011091_251010287_n;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Controls.Add(this.label_no_game);
            this.start.Controls.Add(this.button_user);
            this.start.Controls.Add(this.button_mainmenu);
            this.start.Controls.Add(this.label_rules);
            this.start.Controls.Add(this.button_hard);
            this.start.Controls.Add(this.button_medium);
            this.start.Controls.Add(this.button_easy);
            this.start.Controls.Add(this.button_EXIT);
            this.start.Controls.Add(this.button_RULES);
            this.start.Controls.Add(this.LABEL_TITLE);
            this.start.Controls.Add(this.button_start);
            this.start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(1028, 711);
            this.start.TabIndex = 7;
            this.start.Paint += new System.Windows.Forms.PaintEventHandler(this.start_Paint);
            // 
            // label_no_game
            // 
            this.label_no_game.AutoSize = true;
            this.label_no_game.BackColor = System.Drawing.Color.Moccasin;
            this.label_no_game.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_no_game.ForeColor = System.Drawing.Color.Red;
            this.label_no_game.Location = new System.Drawing.Point(182, 353);
            this.label_no_game.Name = "label_no_game";
            this.label_no_game.Size = new System.Drawing.Size(642, 74);
            this.label_no_game.TabIndex = 9;
            this.label_no_game.Text = "NO THERE IS NO GAME";
            this.label_no_game.Visible = false;
            // 
            // button_user
            // 
            this.button_user.BackColor = System.Drawing.Color.Moccasin;
            this.button_user.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_user.ForeColor = System.Drawing.Color.Red;
            this.button_user.Location = new System.Drawing.Point(362, 491);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(284, 60);
            this.button_user.TabIndex = 8;
            this.button_user.Text = "USER OWN GAME";
            this.button_user.UseVisualStyleBackColor = false;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_mainmenu
            // 
            this.button_mainmenu.BackColor = System.Drawing.Color.Moccasin;
            this.button_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mainmenu.ForeColor = System.Drawing.Color.Red;
            this.button_mainmenu.Location = new System.Drawing.Point(22, 617);
            this.button_mainmenu.Name = "button_mainmenu";
            this.button_mainmenu.Size = new System.Drawing.Size(255, 60);
            this.button_mainmenu.TabIndex = 7;
            this.button_mainmenu.Text = "MAIN MENU";
            this.button_mainmenu.UseVisualStyleBackColor = false;
            this.button_mainmenu.Visible = false;
            this.button_mainmenu.Click += new System.EventHandler(this.button_mainmenu_Click);
            // 
            // label_rules
            // 
            this.label_rules.AutoSize = true;
            this.label_rules.BackColor = System.Drawing.Color.Moccasin;
            this.label_rules.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rules.ForeColor = System.Drawing.Color.Red;
            this.label_rules.Location = new System.Drawing.Point(54, 165);
            this.label_rules.Name = "label_rules";
            this.label_rules.Size = new System.Drawing.Size(908, 420);
            this.label_rules.TabIndex = 6;
            this.label_rules.Text = resources.GetString("label_rules.Text");
            this.label_rules.Visible = false;
            // 
            // button_hard
            // 
            this.button_hard.BackColor = System.Drawing.Color.Moccasin;
            this.button_hard.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hard.ForeColor = System.Drawing.Color.Red;
            this.button_hard.Location = new System.Drawing.Point(397, 491);
            this.button_hard.Name = "button_hard";
            this.button_hard.Size = new System.Drawing.Size(194, 60);
            this.button_hard.TabIndex = 5;
            this.button_hard.Text = "HARD";
            this.button_hard.UseVisualStyleBackColor = false;
            this.button_hard.Visible = false;
            this.button_hard.Click += new System.EventHandler(this.button_hard_Click);
            // 
            // button_medium
            // 
            this.button_medium.BackColor = System.Drawing.Color.Moccasin;
            this.button_medium.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_medium.ForeColor = System.Drawing.Color.Red;
            this.button_medium.Location = new System.Drawing.Point(397, 353);
            this.button_medium.Name = "button_medium";
            this.button_medium.Size = new System.Drawing.Size(194, 60);
            this.button_medium.TabIndex = 4;
            this.button_medium.Text = "MEDIUM";
            this.button_medium.UseVisualStyleBackColor = false;
            this.button_medium.Visible = false;
            this.button_medium.Click += new System.EventHandler(this.button_medium_Click);
            // 
            // button_easy
            // 
            this.button_easy.BackColor = System.Drawing.Color.Moccasin;
            this.button_easy.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_easy.ForeColor = System.Drawing.Color.Red;
            this.button_easy.Location = new System.Drawing.Point(397, 227);
            this.button_easy.Name = "button_easy";
            this.button_easy.Size = new System.Drawing.Size(194, 60);
            this.button_easy.TabIndex = 3;
            this.button_easy.Text = "EASY";
            this.button_easy.UseVisualStyleBackColor = false;
            this.button_easy.Visible = false;
            this.button_easy.Click += new System.EventHandler(this.button_easy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 711);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.start.ResumeLayout(false);
            this.start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label LABEL_TITLE;
        private System.Windows.Forms.Button button_RULES;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Panel start;
        private System.Windows.Forms.Button button_hard;
        private System.Windows.Forms.Button button_medium;
        private System.Windows.Forms.Button button_easy;
        private System.Windows.Forms.Label label_rules;
        private System.Windows.Forms.Button button_mainmenu;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Label label_no_game;

    }
}

