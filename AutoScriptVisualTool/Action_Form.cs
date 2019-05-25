using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool
{
    public partial class Action_Form : Form
    {
        private string[] vision = new string[]
        {
            "Light", "FadeIn", "FadeOut", "Camera", "Anima",
            "ShowText", "ChangeText", "ShowImage", "ShowImageFrom", "ChangeImage",
            "Broadcast",
        };

        public Action_Form()
        {
            InitializeComponent();
            this.AcceptButton = next_btn;
            this.CancelButton = cancel_btn;
        }

        private void action_cat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cat = ((ComboBox)sender).SelectedItem.ToString();

            action_name_cb.Items.Clear();
            if (cat == "視覺")
            {
                action_name_cb.Items.AddRange(vision);
            }
            action_name_cb.Enabled = true;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
