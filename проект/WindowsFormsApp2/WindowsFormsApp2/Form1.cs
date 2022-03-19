using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workshop repair = new Workshop(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            repair.engine = Convert.ToInt32(textBox1.Text);
            repair.transmission = Convert.ToInt32(textBox2.Text);
            repair.wiring = Convert.ToInt32(textBox5.Text);
            repair.body = Convert.ToInt32(textBox6.Text);
            repair.GetInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filename, richTextBox1.Text);
            }
        }
    }

    class Workshop
    {
        public int engine;
        public int transmission;
        public int wiring;
        public int body;

        public Workshop(int engine, int transmission,int wiring, int body)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.wiring = wiring;
            this.body = body;
        }
        public void GetInfo()
        {
           
            if (engine <= 4 && transmission <=4)
            {
                MessageBox.Show($"Требуется ремонт мотора и КПП");
            }
            else if (engine <= 4 && wiring <= 4)
            {
                MessageBox.Show($"Требуется ремонт мотора и Проводки");
            }
            else if (engine <= 4 && body <= 4)
            {
                MessageBox.Show($"Требуется ремонт мотора и Кузова");
            }
            else if (transmission <= 4 && engine <= 4)
            {
                MessageBox.Show($"Требуется ремонт мотора и КПП");
            }
            else if (transmission <= 4 && wiring <= 4)
            {
                MessageBox.Show($"Требуется ремонт Проводки и КПП");
            }
            else if (transmission <= 4 && body <= 4)
            {
                MessageBox.Show($"Требуется ремонт Проводки и КПП");
            }
            else if (wiring <= 4 && engine <= 4)
            {
                MessageBox.Show($"Требуется ремонт Проводки и Мотора");
            }
            else if (wiring <= 4 && transmission <= 4)
            {
                MessageBox.Show($"Требуется ремонт Проводки и КПП");
            }
            else if (wiring <= 4 && body <= 4)
            {
                MessageBox.Show($"Требуется ремонт Проводки и КПП");
            }
            else if (body <= 4 && engine <=4)
            {
                MessageBox.Show($"Требуется ремонт Кузова и Мотора");
            }
            else if (body <= 4 && transmission <= 4)
            {
                MessageBox.Show($"Требуется ремонт Кузова и КПП");
            }
            else if (body <= 4 && wiring <= 4)
            {
                MessageBox.Show($"Требуется ремонт Кузова и Проводки");
            }
            else if (engine <= 4 && wiring <= 4 && transmission <=4 && body <=4)
            {
                MessageBox.Show($"Требуется ремонт Мотора,Проводки,КПП и Кузова");
            }
            else if (engine <= 5 && wiring <= 5 && transmission <= 5 && body <= 5)
            {
                MessageBox.Show($"Ремонт не Требуется,рекомендуется замена расходников {33500}");
            }
        }

    }
    }




