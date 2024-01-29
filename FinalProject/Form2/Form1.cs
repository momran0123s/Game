namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //rb_player1_x.Checked = rb_player1_o.Checked = rb_player2_x.Checked = rb_player2_o.Checked = false;
        }

        private void rb_player1_x_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player1_x.Checked)
            {
                rb_player2_o.Checked = true;
                rb_player2_x.Checked = false;
            }
        }

        private void rb_player1_o_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player1_o.Checked)
            {
                rb_player2_x.Checked = true;
                rb_player2_o.Checked = false;
            }
        }

        private void rb_player2_x_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player2_x.Checked)
            {
                rb_player1_o.Checked = true;
                rb_player1_x.Checked = false;
            }
        }

        private void rb_player2_o_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player2_o.Checked)
            {
                rb_player1_x.Checked = true;
                rb_player1_o.Checked = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
        }
    }
}
