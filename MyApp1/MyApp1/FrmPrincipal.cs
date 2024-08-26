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
using MyApp1.clases;

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
         Persona.Nombre = tbNombre.Text;
         Persona.FechaNac = dtpFechaNac.Value;
         MessageBox.Show(Persona.EvaluarEdad());
      }
   }
}
