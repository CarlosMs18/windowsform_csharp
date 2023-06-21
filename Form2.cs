using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        //List VIEW AGREGADO DAÑOS AL COSTADO EN FORMA DE COLUMNAS Y LIST BOX EN FORMA DE FILAS
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ListaPaises.Items.Add("Hola");


            // list box 
            //ListaPaisesBox.Items.Add("Canada");

            //String elemento = ListaPaisesBox.SelectedItem.ToString();
            //label1.Text = elemento;

            barraProgreso.Value += 10;


            //label2.Text = dateTimePicker1.Text;
           /* label2.Text = dateTimePicker1.Value.ToString();*/ //llamada con fecha y hora

            label2.Text = numericUpDown1.Value.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LINK VISITED PROPIEDAD  = TRUE VISITADO , FALSE QUE AUN NO

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.youtube.com");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //funciona como una especie de textarea
        }
    }
}
