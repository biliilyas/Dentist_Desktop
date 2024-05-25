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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        int id;
        string s;
        DateTime d;
        private void Tx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void DateTr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap4.Fill(ds4, "Prop4");
            dec.con.Close();

            dec.con.Open();
            dec.dap3.Fill(ds3, "Prop3");
            dec.con.Close();
        }
        public void Afficher(int pos)
        {
            if (pos != -1)
            {
                LB_Nom.Text = "il déja visité";
                id = pos;

                for (i = 0; i < ds4.Tables["Prop4"].Rows.Count; i++)
                {
                    if (ds4.Tables["Prop4"].Rows[i][2].ToString() == id1)
                    {
                        DateTr.Items.Add(ds4.Tables["Prop4"].Rows[i][1].ToString());


                    }

                }

            }
            else
            {
                MessageBox.Show("errur");
            }

        }
        string g;
        int f;

        int i, pos = -1;
        string id1;

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pos = RECHER(Tx_id.Text);

            id1 = Tx_id.Text;

            Afficher(pos);
        }

        private void DateTr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (i = 0; i < ds4.Tables["Prop4"].Rows.Count; i++)
            {
                if (ds4.Tables["Prop4"].Rows[i][2].ToString() == id1 && ds4.Tables["Prop4"].Rows[i][1].ToString() == DateTr.SelectedItem.ToString())
                {
                    DataRow[] rows = ds3.Tables["Prop3"].Select("id_visite = '" + ds4.Tables["Prop4"].Rows[i][0].ToString() + "'");
                    guna2DataGridView1.DataSource = rows.CopyToDataTable();

                }

            }
        }

        public int RECHER(string n)
        {
            for (i = 0; i < ds4.Tables["Prop4"].Rows.Count; i++)
            {
                if (ds4.Tables["Prop4"].Rows[i][2].ToString() == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }

    }
}
