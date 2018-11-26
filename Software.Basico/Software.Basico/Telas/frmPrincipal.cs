using Software.Basico.Telas.SubTelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            TemaTela();
            ScreenFrmHome();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ScreenFrmHome();

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnHome.Location.Y);
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            ScreenFrmRecursos();

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnRecursos.Location.Y);
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            ScreenFrmOpcoes();

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnOpcoes.Location.Y);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ScreenFrmUsuarios();

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnUsuarios.Location.Y);
        }

        private void ScreenFrmHome()
        {
            frmHome frm = new frmHome();

            if (pnPrincipal.Controls.Count == 1)
                pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(frm);            
        }

        private void ScreenFrmRecursos()
        {
            frmTema frm = new frmTema();

            if (pnPrincipal.Controls.Count == 1)
                pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(frm);
        }

        private void ScreenFrmOpcoes()
        {
            //frmHome frm = new frmHome();

            //if (pnPrincipal.Controls.Count == 1)
            //    pnPrincipal.Controls.RemoveAt(0);
            //pnPrincipal.Controls.Add(frm);
        }

        private void ScreenFrmUsuarios()
        {
            //frmHome frm = new frmHome();

            //if (pnPrincipal.Controls.Count == 1)
            //    pnPrincipal.Controls.RemoveAt(0);
            //pnPrincipal.Controls.Add(frm);
        }
        
        public void Fechar()
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void TemaTela()
        {
            if (Tema.tema == "1")
            {
                panel2.Visible = true;
                logo1.Visible = true;
            }
            else
                logo2.Visible = true;

            ActiveForm.BackColor = Tema.Principal;
            panel1.BackColor = Tema.Primaria;            
            panel2.BackColor = Tema.Segundaria;
            pnBtnSel.BackColor = Tema.Segundaria;
            flowLayoutPanel1.BackColor = Tema.Segundaria;

            //label2.ForeColor = Tema.Texto;
            btnHome.ForeColor = Tema.Texto;
            btnRecursos.ForeColor = Tema.Texto;
            btnOpcoes.ForeColor = Tema.Texto;
            btnUsuarios.ForeColor = Tema.Texto;
            button4.ForeColor = Tema.Texto;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnBtnSel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
