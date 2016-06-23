namespace BotenVerhuur
{
    partial class Form1
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
            this.lbAddedItems = new System.Windows.Forms.ListBox();
            this.cbbArtikelen = new System.Windows.Forms.ComboBox();
            this.lblArtikel = new System.Windows.Forms.Label();
            this.btnAddArtikel = new System.Windows.Forms.Button();
            this.lblKosten = new System.Windows.Forms.Label();
            this.lblBoot = new System.Windows.Forms.Label();
            this.lblWateren = new System.Windows.Forms.Label();
            this.cbbBoot = new System.Windows.Forms.ComboBox();
            this.cbbWater = new System.Windows.Forms.ComboBox();
            this.btnAddBoot = new System.Windows.Forms.Button();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAddedItems
            // 
            this.lbAddedItems.FormattingEnabled = true;
            this.lbAddedItems.Location = new System.Drawing.Point(12, 164);
            this.lbAddedItems.Name = "lbAddedItems";
            this.lbAddedItems.Size = new System.Drawing.Size(197, 160);
            this.lbAddedItems.TabIndex = 0;
            this.lbAddedItems.Visible = false;
            this.lbAddedItems.SelectedIndexChanged += new System.EventHandler(this.AddedItems_SelectedIndexChanged);
            // 
            // cbbArtikelen
            // 
            this.cbbArtikelen.FormattingEnabled = true;
            this.cbbArtikelen.Location = new System.Drawing.Point(54, 6);
            this.cbbArtikelen.Name = "cbbArtikelen";
            this.cbbArtikelen.Size = new System.Drawing.Size(121, 21);
            this.cbbArtikelen.TabIndex = 1;
            this.cbbArtikelen.Visible = false;
            this.cbbArtikelen.SelectedIndexChanged += new System.EventHandler(this.cbbArtikelen_SelectedIndexChanged);
            // 
            // lblArtikel
            // 
            this.lblArtikel.AutoSize = true;
            this.lblArtikel.Location = new System.Drawing.Point(9, 9);
            this.lblArtikel.Name = "lblArtikel";
            this.lblArtikel.Size = new System.Drawing.Size(39, 13);
            this.lblArtikel.TabIndex = 2;
            this.lblArtikel.Text = "Artikel:";
            this.lblArtikel.Visible = false;
            // 
            // btnAddArtikel
            // 
            this.btnAddArtikel.Location = new System.Drawing.Point(181, 4);
            this.btnAddArtikel.Name = "btnAddArtikel";
            this.btnAddArtikel.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtikel.TabIndex = 3;
            this.btnAddArtikel.Text = "Voeg toe";
            this.btnAddArtikel.UseVisualStyleBackColor = true;
            this.btnAddArtikel.Visible = false;
            this.btnAddArtikel.Click += new System.EventHandler(this.btnArtikelToevoegen_Click);
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(13, 145);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(52, 13);
            this.lblKosten.TabIndex = 4;
            this.lblKosten.Text = "Kosten: €";
            this.lblKosten.Visible = false;
            // 
            // lblBoot
            // 
            this.lblBoot.AutoSize = true;
            this.lblBoot.Location = new System.Drawing.Point(16, 36);
            this.lblBoot.Name = "lblBoot";
            this.lblBoot.Size = new System.Drawing.Size(32, 13);
            this.lblBoot.TabIndex = 5;
            this.lblBoot.Text = "Boot:";
            this.lblBoot.Visible = false;
            // 
            // lblWateren
            // 
            this.lblWateren.AutoSize = true;
            this.lblWateren.Location = new System.Drawing.Point(9, 63);
            this.lblWateren.Name = "lblWateren";
            this.lblWateren.Size = new System.Drawing.Size(39, 13);
            this.lblWateren.TabIndex = 6;
            this.lblWateren.Text = "Water:";
            this.lblWateren.Visible = false;
            // 
            // cbbBoot
            // 
            this.cbbBoot.FormattingEnabled = true;
            this.cbbBoot.Location = new System.Drawing.Point(54, 33);
            this.cbbBoot.Name = "cbbBoot";
            this.cbbBoot.Size = new System.Drawing.Size(121, 21);
            this.cbbBoot.TabIndex = 7;
            this.cbbBoot.Visible = false;
            this.cbbBoot.SelectedIndexChanged += new System.EventHandler(this.cbbBoot_SelectedIndexChanged);
            // 
            // cbbWater
            // 
            this.cbbWater.FormattingEnabled = true;
            this.cbbWater.Location = new System.Drawing.Point(54, 60);
            this.cbbWater.Name = "cbbWater";
            this.cbbWater.Size = new System.Drawing.Size(121, 21);
            this.cbbWater.TabIndex = 8;
            this.cbbWater.Visible = false;
            this.cbbWater.SelectedIndexChanged += new System.EventHandler(this.cbbWater_SelectedIndexChanged);
            // 
            // btnAddBoot
            // 
            this.btnAddBoot.Location = new System.Drawing.Point(181, 31);
            this.btnAddBoot.Name = "btnAddBoot";
            this.btnAddBoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddBoot.TabIndex = 9;
            this.btnAddBoot.Text = "Voeg toe";
            this.btnAddBoot.UseVisualStyleBackColor = true;
            this.btnAddBoot.Visible = false;
            this.btnAddBoot.Click += new System.EventHandler(this.btnAddBoot_Click);
            // 
            // btnAddWater
            // 
            this.btnAddWater.Location = new System.Drawing.Point(181, 58);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(75, 23);
            this.btnAddWater.TabIndex = 10;
            this.btnAddWater.Text = "Voeg toe";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Visible = false;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(235, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(194, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(388, 140);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(194, 171);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(33, 13);
            this.lblNaam.TabIndex = 14;
            this.lblNaam.Text = "naam";
            this.lblNaam.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(388, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(235, 168);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(147, 20);
            this.txtNaam.TabIndex = 16;
            this.txtNaam.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 336);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.btnAddBoot);
            this.Controls.Add(this.cbbWater);
            this.Controls.Add(this.cbbBoot);
            this.Controls.Add(this.lblWateren);
            this.Controls.Add(this.lblBoot);
            this.Controls.Add(this.lblKosten);
            this.Controls.Add(this.btnAddArtikel);
            this.Controls.Add(this.lblArtikel);
            this.Controls.Add(this.cbbArtikelen);
            this.Controls.Add(this.lbAddedItems);
            this.Name = "Form1";
            this.Text = "Boten Verhuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAddedItems;
        private System.Windows.Forms.ComboBox cbbArtikelen;
        private System.Windows.Forms.Label lblArtikel;
        private System.Windows.Forms.Button btnAddArtikel;
        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.Label lblBoot;
        private System.Windows.Forms.Label lblWateren;
        private System.Windows.Forms.ComboBox cbbBoot;
        private System.Windows.Forms.ComboBox cbbWater;
        private System.Windows.Forms.Button btnAddBoot;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtNaam;
    }
}

