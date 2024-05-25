using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class dec
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q49OL3V\MSSQLSERVER01;Initial Catalog=Doctore_2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
);
        public static SqlCommand com = new SqlCommand("select * from Login", con);
        public static SqlDataAdapter dap = new SqlDataAdapter(com);
        public static SqlCommandBuilder cd = new SqlCommandBuilder(dap);


        public static SqlCommand com1 = new SqlCommand("select * from client", con);
        public static SqlDataAdapter dap1 = new SqlDataAdapter(com1);
        public static SqlCommandBuilder cd1 = new SqlCommandBuilder(dap1);


        public static SqlCommand com2 = new SqlCommand("select * from réservation", con);
        public static SqlDataAdapter dap2 = new SqlDataAdapter(com2);
        public static SqlCommandBuilder cd2 = new SqlCommandBuilder(dap2);

        public static SqlCommand com3 = new SqlCommand("select * from Traitment", con);
        public static SqlDataAdapter dap3 = new SqlDataAdapter(com3);
        public static SqlCommandBuilder cd3 = new SqlCommandBuilder(dap3);

        public static SqlCommand com4 = new SqlCommand("select * from visite", con);
        public static SqlDataAdapter dap4 = new SqlDataAdapter(com4);
        public static SqlCommandBuilder cd4 = new SqlCommandBuilder(dap4);



        public static SqlCommand com5 = new SqlCommand("select * from client_S", con);
        public static SqlDataAdapter dap5 = new SqlDataAdapter(com5);
        public static SqlCommandBuilder cd5 = new SqlCommandBuilder(dap5);
    }
}
