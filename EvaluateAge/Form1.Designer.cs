﻿namespace EvaluateAge
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
         this.tbAge = new System.Windows.Forms.TextBox();
         this.btnEvaluate = new System.Windows.Forms.Button();
         this.lblAnswer = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(53, 54);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(139, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Introduce tu edad:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // tbAge
         // 
         this.tbAge.Location = new System.Drawing.Point(199, 53);
         this.tbAge.Name = "tbAge";
         this.tbAge.Size = new System.Drawing.Size(100, 20);
         this.tbAge.TabIndex = 1;
         this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
         // 
         // btnEvaluate
         // 
         this.btnEvaluate.Location = new System.Drawing.Point(327, 53);
         this.btnEvaluate.Name = "btnEvaluate";
         this.btnEvaluate.Size = new System.Drawing.Size(81, 21);
         this.btnEvaluate.TabIndex = 2;
         this.btnEvaluate.Text = "Evaluar";
         this.btnEvaluate.UseVisualStyleBackColor = true;
         this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
         // 
         // lblAnswer
         // 
         this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAnswer.ForeColor = System.Drawing.SystemColors.HotTrack;
         this.lblAnswer.Location = new System.Drawing.Point(58, 86);
         this.lblAnswer.Name = "lblAnswer";
         this.lblAnswer.Size = new System.Drawing.Size(350, 20);
         this.lblAnswer.TabIndex = 3;
         this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(472, 287);
         this.Controls.Add(this.lblAnswer);
         this.Controls.Add(this.btnEvaluate);
         this.Controls.Add(this.tbAge);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Opacity = 0.92D;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Evaluar Edad";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbAge;
      private System.Windows.Forms.Button btnEvaluate;
      private System.Windows.Forms.Label lblAnswer;
   }
}

