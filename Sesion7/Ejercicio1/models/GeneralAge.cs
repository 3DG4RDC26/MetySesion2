using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
   internal class GeneralAge
   {
      private int[] ages = new int[10];
       public void addElement(int age, int pos)
      { 
         ages[pos] = age;
      }
      public int[] GetElement()
      {
         return ages;
      }
   }
}
