using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            TimeSpan igual = DateTime.Today.Subtract(dtefecha.Value.Date);

            int Edad = (int)(igual.TotalDays / 365.25);
            txtmes.Text = dtefecha.Value.Month.ToString();

            txtdias.Text = igual.TotalDays.ToString();
            txthoras.Text = igual.TotalHours.ToString();
            txtminuto.Text = igual.TotalMinutes.ToString();
            txtsegundos.Text = igual.TotalSeconds.ToString();
            txtedad.Text = Edad.ToString();
            System.DateTime Fnac = dtefecha.Value.Date;
            switch (Fnac.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    txtfechaN.Text = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    txtfechaN.Text = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    txtfechaN.Text = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    txtfechaN.Text = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    txtfechaN.Text = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    txtfechaN.Text = "Sabado";
                    break;
                case DayOfWeek.Sunday:
                    txtfechaN.Text = "Domingo";
                    break;
            }
    }
}
