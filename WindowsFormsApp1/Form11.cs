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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet ds5 = new DataSet();
        private void Form11_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap1.Fill(ds, "Prop");
            dec.con.Close();
            dec.con.Open();
            dec.dap5.Fill(ds5, "Prop5");
            dec.con.Close();
        }
        int i, pos = -1;
        public void Afficher(int pos)
        {
            if (pos != -1)
            {
                TX_IDCL_Mod.Text = ds.Tables["Prop"].Rows[pos][0].ToString();
                TX_Nom_Mod.Text = ds.Tables["Prop"].Rows[pos][1].ToString();
                TX_Pre_Mod.Text = ds.Tables["Prop"].Rows[pos][2].ToString();
                TX_Num_Mod.Text = ds.Tables["Prop"].Rows[pos][3].ToString();
                TX_adress_Mod.Text = ds.Tables["Prop"].Rows[pos][4].ToString();
                Date_MOD.Text = ds.Tables["Prop"].Rows[pos][5].ToString();
            }
            else
            {
                MessageBox.Show("errur");
            }

        }
        public int RECHER(string n)
        {
            for (i = 0; i < ds.Tables["Prop"].Rows.Count; i++)
            {
                if (ds.Tables["Prop"].Rows[i][0].ToString() == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }


        public int RECHER2(string n)
        {
            for (i = 0; i < ds5.Tables["Prop5"].Rows.Count; i++)
            {
                if (ds5.Tables["Prop5"].Rows[i][0].ToString() == n)
                {
                    pos = i;
                    break;

                }

            }


            return pos;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int p = RECHER(TX_IDCL_Mod.Text);
            Afficher(p);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int p = RECHER2(TX_IDCL_AJ.Text);
            Afficher2(p);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ds.Tables["Prop"].Rows.Add(TX_IDCL_AJ.Text, TX_Nom_AJ.Text, TX_Pre_AJ.Text, int.Parse(TX_Nusq.Text), TX_Adress.Text, Date_AJ.Value);
            dec.cd1.GetInsertCommand();
            dec.dap1.Update(ds.Tables["Prop"]);
            MessageBox.Show("Bien Ajouté");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int p = RECHER(TX_IDCL_Mod.Text);
            ds.Tables["Prop"].Rows[pos][1] = TX_Nom_Mod.Text;
            ds.Tables["Prop"].Rows[pos][2] = TX_Pre_Mod.Text;
            ds.Tables["Prop"].Rows[pos][3] = int.Parse(TX_Num_Mod.Text);
            ds.Tables["Prop"].Rows[pos][4] = TX_adress_Mod.Text;
            ds.Tables["Prop"].Rows[pos][5] = DateTime.Parse(Date_MOD.Text);

            dec.cd1.GetInsertCommand();
            dec.dap1.Update(ds.Tables["Prop"]);
            MessageBox.Show("Bien Modifé");
        }

        private void BTN_supp_Click(object sender, EventArgs e)
        {
            int p = RECHER(BTN_supp.Text);
            ds.Tables["Prop"].Rows[p].Delete();
            dec.cd1.GetDeleteCommand();
            dec.dap1.Update(ds.Tables["Prop"]);
            MessageBox.Show("Bien supprimé");
        }

        public void Afficher2(int pos)
        {
            if (pos != -1)
            {
                TX_Nom_AJ.Text = ds5.Tables["Prop5"].Rows[pos][1].ToString();
                TX_Pre_AJ.Text = ds5.Tables["Prop5"].Rows[pos][2].ToString();
                TX_Nusq.Text = ds5.Tables["Prop5"].Rows[pos][3].ToString();
                TX_Adress.Text = ds5.Tables["Prop5"].Rows[pos][4].ToString();
                Date_AJ.Text = ds5.Tables["Prop5"].Rows[pos][5].ToString();
            }
            else
            {
                MessageBox.Show("errur");
            }

        }
    }
}
