namespace WF_Main_Project
{
    public partial class Form_Choose_Arena : Form
    {
        private string fighter1;
        private string fighter2;

        public Form_Choose_Arena(string fighter1, string fighter2)
        {
            InitializeComponent();

            this.fighter1 = fighter1;
            this.fighter2 = fighter2;

            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form_Choose_Arena_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Continue_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Continue_btn.Enabled = true;
            Form form = new Battle_Form();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
