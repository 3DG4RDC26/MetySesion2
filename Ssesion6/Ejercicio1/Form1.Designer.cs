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
         this.btnAgregar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.tbNombre = new System.Windows.Forms.TextBox();
         this.cmbNombres = new System.Windows.Forms.ComboBox();
         this.cmbNombres2 = new System.Windows.Forms.ComboBox();
         this.btnCopiar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnAgregar
         // 
         this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
         this.btnAgregar.Location = new System.Drawing.Point(49, 63);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(259, 164);
         this.btnAgregar.TabIndex = 0;
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(45, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(68, 19);
         this.label1.TabIndex = 1;
         this.label1.Text = "Nombre:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // tbNombre
         // 
         this.tbNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
         this.tbNombre.Location = new System.Drawing.Point(113, 37);
         this.tbNombre.Multiline = true;
         this.tbNombre.Name = "tbNombre";
         this.tbNombre.Size = new System.Drawing.Size(167, 20);
         this.tbNombre.TabIndex = 2;
         // 
         // cmbNombres
         // 
         this.cmbNombres.FormattingEnabled = true;
         this.cmbNombres.Location = new System.Drawing.Point(92, 233);
         this.cmbNombres.Name = "cmbNombres";
         this.cmbNombres.Size = new System.Drawing.Size(167, 21);
         this.cmbNombres.TabIndex = 3;
         this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.cmbNombres_SelectedIndexChanged);
         // 
         // cmbNombres2
         // 
         this.cmbNombres2.FormattingEnabled = true;
         this.cmbNombres2.Location = new System.Drawing.Point(92, 434);
         this.cmbNombres2.Name = "cmbNombres2";
         this.cmbNombres2.Size = new System.Drawing.Size(167, 21);
         this.cmbNombres2.TabIndex = 4;
         this.cmbNombres2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // btnCopiar
         // 
         this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
         this.btnCopiar.Location = new System.Drawing.Point(58, 260);
         this.btnCopiar.Name = "btnCopiar";
         this.btnCopiar.Size = new System.Drawing.Size(232, 168);
         this.btnCopiar.TabIndex = 5;
         this.btnCopiar.Text = "Copiar todos los objetos";
         this.btnCopiar.UseVisualStyleBackColor = true;
         this.btnCopiar.Click += new System.EventHandler(this.btnMover_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(657, 482);
         this.Controls.Add(this.btnCopiar);
         this.Controls.Add(this.cmbNombres2);
         this.Controls.Add(this.cmbNombres);
         this.Controls.Add(this.tbNombre);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnAgregar);
         this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbNombre;
      private System.Windows.Forms.ComboBox cmbNombres;
      private System.Windows.Forms.ComboBox cmbNombres2;
      private System.Windows.Forms.Button btnCopiar;
   }
}

