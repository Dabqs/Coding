using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSONParser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region UI events    
        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }
        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebug.Text = string.Empty;
        }
        #endregion

        #region Debug output
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebug.Text = txtDebug.Text + strDebugText + Environment.NewLine;
                txtDebug.SelectionStart = txtDebug.TextLength;
                txtDebug.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            }
        }

        #endregion
        #region json functions
        private void deserialiseJSON(string strJSON)
        {
            try
            {
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                var jPerson = JsonConvert.DeserializeObject<JsonPersonArray>(strJSON);

                debugOutput("Here's our JSON object : " + jPerson);
                debugOutput("First name is: " + jPerson.firstname);
                debugOutput("The street address is: " + jPerson.address.streetAddress);
                debugOutput("Attempting to print phone numbers: ");
                foreach (var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + "- " + num.number.ToString());
                }

                /*
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                debugOutput("Here's our JSON object : " + jPerson);
                debugOutput("First name is: " + jPerson.firstname);
                debugOutput("The street address is: " + jPerson.address.streetAddress);
                //*/
            }
            catch (Exception ex)
            {

                debugOutput("We had a problem: " + ex.Message);
            }
        }
        #endregion

    }
}
