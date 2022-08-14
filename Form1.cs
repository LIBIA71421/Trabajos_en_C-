using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ER_PROYECTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void fact()
        {
                int i;
                int fact = 1;
            double numero = Convert.ToDouble(txtB_Fact.Text);

            if (numero < 0) { fact = 0; }
                else if (numero == 0) { fact = 1; }
                else
                {
                    for (i = 1; i <= numero; i++)
                    {
                        fact = fact * i;
                    }
                }
            MessageBox.Show(txtB_Fact + " su factorial " + fact);
            string RES = Convert.ToString(fact);

            listBox1.Text = RES;
    
            int cont = 1;
            int suma = 0;
            while (cont <= numero)
            {//while que no se llegue a N
                suma = cont + suma;
                cont++;
            }
            MessageBox.Show(txtB_Fact + " su factorial " + suma);
            string RESSUM = Convert.ToString(suma);

        }
        public int Length { get; }
        object PRIMOS()
        {
            int counter = 0, sum = 0;
            double from = Convert.ToDouble(txtFROM.Text);
            double to = Convert.ToDouble(txtTO.Text);
            string cad = Console.WriteLine("'{0}' is { 1 }", from, from.Length);
            NewMethod(ref counter, ref sum, ref from, to); ;
        }

        private static object NewMethod(ref int counter, ref int sum, ref double from, double to)
        {
            for (from.GetHashCode; from <= to; from++)
            {
                for (int i = 1; i <= from; i++)
                {
                    if (from % i == 0)
                    {
                        counter++;
                    };
                };
                if (counter == 2)
                {
                    sum++;
                    //cout << from << " ";
                    string PRIM = Convert.ToString(from);
                    MessageBox.Show(from + " ");
                };
                counter = 0;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            label2.Text = txtName.Text;
           // MessageBox.Show(txtName.Text + " esta " + comboBox1.Text);
            //MessageBox.Show($"{txtName.Text} ")
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    //MessageBox.Show("el imput esta habilitado: ");
            //    txtName.Enabled = true;
            //}
            //else
            //{
            //    //MessageBox.Show("el imput esta inhabilitado : ");
            //    txtName.Enabled = false;
            //}


            //if (checkBox1.Checked)
            //{
            //    //MessageBox.Show("el imput esta habilitado: ");
            //    txtName.Enabled = true;
            //}
            //else
            //{
            //    //MessageBox.Show("el imput esta inhabilitado : ");
            //    txtName.Enabled = false;
            //}

            txtName.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<10;i++)
            {
                listBox1.Items.Add(i+1);
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            fact();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Top = 100;
            lbl.Left = 50;
            lbl.Text = "hola";
            this.Controls.Add(lbl);
        }
    }
}
