namespace WF_Main_Project
{
    partial class Form_Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Start_game_label = new Label();
            Continue_btn = new Button();
            Info_btn = new Button();
            Exit_btn = new Button();
            SuspendLayout();
            // 
            // Start_game_label
            // 
            Start_game_label.AutoSize = true;
            Start_game_label.BackColor = Color.Transparent;
            Start_game_label.Font = new Font("Calibri", 50F, FontStyle.Bold);
            Start_game_label.ForeColor = Color.FromArgb(255, 128, 0);
            Start_game_label.Location = new Point(191, 54);
            Start_game_label.Margin = new Padding(1, 0, 1, 0);
            Start_game_label.Name = "Start_game_label";
            Start_game_label.Size = new Size(345, 93);
            Start_game_label.TabIndex = 0;
            Start_game_label.Text = "Start Game";
            Start_game_label.UseCompatibleTextRendering = true;
            // 
            // Continue_btn
            // 
            Continue_btn.BackColor = Color.OliveDrab;
            Continue_btn.BackgroundImageLayout = ImageLayout.Center;
            Continue_btn.Cursor = Cursors.Hand;
            Continue_btn.Font = new Font("Freestyle Script", 20F);
            Continue_btn.ForeColor = Color.White;
            Continue_btn.Location = new Point(293, 208);
            Continue_btn.Margin = new Padding(1);
            Continue_btn.Name = "Continue_btn";
            Continue_btn.Size = new Size(98, 62);
            Continue_btn.TabIndex = 1;
            Continue_btn.Text = "Continue";
            Continue_btn.UseVisualStyleBackColor = false;
            Continue_btn.Click += Continue_btn_Click;
            // 
            // Info_btn
            // 
            Info_btn.BackColor = Color.Gold;
            Info_btn.Cursor = Cursors.Hand;
            Info_btn.Font = new Font("Freestyle Script", 20F);
            Info_btn.ForeColor = Color.Olive;
            Info_btn.Location = new Point(293, 289);
            Info_btn.Margin = new Padding(1);
            Info_btn.Name = "Info_btn";
            Info_btn.Size = new Size(98, 62);
            Info_btn.TabIndex = 2;
            Info_btn.Text = "Info";
            Info_btn.UseVisualStyleBackColor = false;
            Info_btn.Click += Info_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.IndianRed;
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.Font = new Font("Freestyle Script", 20F);
            Exit_btn.ForeColor = Color.Navy;
            Exit_btn.Location = new Point(293, 371);
            Exit_btn.Margin = new Padding(1);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(98, 63);
            Exit_btn.TabIndex = 3;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Form_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.start_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 534);
            Controls.Add(Exit_btn);
            Controls.Add(Info_btn);
            Controls.Add(Continue_btn);
            Controls.Add(Start_game_label);
            Margin = new Padding(1);
            Name = "Form_Start";
            Text = "Form1";
            Load += Form_Start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Start_game_label;
        private Button Continue_btn;
        private Button Info_btn;
        private Button Exit_btn;
    }
}
