﻿namespace Sesion4
{
   partial class Form1
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.tbSalario = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.tbName = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.nudAumento = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.tbTecho = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(42, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(66, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombre:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // tbSalario
         // 
         this.tbSalario.Location = new System.Drawing.Point(109, 55);
         this.tbSalario.Name = "tbSalario";
         this.tbSalario.Size = new System.Drawing.Size(100, 20);
         this.tbSalario.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(42, 59);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(61, 16);
         this.label2.TabIndex = 2;
         this.label2.Text = "Salario:";
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(109, 25);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(100, 20);
         this.tbName.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(32, 90);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(71, 16);
         this.label3.TabIndex = 5;
         this.label3.Text = "Aumento:";
         // 
         // nudAumento
         // 
         this.nudAumento.Location = new System.Drawing.Point(110, 90);
         this.nudAumento.Name = "nudAumento";
         this.nudAumento.Size = new System.Drawing.Size(99, 20);
         this.nudAumento.TabIndex = 6;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(48, 121);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(55, 16);
         this.label4.TabIndex = 7;
         this.label4.Text = "Techo:";
         // 
         // tbTecho
         // 
         this.tbTecho.Location = new System.Drawing.Point(109, 121);
         this.tbTecho.Name = "tbTecho";
         this.tbTecho.Size = new System.Drawing.Size(100, 20);
         this.tbTecho.TabIndex = 8;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(583, 317);
         this.Controls.Add(this.tbTecho);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.nudAumento);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.tbSalario);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbSalario;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown nudAumento;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox tbTecho;
   }
}

