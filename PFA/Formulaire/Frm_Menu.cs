using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFA.Formulaire
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            pnlParametre.Visible = false;
        }

        //Désactiver le formulaire
        public void desactiverForm()
        {
            btnClient.Enabled = false;
            btnProduit.Enabled = false;
            btnStock.Enabled = false;
            btnEntree.Enabled = false;
            btnSortie.Enabled = false;
            btnFournisseur.Enabled = false;
            btnStats.Enabled = false;
            btnAdmin.Enabled = false;
            btnCopie.Enabled = false;
            btnRestore.Enabled = false;
            btnDeconnect.Enabled = false;
            pnlBut.Enabled = false;
            btnConnexion.Enabled = true;
        }

        //Activer le formulaire
        public void activerForm()
        {
            btnClient.Enabled = true;
            btnProduit.Enabled = true;
            btnStock.Enabled = true;
            btnEntree.Enabled = true;
            btnSortie.Enabled = true;
            btnFournisseur.Enabled = true;
            btnStats.Enabled = true;
            btnAdmin.Enabled = true;
            btnCopie.Enabled = true;
            btnRestore.Enabled = true;
            btnDeconnect.Enabled = true;
            pnlBut.Enabled = true;
            btnConnexion.Enabled = false;
            pnlParametre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void btnReduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(panel1.Width == 229)
            {
                panel1.Size = new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnProduit.Top;
            if (!pnlAfficher.Controls.Contains(User_Liste_Produit.Instance))
            {
                pnlAfficher.Controls.Add(User_Liste_Produit.Instance);
                User_Liste_Produit.Instance.Dock = DockStyle.Fill;
                User_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                User_Liste_Produit.Instance.BringToFront();
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnClient.Top;
            if(!pnlAfficher.Controls.Contains(User_Liste_Client.Instance))
            {
                pnlAfficher.Controls.Add(User_Liste_Client.Instance);
                User_Liste_Client.Instance.Dock = DockStyle.Fill;
                User_Liste_Client.Instance.BringToFront();
            }
            else
            {
                User_Liste_Client.Instance.BringToFront();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnStock.Top;
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnEntree.Top;
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnSortie.Top;
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnFournisseur.Top;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnStats.Top;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnAdmin.Top;
        }

        /*private void btnConnexion_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this);
            frmC.ShowDialog();
        }*/

        private void btnParametre_Click(object sender, EventArgs e)
        {
            pnlParametre.Size = new Size(313, 206);
            pnlParametre.Visible = !pnlParametre.Visible;
        }

        private void btnReduce_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            FRM_Connexion connexion = new FRM_Connexion(this);// this = Frm_Menu
            connexion.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btnDeconnect_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
