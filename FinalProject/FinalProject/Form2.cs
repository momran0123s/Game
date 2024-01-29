using Microsoft.Data.SqlClient;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        public string player1;
        public string player2;
        public int score1 = 0;
        public int score2 = 0;
        char turn = 'X';
        int movement = 0;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=XOGame;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_player1.Text = player1;
            lbl_player2.Text = player2;
        }




        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            btn.BackColor = Color.CadetBlue;
            if (turn == 'X')
            {
                btn.Text = "X";
                if (checkDraw()) { MessageBox.Show("Draw"); turn = 'O'; }
                else if (checkWinner())
                {
                    MessageBox.Show($"The winner is {lbl_player1.Text}");
                    score1++;
                    lbl_score1.Text = score1.ToString();
                    turn = 'O';
                }
                else turn = 'O';
            }
            else
            {
                btn.Text = "O";
                if (checkDraw()) { MessageBox.Show("Draw"); turn = 'X'; }
                else if (checkWinner())
                {
                    MessageBox.Show($"The winner is {lbl_player2.Text}");
                    score2++;
                    lbl_score2.Text = score2.ToString();
                    turn = 'X';
                }
                else turn = 'X';
            }
            movement++;
        }
        private bool checkDraw()
        {
            if (movement == 8)
            {
                
                tlp_btns.Enabled = false;
                return true;
            }else return false;
        }
        private bool checkWinner()
        {
            if ((btn_1.Text == btn_2.Text && btn_2.Text == btn_3.Text && btn_2.Text != "") ||
                (btn_4.Text == btn_5.Text && btn_5.Text == btn_6.Text && btn_4.Text != "") ||
                (btn_7.Text == btn_8.Text && btn_8.Text == btn_9.Text && btn_8.Text != "") ||
                (btn_1.Text == btn_4.Text && btn_4.Text == btn_7.Text && btn_4.Text != "") ||
                (btn_2.Text == btn_5.Text && btn_5.Text == btn_8.Text && btn_5.Text != "") ||
                (btn_3.Text == btn_6.Text && btn_6.Text == btn_9.Text && btn_6.Text != "") ||
                (btn_1.Text == btn_5.Text && btn_5.Text == btn_9.Text && btn_5.Text != "") ||
                (btn_3.Text == btn_5.Text && btn_5.Text == btn_7.Text && btn_5.Text != ""))
            {

                tlp_btns.Enabled = false;
                return true;

            }
            else return false;

        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            //turn = 'X';
            movement = 0;
            btn_1.Enabled = true; btn_1.Text = ""; btn_1.BackColor = Color.White;
            btn_2.Enabled = true; btn_2.Text = ""; btn_2.BackColor = Color.White;
            btn_3.Enabled = true; btn_3.Text = ""; btn_3.BackColor = Color.White;
            btn_4.Enabled = true; btn_4.Text = ""; btn_4.BackColor = Color.White;
            btn_5.Enabled = true; btn_5.Text = ""; btn_5.BackColor = Color.White;
            btn_6.Enabled = true; btn_6.Text = ""; btn_6.BackColor = Color.White;
            btn_7.Enabled = true; btn_7.Text = ""; btn_7.BackColor = Color.White;
            btn_8.Enabled = true; btn_8.Text = ""; btn_8.BackColor = Color.White;
            btn_9.Enabled = true; btn_9.Text = ""; btn_9.BackColor = Color.White;
            tlp_btns.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_newGame_Click(sender, e);
            score1 = 0;
            score2 = 0;
            lbl_score1.Text = score1.ToString();
            lbl_score2.Text = score2.ToString();


        }

        private void btn_saveScore_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into Game ([PlayerXName],[PlayerXScore],[PlayerOName],[PlayerOScore],[GameDate])values('{player1}',{score1},'{player2}',{score2},GETDATE())", con);
            int rowAffected = 0;
            try
            {
                con.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            if (rowAffected > 0)
            {
                MessageBox.Show("Scores added successfully");
                this.Hide();
                Scores scores = new Scores();
                scores.ShowDialog();
                this.Close();
            }
        }

        private void lbl_y_Click(object sender, EventArgs e)
        {

        }
    }
}

        //private bool checkWinner2()
        //{
        //    string[,] arrOfBtn =
        //          {
        //        {btn_1.Text, btn_2.Text, btn_3.Text },
        //        {btn_4.Text, btn_5.Text, btn_6.Text },
        //        {btn_7.Text, btn_8.Text, btn_9.Text }
        //          };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if ((arrOfBtn[i, 0] == arrOfBtn[i, 1] && arrOfBtn[i, 1] == arrOfBtn[i, 2] && arrOfBtn[i, 1] != "") ||
        //            (arrOfBtn[0, i] == arrOfBtn[1, i] && arrOfBtn[1, i] == arrOfBtn[2, i] && arrOfBtn[1, i] != "") ||
        //            (arrOfBtn[0, 0] == arrOfBtn[1, 1] && arrOfBtn[1, 1] == arrOfBtn[2, 2] && arrOfBtn[1, 1] != "") ||
        //            (arrOfBtn[0, 2] == arrOfBtn[1, 1] && arrOfBtn[1, 1] == arrOfBtn[2, 0] && arrOfBtn[1, 1] != ""))
        //        {
        //            tlp_btns.Enabled = false;
        //            return true;
        //        }
        //        else return false;
        //    }
        //    return false;
        //}