namespace EksamensProjekt
{
    partial class Form1
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
            opskrifterListBox = new ListBox();
            label1 = new Label();
            udførselTextBox = new TextBox();
            gemOpskriftButton = new Button();
            label2 = new Label();
            titelTextBox = new TextBox();
            kategoriComboBox = new ComboBox();
            ingredienserCheckedListBox = new CheckedListBox();
            ingredienserTextBox = new TextBox();
            nyOpskriftButton = new Button();
            sletIngrediensButton = new Button();
            button4 = new Button();
            visKategoriComboBox = new ComboBox();
            sletOpskriftButton = new Button();
            SuspendLayout();
            // 
            // opskrifterListBox
            // 
            opskrifterListBox.FormattingEnabled = true;
            opskrifterListBox.Location = new Point(43, 85);
            opskrifterListBox.Name = "opskrifterListBox";
            opskrifterListBox.Size = new Size(206, 524);
            opskrifterListBox.TabIndex = 0;
            opskrifterListBox.SelectedIndexChanged += listBoxIndholdsliste_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 21);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Opskrifter";
            // 
            // udførselTextBox
            // 
            udførselTextBox.Location = new Point(300, 156);
            udførselTextBox.Multiline = true;
            udførselTextBox.Name = "udførselTextBox";
            udførselTextBox.ScrollBars = ScrollBars.Vertical;
            udførselTextBox.Size = new Size(484, 453);
            udførselTextBox.TabIndex = 2;
            udførselTextBox.Text = "Angiv udførelsen";
            // 
            // gemOpskriftButton
            // 
            gemOpskriftButton.Location = new Point(828, 580);
            gemOpskriftButton.Name = "gemOpskriftButton";
            gemOpskriftButton.Size = new Size(205, 29);
            gemOpskriftButton.TabIndex = 3;
            gemOpskriftButton.Text = "Gem opskrift";
            gemOpskriftButton.UseVisualStyleBackColor = true;
            gemOpskriftButton.Click += buttonGemEllerRedigerOpskrift_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 42);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // titelTextBox
            // 
            titelTextBox.Location = new Point(301, 85);
            titelTextBox.Name = "titelTextBox";
            titelTextBox.Size = new Size(232, 27);
            titelTextBox.TabIndex = 7;
            titelTextBox.Text = "Angiv titel";
            // 
            // kategoriComboBox
            // 
            kategoriComboBox.FormattingEnabled = true;
            kategoriComboBox.Items.AddRange(new object[] { "Forret", "Hovedret", "Dessert" });
            kategoriComboBox.Location = new Point(301, 119);
            kategoriComboBox.Name = "kategoriComboBox";
            kategoriComboBox.Size = new Size(231, 28);
            kategoriComboBox.TabIndex = 8;
            kategoriComboBox.Text = "Angiv kategori";
            // 
            // ingredienserCheckedListBox
            // 
            ingredienserCheckedListBox.CheckOnClick = true;
            ingredienserCheckedListBox.FormattingEnabled = true;
            ingredienserCheckedListBox.Location = new Point(828, 85);
            ingredienserCheckedListBox.Name = "ingredienserCheckedListBox";
            ingredienserCheckedListBox.Size = new Size(205, 224);
            ingredienserCheckedListBox.TabIndex = 9;
            // 
            // ingredienserTextBox
            // 
            ingredienserTextBox.Location = new Point(828, 353);
            ingredienserTextBox.Multiline = true;
            ingredienserTextBox.Name = "ingredienserTextBox";
            ingredienserTextBox.ScrollBars = ScrollBars.Vertical;
            ingredienserTextBox.Size = new Size(205, 222);
            ingredienserTextBox.TabIndex = 10;
            ingredienserTextBox.Text = "Angiv ingredienserne, adskilt af et linjeskift for hver ingrediens.";
            // 
            // nyOpskriftButton
            // 
            nyOpskriftButton.Location = new Point(652, 83);
            nyOpskriftButton.Name = "nyOpskriftButton";
            nyOpskriftButton.Size = new Size(132, 29);
            nyOpskriftButton.TabIndex = 12;
            nyOpskriftButton.Text = "Ny opskrift";
            nyOpskriftButton.UseVisualStyleBackColor = true;
            nyOpskriftButton.Click += buttonNyOpskrift_Click;
            // 
            // sletIngrediensButton
            // 
            sletIngrediensButton.Location = new Point(828, 318);
            sletIngrediensButton.Name = "sletIngrediensButton";
            sletIngrediensButton.Size = new Size(205, 29);
            sletIngrediensButton.TabIndex = 13;
            sletIngrediensButton.Text = "Slet ingrediens";
            sletIngrediensButton.UseVisualStyleBackColor = true;
            sletIngrediensButton.Click += buttonSletIngredienser_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1076, 329);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // visKategoriComboBox
            // 
            visKategoriComboBox.FormattingEnabled = true;
            visKategoriComboBox.Items.AddRange(new object[] { "Alle opskrifter", "Forret", "Hovedret", "Dessert" });
            visKategoriComboBox.Location = new Point(43, 49);
            visKategoriComboBox.Name = "visKategoriComboBox";
            visKategoriComboBox.Size = new Size(206, 28);
            visKategoriComboBox.TabIndex = 15;
            visKategoriComboBox.Text = "Vis Opskriftskategori";
            visKategoriComboBox.SelectedIndexChanged += comboBoxVisKategori_SelectedIndexChanged;
            // 
            // sletOpskriftButton
            // 
            sletOpskriftButton.Location = new Point(652, 118);
            sletOpskriftButton.Name = "sletOpskriftButton";
            sletOpskriftButton.Size = new Size(132, 29);
            sletOpskriftButton.TabIndex = 16;
            sletOpskriftButton.Text = "Slet opskrift";
            sletOpskriftButton.UseVisualStyleBackColor = true;
            sletOpskriftButton.Click += buttonSletOpskrift_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 647);
            Controls.Add(sletOpskriftButton);
            Controls.Add(visKategoriComboBox);
            Controls.Add(button4);
            Controls.Add(sletIngrediensButton);
            Controls.Add(nyOpskriftButton);
            Controls.Add(ingredienserTextBox);
            Controls.Add(ingredienserCheckedListBox);
            Controls.Add(kategoriComboBox);
            Controls.Add(titelTextBox);
            Controls.Add(label2);
            Controls.Add(gemOpskriftButton);
            Controls.Add(udførselTextBox);
            Controls.Add(label1);
            Controls.Add(opskrifterListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TextChanged += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox opskrifterListBox;
        private Label label1;
        private TextBox udførselTextBox;
        private Button gemOpskriftButton;
        private Label label2;
        private TextBox titelTextBox;
        private ComboBox kategoriComboBox;
        private CheckedListBox ingredienserCheckedListBox;
        private TextBox ingredienserTextBox;
        private Button nyOpskriftButton;
        private Button sletIngrediensButton;
        private Button button4;
        private Button sletIngrediens;
        private ComboBox visKategoriComboBox;
        private Button sletOpskriftButton;
    }
}
