namespace WF_Main_Project
{
    partial class Form_Choose_Arena
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
            Continue_btn = new Button();
            Choose_fighters_label = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Continue_btn
            // 
            Continue_btn.BackColor = Color.OliveDrab;
            Continue_btn.BackgroundImageLayout = ImageLayout.Center;
            Continue_btn.Cursor = Cursors.Hand;
            Continue_btn.Font = new Font("Freestyle Script", 50F, FontStyle.Bold);
            Continue_btn.ForeColor = Color.White;
            Continue_btn.Location = new Point(121, 397);
            Continue_btn.Margin = new Padding(1);
            Continue_btn.Name = "Continue_btn";
            Continue_btn.Size = new Size(491, 87);
            Continue_btn.TabIndex = 8;
            Continue_btn.Text = "Continue";
            Continue_btn.UseVisualStyleBackColor = false;
            Continue_btn.Click += Continue_btn_Click;
            // 
            // Choose_fighters_label
            // 
            Choose_fighters_label.AutoSize = true;
            Choose_fighters_label.BackColor = Color.Transparent;
            Choose_fighters_label.Font = new Font("Calibri", 50F, FontStyle.Bold);
            Choose_fighters_label.ForeColor = Color.Green;
            Choose_fighters_label.Location = new Point(43, 52);
            Choose_fighters_label.Margin = new Padding(1, 0, 1, 0);
            Choose_fighters_label.Name = "Choose_fighters_label";
            Choose_fighters_label.Size = new Size(623, 93);
            Choose_fighters_label.TabIndex = 7;
            Choose_fighters_label.Text = "Choose Battleground";
            Choose_fighters_label.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.forest_bcg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 193);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 149);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Snow_Arena;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(266, 193);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 149);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.choose_battlefield_image;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(511, 194);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 151);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_Choose_Arena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.moon_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 537);
            Controls.Add(Choose_fighters_label);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Continue_btn);
            Margin = new Padding(1);
            Name = "Form_Choose_Arena";
            Text = "Form_Choose_Arena";
            Load += Form_Choose_Arena_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button choose_fighter2_btn;
        private Button choose_fighter1_btn;
        private Label Fighter_2;
        private Label Fighter_1;
        private Button Continue_btn;
        private Label Choose_fighters_label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}