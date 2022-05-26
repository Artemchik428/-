using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shablon
{
    public partial class Form1 : Form
    {
        public static Class1[] element1 = new Class1[3];
        public static Class2[] element2 = new Class2[3];
        
        public Form1()
        {
            InitializeComponent();

            element1[0] = new Class1();
            element1[0].set("321", "Математика");

            element1[1] = new Class1();
            element1[1].set("304", "Электроника");


            element1[2] = new Class1();
            element1[2].set("220", "Программирование");




            element2[0] = new Class2();
            element2[0].set("321", "Acer", "Intel Core i5", "512GB");

            element2[1] = new Class2();
            element2[1].set("304", "Asus", "Intel Core i7", "1TB");

            element2[2] = new Class2();
            element2[2].set("220", "HP", "Intel Core i9", "2TB");



            label1.Text = element1[0].StringID;
            for (int i = 0; i < 3; i++)
                tabControl1.Controls["tabPage1"].Controls["label" + (1 + i)].Text = element1[i].StringID;

            lab1.Text = element1[0].String2;
            for (int i = 0; i < 3; i++)
                tabControl1.Controls["tabPage1"].Controls["lab" + (1 + i)].Text = element1[i].String2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.stringid = "321";
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.stringid = "304";
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.stringid = "220";
            form1.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lab1_Click(object sender, EventArgs e)
        {

        }

        private void lab2_Click(object sender, EventArgs e)
        {

        }
    }
}
