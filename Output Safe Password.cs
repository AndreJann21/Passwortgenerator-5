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
    public partial class Output_Safe_Password : Form
    {
        string upperCase1, lowerCase1, specialChars1, digits1;
        int upperCase2, lowerCase2, specialChars2, digits2;

        private void btn_copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txt_input1.Text, true);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt_input1.Text, "Show whole password");
        }
        Form1 a;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_input1.PasswordChar = '\0';
                txtb_fys.PasswordChar = '\0';
            }
            else
            {
                txt_input1.PasswordChar = '*';
                txtb_fys.PasswordChar = '*';
            }
        }
        
        public Output_Safe_Password(string upperCase, string lowerCase, string specialChars, string digits)
        {
            upperCase1 = upperCase; lowerCase1 = lowerCase; specialChars1 = specialChars; digits1 = digits; 
            //Umwandlung von string in Int & Abfangen, falls was falsches hineinkopiert wurde
            int.TryParse(upperCase1, out upperCase2); lowerCase2 = int.Parse(lowerCase1); int.TryParse(digits1, out digits2); int.TryParse(specialChars1, out specialChars2);
            
            InitializeComponent();
        }

        private void Output_Safe_Password_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            string B = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string b = "abcdefghijklmnopqrstuvwxyz";
            string c = "0123456789";
            string sc = "^!\"§$%&/()=?²³{[]}\\`´+*~#',.-;:_<>|";
            string random = "";
            for (int i1 = 0; i1 < upperCase2; i1++)
            {
                int a2 = ran.Next(B.Length);
                random = random + B.ElementAt(a2);
            }
            for (int i = 0; i < lowerCase2; i++)
            {
                int a = ran.Next(b.Length);
                random = random + b.ElementAt(a);
            }
            for (int j = 0; j < specialChars2; j++)
            {
                int sz = ran.Next(sc.Length);
                random = random + sc.ElementAt(sz);
            }
            for (int i = 0; i < digits2; i++)
            {
                int a1 = ran.Next(c.Length);
                random = random + c.ElementAt(a1);
            }
            string rand = new string(random.ToCharArray().OrderBy(s => (ran.Next(2) % 2) == 0).ToArray());
            txt_input1.Text = rand;
            
            //Fisher-Yates-Shuffle
            Random rnd = new Random();
            string output = "";
            int arraysize = rand.Length;
            int[] randomArray = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            {
                randomArray[i] = i;
            }
            arraysize = randomArray.Length;
            int random1;
            int temp;

            for (int i = 0; i < arraysize; i++)
            {
                random1 = i + (int)(rnd.NextDouble() * (arraysize - i));
                temp = randomArray[random1];
                randomArray[random1] = randomArray[i];
                randomArray[i] = temp;
            }
            for (int i = 0; i < arraysize; i++)
            {
                output += rand[randomArray[i]];
            }
            txtb_fys.Text =  output;


           // Idee (lock password): Länge des Passworts abfragen und Länge mal (*) in die Textbox
           // Idee (unlock password): 'rand' ausgeben

           // Idee (see whole password): Öffnet ein neues Fenster mit einem 
           // Idee 2 (copy password): Ein Button, wo man das Passwort speichern kann
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
