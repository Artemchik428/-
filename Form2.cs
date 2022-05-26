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
    public partial class Form2 : Form
    {
        public string stringid = "0";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.element2.Length; i++)
                if (Form1.element2[i].StringID == this.stringid)

                    dataGridView1.Rows.Add(Form1.element2[i].StringID, Form1.element2[i].String3, Form1.element2[i].String4, Form1.element2[i].String5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
