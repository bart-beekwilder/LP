using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotenVerhuur
{
    public partial class Form1 : Form
    {
        List<Artikel> artikelen = new List<Artikel>();
        List<Water> wateren = new List<Water>(); 
        List<Boot> boten = new List<Boot>(); 
        private double kosten;
        private bool roeien = false;
        private bool motornodig = false;
        Database db =
    new Database(
        "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));");
        public Form1()
        {
            InitializeComponent();
            artikelen = db.GetArktikelen();
            wateren = db.GetWateren();
            boten = db.GetBoten();
            UpdateUI();
        }

        private void UpdateUI()
        {
            cbbWater.Items.Clear();
            cbbArtikelen.Items.Clear();
            cbbBoot.Items.Clear();
            lblKosten.Text = "Kosten: €" + Convert.ToString(kosten);

            foreach (Artikel artikel in artikelen)
            {
                cbbArtikelen.Items.Add(artikel);
            }

            foreach (Water water in wateren)
            {
                cbbWater.Items.Add(water);
            }
            foreach (Boot boot in boten)
            {
                cbbBoot.Items.Add(boot);
            }
            foreach (Water water in wateren)
            {
                if (roeien == true && water.motorNodig == true)
                {
                    wateren.Remove(water);
                    break;
                }
            }
            foreach (Boot boot in boten)
            {
                if (motornodig == true && boot.tankInhoud == 0)
                {
                    boten.Remove(boot);
                    break;
                }
            }
            CheckNull();
        }

        private void CheckNull()
        {
            if (cbbArtikelen.SelectedItem == null)
            {
                btnAddArtikel.Enabled = false;
            }
            else
            {
                btnAddArtikel.Enabled = true;
            }
            if (cbbWater.SelectedItem == null)
            {
                btnAddWater.Enabled = false;
            }
            else
            {
                btnAddWater.Enabled = true;
            }
            if (cbbBoot.SelectedItem == null)
            {
                btnAddBoot.Enabled = false;
            }
            else
            {
                btnAddBoot.Enabled = true;
            }
        }

        private void AddedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnArtikelToevoegen_Click(object sender, EventArgs e)
        {
            lbAddedItems.Items.Add(cbbArtikelen.SelectedItem);
            foreach (Artikel artikl in artikelen)
            {
                if (cbbArtikelen.SelectedItem == artikl)
                {
                    kosten += artikl.prijs;
                    artikelen.Remove(artikl);
                    break;
                }

            }
            UpdateUI();
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            
            foreach (Water watr in wateren)
            {
                if (cbbWater.SelectedItem == watr)
                {
                    if (watr.motorNodig == false || (watr.motorNodig == true && roeien == false))
                    {
                        if (watr.motorNodig == true)
                        {
                            motornodig = true;
                        }
                        kosten += watr.prijs;
                        wateren.Remove(watr);
                        lbAddedItems.Items.Add(cbbWater.SelectedItem);
                        break;
                    }

                }

            }
            UpdateUI();
        }
        private void btnAddBoot_Click(object sender, EventArgs e)
        {
            
            foreach (Boot bootr in boten)
            {
                if (cbbBoot.SelectedItem == bootr)
                {
                    if (bootr.tankInhoud > 0 || (bootr.tankInhoud == 0 && motornodig == false))
                    {
                        if (bootr.tankInhoud == 0)
                        {
                            roeien = true;
                        }
                        kosten += bootr.prijs;
                        lbAddedItems.Items.Add(cbbBoot.SelectedItem);
                        boten.Remove(bootr);
                        break;
                    }
                }
            }
            UpdateUI();
        }

        private void cbbWater_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void cbbBoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void cbbArtikelen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (db.CheckEmail(txtEmail.Text))
            {
                txtEmail.Visible = false;
                lblEmail.Visible = false;
                btnCheck.Visible = false;
                cbbArtikelen.Visible = true;
                cbbBoot.Visible = true;
                cbbWater.Visible = true;
                btnAddArtikel.Visible = true;
                btnAddBoot.Visible = true;
                btnAddWater.Visible = true;
                lbAddedItems.Visible = true;
                lblArtikel.Visible = true;
                lblKosten.Visible = true;
                lblBoot.Visible = true;
                lblWateren.Visible = true;
            }
            else
            {
                btnCheck.Visible = false;
                lblNaam.Visible = true;
                txtNaam.Visible = true;
            }
        }
    }
}
