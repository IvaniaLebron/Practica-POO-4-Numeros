using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4NumerosEnteros
{
    public partial class Formulario1 : Form
    {
        //variables publicas
        public int num1, num2, num3, num4, mayor=0, menor=0, suma=0,mayorA=0, menorA=0;

        private void txtnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condiciones de numero <=0 y no repetidos para cada textbox
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                num2 = Convert.ToInt32(txtnum2.Text);
                if (num2 <= 0)
                {
                    MessageBox.Show("Los números no pueden ser menores o iguales a cero. Intenta de nuevo");
                    txtnum2.Clear();
                    txtnum2.Focus();
                }
                if (num2 == num1)
                {
                    MessageBox.Show("Los números deben ser diferentes. Ingresa otro número");
                    txtnum2.Clear();
                    txtnum2.Focus();
                }
                else { txtnum3.Focus(); }
            }
        }

        private void txtnum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                num3= Convert.ToInt32(txtnum3.Text);
                if (num3 <= 0)
                {
                    MessageBox.Show("Los números no pueden ser menores o iguales a cero. Intenta de nuevo");
                    txtnum3.Clear();
                    txtnum3.Focus();
                }
                if (num3 == num1||num3==num2)
                {
                    MessageBox.Show("Los números deben ser diferentes. Ingresa otro número");
                    txtnum3.Clear();
                    txtnum3.Focus();
                }
                else { txtnum4.Focus(); }
            }
        }

        private void txtnum4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpiar los textbox
            txtnum.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            txtnum4.Clear();
            txtnum.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //boton salir
            Application.Exit();
        }

        private void txtnum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                num4 = Convert.ToInt32(txtnum4.Text);
                if (num4 <= 0)
                {
                    MessageBox.Show("Los números no pueden ser menores o iguales a cero. Intenta de nuevo");
                    txtnum4.Clear();
                    txtnum4.Focus();
                }
                if (num4 == num1||num4==num2||num4==num3)
                {
                    MessageBox.Show("Los números deben ser diferentes. Ingresa otro número");
                    txtnum4.Clear();
                    txtnum4.Focus();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                num1 = Convert.ToInt32(txtnum.Text);
                if(num1<=0)
                {
                    MessageBox.Show("Los números no pueden ser menores o iguales a cero. Intenta de nuevo");
                    txtnum.Clear();
                    txtnum.Focus();
                }

                else { txtnum2.Focus(); }
            }
        }

        public Formulario1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables por numero
            num1 = Convert.ToInt32(txtnum.Text);
            num2 = Convert.ToInt32(txtnum2.Text);
            num3 = Convert.ToInt32(txtnum3.Text);
            num4 = Convert.ToInt32(txtnum4.Text);
            suma = num1 + num2 + num3 + num4;
            //verificando que la suma de los numeros sea menor a 200
            if(suma>=200)
            {
                MessageBox.Show("La suma de los números debe ser menor que 200, vuelve a ingresar unos nuevos");
                txtnum.Clear();
                txtnum2.Clear();
                txtnum3.Clear();
                txtnum4.Clear();
                txtnum.Focus();
            }
            else
            {
                //determinando el numero mayor
                mayor = num1;
                if (num2 > num1) mayor = num2;
                if (num3 > num2) mayor = num3;
                if (num4 > num3) mayor = num4;
                //determinando el numero mayor
                menor = num1;
                if (num2 < num1) menor = num2;
                if (num3 < num2) menor = num3;
                if (num4 < num3) menor = num4;
                //actualizando los numeros menor y mayor
                if(menor>10)
                {
                    mayorA = mayor + 10;
                }
                if(mayor<50)
                {
                    menorA = menor - 5;
                }
                //mandando los resultados al otro formulario con un constructor
                string result = string.Format($"Número mayor: {mayor}\nNúmero menor: {menor}\nNúmeros " +
                    $"actualizados\nMayor: {mayorA}\nMenor: {menorA}");
                Form2 lblresultado = new Form2(result);
                lblresultado.Visible = true;
                this.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
