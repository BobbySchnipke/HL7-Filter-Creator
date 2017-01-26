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
    public partial class FilterText : Form
    {
        // pull variables from InputForm
        string allowBlock = InputForm.allowBlock;
        string PV1 = InputForm.PV1;
        string resultType = InputForm.resultType;
        string fromFacility = InputForm.fromFacility;
        string MSH4_1;
        string MSH21_1;

        // create variables to hold parts of the finalFilterText
        string PV1Out;
        string resultTypeOut;
        string fromFacilityOut;
        string MSH4_1Out;
        string MSH21_1Out;

        // create variables for converting input to code
        string PV1Code;
        string resultTypeCode;
        string fromFacilityCode;

        // create a string to hold the constructed filter
        string finalFilterText;

        public FilterText()
        {
            InitializeComponent();
        }

        private void FilterText_Load(object sender, EventArgs e)
        {

            // create variables to hold parts of the filter string
            string equalNotEqual;

            // call the function to convert text to code
            ConvertTextToCode();

            //Begin conditions to build filter here
            if (allowBlock == "Block")
            {
                equalNotEqual = "!=";
            }
            else
            {
                equalNotEqual = "==";
            }

            if (PV1 == "")
            {
                PV1Out = "";
            }
            else
            {
                PV1Out = Environment.NewLine+"({HL7:PV1.2-1} = '" + PV1Code + "')" +Environment.NewLine+"and";
            }

            if (resultType == "")
            {
                resultTypeOut = "";
            }
            else
            {
                // only add a new line and "and" if pv1 and fromFacility aren't blank
                if (PV1 != "" && fromFacility != "")
                {
                    resultTypeOut = "({ HL7: MSH.21-1} " + equalNotEqual + " '" + resultTypeCode + "') " + Environment.NewLine + "and";
                }
                else
                {
                    resultTypeOut = "({ HL7: MSH.21-1} " + equalNotEqual + " '" + resultTypeCode + "') ";
                }
            }

            if (fromFacility == "")
            {
                fromFacilityOut = "";
            }
            else
            {
                fromFacilityOut = Environment.NewLine +"({ HL7: MSH.4-1} = '" + fromFacilityCode + "')";
            }

            // call the code to build the filter
            BuildFilter();

            // clear the textbox before writing to it
            filterTextBox.Clear();
            // write the final filter to the textbox
            filterTextBox.Text += finalFilterText;


        }

        private void ConvertTextToCode()
        {
            // first we will convert the PV1 text into HL7 code
            string PV1Switch = PV1;
            switch (PV1)
            {
                case "Inpatient":
                    PV1Code = "I";
                    break;
                case "Outpatient":
                    PV1Code = "O";
                    break;
                case "Preadmit":
                    PV1Code = "P";
                    break;
                case "Recurring patient":
                    PV1Code = "R";
                    break;
                case "Obstetrics":
                    PV1Code = "B";
                    break;
                case "Unknown":
                    PV1Code = "U";
                    break;
            }

            // Next we will convert the resultType text into HL7 code

            string resultTypeSwitch = resultType;
            switch (resultType)
            {
                case "ADTs":
                    resultTypeCode = "ADT";
                    break;
                case "LABs":
                    resultTypeCode = "LAB";
                    break;
                case "RADs":
                    resultTypeCode = "RAD";
                    break;
            }

            // Convert location into code

            string fromFacilitySwitch = fromFacility;
            switch(fromFacility)
            {
                case "All Locations":
                    fromFacilityCode = "";
                    break;
                case "Quest Diagnostics Labaratory":
                    fromFacilityCode = "QDS";
                    break;
                case "Mercy":
                    fromFacilityCode = "MHP";
                    break;
                case "Trihealth":
                    fromFacilityCode = "TRI";
                    break;
                case "Labcorps":
                    fromFacilityCode = "LCA";
                    break;
                case "Children's Hospital":
                    fromFacilityCode = "CHM";
                    break;
            }
        }
        private void BuildFilter()
        {
            finalFilterText = resultTypeOut + PV1Out + fromFacilityOut;
        }
    }
}
