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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();
            form1.FormBorderStyle = FormBorderStyle.None;
            
            //panel1.Controls.Clear();
            //Form2 form2 = new Form2();
            //form2.TopLevel = false;
            //panel1.Controls.Add(form2);
        }
    

    }
}
