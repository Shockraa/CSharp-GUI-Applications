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
    public partial class Form1 : Form
    {

        private double valor = 0;
        private double valor2 = 0;
        private double auxiliar = 0;
        private double valorTotal = 0;
        private double valorTotal2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Cobrar do SUS";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                valor += 65.00;
                label8.Text = valor.ToString() + "$";
            }
            else
            {
                valor -= 65.00;
                label8.Text = valor.ToString() + "$";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                valor += 180.00;
                label8.Text = valor.ToString() + "$";
            }
            else
            {
                valor -= 180.00;
                label8.Text = valor.ToString() + "$";
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (valorTotal == 0) { label9.Text = valorTotal2.ToString() + "$"; }

            else { label9.Text = valorTotal.ToString() + "$"; }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                valor += 120.00;
                label8.Text = valor.ToString() + "$";
            }
            else
            {
                valor -= 120.00;
                label8.Text = valor.ToString() + "$";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        public void AtivarConta()
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) //A vista
        {
            valorTotal2 = 0;
                valorTotal = valor + valor2;
                auxiliar = valorTotal * 0.10;
                valorTotal = valorTotal - auxiliar;
                
            

            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            valorTotal = 0;
            valorTotal2 = valor + valor2;
            auxiliar = valorTotal2 * 0.15;
            valorTotal2 = valorTotal2 + auxiliar;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Cobrar do Plano de Saúde";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Cobrar do Paciênte";
        }
    }
}
