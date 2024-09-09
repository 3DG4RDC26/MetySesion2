using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
   public partial class Form1 : Form
   {
      GeneralAge ages = new GeneralAge();
      int index = 0;
      public Form1()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         AddElement();
      }

      private void AddElement()
      {
         try
         {
            int age = Convert.ToInt32(tbAge.Text);
            ages.addElement(age, index);
            index++;
            ShowAges();
            tbAge.Clear();
            tbAge.Focus(); 
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void ShowAges()
      {
         try
         {
            lbAges.Items.Clear();
            for (int i = 0; i < index; i++)
            {
               lbAges.Items.Add(ages.GetElement()[(int)i]);
            }
            int sum = ages.GetElement().Sum();
            Double average = sum/index;
            lblsum.Text = "Suma: " + sum;
            lblaravage.Text= "Promedio: " + average;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
         }
      }

      private void tbAge_TextChanged(object sender, EventArgs e)
      {

      }

      private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         if(e.KeyChar == (Char) Keys.Enter)
         {
             AddElement();
         }
      }

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }

      private void label3_Click(object sender, EventArgs e)
      {

      }
   }
}
