using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtener la fecha seleccionada
            DateTime date = this.dateTimePicker2.Value;

            //crear diccionario con los numero y mes
            string[] n = new string[] {"uno","dos","tres","cuatro","cinco","seis","siete","ocho","nueve","diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve", "veinte", "veinti", "treinta"};
            string[] m = new string[] {"enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre", "noviembre", "diciembre"};

            //dar valor por defecto a dia y año
            string dia = n[((date.Day <= 20) ? date.Day : 20) - 1];
            string year = n[(((date.Year % 100) <= 20) ? (date.Year % 100) : 20) - 1];

            

           


        }
    }
}
