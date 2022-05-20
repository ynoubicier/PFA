namespace PFA.Formulaire
{
    partial class FRM_Ajouter_Modifier_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNomProduit = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.comboFournisseur = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 531);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 534);
            this.panel4.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(177, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Ajouter produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image";
            // 
            // btnParcourir
            // 
            this.btnParcourir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnParcourir.FlatAppearance.BorderSize = 0;
            this.btnParcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcourir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnParcourir.Location = new System.Drawing.Point(199, 340);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(117, 32);
            this.btnParcourir.TabIndex = 6;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = false;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // comboCategorie
            // 
            this.comboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Location = new System.Drawing.Point(520, 101);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboCategorie.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(395, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 1);
            this.panel5.TabIndex = 14;
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNomProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomProduit.Location = new System.Drawing.Point(395, 165);
            this.txtNomProduit.Multiline = true;
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.Size = new System.Drawing.Size(261, 35);
            this.txtNomProduit.TabIndex = 13;
            this.txtNomProduit.Text = "Nom du produit";
            this.txtNomProduit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomProduit.Enter += new System.EventHandler(this.txtNomProduit_Enter);
            this.txtNomProduit.Leave += new System.EventHandler(this.txtNomProduit_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(395, 294);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 1);
            this.panel6.TabIndex = 17;
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtQte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQte.Location = new System.Drawing.Point(395, 258);
            this.txtQte.Multiline = true;
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(261, 35);
            this.txtQte.TabIndex = 16;
            this.txtQte.Text = "Quantité";
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.Enter += new System.EventHandler(this.txtQte_Enter);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            this.txtQte.Leave += new System.EventHandler(this.txtQte_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(395, 389);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 1);
            this.panel7.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.Location = new System.Drawing.Point(395, 353);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(261, 35);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.Text = "Prix";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnregistrer.Location = new System.Drawing.Point(394, 437);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(229, 40);
            this.btnEnregistrer.TabIndex = 34;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualiser.Location = new System.Drawing.Point(50, 437);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(229, 40);
            this.btnActualiser.TabIndex = 33;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorie.Location = new System.Drawing.Point(345, 99);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(89, 19);
            this.lblCategorie.TabIndex = 35;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFournisseur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFournisseur.Location = new System.Drawing.Point(26, 99);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(103, 19);
            this.lblFournisseur.TabIndex = 36;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // comboFournisseur
            // 
            this.comboFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFournisseur.FormattingEnabled = true;
            this.comboFournisseur.Location = new System.Drawing.Point(147, 101);
            this.comboFournisseur.Name = "comboFournisseur";
            this.comboFournisseur.Size = new System.Drawing.Size(121, 21);
            this.comboFournisseur.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PFA.Properties.Resources.cost;
            this.pictureBox3.Location = new System.Drawing.Point(340, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PFA.Properties.Resources.delivered_box;
            this.pictureBox2.Location = new System.Drawing.Point(340, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PFA.Properties.Resources.used_product__1_;
            this.pictureBox1.Location = new System.Drawing.Point(340, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picProduit
            // 
            this.picProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picProduit.Location = new System.Drawing.Point(106, 193);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(210, 129);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 4;
            this.picProduit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::PFA.Properties.Resources.experimental_delete_sign_tiny_color;
            this.btnExit.Location = new System.Drawing.Point(602, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 46);
            this.btnExit.TabIndex = 38;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FRM_Ajouter_Modifier_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(669, 537);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboFournisseur);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtNomProduit);
            this.Controls.Add(this.comboCategorie);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtNomProduit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.ComboBox comboFournisseur;
        private System.Windows.Forms.Button btnExit;
    }
}