namespace MyApp1
{
   partial class FrmPrincipal
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
         this.label2 = new System.Windows.Forms.Label();
         this.tbNombre = new System.Windows.Forms.TextBox();
         this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(54, 46);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(93, 25);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombre:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(22, 71);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(125, 25);
         this.label2.TabIndex = 1;
         this.label2.Text = "Nacimiento:";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         // 
         // tbNombre
         // 
         this.tbNombre.BackColor = System.Drawing.SystemColors.Window;
         this.tbNombre.Location = new System.Drawing.Point(143, 51);
         this.tbNombre.Name = "tbNombre";
         this.tbNombre.Size = new System.Drawing.Size(211, 20);
         this.tbNombre.TabIndex = 2;
         // 
         // dtpFechaNac
         // 
         this.dtpFechaNac.Location = new System.Drawing.Point(143, 75);
         this.dtpFechaNac.Name = "dtpFechaNac";
         this.dtpFechaNac.Size = new System.Drawing.Size(211, 20);
         this.dtpFechaNac.TabIndex = 3;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
         this.button1.Location = new System.Drawing.Point(202, 101);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Evaluar";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.btnEvaluar_Click);
         // 
         // FrmPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dtpFechaNac);
         this.Controls.Add(this.tbNombre);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "FrmPrincipal";
         this.Text = " ";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbNombre;
      private System.Windows.Forms.DateTimePicker dtpFechaNac;
      private System.Windows.Forms.Button button1;
   }
}

