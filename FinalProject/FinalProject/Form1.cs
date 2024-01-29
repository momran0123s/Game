using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
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


        //private void validate()
        //{
        //    if(tb_player1.Text == "" || tb_player2.Text == "")
        //    {
        //        throw new Exception("Enter Player Names");
        //    }
        //}
    
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            if(tb_player1.Text.Length == 0|| tb_player2.Text.Length == 0)
            {
                MessageBox.Show("please enter player names");
            }
            else
            {
            this.Hide();
            Form2 form2 = new Form2();
            if (rb_player1_x.Checked)
            {
                form2.player1 = tb_player1.Text;
                form2.player2 = tb_player2.Text;

            }
            if (rb_player2_x.Checked)
            {
                form2.player1 = tb_player2.Text;
                form2.player2 = tb_player1.Text;
            }
            form2.ShowDialog();
            this.Close();

            }

        }


    }
}
