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
    public partial class Form6 : Form
    {
        DataSet ds6 = new DataSet();
        public Form6()
        {
            InitializeComponent();
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap1.Fill(ds6, "Prop7");
            dec.con.Close();
            guna2DataGridView2.DataSource = ds6.Tables["Prop7"];
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            DataRow[] rows = ds6.Tables["Prop7"].Select("CIN = '" + id6.Text + "'");
            guna2DataGridView2.DataSource = rows.CopyToDataTable();
        }
        int i, pos = -1;

        private void guna2DataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public int RECHER(int n)
        {
            for (i = 0; i < ds6.Tables["Prop7"].Rows.Count; i++)
            {
                if (int.Parse(ds6.Tables["Prop7"].Rows[i][0].ToString()) == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }
    }
}
