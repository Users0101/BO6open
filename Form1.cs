using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Process.Start("https://discord.gg/mXu98DHrR2");
            comboBox1.Items.Add("> Fusils d'assaut");
            comboBox1.Items.Add("=> Mitraillette");
            comboBox1.Items.Add("==> Fusil à pompe");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();

            if (selectedItem == "> Fusils d'assaut")    // Ajoute tous les defi de tes arme Fusils d'assaut
            {
/////// tableau  1   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox1.Text = "XM4";// nom de ton arme ici
                checkBox2.Text = "défi 1 Special XM4";// défi 1 Special 
                checkBox3.Text = "défi 2 Special XM4"; // défi 2 Special 
 /////// tableau  2   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox2.Text = "AK-74"; // nom de ton arme ici
                checkBox13.Text = "défi 1 Special T2 ";  // défi 1 Special 
                checkBox12.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  3    ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox3.Text = "Nom de ton arme 3"; // nom de ton arme ici
                checkBox20.Text = "défi 1 Special T3";  // défi 1 Special 
                checkBox19.Text = "défi 2 Special"; // défi 2 Special  
  /////// tableau  4   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox4.Text = "Nom de ton arme 4"; // nom de ton arme ici
                checkBox27.Text = "défi 1 Special T4";  // défi 1 Special 
                checkBox26.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  5   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox5.Text = "Nom de ton arme 5"; // nom de ton arme ici
                checkBox34.Text = "défi 1 Special T5";  // défi 1 Special 
                checkBox33.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  6   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox6.Text = "Nom de ton arme 6"; // nom de ton arme ici
                checkBox41.Text = "défi 1 Special T6";  // défi 1 Special 
                checkBox40.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  7   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox7.Text = "Nom de ton arme 7"; // nom de ton arme ici
                checkBox48.Text = "défi 1 Special T7";  // défi 1 Special 
                checkBox47.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  8   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox8.Text = "Nom de ton arme 8"; // nom de ton arme ici
                checkBox55.Text = "défi 1 Special T8";  // défi 1 Special 
                checkBox54.Text = "défi 2 Special"; // défi 2 Special  
            }

            if (selectedItem == "=> Mitraillette")
            {
/////// tableau  1   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox1.Text = "C9";// nom de ton arme ici
                checkBox2.Text = "défi 1 Special C9";// défi 1 Special 
                checkBox3.Text = "défi 2 Special C9"; // défi 2 Special 
 /////// tableau  2   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox2.Text = "KSV"; // nom de ton arme ici
                checkBox13.Text = "défi 1 Special T2 ";  // défi 1 Special 
                checkBox12.Text = "défi 2 Special"; // défi 2 Special  
/////// tableau  3   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox3.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox20.Text = "défi 1 Special T3";  // défi 1 Special 
                checkBox19.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  4   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox4.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox27.Text = "défi 1 Special T4";  // défi 1 Special 
                checkBox26.Text = "défi 2 Special"; // défi 2 Special  
/////// tableau  5   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox5.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox34.Text = "défi 1 Special T5";  // défi 1 Special 
                checkBox33.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  6   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox6.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox41.Text = "défi 1 Special T6";  // défi 1 Special 
                checkBox40.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  7   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox7.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox48.Text = "défi 1 Special T7";  // défi 1 Special 
                checkBox47.Text = "défi 2 Special"; // défi 2 Special  
 /////// tableau  8   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox8.Text = "Nom de ton arme"; // nom de ton arme ici
                checkBox55.Text = "défi 1 Special T8";  // défi 1 Special 
                checkBox54.Text = "défi 2 Special"; // défi 2 Special  
            }
            if (selectedItem == "==> Fusil à pompe")
            {
/////// tableau  1   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox1.Text = "C9";// nom de ton arme ici
                checkBox2.Text = "défi 1 Special C9";// défi 1 Special 
                checkBox3.Text = "défi 2 Special C9"; // défi 2 Special 
                                                      /////// tableau  2   ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox2.Text = "KSV"; // nom de ton arme ici
                checkBox13.Text = "défi 1 Special T2 ";  // défi 1 Special 
                checkBox12.Text = "défi 2 Special"; // défi 2 Special  

                // tableau  3 // Cache ce qui serre a rien on cache le groupe vue que on a que 2 arme ->  Open source by lemelvin https://discord.gg/mXu98DHrR2
                groupBox3.Visible = false; 
/////// tableau  4
                groupBox4.Visible = false; 
 /////// tableau  5
                groupBox5.Visible = false;
 /////// tableau  6
                groupBox6.Visible = false;
/////// tableau  7
                groupBox7.Visible = false;
/////// tableau  8
                groupBox8.Visible = false;
            }
            else
            {

            }
        }
    }
}
