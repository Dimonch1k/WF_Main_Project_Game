using Microsoft.VisualBasic.Devices;

namespace WF_Main_Project
{
    public partial class choose_fighter_radio_form : Form
    {
        public static int Fighter { get; set; }

        public choose_fighter_radio_form()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
        }

        private void choose_fighter_radio_form_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        // Archer radio button changed
        private void Archer_radio_btn_Click(object sender, EventArgs e)
        {
            Fighter = 1;
            Mage_radio_btn.Checked = false;
            Warrior_radio_btn.Checked = false;
        }

        // Mage radio button changed
        private void Mage_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            Fighter = 2;
            Archer_radio_btn.Checked = false;
            Warrior_radio_btn.Checked = false;
        }

        // Warrior radio button changed
        private void Warrior_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            Fighter = 3;
            Archer_radio_btn.Checked = false;
            Mage_radio_btn.Checked = false;
        }


        // Check every 0.1s if Submit_btn is can be Enabled
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Archer_radio_btn.Checked == true || Mage_radio_btn.Checked == true || Warrior_radio_btn.Checked == true)
            {
                Submit_btn.Enabled = true;
            }
            else
            {
                Submit_btn.Enabled = false;
            }
        }


        // Submit button Click
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
        }
    }
}

