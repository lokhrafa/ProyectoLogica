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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            double N3, N4, R2, N5, N6,R3,R4,N7, N8;
            double r4 = 1.33333;
            double r5 = 0.333;
            double volumen;
            double volumencono;
            double volumenromboedro;
            double volumenparalalepido;
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            R = N1 + N2;
            textBox3.Text = R.ToString();

            N3 = double.Parse(textBox4.Text);
            N4 = double.Parse(textBox5.Text);
            R2 = N3 + N4;
            textBox6.Text = R2.ToString();


            N5 = double.Parse(textBox7.Text);
            N6 = double.Parse(textBox8.Text);
            R3 = N5 + N6;
            textBox9.Text = R3.ToString();

            N7 = double.Parse(textBox10.Text);
            N8 = double.Parse(textBox11.Text);
            R4 = N7 + N8;
            textBox12.Text = R4.ToString();



            /* Volumen de esfera */


            if (R % 5 == 0)
            {
                

                volumen = r4 * Math.PI * (Math.Pow(R, 3));

                textBox13.Text = String.Format("El volumen de la esfera: {0}", volumen);

            } 
            else
            {
                textBox13.Text = String.Format("El primer par no es multiplo de 5");
            }

            /* Volumen de  cono, romboedro, paralalepido */

           
            if(R2 % 2 == 1 && R3 % 2 == 1 && R4 % 5 == 0)
            {
               

                volumencono = r5 * Math.PI * (Math.Pow(R2, 2)) * R3;

                textBox14.Text = String.Format("El volumen del cono es: {0}", volumencono);


                volumenromboedro = (R2 * R3) / 2 * R4;



                textBox15.Text = String.Format("El volumen del romboedro es {0}", volumenromboedro);


                volumenparalalepido = R2 * R3 * R4;

                textBox16.Text = String.Format("EL volumen del paralalepido es {0}", volumenparalalepido);
                
            }
            else if(R2 % 2 == 1 && R3 % 2 == 1)
            {
                textBox14.Text = String.Format("el segundo par es impar");
                textBox15.Text = String.Format("El tercer par es impar");
                textBox16.Text = String.Format("El cuarto par no es multiplo de 5");
            }
            else if (R3 % 2 == 1 && R4 % 5 == 0)
            {
                textBox14.Text = String.Format("el segundo par  no es impar");
                textBox15.Text = String.Format("El tercer par es impar");
                textBox16.Text = String.Format("El cuarto par no es multiplo de 5");
            } else if (R2 % 2 == 1 && R4 % 5 == 0)
            {
                textBox14.Text = String.Format("el segundo par  no es impar");
                textBox15.Text = String.Format("El tercer par no es impar");
                textBox16.Text = String.Format("El cuarto par no es multiplo de 5");
            }
            else
            {
                textBox14.Text = String.Format("el segundo par no es impar");
                textBox15.Text = String.Format("El tercer par no es impar");
                textBox16.Text = String.Format("El cuarto par no es multiplo de 5");
            }


       


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
