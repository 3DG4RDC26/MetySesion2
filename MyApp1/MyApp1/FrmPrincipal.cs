using Sesion2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp1.Properties; /*Cambie MyApp1.clases por MyApp.Properties y ya ejecuta el codigo y 
                          muestra el public string EvaluarEdad()*/

namespace MyApp1
{
   public partial class FrmPrincipal : Form
   {
      public FrmPrincipal()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void btnEvaluar_Click(object sender, EventArgs e)
      {
        Persona p = new Persona();
        p.Nombre = tbNombre.Text;
        p.FechaNac = dtpFechaNac.Value;
        MessageBox.Show(p.EvaluarEdad());
        }
    }
}
