using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boxmass = textBox1.Text.Split();
            int[] A = new int[boxmass.Length];
            int x, y, value;
            bool check = true;

            for (int i = 0; i < boxmass.Length; i++)
            {
                do { } while (!int.TryParse(boxmass[i], out value));
                
                A[i] = value;
            }

            do { } while (!int.TryParse(textBox2.Text, out x));

            do { } while (!int.TryParse(textBox3.Text, out y) || x >= y);

            textBox4.Text = "";
            
            for (int i = 0; i < A.Length; i++)
            {
                if (x < A[i] && A[i] < y)
                {
                    textBox4.Text += i + "-ый элемент = " + A[i] + ", " + x + " < " + A[i] + " < " + y + Environment.NewLine;
                    textBox4.Text += "\n";
                    check = false;
                }
            }

            if (check) 
            { 
                textBox4.Text = ("Элементов для данного условия не найдено."); 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
