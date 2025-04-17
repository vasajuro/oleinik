using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oleinik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from authorization where login = '{textBox1.Text}' and password = '{textBox2.Text}'";
            DataTable dt = DBConn.select(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
