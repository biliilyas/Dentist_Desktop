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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds3 = new DataSet();
        private void Form9_Load(object sender, EventArgs e)
        {
            dec.con.Open();
            dec.dap1.Fill(ds, "Prop");
            dec.con.Close();

            dec.con.Open();
            dec.dap4.Fill(ds4, "Prop4");
            dec.con.Close();

            dec.con.Open();
            dec.dap3.Fill(ds3, "Prop3");
            dec.con.Close();

            for (i = 0; i < 32; i++)
            {
                CM_DATE.Items.Add(s.ToString());
                s++;
            }
        }
        int i, pos = -1;
        string cin;
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
        int s = 1;

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pos = RECHER(Tx_id.Text);
            Afficher(pos);
            cin = Tx_id.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ds4.Tables["Prop4"].Rows.Add(null, DateTime.Parse(DateT.Text), cin);
            dec.cd4.GetInsertCommand();
            dec.dap4.Update(ds4.Tables["Prop4"]);

            int de = int.Parse(ds4.Tables["Prop4"].Rows.Count.ToString());

            ds3.Tables["Prop3"].Rows.Add(null, tx_desc.Text, int.Parse(CM_DATE.Text), DateTime.Parse(DateT.Text), de);
            dec.cd3.GetInsertCommand();
            dec.dap3.Update(ds3.Tables["Prop3"]);



            MessageBox.Show("Bien Ajouté");
        }

        public void Afficher(int pos)
        {
            if (pos != -1)
            {
                label5.Text = ds.Tables["Prop"].Rows[pos][1].ToString();
                label1.Text = ds.Tables["Prop"].Rows[pos][2].ToString();
            }
            else
            {
                MessageBox.Show("errur");
            }

        }
    }
}
