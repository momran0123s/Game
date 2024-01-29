using Microsoft.Data.SqlClient;
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
    public partial class Scores : Form
    {
        SqlConnection con;
        public Scores()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=XOGame;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            getScores();
            
        }

        private void getScores()
        {
            SqlCommand cmd = new SqlCommand("select [Id],[PlayerXName],[PlayerXScore],[PlayerOName],[PlayerOScore],[GameDate] from Game", con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            dgv_scores.DataSource = dt;
        }


        int curId = 0;
        private void dgv_scores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgv_scores.SelectedRows[0];
            curId = (int)row.Cells["Id"].Value;
            btn_delete.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from [Game] where [Id] = @id", con);
            cmd.Parameters.AddWithValue("id", curId);
            int rowAffected = 0;
            try
            {
                con.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close();}
            if (rowAffected != 0)
            {
                MessageBox.Show("Data Deleted successfully");
                btn_delete.Visible=false;
                getScores();
            }
        }
    }
}
