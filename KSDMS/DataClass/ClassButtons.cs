using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace KSDMS.DataClass
{
    class ClassButtons
    {
        public void Fn_Buttons(string ST, Panel PN)
        {
            Boolean Add = true;
            Boolean Edit = true;
            Boolean Save = true;
            Boolean Delete = true;
            Boolean View = true;
            Boolean Cancel = true;
            Boolean Print = true;

            if (ST == "A")
            {
                Add = false;
                Edit = false;
                Save = true;
                Delete = false;
                View = false;
                Cancel = true;
                Print = false;
            }

            if (ST == "S")
            {
                Add = true;
                Edit = false;
                Save = false;
                Delete = false;
                View = true;
                Cancel = true;
                Print = false;
            }

            if (ST == "E")
            {
                Add = false;
                Edit = false;
                Save = true;
                Delete = true;
                View = false;
                Cancel = true;
                Print = false;
            }

            if (ST == "D")
            {
                Add = true;
                Edit = false;
                Save = false;
                Delete = false;
                View = true;
                Cancel = true;
                Print = false;
            }

            if (ST == "V")
            {
                Add = false;
                Edit = true;
                Save = false;
                Delete = false;
                View = true;
                Cancel = true;
                Print = true;
            }

            if (ST == "C")
            {
                Add = true;
                Edit = false;
                Save = false;
                Delete = false;
                View = true;
                Cancel = true;
                Print = false;
            }
            List<Control> cleanControls = new List<Control>();
            foreach (Control ctr in PN.Controls)
            {
                if (ctr.Name.StartsWith("BtnAdd")) 
                { 
                    ctr.Enabled = Add;
                }
                if (ctr.Name.StartsWith("BtnEdit")) 
                { ctr.Enabled = Edit; 
                }
                if (ctr.Name.StartsWith("BtnSave")) { ctr.Enabled = Save; }
                if (ctr.Name.StartsWith("BtnDelete")) { ctr.Enabled = Delete; }
                if (ctr.Name.StartsWith("BtnView")) { ctr.Enabled = View; }
                if (ctr.Name.StartsWith("BtnCancel")) { ctr.Enabled = Cancel; }
                if (ctr.Name.StartsWith("BtnPrint")) { ctr.Enabled = Print; }

            }

        }

    }
}
