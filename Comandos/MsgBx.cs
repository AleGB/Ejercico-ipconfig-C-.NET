using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandos
{
    public partial class MsgBx : Form
    {
        public MsgBx()
        {
            InitializeComponent();
        }

        public MsgBx(string Tipo, string Mensaje)
        {
            InitializeComponent();
            lblMsg.Text = Mensaje;

            switch (Tipo) {
                case "alerta":
                    lblMsgBxTitulo.Text = "Alerta";
                    lblMsgBxTitulo.ForeColor = Color.Orange;
                    pnlMsgBx1.BackColor = Color.Orange;
                    pAlerta.Visible = true;
                    break;
                case "error":
                    lblMsgBxTitulo.Text = "Error";
                    lblMsgBxTitulo.ForeColor = Color.Firebrick;
                    pnlMsgBx1.BackColor = Color.Firebrick;
                    pError.Visible = true;
                    break;
            }
        }
        private void MsgBx_Load(object sender, EventArgs e)
        {

        }

        private void btnMsgBxOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
