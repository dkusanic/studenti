using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studenti
{
    public partial class Form1 : Form
    {
        List<Student> list = Student.dohvatiStudente();
        List<Student> vjDa = Student.VjezbeDa();
        List<Student> vjNe = Student.VjezbeNe();
        

        private Student student;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = list;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string unos = textBox1.Text;
            List<Student> mentor = Student.mentorFilter(unos);
            dataGridView1.DataSource = mentor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                dataGridView1.DataSource = list;
                textBox1.Text = null;
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                dataGridView1.DataSource = vjDa;
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                dataGridView1.DataSource = vjNe;
            }
        }
    }
}
