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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataSet1 ds1 = new DataSet1();
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Container_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void container(object _form)
        {

            if (guna2Panel3_Container.Controls.Count > 0) guna2Panel3_Container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel3_Container.Controls.Add(fm);
            guna2Panel3_Container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Client";
            
            container(new Form6());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Réservation";
            
            container(new Form7());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Ajoute Client";
            container(new Form8());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Réservation";
            container(new Form9());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Réservation";
            container(new Form10());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Clients";
            container(new Form11());
        }
    }
}
