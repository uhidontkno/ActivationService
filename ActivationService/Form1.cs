using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ActivationService
{
    public partial class Form1 : Form
    {
        public static string VersionID = "1.0.0";
        public static string settingsPath = "";
        public static string path = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
        }


        private static Random random = new Random();

        private Boolean findString(String baseString, String strinfToFind, String separator)
        {
            foreach (String str in baseString.Split(separator.ToCharArray()))
            {
                if (str.Equals(strinfToFind))
                {
                    return true;
                }
            }
            return false;
        }

        public static string RandomString(int length)
        {
               const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private void GenerateConfig() {


            settingsPath = $@"{path}\properties.env";
            File.Create(settingsPath).Close();
            using (StreamWriter writer = new StreamWriter($@"{path}\properties.env", true))
            {
                writer.WriteLine($"version = {VersionID}");
                writer.WriteLine($"---- KEYS ----");
                writer.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!File.Exists($@"{path}\properties.env"))
            {

                DialogResult choice = MessageBox.Show("You don't have a Properties file. Do you want to create one?", "Hey!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choice == DialogResult.Yes)
                {

                    GenerateConfig();
                    

                }
                else { Application.Exit(); }

            }
            else { settingsPath = $@"{path}\properties.env"; }
            if (File.ReadAllText(settingsPath).Length == 0)
            {
                File.Delete($@"{path}\properties.env");
                GenerateConfig();
            }

            if (!File.ReadAllText(settingsPath).Contains(VersionID)) 
            {

                DialogResult choice = MessageBox.Show("Your config doesn't match this version's config!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Delete($@"{path}\properties.env");
                GenerateConfig();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            submitKey.Enabled = false;
            button1.Enabled = false;
            //TextWriter tsw = new StreamWriter($@"{path}\properties.env", true);
            int num = (int)keyNum.Value;



          //  $"{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(5)}"
            using (StreamWriter sw = File.AppendText($@"{path}\properties.env"))
            {
                for (int i = 0; i < num; i++)
                {

                    sw.WriteLine($"{RandomString(2)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}");
                  //  MessageBox.Show("a");
                }
                

            }

            MessageBox.Show("Operation completed.");

            button2.Enabled = true;
            submitKey.Enabled = true;
            button1.Enabled = true;
        }

        private void submitKey_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            submitKey.Enabled = false;
            button1.Enabled = false;
            var keys = File.ReadAllText(settingsPath);
            keys = keys.Replace($"version = {VersionID}",null);
            keys = keys.Replace($"---- KEYS ----", null);
            if (findString(keys,key.Text,"")) { MessageBox.Show("Valid!"); } else { MessageBox.Show("Not Valid"); }
            button2.Enabled = true;
            submitKey.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            submitKey.Enabled = false;
            button1.Enabled = false;
            File.Delete(settingsPath);
            GenerateConfig();
            button2.Enabled = true;
            submitKey.Enabled = true;
            button1.Enabled = true;
        }
    }
}
