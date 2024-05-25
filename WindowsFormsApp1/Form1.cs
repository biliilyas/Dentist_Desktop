using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            dec.con.Open();
            dec.dap.Fill(ds, "Prop27");
            dec.con.Close();
        }
        int i, pos = -1;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool br = false;
            for (i = 0; i < ds.Tables["Prop27"].Rows.Count; i++)
            {
                if (ds.Tables["Prop27"].Rows[i][0].ToString() == User7.Text && ds.Tables["Prop27"].Rows[i][1].ToString() == Pass7.Text)
                {
                    this.Hide();
                    Form2 F = new Form2();
                    F.Show();
                    br = true;
                }



            }
            if (br == false)
            {
                MessageBox.Show("Erreur");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
