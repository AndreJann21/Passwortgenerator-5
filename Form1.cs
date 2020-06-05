using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwortgenerator5_WF
{
    public partial class Form1 : Form
    {
        Output_Safe_Password t;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_outputPswd_Click(object sender, EventArgs e)
        {

            
            if (String.IsNullOrWhiteSpace(txtb_clttsInput.Text))
                txtb_clttsInput.Text = "0";
            if (String.IsNullOrEmpty(txtb_llettersInput.Text))
                txtb_llettersInput.Text = "0";
            if (String.IsNullOrEmpty(txtb_specialInput.Text))
                txtb_specialInput.Text = "0";
            if (String.IsNullOrEmpty(txtb_digitsInput.Text))
                txtb_digitsInput.Text = "0";

            //Falls man das (in die Zwischenablage) Kopierte hier nochmal als Input verwenden will und es kein reiner 'int' ist:
            int i, o, l, m;
            if (!int.TryParse(txtb_clttsInput.Text, out i))
            {
                txtb_clttsInput.ForeColor = Color.Red;
                txtb_clttsInput.Text = "error";
            }
            if (!int.TryParse(txtb_llettersInput.Text, out o))
            {
                txtb_llettersInput.ForeColor = Color.Red;
                txtb_llettersInput.Text = "error";
            }
            if (!int.TryParse(txtb_specialInput.Text, out l))
            {
                txtb_specialInput.ForeColor = Color.Red;
                txtb_specialInput.Text = "error";
            }
            if (!int.TryParse(txtb_digitsInput.Text, out m))
            {
                txtb_digitsInput.ForeColor = Color.Red;
                txtb_digitsInput.Text = "error";
            }
            if (int.TryParse(txtb_clttsInput.Text, out i) && int.TryParse(txtb_llettersInput.Text, out o) && int.TryParse(txtb_specialInput.Text, out l) && int.TryParse(txtb_digitsInput.Text, out m))
            {
                t = new Output_Safe_Password(txtb_clttsInput.Text, txtb_llettersInput.Text, txtb_specialInput.Text, txtb_digitsInput.Text);
                t.Show();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//Protection against wrong typed userinput
            txtb_clttsInput.ForeColor = Color.Black; txtb_llettersInput.ForeColor = Color.Black; txtb_specialInput.ForeColor = Color.Black; txtb_digitsInput.ForeColor = Color.Black;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cb_quickpassword_CheckedChanged(object sender, EventArgs e)
        {
            //txtb_clttsInput.Text = "0"; txtb_llettersInput.Text = "0"; txtb_specialInput.Text = "0"; txtb_digitsInput.Text = "0";
            txtb_clttsInput.ReadOnly = true; txtb_llettersInput.ReadOnly = true; txtb_specialInput.ReadOnly = true; txtb_digitsInput.ReadOnly = true;
            //Test mit unterschiedlichen Zufallszahlen 1 - 10 So kann es nie den Zufall geben, dass überall '0' steht, währe ja sonst theoretisch möglich

            //Legt den Zahlenbereich fest, aus dem die 
            //Zufallszahlen gewählt werden sollen
            int kleinsteZahl = 1;
            int größteZahle = 10;

            //Legt fest wie viele Zufallszahlen generiert werden sollen
            int zufallszahlen = 4;

            //Wir legen eine Liste an, aus denen
            //die Zufallszahlen gewählt werden sollen
            List<int> auswahlZahlen = new List<int>();
            for (int i = kleinsteZahl; i <= größteZahle; i++)
                auswahlZahlen.Add(i);

            //Wir legen eine Liste an, die unsere Ergebnisse 
            //beinhalten soll
            List<int> ergebnisse = new List<int>();

            //Wir initialisieren den Zufallsgenerator
            Random rand = new Random();

            //Die Schleife ermittelt in jedem Durchlauf eine Zufallszahl
            for(int i = 0; i < zufallszahlen; i++)
            {
                //Es wird eine Zufallszahl generiert
                int zZahl = rand.Next(1, auswahlZahlen.Count) - 1;

                //Die generierte Zufallszahldient als Index für die Liste
                //mit den Zahlen aus denen wir wählen
                ergebnisse.Add(auswahlZahlen[zZahl]);

                //Die gewählte eindeutige Zufallszahl wird aus der 
                //auswahlZahlen List entfernt
                auswahlZahlen.RemoveAt(zZahl);
            }
            string myString = ergebnisse[0].ToString(); txtb_clttsInput.Text = myString; string myString1 = ergebnisse[1].ToString(); txtb_llettersInput.Text = myString1; string myString2 = ergebnisse[2].ToString(); txtb_specialInput.Text = myString2;
            string myString3 = ergebnisse[3].ToString(); txtb_digitsInput.Text = myString3;
            // string myString = future[1].ToString(); txtb_clttsInput.Text = myString;
            if (!cb_quickpassword.Checked)
            {
                txtb_clttsInput.Text = "\0"; txtb_llettersInput.Text = "\0"; txtb_specialInput.Text = "\0"; txtb_digitsInput.Text = "\0";
                txtb_clttsInput.ReadOnly = false; txtb_llettersInput.ReadOnly = false; txtb_specialInput.ReadOnly = false; txtb_digitsInput.ReadOnly = false;
            }
        }
    }
    //Funktioniert irgendwie nicht:
    public class NumTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
