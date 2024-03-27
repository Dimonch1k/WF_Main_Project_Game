namespace WF_Main_Project
{
    partial class choose_fighter_radio_form
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
            Archer_radio_btn = new RadioButton();
            Submit_btn = new Button();
            Mage_radio_btn = new RadioButton();
            Warrior_radio_btn = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Archer_radio_btn
            // 
            Archer_radio_btn.AutoSize = true;
            Archer_radio_btn.BackColor = Color.OliveDrab;
            Archer_radio_btn.Checked = true;
            Archer_radio_btn.Font = new Font("Calibri", 12F);
            Archer_radio_btn.Location = new Point(56, 69);
            Archer_radio_btn.Margin = new Padding(1, 1, 1, 1);
            Archer_radio_btn.Name = "Archer_radio_btn";
            Archer_radio_btn.Size = new Size(69, 23);
            Archer_radio_btn.TabIndex = 0;
            Archer_radio_btn.TabStop = true;
            Archer_radio_btn.Text = "Archer";
            Archer_radio_btn.UseVisualStyleBackColor = false;
            Archer_radio_btn.Click += Archer_radio_btn_Click;
            // 
            // Submit_btn
            // 
            Submit_btn.BackColor = Color.Yellow;
            Submit_btn.Font = new Font("Segoe UI", 15F);
            Submit_btn.Location = new Point(56, 140);
            Submit_btn.Margin = new Padding(1, 1, 1, 1);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(291, 43);
            Submit_btn.TabIndex = 1;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = false;
            Submit_btn.Click += Submit_btn_Click;
            // 
            // Mage_radio_btn
            // 
            Mage_radio_btn.AutoSize = true;
            Mage_radio_btn.BackColor = Color.SteelBlue;
            Mage_radio_btn.Font = new Font("Segoe UI", 12F);
            Mage_radio_btn.Location = new Point(164, 68);
            Mage_radio_btn.Margin = new Padding(1, 1, 1, 1);
            Mage_radio_btn.Name = "Mage_radio_btn";
            Mage_radio_btn.Size = new Size(67, 25);
            Mage_radio_btn.TabIndex = 2;
            Mage_radio_btn.Text = "Mage";
            Mage_radio_btn.UseVisualStyleBackColor = false;
            Mage_radio_btn.CheckedChanged += Mage_radio_btn_CheckedChanged;
            // 
            // Warrior_radio_btn
            // 
            Warrior_radio_btn.AutoSize = true;
            Warrior_radio_btn.BackColor = Color.IndianRed;
            Warrior_radio_btn.Font = new Font("Segoe UI", 12F);
            Warrior_radio_btn.Location = new Point(267, 68);
            Warrior_radio_btn.Margin = new Padding(1, 1, 1, 1);
            Warrior_radio_btn.Name = "Warrior_radio_btn";
            Warrior_radio_btn.Size = new Size(81, 25);
            Warrior_radio_btn.TabIndex = 3;
            Warrior_radio_btn.Text = "Warrior";
            Warrior_radio_btn.UseVisualStyleBackColor = false;
            Warrior_radio_btn.CheckedChanged += Warrior_radio_btn_CheckedChanged;
            // 
            // choose_fighter_radio_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 252);
            Controls.Add(Warrior_radio_btn);
            Controls.Add(Mage_radio_btn);
            Controls.Add(Submit_btn);
            Controls.Add(Archer_radio_btn);
            Margin = new Padding(1, 1, 1, 1);
            Name = "choose_fighter_radio_form";
            Text = "choose_fighter_radio_form";
            Load += choose_fighter_radio_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Archer_radio_btn;
        private Button Submit_btn;
        private RadioButton Mage_radio_btn;
        private RadioButton Warrior_radio_btn;
        private System.Windows.Forms.Timer timer1;
    }
}