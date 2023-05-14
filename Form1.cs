using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string KETNOI= @"Data Source=Hi;Initial Catalog=BANHANG;Integrated Security=True";//ten server va data
        string truyvan = " SELECT*FROM LOAIHANG";// caau lenh muon truy van
        DataTable databang = new DataTable();//noi tra ve data khi truy van
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)// khi bam nut thi goi ham nay
        {
            SqlConnection con =new SqlConnection(KETNOI);// dat ten(con)
            con.Open();//mo ket noi
            SqlCommand cmd = con.CreateCommand();// thuc thi cau lenh  (dong21)
            cmd.Connection = con; 
            cmd.CommandType = CommandType.Text;// truyefn thang cau lenh qsl cho no
            cmd.CommandText = truyvan;// gan cau lenh sql cho cmd 
            SqlDataReader reader = cmd.ExecuteReader(); //cmd thuc hien cau lenh SQL
            databang.Load(reader);//tra ve data
            dataGridView1.DataSource = databang;// noi hien thi
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
