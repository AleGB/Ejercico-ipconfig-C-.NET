namespace Comandos
{
    partial class MsgBx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBx));
            this.pnlMsgBx1 = new System.Windows.Forms.Panel();
            this.pnlMsgBx2 = new System.Windows.Forms.Panel();
            this.lblMsgBxTitulo = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pAlerta = new System.Windows.Forms.PictureBox();
            this.btnMsgBxOK = new System.Windows.Forms.Button();
            this.pError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMsgBx1
            // 
            this.pnlMsgBx1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMsgBx1.Location = new System.Drawing.Point(-1, 64);
            this.pnlMsgBx1.Name = "pnlMsgBx1";
            this.pnlMsgBx1.Size = new System.Drawing.Size(422, 4);
            this.pnlMsgBx1.TabIndex = 0;
            // 
            // pnlMsgBx2
            // 
            this.pnlMsgBx2.BackColor = System.Drawing.Color.Silver;
            this.pnlMsgBx2.Location = new System.Drawing.Point(-1, 155);
            this.pnlMsgBx2.Name = "pnlMsgBx2";
            this.pnlMsgBx2.Size = new System.Drawing.Size(422, 4);
            this.pnlMsgBx2.TabIndex = 1;
            // 
            // lblMsgBxTitulo
            // 
            this.lblMsgBxTitulo.AutoSize = true;
            this.lblMsgBxTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsgBxTitulo.Location = new System.Drawing.Point(68, 22);
            this.lblMsgBxTitulo.Name = "lblMsgBxTitulo";
            this.lblMsgBxTitulo.Size = new System.Drawing.Size(65, 25);
            this.lblMsgBxTitulo.TabIndex = 2;
            this.lblMsgBxTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(12, 75);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(396, 70);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // pAlerta
            // 
            this.pAlerta.Image = global::Comandos.Properties.Resources.warning;
            this.pAlerta.Location = new System.Drawing.Point(12, 12);
            this.pAlerta.Name = "pAlerta";
            this.pAlerta.Size = new System.Drawing.Size(50, 35);
            this.pAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAlerta.TabIndex = 4;
            this.pAlerta.TabStop = false;
            this.pAlerta.Visible = false;
            // 
            // btnMsgBxOK
            // 
            this.btnMsgBxOK.Location = new System.Drawing.Point(333, 165);
            this.btnMsgBxOK.Name = "btnMsgBxOK";
            this.btnMsgBxOK.Size = new System.Drawing.Size(75, 23);
            this.btnMsgBxOK.TabIndex = 5;
            this.btnMsgBxOK.Text = "Ok";
            this.btnMsgBxOK.UseVisualStyleBackColor = true;
            this.btnMsgBxOK.Click += new System.EventHandler(this.btnMsgBxOK_Click);
            // 
            // pError
            // 
            this.pError.Image = ((System.Drawing.Image)(resources.GetObject("pError.Image")));
            this.pError.Location = new System.Drawing.Point(12, 12);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(50, 35);
            this.pError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pError.TabIndex = 6;
            this.pError.TabStop = false;
            this.pError.Visible = false;
            // 
            // MsgBx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.ControlBox = false;
            this.Controls.Add(this.pError);
            this.Controls.Add(this.btnMsgBxOK);
            this.Controls.Add(this.pAlerta);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblMsgBxTitulo);
            this.Controls.Add(this.pnlMsgBx2);
            this.Controls.Add(this.pnlMsgBx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MsgBx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comandos (Mensaje)";
            this.Load += new System.EventHandler(this.MsgBx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlMsgBx1;
        private Panel pnlMsgBx2;
        private Label lblMsgBxTitulo;
        private Label lblMsg;
        private PictureBox pAlerta;
        private Button btnMsgBxOK;
        private PictureBox pError;
    }
}