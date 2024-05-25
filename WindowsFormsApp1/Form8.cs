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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        private void guna2Button2_Click_2(object sender, EventArgs e)
        {

        }
        public void Afficher(int pos)
        {
            if (pos != -1)
            {
                NM_1.Text = ds1.Tables["Prop1"].Rows[pos][1].ToString();
                PR_1.Text = ds1.Tables["Prop1"].Rows[pos][2].ToString();
            }
            else
            {
                MessageBox.Show("errur");
            }

        }
        string ps;
        string id;
        string cin;
        private void Form8_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap1.Fill(ds1, "Prop1");
            dec.con.Close();
            dec.con.Open();
            dec.dap2.Fill(ds2, "Prop2");
            dec.con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int p = RECHER3(guna2TextBox4.Text);
            ds2.Tables["Prop2"].Rows[p][1] = DateTime.Parse(guna2DateTimePicker1.Text);
            ds2.Tables["Prop2"].Rows[p][2] = Time_btn.Text;
            ds2.Tables["Prop2"].Rows[p][3] = cin;

            dec.cd2.GetInsertCommand();
            dec.dap2.Update(ds2.Tables["Prop2"]);
            MessageBox.Show("Bien Modifé");
        }
        int i, pos = -1;

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ds2.Tables["Prop2"].Rows.Add(null, DateTime.Parse(Date_AJ.Text), Time_AJ.Text, cin);
            dec.cd2.GetInsertCommand();
            dec.dap2.Update(ds2.Tables["Prop2"]);
            MessageBox.Show("Bien Ajouté");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pos = RECHER(guna2TextBox5.Text);
            Afficher(pos);
            RECHER2(guna2TextBox5.Text);
            cin = guna2TextBox5.Text;
        }

        public int RECHER(string n)
        {
            for (i = 0; i < ds1.Tables["Prop1"].Rows.Count; i++)
            {
                if (ds1.Tables["Prop1"].Rows[i][0].ToString() == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }

        private void BTN_supp_Click(object sender, EventArgs e)
        {
            int p = RECHER3(ID_SUPP.Text);
            ds2.Tables["Prop2"].Rows[p].Delete();
            dec.cd2.GetDeleteCommand();
            dec.dap2.Update(ds2.Tables["Prop2"]);
            MessageBox.Show("Bien supprimé");

        }

        public void RECHER2(string n)
        {
            for (i = 0; i < ds2.Tables["Prop2"].Rows.Count; i++)
            {
                if (ds2.Tables["Prop2"].Rows[i][3].ToString() == n)
                {
                    DataRow[] rows = ds2.Tables["Prop2"].Select("CIN = '" + n + "'");
                    DGV1.DataSource = rows.CopyToDataTable();

                    DataRow[] rows1 = ds2.Tables["Prop2"].Select("CIN = '" + n + "'");
                    DGV2.DataSource = rows1.CopyToDataTable();

                }

            }



        }
        public int RECHER3(string d)
        {
            for (i = 0; i < ds2.Tables["Prop2"].Rows.Count; i++)
            {
                if (ds2.Tables["Prop2"].Rows[i][0].ToString() == d)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }
    }
}
