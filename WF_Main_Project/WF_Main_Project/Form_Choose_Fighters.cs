namespace WF_Main_Project
{
    public partial class Form_Choose_Fighters : Form
    {
        public Form_Choose_Fighters()
        {
            InitializeComponent();
            Choose_fighters_Label();

            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form_Choose_Fighters_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        // Choose Fighters Label
        private void Choose_fighters_Label()
        {
            Choose_fighters_label.Left = (this.ClientSize.Width - Choose_fighters_label.Size.Width) / 2;
            Choose_fighters_label.Top = (this.ClientSize.Height - Choose_fighters_label.Size.Height) / 10;
            Choose_fighters_label.TextAlign = ContentAlignment.MiddleCenter;
        }


        // Choose fighter 1 Click
        private void choose_fighter1_btn_Click(object sender, EventArgs e)
        {
            Form form = new choose_fighter_radio_form();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();


            int fighter = choose_fighter_radio_form.Fighter;

            switch (fighter)
            {
                case 0:
                    choose_fighter1_btn.Text = "Choose fighter 1";
                    choose_fighter1_btn.BackColor = Color.Gray;
                    break;
                case 1:
                    choose_fighter1_btn.Text = "Archer";
                    choose_fighter1_btn.BackColor = Color.DarkSeaGreen;
                    break;
                case 2:
                    choose_fighter1_btn.Text = "Mage";
                    choose_fighter1_btn.BackColor = Color.DarkCyan;
                    break;
                case 3:
                    choose_fighter1_btn.Text = "Warrior";
                    choose_fighter1_btn.BackColor = Color.DarkOrange;
                    break;
            }
        }

        // Choose fighter 2 Click
        private void choose_fighter2_btn_Click(object sender, EventArgs e)
        {
            Form form = new choose_fighter_radio_form();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();


            int fighter = choose_fighter_radio_form.Fighter;

            switch (fighter)
            {
                case 0:
                    choose_fighter2_btn.Text = "Choose fighter 2";
                    choose_fighter2_btn.BackColor = Color.Gray;
                    break;
                case 1:
                    choose_fighter2_btn.Text = "Archer";
                    choose_fighter2_btn.BackColor = Color.DarkSeaGreen;
                    break;
                case 2:
                    choose_fighter2_btn.Text = "Mage";
                    choose_fighter2_btn.BackColor = Color.DarkCyan;
                    break;
                case 3:
                    choose_fighter2_btn.Text = "Warrior";
                    choose_fighter2_btn.BackColor = Color.DarkOrange;
                    break;
            }
        }


        // Continue button Click
        private void Continue_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Continue_btn.Enabled = true;
            string fighter1 = choose_fighter1_btn.Text;
            string fighter2 = choose_fighter2_btn.Text;
            Form form = new Form_Choose_Arena(fighter1, fighter2);
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }


        // Timer Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (choose_fighter1_btn.Text == "Click to choose 1" || choose_fighter2_btn.Text == "Click to choose 2")
            {
                Continue_btn.Enabled = false;
                Continue_btn.Cursor = Cursors.No;
            }
            else
            {
                Continue_btn.Enabled = true;
                Continue_btn.Cursor = Cursors.Hand;
            }
        }
    }
}
