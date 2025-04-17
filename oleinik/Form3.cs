using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oleinik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Добавление
        {


            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == "") || (textBox8.Text == "") || (textBox9.Text == "") || (textBox10.Text == "") || (textBox11.Text == "") || (textBox12.Text == "") || (textBox13.Text == ""))
            {
                MessageBox.Show("Введите данные!");
            }
            else
            {
                DataTable dt = DBConn.select("insert into staff(last_name,first_name,patronymic,phone_number,inn,snils,post_id,mail,residential_address,registration_address,gender_id,military_duty_id,marital_status_id)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','"+textBox13.Text+"')");
                dt = DBConn.select("select * from staff");
                dataGridView1.DataSource = dt;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Удаление
        {
            DataTable dt = DBConn.select("delete from staff where idstaff=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            dt = DBConn.select("select * from staff");
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dt = DBConn.select("select * from staff");
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e) // Сортировка
        {
            DataTable dt = DBConn.select("select * from staff");
            DataView dataView = new DataView(dt);
            dataView.Sort = comboBox1.Text;
            dataGridView1.DataSource = dataView;
        }

        private void button4_Click(object sender, EventArgs e) // Поиск
        {
            DataTable dt = DBConn.select("select * from staff");
            DataView dataView = new DataView(dt);
            dataView.RowFilter = $"{comboBox2.Text} like '%{textBox14.Text}%' ";
            dataGridView1.DataSource = dataView;
        }

        private void button5_Click(object sender, EventArgs e) // Редактирование 
        {
            DataTable dt = DBConn.select("update staff set "+ comboBox3.Text+" = '"+ textBox15.Text+"' where idstaff=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            dt = DBConn.select("select * from staff");
            dataGridView1.DataSource = dt;
            textBox15.Clear();
        }

       
    }
}
