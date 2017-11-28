using BBW.Moebelverwaltung;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsMoebelverwaltung
{
    // partielle Klassen verwendet,
    // um den Quellcode einer Klasse in mehrere Dateien aufzuteilen
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ausgeführt, wenn auf den Button geklickt wird
        private void btnAendern_Click(object sender, EventArgs e)
        {
            // geprüft, ob Eigenschaft Text des Labels "Hallo Welt" ist
            if (labelHalloWelt.Text == "Hallo Welt")
                labelHalloWelt.Text = "Guten Tag";
            else
                labelHalloWelt.Text = "Hallo Welt";

        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            string laenge = txtLaenge.Text;
            string breite = txtBreite.Text;
            // txtHoehe ist vom Typ NumericUpDown
            // Eigenschaft Value gibt ein decimal zurück
            string hoehe = numHoehe.Value.ToString();
            string anzahl = txtAnzahl.Text;
            string gewicht = txtGewicht.Text;
            string farbe = txtFarbe.Text;
            // ausgewählten Wert aus der ComboBox in String umwandeln 
            string material = cmbMaterial.SelectedItem.ToString();
            string text = string.Format("Tisch: {0} cm x {1} cm x {2} cm"
                                     ,laenge, breite, hoehe);
            text += " Farbe: "+farbe + " Material: " + material;

            MessageBox.Show(text);
        }
        // ausgeführt, bevor Formular angezeigt wird
        private void Form1_Load(object sender, EventArgs e)
        {
            Material m = Material.Holz;
            // Enum.GetNames() liefert alle Enum-Konstanten als string[] zurück
            // GetNames() muss ein Type - Objekt übergeben werden
            // GetType() ist eine Objektmethode
            // -> muss für ein Objekt aufgerufen werden
            foreach (var item in Enum.GetNames(m.GetType()))
            {
                // ComboBox hat Eigenschaft Items,
                // der mittels Add() die Elemente hinzugefügt werden
                cmbMaterial.Items.Add(item);
            }
            cmbMaterial.Text = "Bitte auswählen";
            radSchwarz.Checked = true;
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMaterial.Text = "Bitte auswählen";
            txtAnzahl.Text = "";
            txtBreite.Text = "";
            txtFarbe.Text = "";
            txtGewicht.Text = "";
            // setzt den Wert auf den Standardwert zurück
            //numHoehe.ResetText();
            numHoehe.Value = 20;
            txtLaenge.Text = "";
        }
        // Ereignis wird ausgeführt,
        // wenn eine andere Registerseite geöffnet werden soll
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // wenn Haken gesetzt ist und
            // Register "Formular Tische" ausgewählt ist,
            // soll Formular angezeigt werden
            if (chkFormular.Checked
                && tabControl1.SelectedTab == tabFormularTische)
                // Anzeige des Formulars 
                tabControl1.SelectedTab = tabFormularTische;
            // wenn Haken nicht gesetzt ist und ich Formular öffen will
            else if(!(chkFormular.Checked) &&
                    tabControl1.SelectedTab == tabFormularTische)
            {
                MessageBox.Show("Keine Rechte zum Anzeigen");
                // Weiterleitung an Seite 3
                tabControl1.SelectedTab = tabSeite3;
            }

        }

        private void chkFormular_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkFormular.Checked 
                && tabControl1.SelectedTab == tabFormularTische)
            {
                //cmbMaterial.Text = "Bitte auswählen";
                //txtAnzahl.Text = "";
                //txtBreite.Text = "";
                //txtFarbe.Text = "";
                //txtGewicht.Text = "";
                //numHoehe.Value = 20;
                //txtLaenge.Text = "";
                // Weiterleitung an Allgemeines
                tabControl1.SelectedTab = tabAllgemein;
            }
        }

        private void radRot_CheckedChanged(object sender, EventArgs e)
        {
            if(radRot.Checked)
            {
                // Auflistung Controls enthält alle Steuerelemente
                // des Tabs tabFormularTische
                foreach (var item in tabFormularTische.Controls)
                {
                    if(item is Label)
                    {
                        (item as Label).ForeColor = Color.Red;
                    }
                    else if(item is TextBox)
                    {
                        (item as TextBox).ForeColor = Color.Red;
                    }
                    else if(item is NumericUpDown)
                    {
                        (item as NumericUpDown).ForeColor = Color.Red;
                    }
                }
            }
        }

        private void radBlau_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlau.Checked)
            {
                // Auflistung Controls enthält alle Steuerelemente
                // des Tabs tabFormularTische
                foreach (var item in tabFormularTische.Controls)
                {
                    if (item is Label)
                    {
                        (item as Label).ForeColor = Color.Blue;
                    }
                    else if (item is TextBox)
                    {
                        (item as TextBox).ForeColor = Color.Blue;
                    }
                    else if (item is NumericUpDown)
                    {
                        (item as NumericUpDown).ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void radSchwarz_CheckedChanged(object sender, EventArgs e)
        {
            if (radSchwarz.Checked)
            {
                // Auflistung Controls enthält alle Steuerelemente
                // des Tabs tabFormularTische
                foreach (var item in tabFormularTische.Controls)
                {
                    if (item is Label)
                    {
                        (item as Label).ForeColor = Color.Black;
                    }
                    else if (item is TextBox)
                    {
                        (item as TextBox).ForeColor = Color.Black;
                    }
                    else if (item is NumericUpDown)
                    {
                        (item as NumericUpDown).ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnFarbauswahl_Click(object sender, EventArgs e)
        {
            // legt fest, ob benutzerdefinierte Farben erstellt werden können
            colorDialog1.AllowFullOpen = true;
            // legt vorausgewählte Farbe fest
            // Hintergrundfarbe des Tabs
            colorDialog1.Color = tabFormularTische.BackColor;
            // prüft, ob Schaltfläche "OK" geklickt wurde
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Hintergrundfarbe für das Tab setzen
                tabFormularTische.BackColor = colorDialog1.Color;
            }
        }

        private void txtFarbe_Leave(object sender, EventArgs e)
        {
            // Farbnamen werden kleingschrieben 
            // und dürfen nur Buchstaben enthalten
            // mind. 3 Buchstaben
            // Prüfung mittels regulären Ausdrücken
            // {min,max}, {min,}, {,max},{genaue Anzahl}
            string muster = "\\b[a-zäöüß]{3,}\\b";
            // Regex - Objekt benötigt, das mit dem regulären
            // Ausdruck initialisiert wird
            Regex ausdruck = new Regex(muster);

            if (ausdruck.IsMatch(txtFarbe.Text))
                MessageBox.Show("passt");
            else
            {
                MessageBox.Show("Farbnamen müssen kleingeschrieben werden und dürfen keine Zahlen enthalten");
                txtFarbe.Text = "";
            }
        }
        // ausgeführt, wenn eine Taste gedrückt wird
        private void txtFarbe_KeyDown(object sender, KeyEventArgs e)
        {
            // geprüft, ob Enter - Taste gedrückt wurde
            if (e.KeyCode == Keys.Enter)
            {
                string muster = "\\b[a-zäöüß]{3,}\\b";
                // Regex - Objekt benötigt, das mit dem regulären
                // Ausdruck initialisiert wird
                Regex ausdruck = new Regex(muster);

                if (ausdruck.IsMatch(txtFarbe.Text))
                    MessageBox.Show("passt");
                else
                {
                    MessageBox.Show("Farbnamen müssen kleingeschrieben werden und dürfen keine Zahlen enthalten");
                    txtFarbe.Text = "";
                }
            }
        }

        private void txtAdresszeile_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // zuweisen der Webadresse an den Browser
                webBrowser1.Url = new Uri(txtAdresszeile.Text);
            }
        }

        private void btnSpeichernDatei_Click(object sender, EventArgs e)
        {
            string laenge = txtLaenge.Text;
            string breite = txtBreite.Text;
            string hoehe = numHoehe.Value.ToString();
            string anzahl = txtAnzahl.Text;
            string gewicht = txtGewicht.Text;
            string farbe;
            if (txtFarbe.Text.Contains(" "))
            {
                // gibt die Teilzeichenkette bis zum 1. Leerzeichen zurück
                farbe = txtFarbe.Text.Substring
                               (0, txtFarbe.Text.IndexOf(" "));
            }
            else
                farbe = txtFarbe.Text;


            string material = cmbMaterial.SelectedItem.ToString();

            // StringBuilder ist eine veränderliche Zeichenkette
            StringBuilder sb = new StringBuilder();
            sb.Append(laenge);
            sb.Append(";");
            sb.Append(breite);
            sb.Append(";");
            sb.Append(hoehe);
            sb.Append(";");
            sb.Append(anzahl);
            sb.Append(";");
            sb.Append(gewicht);
            sb.Append(";");
            sb.Append(farbe);
            sb.Append(";");
            sb.Append(material);
            // legt das Startverzeichnis fest,
            // ist es nicht vorhanden, wird ein Standardverzeichnis angezeigt
            saveFileDialog1.InitialDirectory = "C:\\Users\\Fachinformatiker BBW\\Documents";
            // filtert die Auswahl von Dateitypen
            // Syntax: "Anzeige für Benutzer(z.B. CSV-Dateien (*.csv))|*.Dateiendung"
            saveFileDialog1.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw=null;
                // alle Anweisungen, die Fehler verursachen könnten,
                // werden in den try - Block geschrieben
                try
                {
                    // Dateipfad in einer Variablen speichern
                    string pfad = saveFileDialog1.FileName;
                    // erzeugt ein StreamWriter - Objekt
                    // 2. Parameter gibt an, 
                    // ob an Datei angehangen werden soll
                    // ist Datei nicht vorhanden,
                    // wird diese angelegt
                    sw = new StreamWriter(pfad, true);
                    // schreiben des StringBuilder - Objekts in die Datei
                    sw.WriteLine(sb.ToString());
                }
                // catch - Blöcke behandeln Fehler
                // catch - Blöcke von der spezifischsten zur
                // allgemeinsten Exception ordnen 
                catch(IOException ex)
                {
                    MessageBox.Show("Fehler bei Arbeit mit Dateien: "+ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("allgemeiner Fehler: "+ex.Message);
                }
                // wird immer ausgeführt,
                // auch wenn eine Exception ausgelöst wird
                finally
                {
                    // geprüft, ob StreamWriter ungleich null ist
                    if (sw != null)
                        // Schließen des StreamWriter - Objekts
                        sw.Close();
                }
            }
        }

        private void btnDateiLesen_Click(object sender, EventArgs e)
        {
            // leeren der ListBox
            listBoxDateiinhalt.Items.Clear();
            // Erzeugung eines OpenFileDialog - Objekts
            OpenFileDialog dateiOeffnen = new OpenFileDialog();
            dateiOeffnen.InitialDirectory = "C:\\Users\\Fachinformatiker BBW\\Documents";
            // filtert die Auswahl von Dateitypen
            dateiOeffnen.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";

            StreamReader sr = null;
            string inhalt;

            if (dateiOeffnen.ShowDialog() == DialogResult.OK)
            {
                string dateiname = dateiOeffnen.FileName;
                // prüfen, ob es sich um Textdateien, CSV-Dateien handelt
                if(dateiname.EndsWith(".txt") || dateiname.EndsWith(".csv"))
                {
                    try
                    {
                        // Erzeugung des StreamReader - Objekts
                        sr = new StreamReader(dateiname);
                        if(sr != null)
                        {
                            while ((inhalt = sr.ReadLine()) != null)
                            {
                                listBoxDateiinhalt.Items.Add(inhalt);   
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex.Message);
                    }
                    finally
                    {
                        if(sr != null)
                            sr.Close();
                    }

                }
            }
        }

        private void btnOeffnenExtern_Click(object sender, EventArgs e)
        {
            OpenFileDialog dateiOeffnen = new OpenFileDialog();
            dateiOeffnen.InitialDirectory = "C:\\Users\\Fachinformatiker BBW\\Documents";
            // filtert die Auswahl von Dateitypen
            dateiOeffnen.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (dateiOeffnen.ShowDialog() == DialogResult.OK)
            {
                // Starten des externen Programms
                // automatisch Standardprogramm verwendet
                System.Diagnostics.Process.Start(dateiOeffnen.FileName);
            }
        }

        private void btnAnzeigenTischeDB_Click(object sender, EventArgs e)
        {
            // benötigt, um sich mit der MySQL - DB zu verbinden
            MySqlConnection conn = null;
            // dient als Brücke zwischen DataSet und Datenbank
            MySqlDataAdapter da = null;
            // dient als Quelle z.B. für das DataGridView
            DataSet ds = null;
            // ConnectionString für Verbindung zur DB benötigt
            string connection = "Database=moebelverwaltung;Data Source=localhost; User Id = root";
            try
            {
                // 1. Erzeugung des Connection - Objekts
                conn = new MySqlConnection(connection);
                // 2. SQL - Befehl definieren
                string sql = "SELECT * FROM Tische";
                // 3. Erzeugung des DataAdapter - Objekts
                da = new MySqlDataAdapter(sql, conn);
                // 4. Erzeugung des DataSet - Objekts
                ds = new DataSet();
                // 5. Füllen des DataSet - Objekts
                // Syntax: da.Fill(DataSet,Aliasname_der_Tabelle)
                da.Fill(ds, "Tische");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fehler bei Zugriff auf die DB: "+ex.Message);
            }
            finally
            {
                if (conn != null)
                    // 6. Schließen der DB - Verbindung
                    conn.Close();
            }
            // 7. DataGridView mit DataSet verknüpfen
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tische"; 
        }

        private void btnSpeichernDB_Click(object sender, EventArgs e)
        {
            // Auslesen der Textfelder
            string laenge = txtLaenge.Text;
            string breite = txtBreite.Text;
            string hoehe = numHoehe.Value.ToString();
            string anzahl = txtAnzahl.Text;
            string gewicht = txtGewicht.Text;
            string farbe;
            if (txtFarbe.Text.Contains(" "))
            {
                // gibt die Teilzeichenkette bis zum 1. Leerzeichen zurück
                farbe = txtFarbe.Text.Substring
                               (0, txtFarbe.Text.IndexOf(" "));
            }
            else
                farbe = txtFarbe.Text;
            
            string material = cmbMaterial.SelectedItem.ToString();

            // Zusammensetzen des SQL - Befehls
            string sql = "INSERT INTO tische (Laenge, Breite, Hoehe, AnzahlTischbeine, Gewicht, Farbe,Material)";
            sql += "VALUES ('"
                    + laenge + ","
                    + breite + ","
                    + hoehe + ","
                    + anzahl + ","
                    + gewicht + ", '"
                    + farbe + "', '"
                    + material + "');";

            MySqlConnection conn = new MySqlConnection("Database = moebelverwaltung; Data Source = localhost; User Id = root");
            // Command - Objekt benötigt, um SQL - Befehl auszuführen
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // Öffnen der Verbindung
                conn.Open();
                // Ausführen der INSERT INTO - Anweisung
                // INSERT, DELETE, UPDATE sind keine Abfragen
                // -> ExecuteNonQuery()
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }


        //private void labelHalloWelt_Click(object sender, EventArgs e)
        //{

        //}
    }
}
