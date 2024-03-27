namespace WF_Main_Project
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
            Create_Label_Start();
        }

        public void Form_Start_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }


        // Continue button Click
        private void Continue_btn_Click(object sender, EventArgs e)
        {
            Form form = new Form_Choose_Fighters();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }


        // Info button Click
        private void Info_btn_Click(object obj, EventArgs e)
        {
            string message = "Game, where you can choose two heroes and manage them. they have buffs and debuffs at different locations. there is also chance to make crit and to dodge the enemy attack.";
            MessageBox.Show(message, "GAME Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Exit button Click 
        private void Exit_btn_Click(Object obj, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


        // Create Label Start - forColor, backColor, alighnment, location
        private void Create_Label_Start()
        {
            Start_game_label.Left = (this.ClientSize.Width - Start_game_label.Size.Width) / 2;
            Start_game_label.Top = (this.ClientSize.Height - Start_game_label.Size.Height) / 10;
            Start_game_label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
