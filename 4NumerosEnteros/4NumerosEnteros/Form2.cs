using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4NumerosEnteros
{
    public partial class Form2 : Form
    {
        public Form2(string resultado)
        {
            InitializeComponent();
            lblresultado.Text = resultado; //se trae el mensaje al label
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnregre_Click(object sender, EventArgs e)
        {
            //cerrando el formulario actual y regresando al otro con constructor
            Formulario1 Form1 = new Formulario1();
            this.Close();
            Form1.Visible = true;
        }
    }
}
