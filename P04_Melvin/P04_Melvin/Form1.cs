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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P04_Melvin
{
    public partial class PlayerNamed : Form
    {

        public PlayerNamed()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText("PlayerNamed.txt");
            streamWriter.WriteLine("Bobert");
            streamWriter.WriteLine("Smelly");
            streamWriter.WriteLine("Baby");
            streamWriter.WriteLine("Stink");
            streamWriter.Close();
            StreamReader streamReader1;
            streamReader1 = File.OpenText("PlayerNamed.txt");
            while (!streamReader1.EndOfStream)
                {
                    cmbBoxPlayers.Items.Add(streamReader1.ReadLine());
                }
            streamReader1.Close();
        }

        //Add
        private void btnFirstAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxFirst.Items.Add(cmbBoxPlayers.SelectedItem);
                cmbBoxPlayers.Items.Remove(cmbBoxPlayers.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // if (SelectedIndex.)
        }
        private void btnSecondAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxSecond.Items.Add(cmbBoxPlayers.SelectedItem);
                cmbBoxPlayers.Items.Remove(cmbBoxPlayers.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Remove
        private void btnFirstRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxFirst.Items.Remove(lstBoxFirst.SelectedItem);// Why doens't this work???
                //cmbBoxPlayers.Items.Add(cmbBoxPlayers); this too
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSecondRemove_Click(object sender, EventArgs e)
        {
            try 
            {
                lstBoxSecond.Items.Remove(lstBoxSecond.SelectedItem);// Why doens't this work???
                //cmbBoxPlayers.Items.Add(lstBoxSecond.SelectedItem); Doesn't work
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}
        //comboBox
        private void cmbBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmbBoxPlayers.Items.Add(cmbBoxPlayers.SelectedItem); ///Help
        }


        private void cmbBoxPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbBoxPlayers.Items.Add(cmbBoxPlayers.Text);//
            }
        }
        //Restart
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();  /////??????????
        }
    }
}

