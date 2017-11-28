namespace WindowsFormsMoebelverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAllgemein = new System.Windows.Forms.TabPage();
            this.btnAendern = new System.Windows.Forms.Button();
            this.labelHalloWelt = new System.Windows.Forms.Label();
            this.tabFormularTische = new System.Windows.Forms.TabPage();
            this.btnSpeichernDB = new System.Windows.Forms.Button();
            this.btnSpeichernDatei = new System.Windows.Forms.Button();
            this.btnFarbauswahl = new System.Windows.Forms.Button();
            this.radSchwarz = new System.Windows.Forms.RadioButton();
            this.radBlau = new System.Windows.Forms.RadioButton();
            this.radRot = new System.Windows.Forms.RadioButton();
            this.numHoehe = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.labelAnzBeine = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtFarbe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.labelGewicht = new System.Windows.Forms.Label();
            this.labelHoehe = new System.Windows.Forms.Label();
            this.txtBreite = new System.Windows.Forms.TextBox();
            this.labelBreite = new System.Windows.Forms.Label();
            this.txtLaenge = new System.Windows.Forms.TextBox();
            this.labelLaenge = new System.Windows.Forms.Label();
            this.tabSeite3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtAdresszeile = new System.Windows.Forms.TextBox();
            this.tabAnzeige = new System.Windows.Forms.TabPage();
            this.btnOeffnenExtern = new System.Windows.Forms.Button();
            this.btnDateiLesen = new System.Windows.Forms.Button();
            this.listBoxDateiinhalt = new System.Windows.Forms.ListBox();
            this.tabDB = new System.Windows.Forms.TabPage();
            this.btnAnzeigenTischeDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkFormular = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabAllgemein.SuspendLayout();
            this.tabFormularTische.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoehe)).BeginInit();
            this.tabSeite3.SuspendLayout();
            this.tabAnzeige.SuspendLayout();
            this.tabDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAllgemein);
            this.tabControl1.Controls.Add(this.tabFormularTische);
            this.tabControl1.Controls.Add(this.tabSeite3);
            this.tabControl1.Controls.Add(this.tabAnzeige);
            this.tabControl1.Controls.Add(this.tabDB);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 349);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAllgemein
            // 
            this.tabAllgemein.Controls.Add(this.btnAendern);
            this.tabAllgemein.Controls.Add(this.labelHalloWelt);
            this.tabAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tabAllgemein.Name = "tabAllgemein";
            this.tabAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllgemein.Size = new System.Drawing.Size(720, 323);
            this.tabAllgemein.TabIndex = 0;
            this.tabAllgemein.Text = "Allgemeines";
            this.tabAllgemein.UseVisualStyleBackColor = true;
            // 
            // btnAendern
            // 
            this.btnAendern.Location = new System.Drawing.Point(93, 111);
            this.btnAendern.Name = "btnAendern";
            this.btnAendern.Size = new System.Drawing.Size(137, 50);
            this.btnAendern.TabIndex = 1;
            this.btnAendern.Text = "Text ändern";
            this.btnAendern.UseVisualStyleBackColor = true;
            this.btnAendern.Click += new System.EventHandler(this.btnAendern_Click);
            // 
            // labelHalloWelt
            // 
            this.labelHalloWelt.AutoSize = true;
            this.labelHalloWelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalloWelt.Location = new System.Drawing.Point(89, 53);
            this.labelHalloWelt.Name = "labelHalloWelt";
            this.labelHalloWelt.Size = new System.Drawing.Size(81, 20);
            this.labelHalloWelt.TabIndex = 0;
            this.labelHalloWelt.Text = "Hallo Welt";
            // 
            // tabFormularTische
            // 
            this.tabFormularTische.Controls.Add(this.btnSpeichernDB);
            this.tabFormularTische.Controls.Add(this.btnSpeichernDatei);
            this.tabFormularTische.Controls.Add(this.btnFarbauswahl);
            this.tabFormularTische.Controls.Add(this.radSchwarz);
            this.tabFormularTische.Controls.Add(this.radBlau);
            this.tabFormularTische.Controls.Add(this.radRot);
            this.tabFormularTische.Controls.Add(this.numHoehe);
            this.tabFormularTische.Controls.Add(this.btnReset);
            this.tabFormularTische.Controls.Add(this.btnAnzeigen);
            this.tabFormularTische.Controls.Add(this.txtAnzahl);
            this.tabFormularTische.Controls.Add(this.labelAnzBeine);
            this.tabFormularTische.Controls.Add(this.cmbMaterial);
            this.tabFormularTische.Controls.Add(this.txtFarbe);
            this.tabFormularTische.Controls.Add(this.label5);
            this.tabFormularTische.Controls.Add(this.label4);
            this.tabFormularTische.Controls.Add(this.txtGewicht);
            this.tabFormularTische.Controls.Add(this.labelGewicht);
            this.tabFormularTische.Controls.Add(this.labelHoehe);
            this.tabFormularTische.Controls.Add(this.txtBreite);
            this.tabFormularTische.Controls.Add(this.labelBreite);
            this.tabFormularTische.Controls.Add(this.txtLaenge);
            this.tabFormularTische.Controls.Add(this.labelLaenge);
            this.tabFormularTische.Location = new System.Drawing.Point(4, 22);
            this.tabFormularTische.Name = "tabFormularTische";
            this.tabFormularTische.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormularTische.Size = new System.Drawing.Size(720, 323);
            this.tabFormularTische.TabIndex = 1;
            this.tabFormularTische.Text = "Formular Tische";
            this.tabFormularTische.UseVisualStyleBackColor = true;
            // 
            // btnSpeichernDB
            // 
            this.btnSpeichernDB.Location = new System.Drawing.Point(267, 269);
            this.btnSpeichernDB.Name = "btnSpeichernDB";
            this.btnSpeichernDB.Size = new System.Drawing.Size(162, 48);
            this.btnSpeichernDB.TabIndex = 23;
            this.btnSpeichernDB.Text = "Speichern in DB";
            this.btnSpeichernDB.UseVisualStyleBackColor = true;
            this.btnSpeichernDB.Click += new System.EventHandler(this.btnSpeichernDB_Click);
            // 
            // btnSpeichernDatei
            // 
            this.btnSpeichernDatei.Location = new System.Drawing.Point(21, 269);
            this.btnSpeichernDatei.Name = "btnSpeichernDatei";
            this.btnSpeichernDatei.Size = new System.Drawing.Size(159, 48);
            this.btnSpeichernDatei.TabIndex = 22;
            this.btnSpeichernDatei.Text = "Speichern in Datei";
            this.btnSpeichernDatei.UseVisualStyleBackColor = true;
            this.btnSpeichernDatei.Click += new System.EventHandler(this.btnSpeichernDatei_Click);
            // 
            // btnFarbauswahl
            // 
            this.btnFarbauswahl.Location = new System.Drawing.Point(507, 202);
            this.btnFarbauswahl.Name = "btnFarbauswahl";
            this.btnFarbauswahl.Size = new System.Drawing.Size(145, 42);
            this.btnFarbauswahl.TabIndex = 21;
            this.btnFarbauswahl.Text = "Farbe auswählen";
            this.btnFarbauswahl.UseVisualStyleBackColor = true;
            this.btnFarbauswahl.Click += new System.EventHandler(this.btnFarbauswahl_Click);
            // 
            // radSchwarz
            // 
            this.radSchwarz.AutoSize = true;
            this.radSchwarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSchwarz.Location = new System.Drawing.Point(507, 102);
            this.radSchwarz.Name = "radSchwarz";
            this.radSchwarz.Size = new System.Drawing.Size(85, 24);
            this.radSchwarz.TabIndex = 20;
            this.radSchwarz.TabStop = true;
            this.radSchwarz.Text = "schwarz";
            this.radSchwarz.UseVisualStyleBackColor = true;
            this.radSchwarz.CheckedChanged += new System.EventHandler(this.radSchwarz_CheckedChanged);
            // 
            // radBlau
            // 
            this.radBlau.AutoSize = true;
            this.radBlau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlau.Location = new System.Drawing.Point(507, 68);
            this.radBlau.Name = "radBlau";
            this.radBlau.Size = new System.Drawing.Size(57, 24);
            this.radBlau.TabIndex = 19;
            this.radBlau.TabStop = true;
            this.radBlau.Text = "blau";
            this.radBlau.UseVisualStyleBackColor = true;
            this.radBlau.CheckedChanged += new System.EventHandler(this.radBlau_CheckedChanged);
            // 
            // radRot
            // 
            this.radRot.AutoSize = true;
            this.radRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRot.Location = new System.Drawing.Point(507, 33);
            this.radRot.Name = "radRot";
            this.radRot.Size = new System.Drawing.Size(46, 24);
            this.radRot.TabIndex = 18;
            this.radRot.TabStop = true;
            this.radRot.Text = "rot";
            this.radRot.UseVisualStyleBackColor = true;
            this.radRot.CheckedChanged += new System.EventHandler(this.radRot_CheckedChanged);
            // 
            // numHoehe
            // 
            this.numHoehe.Location = new System.Drawing.Point(165, 123);
            this.numHoehe.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numHoehe.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHoehe.Name = "numHoehe";
            this.numHoehe.Size = new System.Drawing.Size(56, 20);
            this.numHoehe.TabIndex = 17;
            this.numHoehe.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(267, 202);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 51);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(21, 202);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(162, 51);
            this.btnAnzeigen.TabIndex = 15;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(165, 163);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(56, 20);
            this.txtAnzahl.TabIndex = 14;
            // 
            // labelAnzBeine
            // 
            this.labelAnzBeine.AutoSize = true;
            this.labelAnzBeine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnzBeine.Location = new System.Drawing.Point(17, 163);
            this.labelAnzBeine.Name = "labelAnzBeine";
            this.labelAnzBeine.Size = new System.Drawing.Size(142, 20);
            this.labelAnzBeine.TabIndex = 13;
            this.labelAnzBeine.Text = "Anzahl Tischbeine:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(339, 72);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(90, 21);
            this.cmbMaterial.TabIndex = 12;
            // 
            // txtFarbe
            // 
            this.txtFarbe.Location = new System.Drawing.Point(339, 123);
            this.txtFarbe.Name = "txtFarbe";
            this.txtFarbe.Size = new System.Drawing.Size(90, 20);
            this.txtFarbe.TabIndex = 11;
            this.txtFarbe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFarbe_KeyDown);
            this.txtFarbe.Leave += new System.EventHandler(this.txtFarbe_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Farbe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Material:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(339, 33);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(90, 20);
            this.txtGewicht.TabIndex = 7;
            // 
            // labelGewicht
            // 
            this.labelGewicht.AutoSize = true;
            this.labelGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewicht.Location = new System.Drawing.Point(263, 34);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(71, 20);
            this.labelGewicht.TabIndex = 6;
            this.labelGewicht.Text = "Gewicht:";
            // 
            // labelHoehe
            // 
            this.labelHoehe.AutoSize = true;
            this.labelHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoehe.Location = new System.Drawing.Point(17, 124);
            this.labelHoehe.Name = "labelHoehe";
            this.labelHoehe.Size = new System.Drawing.Size(52, 20);
            this.labelHoehe.TabIndex = 4;
            this.labelHoehe.Text = "Höhe:";
            // 
            // txtBreite
            // 
            this.txtBreite.Location = new System.Drawing.Point(165, 74);
            this.txtBreite.Name = "txtBreite";
            this.txtBreite.Size = new System.Drawing.Size(56, 20);
            this.txtBreite.TabIndex = 3;
            // 
            // labelBreite
            // 
            this.labelBreite.AutoSize = true;
            this.labelBreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreite.Location = new System.Drawing.Point(17, 76);
            this.labelBreite.Name = "labelBreite";
            this.labelBreite.Size = new System.Drawing.Size(55, 20);
            this.labelBreite.TabIndex = 2;
            this.labelBreite.Text = "Breite:";
            // 
            // txtLaenge
            // 
            this.txtLaenge.Location = new System.Drawing.Point(165, 34);
            this.txtLaenge.Name = "txtLaenge";
            this.txtLaenge.Size = new System.Drawing.Size(56, 20);
            this.txtLaenge.TabIndex = 1;
            // 
            // labelLaenge
            // 
            this.labelLaenge.AutoSize = true;
            this.labelLaenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaenge.Location = new System.Drawing.Point(17, 36);
            this.labelLaenge.Name = "labelLaenge";
            this.labelLaenge.Size = new System.Drawing.Size(58, 20);
            this.labelLaenge.TabIndex = 0;
            this.labelLaenge.Text = "Länge:";
            // 
            // tabSeite3
            // 
            this.tabSeite3.Controls.Add(this.webBrowser1);
            this.tabSeite3.Controls.Add(this.txtAdresszeile);
            this.tabSeite3.Location = new System.Drawing.Point(4, 22);
            this.tabSeite3.Name = "tabSeite3";
            this.tabSeite3.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeite3.Size = new System.Drawing.Size(720, 323);
            this.tabSeite3.TabIndex = 2;
            this.tabSeite3.Text = "Seite 3";
            this.tabSeite3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-4, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(707, 272);
            this.webBrowser1.TabIndex = 1;
            // 
            // txtAdresszeile
            // 
            this.txtAdresszeile.Location = new System.Drawing.Point(6, 7);
            this.txtAdresszeile.Name = "txtAdresszeile";
            this.txtAdresszeile.Size = new System.Drawing.Size(708, 20);
            this.txtAdresszeile.TabIndex = 0;
            this.txtAdresszeile.Text = "http://";
            this.txtAdresszeile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdresszeile_KeyDown);
            // 
            // tabAnzeige
            // 
            this.tabAnzeige.Controls.Add(this.btnOeffnenExtern);
            this.tabAnzeige.Controls.Add(this.btnDateiLesen);
            this.tabAnzeige.Controls.Add(this.listBoxDateiinhalt);
            this.tabAnzeige.Location = new System.Drawing.Point(4, 22);
            this.tabAnzeige.Name = "tabAnzeige";
            this.tabAnzeige.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnzeige.Size = new System.Drawing.Size(720, 323);
            this.tabAnzeige.TabIndex = 3;
            this.tabAnzeige.Text = "Anzeige Daten";
            this.tabAnzeige.UseVisualStyleBackColor = true;
            // 
            // btnOeffnenExtern
            // 
            this.btnOeffnenExtern.Location = new System.Drawing.Point(357, 191);
            this.btnOeffnenExtern.Name = "btnOeffnenExtern";
            this.btnOeffnenExtern.Size = new System.Drawing.Size(155, 39);
            this.btnOeffnenExtern.TabIndex = 2;
            this.btnOeffnenExtern.Text = "externes Programm öffnen";
            this.btnOeffnenExtern.UseVisualStyleBackColor = true;
            this.btnOeffnenExtern.Click += new System.EventHandler(this.btnOeffnenExtern_Click);
            // 
            // btnDateiLesen
            // 
            this.btnDateiLesen.Location = new System.Drawing.Point(48, 191);
            this.btnDateiLesen.Name = "btnDateiLesen";
            this.btnDateiLesen.Size = new System.Drawing.Size(169, 39);
            this.btnDateiLesen.TabIndex = 1;
            this.btnDateiLesen.Text = "Dateiinhalt anzeigen";
            this.btnDateiLesen.UseVisualStyleBackColor = true;
            this.btnDateiLesen.Click += new System.EventHandler(this.btnDateiLesen_Click);
            // 
            // listBoxDateiinhalt
            // 
            this.listBoxDateiinhalt.FormattingEnabled = true;
            this.listBoxDateiinhalt.Location = new System.Drawing.Point(16, 17);
            this.listBoxDateiinhalt.Name = "listBoxDateiinhalt";
            this.listBoxDateiinhalt.Size = new System.Drawing.Size(242, 121);
            this.listBoxDateiinhalt.TabIndex = 0;
            // 
            // tabDB
            // 
            this.tabDB.Controls.Add(this.btnAnzeigenTischeDB);
            this.tabDB.Controls.Add(this.dataGridView1);
            this.tabDB.Location = new System.Drawing.Point(4, 22);
            this.tabDB.Name = "tabDB";
            this.tabDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDB.Size = new System.Drawing.Size(720, 323);
            this.tabDB.TabIndex = 4;
            this.tabDB.Text = "Anzeige DB";
            this.tabDB.UseVisualStyleBackColor = true;
            // 
            // btnAnzeigenTischeDB
            // 
            this.btnAnzeigenTischeDB.Location = new System.Drawing.Point(25, 262);
            this.btnAnzeigenTischeDB.Name = "btnAnzeigenTischeDB";
            this.btnAnzeigenTischeDB.Size = new System.Drawing.Size(155, 36);
            this.btnAnzeigenTischeDB.TabIndex = 1;
            this.btnAnzeigenTischeDB.Text = "Anzeigen";
            this.btnAnzeigenTischeDB.UseVisualStyleBackColor = true;
            this.btnAnzeigenTischeDB.Click += new System.EventHandler(this.btnAnzeigenTischeDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkFormular
            // 
            this.chkFormular.AutoSize = true;
            this.chkFormular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormular.Location = new System.Drawing.Point(16, 393);
            this.chkFormular.Name = "chkFormular";
            this.chkFormular.Size = new System.Drawing.Size(180, 24);
            this.chkFormular.TabIndex = 1;
            this.chkFormular.Text = "Formular bearbeiten?";
            this.chkFormular.UseVisualStyleBackColor = true;
            this.chkFormular.CheckedChanged += new System.EventHandler(this.chkFormular_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 466);
            this.Controls.Add(this.chkFormular);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Möbelverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAllgemein.ResumeLayout(false);
            this.tabAllgemein.PerformLayout();
            this.tabFormularTische.ResumeLayout(false);
            this.tabFormularTische.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoehe)).EndInit();
            this.tabSeite3.ResumeLayout(false);
            this.tabSeite3.PerformLayout();
            this.tabAnzeige.ResumeLayout(false);
            this.tabDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAllgemein;
        private System.Windows.Forms.Button btnAendern;
        private System.Windows.Forms.Label labelHalloWelt;
        private System.Windows.Forms.TabPage tabFormularTische;
        private System.Windows.Forms.TabPage tabSeite3;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.Label labelAnzBeine;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtFarbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Label labelGewicht;
        private System.Windows.Forms.Label labelHoehe;
        private System.Windows.Forms.TextBox txtBreite;
        private System.Windows.Forms.Label labelBreite;
        private System.Windows.Forms.TextBox txtLaenge;
        private System.Windows.Forms.Label labelLaenge;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numHoehe;
        private System.Windows.Forms.CheckBox chkFormular;
        private System.Windows.Forms.RadioButton radSchwarz;
        private System.Windows.Forms.RadioButton radBlau;
        private System.Windows.Forms.RadioButton radRot;
        private System.Windows.Forms.Button btnFarbauswahl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtAdresszeile;
        private System.Windows.Forms.Button btnSpeichernDatei;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabAnzeige;
        private System.Windows.Forms.Button btnDateiLesen;
        private System.Windows.Forms.ListBox listBoxDateiinhalt;
        private System.Windows.Forms.Button btnOeffnenExtern;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.Button btnAnzeigenTischeDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpeichernDB;
    }
}

