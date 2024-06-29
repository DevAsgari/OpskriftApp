using CsvHelper.Configuration;
using EksamensProjekt.JSON;
using EksamensProjekt.Opskrifter;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace EksamensProjekt
{
    public partial class Form1 : Form
    {
        List<Opskrift> opskrifter;
        List<Ingrediens> ingredienser;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getOpskrifter();
        }


        private void listBoxIndholdsliste_SelectedIndexChanged(object sender, EventArgs e)
        {

            showContent();

            {
                if (opskrifterListBox.SelectedIndex != -1)
                {
                    gemOpskriftButton.Text = "Rediger";
                }
                else
                {
                    gemOpskriftButton.Text = "Gem";
                }
            }
        }

        private void buttonGemEllerRedigerOpskrift_Click_1(object sender, EventArgs e)
        {
            GemEllerRedigerOpskrift();
        }

        private void buttonNyOpskrift_Click(object sender, EventArgs e)
        {
            resetFormular();
        }

        private async void buttonSletIngredienser_Click(object sender, EventArgs e)
        {
            // slet valgte ingredienser

            int index = findIndex();

            if (opskrifterListBox.SelectedIndex != -1)
            {
                sletIngredienser(index);
            }
            else
            {
                MessageBox.Show("Vælg en opskrift", "Dialogbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBoxVisKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            getKategorier(visKategoriComboBox.SelectedItem.ToString());
        }

        private void buttonSletOpskrift_Click(object sender, EventArgs e)
        {
            int index = findIndex();

            if (opskrifterListBox.SelectedIndex != -1)
            {
                sletOpskrift(index);
            }
            else
            {
                MessageBox.Show("Vælg en opskrift", "Dialogbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sletIngredienser(int index)
        {
            Opskrift valgtOpskrift = opskrifter[index];

            if (ingredienserCheckedListBox.CheckedItems.Count > 0)
            {
                List<Ingrediens> valgteIngredienser = new List<Ingrediens>();
                foreach (object selectedItem in ingredienserCheckedListBox.CheckedItems)
                {
                    valgteIngredienser.Add((Ingrediens)selectedItem);
                }

                foreach (Ingrediens ingredient in valgteIngredienser)
                {
                    valgtOpskrift.Ingredienser.Remove(ingredient);
                }

                for (int i = 0; i < ingredienserCheckedListBox.Items.Count; i++)
                {
                    ingredienserCheckedListBox.SetItemChecked(i, false);
                }

                updateOpskrifter();

                opskrifterListBox.SelectedIndex = index;

                showContent();
            }
            else
            {
                MessageBox.Show("Vælg mindst en ingrediens, som skal slettes", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void sletOpskrift(int index)
        {

            opskrifter.RemoveAt(index);

            updateOpskrifter();

            if (opskrifter.Count < 0)
            {
                showContent();
            }
            else
            {
                resetFormular();
            }

            opskrifterListBox.SelectedIndex = index - 1;

            MessageBox.Show("Opskriften blev slettet", "Slettet opskrift", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<Ingrediens> addIngrediens(String ingrediensNavne)
        {
            string[] ingrediensSplit = ingrediensNavne.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<Ingrediens> resultat = new List<Ingrediens>();

            foreach (string ingrediensNavn in ingrediensSplit)
            {
                resultat.Add(new Ingrediens(ingrediensNavn.Trim()));
            }
            return resultat;
        }

        private void resetFormular()
        {
            titelTextBox.Text = "Angiv titel";
            udførselTextBox.Text = "Angiv udførelsen her";
            ingredienserTextBox.Text = "Angiv ingredienserne, adskilt af et linjeskift for hver ingrediens.";
            kategoriComboBox.Text = "Angiv kategori";
            ingredienserCheckedListBox.DataSource = null;
            opskrifterListBox.ClearSelected();
            gemOpskriftButton.Text = "Gem";
        }

        private void showContent()
        {
            int index = findIndex();

            if (index != -1)
            {
                titelTextBox.Text = opskrifter[index].Titel;
                udførselTextBox.Text = opskrifter[index].Udførelsel + "\r\n\r\n" + sundOpskrift(opskrifter[index]);
                ingredienserCheckedListBox.DataSource = opskrifter[index].Ingredienser;
                ingredienserCheckedListBox.DisplayMember = "IngrediensNavn";
                kategoriComboBox.SelectedItem = opskrifter[index].Type;
                ingredienserTextBox.Clear();
            }
            else
            {
                resetFormular();
            }
        }

        private int findIndex()
        {
            Opskrift aktuelleOpskrift = opskrifter.FirstOrDefault(opskrift => opskrift.Titel == opskrifterListBox.Text);
            int index = opskrifter.IndexOf(aktuelleOpskrift);
            return index;
        }

        private String sundOpskrift(Opskrift opskrift)
        {
            bool sund = opskrift.sundMadret();

            if (sund == true)
            {
                return "Denne opskrift er sund";
            }
            else
            {
                return "Denne opskrift er ikke sund";
            }

        }


        private void GemEllerRedigerOpskrift()
        {
            int index = findIndex();

            if (index != -1)
            {
                // Rediger en opskrift
                Opskrift ValgtOpskrift = opskrifter[index];

                ValgtOpskrift.Titel = titelTextBox.Text;
                ValgtOpskrift.Udførelsel = udførselTextBox.Text;
                ValgtOpskrift.Ingredienser.AddRange(addIngrediens(ingredienserTextBox.Text));
                ValgtOpskrift.Type = kategoriComboBox.Text;

                updateOpskrifter();

                opskrifterListBox.SelectedIndex = index;

                showContent();

                visKategoriComboBox.SelectedItem = "Alle opskrifter";

                MessageBox.Show("Opskriften blev redigeret", "Redigeret opskrift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Gem en ny Opskrift

                ingredienser = addIngrediens(ingredienserTextBox.Text);

                Opskrift nyOpskrift;

                if (kategoriComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Vælg en kategori", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    nyOpskrift = Utils.factories[kategoriComboBox.SelectedItem.ToString()].CreateOpskrift(titelTextBox.Text,
                        ingredienser,
                        udførselTextBox.Text);
                }

                opskrifter.Add(nyOpskrift);

                updateOpskrifter();

                opskrifterListBox.SelectedIndex = opskrifter.Count - 1;

                visKategoriComboBox.SelectedItem = "Alle opskrifter";

                MessageBox.Show("Opskriften blev oprettet", "Ny opskrift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getKategorier(String kategori)
        {
            opskrifterListBox.Items.Clear();

            if (kategori == "Alle opskrifter")
            {
                getOpskrifter();
            }
            else
            {
                var visOpskriftKategori = opskrifter.Where(x => x.Type == kategori).ToList();

                foreach (var opskrift in visOpskriftKategori)
                {
                    opskrifterListBox.Items.Add(opskrift.Titel);
                }
            }
        }

        private void updateOpskrifter()
        {
            WriteJson.WriteJsonFile(opskrifter);

            opskrifterListBox.Items.Clear();

            getOpskrifter();
        }

        private void getOpskrifter()
        {
            opskrifter = ReadJson.ReadOpskrifter();

            for (int i = 0; i < opskrifter.Count; i++)
            {
                opskrifterListBox.Items.Add(opskrifter[i].Titel);
            }
        }
    }
}
