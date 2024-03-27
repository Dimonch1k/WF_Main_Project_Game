namespace WF_Main_Project
{
    partial class Form_Choose_Fighters
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
            components = new System.ComponentModel.Container();
            Choose_fighters_label = new Label();
            Continue_btn = new Button();
            Fighter_1 = new Label();
            Fighter_2 = new Label();
            choose_fighter1_btn = new Button();
            choose_fighter2_btn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Choose_fighters_label
            // 
            Choose_fighters_label.AutoSize = true;
            Choose_fighters_label.BackColor = Color.Transparent;
            Choose_fighters_label.Font = new Font("Calibri", 50F, FontStyle.Bold);
            Choose_fighters_label.ForeColor = Color.FromArgb(0, 0, 192);
            Choose_fighters_label.Location = new Point(124, 35);
            Choose_fighters_label.Margin = new Padding(1, 0, 1, 0);
            Choose_fighters_label.Name = "Choose_fighters_label";
            Choose_fighters_label.Size = new Size(475, 93);
            Choose_fighters_label.TabIndex = 1;
            Choose_fighters_label.Text = "Choose Fighters";
            Choose_fighters_label.UseCompatibleTextRendering = true;
            // 
            // Continue_btn
            // 
            Continue_btn.BackColor = Color.OliveDrab;
            Continue_btn.BackgroundImageLayout = ImageLayout.Center;
            Continue_btn.Cursor = Cursors.Hand;
            Continue_btn.Enabled = false;
            Continue_btn.Font = new Font("Freestyle Script", 50F, FontStyle.Bold);
            Continue_btn.ForeColor = Color.White;
            Continue_btn.Location = new Point(116, 403);
            Continue_btn.Margin = new Padding(1);
            Continue_btn.Name = "Continue_btn";
            Continue_btn.Size = new Size(491, 87);
            Continue_btn.TabIndex = 2;
            Continue_btn.Text = "Continue";
            Continue_btn.UseVisualStyleBackColor = false;
            Continue_btn.Click += Continue_btn_Click;
            // 
            // Fighter_1
            // 
            Fighter_1.AutoSize = true;
            Fighter_1.BackColor = Color.FromArgb(255, 128, 0);
            Fighter_1.Font = new Font("MV Boli", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fighter_1.Location = new Point(116, 192);
            Fighter_1.Margin = new Padding(1, 0, 1, 0);
            Fighter_1.Name = "Fighter_1";
            Fighter_1.Size = new Size(204, 52);
            Fighter_1.TabIndex = 3;
            Fighter_1.Text = "Fighter 1:";
            // 
            // Fighter_2
            // 
            Fighter_2.AutoSize = true;
            Fighter_2.BackColor = Color.FromArgb(255, 128, 128);
            Fighter_2.Font = new Font("MV Boli", 30F);
            Fighter_2.Location = new Point(116, 287);
            Fighter_2.Margin = new Padding(1, 0, 1, 0);
            Fighter_2.Name = "Fighter_2";
            Fighter_2.Size = new Size(215, 52);
            Fighter_2.TabIndex = 4;
            Fighter_2.Text = "Fighter 2:";
            // 
            // choose_fighter1_btn
            // 
            choose_fighter1_btn.BackColor = Color.FromArgb(255, 192, 128);
            choose_fighter1_btn.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            choose_fighter1_btn.Location = new Point(458, 192);
            choose_fighter1_btn.Margin = new Padding(1);
            choose_fighter1_btn.Name = "choose_fighter1_btn";
            choose_fighter1_btn.Size = new Size(149, 52);
            choose_fighter1_btn.TabIndex = 5;
            choose_fighter1_btn.Text = "Click to choose 1";
            choose_fighter1_btn.UseVisualStyleBackColor = false;
            choose_fighter1_btn.Click += choose_fighter1_btn_Click;
            // 
            // choose_fighter2_btn
            // 
            choose_fighter2_btn.BackColor = Color.FromArgb(255, 128, 128);
            choose_fighter2_btn.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            choose_fighter2_btn.Location = new Point(458, 287);
            choose_fighter2_btn.Margin = new Padding(1);
            choose_fighter2_btn.Name = "choose_fighter2_btn";
            choose_fighter2_btn.Size = new Size(149, 52);
            choose_fighter2_btn.TabIndex = 6;
            choose_fighter2_btn.Text = "Click to choose 2";
            choose_fighter2_btn.UseVisualStyleBackColor = false;
            choose_fighter2_btn.Click += choose_fighter2_btn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_Choose_Fighters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.choose_fighters_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 541);
            Controls.Add(choose_fighter2_btn);
            Controls.Add(choose_fighter1_btn);
            Controls.Add(Fighter_2);
            Controls.Add(Fighter_1);
            Controls.Add(Continue_btn);
            Controls.Add(Choose_fighters_label);
            Margin = new Padding(1);
            Name = "Form_Choose_Fighters";
            Text = "Form_Choose_Fighters";
            Load += Form_Choose_Fighters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Choose_fighters_label;
        private Button Continue_btn;
        private Label Fighter_1;
        private Label Fighter_2;
        private Button choose_fighter1_btn;
        private Button choose_fighter2_btn;
        private System.Windows.Forms.Timer timer1;
    }
}