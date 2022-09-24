
namespace Formulario_Semana9
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelID = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.btAFP = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btISS = new System.Windows.Forms.Button();
            this.SalarioNeto = new System.Windows.Forms.Button();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelID.Location = new System.Drawing.Point(258, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(390, 230);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNombre.Location = new System.Drawing.Point(258, 81);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDUI.Location = new System.Drawing.Point(258, 135);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 3;
            this.labelDUI.Text = "DUI";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSalario.Location = new System.Drawing.Point(258, 178);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 4;
            this.labelSalario.Text = "Salario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(365, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(365, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(365, 132);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(365, 175);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 9;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(660, 33);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 10;
            // 
            // btAFP
            // 
            this.btAFP.Location = new System.Drawing.Point(558, 30);
            this.btAFP.Name = "btAFP";
            this.btAFP.Size = new System.Drawing.Size(75, 23);
            this.btAFP.TabIndex = 11;
            this.btAFP.Text = " AFP";
            this.btAFP.UseVisualStyleBackColor = true;
            this.btAFP.Click += new System.EventHandler(this.btAFP_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRegistro.Location = new System.Drawing.Point(671, 198);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btISS
            // 
            this.btISS.Location = new System.Drawing.Point(558, 78);
            this.btISS.Name = "btISS";
            this.btISS.Size = new System.Drawing.Size(75, 23);
            this.btISS.TabIndex = 13;
            this.btISS.Text = "ISSS";
            this.btISS.UseVisualStyleBackColor = true;
            this.btISS.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalarioNeto
            // 
            this.SalarioNeto.Location = new System.Drawing.Point(558, 135);
            this.SalarioNeto.Name = "SalarioNeto";
            this.SalarioNeto.Size = new System.Drawing.Size(75, 23);
            this.SalarioNeto.TabIndex = 14;
            this.SalarioNeto.Text = "Salario Neto";
            this.SalarioNeto.UseVisualStyleBackColor = true;
            this.SalarioNeto.Click += new System.EventHandler(this.SalarioNeto_Click);
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(660, 78);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 15;
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(663, 135);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNeto.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.SalarioNeto);
            this.Controls.Add(this.btISS);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.btAFP);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.labelID);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Button btAFP;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Button SalarioNeto;
        private System.Windows.Forms.Button btISS;
    }
}

