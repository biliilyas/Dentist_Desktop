using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        DataSet ds7 = new DataSet();

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int i, pos = -1;
        public int RECHER(string n)
        {
            for (i = 0; i < ds7.Tables["Prop2"].Rows.Count; i++)
            {
                if (ds7.Tables["Prop2"].Rows[i][3].ToString() == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap2.Fill(ds7, "Prop2");
            dec.con.Close();


            guna2DataGridView1.DataSource = ds7.Tables["Prop2"];
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            DataRow[] rows = ds7.Tables["Prop2"].Select("CIN = '" + ID7.Text + "'");
            guna2DataGridView1.DataSource = rows.CopyToDataTable();
        }
    }
}
