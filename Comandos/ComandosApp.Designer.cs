namespace Comandos
{
    partial class ComandosApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbComandos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbComandos
            // 
            this.cmbComandos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbComandos.FormattingEnabled = true;
            this.cmbComandos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbComandos.Items.AddRange(new object[] {
            "ipconfig ",
            "ipconfig /all"});
            this.cmbComandos.Location = new System.Drawing.Point(62, 138);
            this.cmbComandos.MaxDropDownItems = 15;
            this.cmbComandos.Name = "cmbComandos";
            this.cmbComandos.Size = new System.Drawing.Size(168, 23);
            this.cmbComandos.TabIndex = 0;
            this.cmbComandos.Text = "Seleccionar...";
            this.cmbComandos.SelectedIndexChanged += new System.EventHandler(this.cmbComandos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(-8, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 83);
            this.panel1.TabIndex = 11;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.Titulo.Location = new System.Drawing.Point(294, 28);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(438, 32);
            this.Titulo.TabIndex = 9;
            this.Titulo.Text = "Comandos consola de Windows";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(890, 640);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 39);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(487, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Información";
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProp.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelProp.Location = new System.Drawing.Point(49, 242);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(105, 21);
            this.labelProp.TabIndex = 7;
            this.labelProp.Text = "Propiedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(49, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Secciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(49, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comandos";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(62, 203);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(316, 23);
            this.cmbSeccion.TabIndex = 4;
            this.cmbSeccion.Text = "Seleccionar...";
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
            // 
            // txbInfo
            // 
            this.txbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.txbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInfo.ForeColor = System.Drawing.Color.White;
            this.txbInfo.Location = new System.Drawing.Point(487, 138);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.ReadOnly = true;
            this.txbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbInfo.Size = new System.Drawing.Size(521, 496);
            this.txbInfo.TabIndex = 3;
            // 
            // ComandosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1044, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.cmbComandos);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "ComandosApp";
            this.Text = "Comandos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbComandos;
        private TextBox txbInfo;
        private ComboBox cmbSeccion;
        private Label label1;
        private Label label2;
        private Label labelProp;
        private Label label4;
        private Label Titulo;
        private Button btnLimpiar;
        private Panel panel1;
    }
}