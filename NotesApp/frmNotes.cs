using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class frmNotes : Form
    {
        public frmNotes()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToLongDateString();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.MyValue = txtNote.Text;
            Properties.Settings.Default.Save();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            txtNote.Text = Properties.Settings.Default.MyValue;
        }

        public void ChangeMySelectionColor()
        {
            ColorDialog colorDialog1 = new ColorDialog();

            // Set the initial color of the dialog to the current text color.
            colorDialog1.Color = txtNote.SelectionColor;

            // Determine if the user clicked OK in the dialog and that the color has changed.
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != txtNote.SelectionColor)
            {
                // Change the selection color to the user specified color.
                txtNote.SelectionColor = colorDialog1.Color;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.RoyalBlue;
            //ChangeMySelectionColor();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.Crimson;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.MediumSeaGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.MediumOrchid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.LightSeaGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.DodgerBlue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.Tomato;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNote.SelectionColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeMySelectionColor();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(cbClassSelect.Text == "CIS3309")
            {
                richTextBox1.ForeColor = Color.RoyalBlue;
            }
        }
    }
}
