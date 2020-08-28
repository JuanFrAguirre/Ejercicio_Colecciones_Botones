namespace Ejercicio_Colecciones_Botones
{
  partial class frmBotonesColecciones
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblCantItems1 = new System.Windows.Forms.Label();
      this.lblCantItems2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnTodosIzquierda = new System.Windows.Forms.Button();
      this.btnSelectIzquierda = new System.Windows.Forms.Button();
      this.btnTodosDerecha = new System.Windows.Forms.Button();
      this.btnSelectDerecha = new System.Windows.Forms.Button();
      this.lstDatos1 = new System.Windows.Forms.ListBox();
      this.lstDatos2 = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblCantItems1
      // 
      this.lblCantItems1.AutoSize = true;
      this.lblCantItems1.Location = new System.Drawing.Point(325, 564);
      this.lblCantItems1.Name = "lblCantItems1";
      this.lblCantItems1.Size = new System.Drawing.Size(174, 25);
      this.lblCantItems1.TabIndex = 1;
      this.lblCantItems1.Text = "Cantidad Items: -";
      // 
      // lblCantItems2
      // 
      this.lblCantItems2.AutoSize = true;
      this.lblCantItems2.Location = new System.Drawing.Point(762, 564);
      this.lblCantItems2.Name = "lblCantItems2";
      this.lblCantItems2.Size = new System.Drawing.Size(174, 25);
      this.lblCantItems2.TabIndex = 1;
      this.lblCantItems2.Text = "Cantidad Items: -";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(274, 51);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 25);
      this.label3.TabIndex = 3;
      this.label3.Text = "Dato";
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(337, 48);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(208, 31);
      this.txtDato.TabIndex = 0;
      this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDato_KeyDown);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(577, 33);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(114, 66);
      this.btnAgregar.TabIndex = 1;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(722, 33);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(114, 66);
      this.btnEliminar.TabIndex = 2;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(867, 33);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(114, 66);
      this.btnLimpiar.TabIndex = 3;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lstDatos2);
      this.panel1.Controls.Add(this.lstDatos1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Location = new System.Drawing.Point(249, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(762, 624);
      this.panel1.TabIndex = 5;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnTodosIzquierda);
      this.panel2.Controls.Add(this.btnSelectIzquierda);
      this.panel2.Controls.Add(this.btnTodosDerecha);
      this.panel2.Controls.Add(this.btnSelectDerecha);
      this.panel2.Location = new System.Drawing.Point(328, 127);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(114, 404);
      this.panel2.TabIndex = 0;
      // 
      // btnTodosIzquierda
      // 
      this.btnTodosIzquierda.Location = new System.Drawing.Point(25, 304);
      this.btnTodosIzquierda.Name = "btnTodosIzquierda";
      this.btnTodosIzquierda.Size = new System.Drawing.Size(64, 66);
      this.btnTodosIzquierda.TabIndex = 3;
      this.btnTodosIzquierda.Text = "<<";
      this.btnTodosIzquierda.UseVisualStyleBackColor = true;
      this.btnTodosIzquierda.Click += new System.EventHandler(this.btnTodosIzquierda_Click);
      // 
      // btnSelectIzquierda
      // 
      this.btnSelectIzquierda.Location = new System.Drawing.Point(25, 214);
      this.btnSelectIzquierda.Name = "btnSelectIzquierda";
      this.btnSelectIzquierda.Size = new System.Drawing.Size(64, 66);
      this.btnSelectIzquierda.TabIndex = 2;
      this.btnSelectIzquierda.Text = "<";
      this.btnSelectIzquierda.UseVisualStyleBackColor = true;
      this.btnSelectIzquierda.Click += new System.EventHandler(this.btnSelectIzquierda_Click);
      // 
      // btnTodosDerecha
      // 
      this.btnTodosDerecha.Location = new System.Drawing.Point(25, 34);
      this.btnTodosDerecha.Name = "btnTodosDerecha";
      this.btnTodosDerecha.Size = new System.Drawing.Size(64, 66);
      this.btnTodosDerecha.TabIndex = 0;
      this.btnTodosDerecha.Text = ">>";
      this.btnTodosDerecha.UseVisualStyleBackColor = true;
      this.btnTodosDerecha.Click += new System.EventHandler(this.btnTodosDerecha_Click);
      // 
      // btnSelectDerecha
      // 
      this.btnSelectDerecha.Location = new System.Drawing.Point(25, 124);
      this.btnSelectDerecha.Name = "btnSelectDerecha";
      this.btnSelectDerecha.Size = new System.Drawing.Size(64, 66);
      this.btnSelectDerecha.TabIndex = 1;
      this.btnSelectDerecha.Text = ">";
      this.btnSelectDerecha.UseVisualStyleBackColor = true;
      this.btnSelectDerecha.Click += new System.EventHandler(this.btnSelectDerecha_Click);
      // 
      // lstDatos1
      // 
      this.lstDatos1.FormattingEnabled = true;
      this.lstDatos1.ItemHeight = 25;
      this.lstDatos1.Location = new System.Drawing.Point(30, 127);
      this.lstDatos1.Name = "lstDatos1";
      this.lstDatos1.Size = new System.Drawing.Size(266, 404);
      this.lstDatos1.TabIndex = 1;
      // 
      // lstDatos2
      // 
      this.lstDatos2.FormattingEnabled = true;
      this.lstDatos2.ItemHeight = 25;
      this.lstDatos2.Location = new System.Drawing.Point(473, 127);
      this.lstDatos2.Name = "lstDatos2";
      this.lstDatos2.Size = new System.Drawing.Size(266, 404);
      this.lstDatos2.TabIndex = 1;
      // 
      // frmBotonesColecciones
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1260, 677);
      this.Controls.Add(this.txtDato);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.lblCantItems2);
      this.Controls.Add(this.lblCantItems1);
      this.Controls.Add(this.panel1);
      this.Name = "frmBotonesColecciones";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ejercicio Botones Colecciones";
      this.Load += new System.EventHandler(this.frmBotonesColecciones_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblCantItems1;
    private System.Windows.Forms.Label lblCantItems2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDato;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnTodosIzquierda;
    private System.Windows.Forms.Button btnSelectIzquierda;
    private System.Windows.Forms.Button btnTodosDerecha;
    private System.Windows.Forms.Button btnSelectDerecha;
    private System.Windows.Forms.ListBox lstDatos2;
    private System.Windows.Forms.ListBox lstDatos1;
  }
}

