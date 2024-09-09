namespace Ejercicio1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.lbAges = new System.Windows.Forms.ListBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnAdd = new System.Windows.Forms.Button();
         this.tbAge = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.lblsum = new System.Windows.Forms.Label();
         this.lblaravage = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.lblaravage);
         this.groupBox1.Controls.Add(this.lblsum);
         this.groupBox1.Controls.Add(this.lbAges);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.btnAdd);
         this.groupBox1.Controls.Add(this.tbAge);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(30, 38);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(325, 212);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Registro de edades";
         this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
         // 
         // lbAges
         // 
         this.lbAges.FormattingEnabled = true;
         this.lbAges.Location = new System.Drawing.Point(9, 84);
         this.lbAges.Name = "lbAges";
         this.lbAges.Size = new System.Drawing.Size(101, 17);
         this.lbAges.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 58);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(102, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Edades resgistradas";
         // 
         // btnAdd
         // 
         this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
         this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
         this.btnAdd.Location = new System.Drawing.Point(171, 13);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(56, 37);
         this.btnAdd.TabIndex = 3;
         this.btnAdd.UseVisualStyleBackColor = false;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // tbAge
         // 
         this.tbAge.Location = new System.Drawing.Point(84, 22);
         this.tbAge.Multiline = true;
         this.tbAge.Name = "tbAge";
         this.tbAge.Size = new System.Drawing.Size(81, 22);
         this.tbAge.TabIndex = 2;
         this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
         this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Ingrese edad:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // lblsum
         // 
         this.lblsum.Location = new System.Drawing.Point(6, 116);
         this.lblsum.Name = "lblsum";
         this.lblsum.Size = new System.Drawing.Size(100, 23);
         this.lblsum.TabIndex = 6;
         this.lblsum.Text = "Suma: 0";
         this.lblsum.Click += new System.EventHandler(this.label3_Click);
         // 
         // lblaravage
         // 
         this.lblaravage.Location = new System.Drawing.Point(6, 139);
         this.lblaravage.Name = "lblaravage";
         this.lblaravage.Size = new System.Drawing.Size(100, 23);
         this.lblaravage.TabIndex = 7;
         this.lblaravage.Text = "Promedio: 0";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "Arreglos";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.TextBox tbAge;
      private System.Windows.Forms.ListBox lbAges;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblaravage;
      private System.Windows.Forms.Label lblsum;
   }
}

