using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Results_Filter_Creator
{
    public partial class InputForm : Form
    {
        public static string allowBlock;
        public static string PV1;
        public static string resultType;
        public static string fromFacility;

        public InputForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateFilterButton_Click(object sender, EventArgs e)
        {
            //move text from Fields into variables
            allowBlock = AllowBlockComboBox.Text;
            PV1 = PV1ComboBox.Text;
            resultType = ResultTypeComboBox.Text;
            fromFacility = LocationComboBox.Text;

            FilterText FilterText = new FilterText();
            //hide the current StartScreen form, but do not close it
            this.Hide();

            //display the FilterText form
            FilterText.ShowDialog();

            //close the InputForm when GamePlayForm is exited so the entire program is terminated
            this.Close();
        }
    }
}
