using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScriptVisualTool.ActionForms.Vision;

namespace AutoScriptVisualTool
{
    public partial class Action_Form : Form
    {
        public String actstr { get; set; } = String.Empty;

        String cat = String.Empty, cmd = String.Empty;
        BaseActionForm baseAF = null;

        private string[] vision = new string[]
        {
            "Light", "FadeIn", "FadeOut", "Camera", "Anima",
            "ShowText", "ChangeText", "ShowImage", "ShowImageFrom", "ChangeImage",
            "Broadcast",
        };

        private string[] mechanics = new string[]
        {
            "Rotate", "Scale", "Teleport", "AddForce", "Rigid",
        };

        private string[] create = new string[]
        {
            "Virtual", "Create", "NPC", "SpnParticle",
        };

        private string[] sound = new string[]
        {
            "PlaySound", "PSfrom", "ChBGM", "ChBGMfrom",
        };

        private string[] enemy = new string[]
        {
            "GenMonster",
        };

        private string[] str = new string[]
        {
            "DefineStr",
        };

        private string[] plot = new string[]
        {
            "Bind", "ShowButton", "ChangeButton", "ShowInput", "GetText",
            "Walk", "WalkForward", "WalkBackward", "WalkLeft", "WalkRight",
            "StopWalk", "Route", "PushTalk", "StartTalk", "Pause",
            "Restart", "Trigger", "Damage", "Menu", "OpenShop",
            "Shop", "AddItem", "AddEquip", "NextOne", "Alchemy",
            "Rename", "LoadScene",
        };

        private string[] logic = new string[]
        {
            "Call", "Execute", "GetSp", "Goto", "SetVar",
            "SetRandom", "Eval", "SetSp", "Stop", "Destroy",
            "Return", "Disable",
        };

        private string[] debug = new string[]
        {
            "Log", "Cast",
        };

        public Action_Form()
        {
            InitializeComponent();
            this.AcceptButton = next_btn;
            this.CancelButton = cancel_btn;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (baseAF != null)
            {
                this.actstr = baseAF.make_actstr();
                MessageBox.Show(actstr);
                //this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Action參數錯誤", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void action_cat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cat = ((ComboBox)sender).SelectedItem.ToString();

            action_name_cb.Items.Clear();
            if (cat == "視覺")
            {
                action_name_cb.Items.AddRange(vision);
            }
            else if (cat == "力學")
            {
                action_name_cb.Items.AddRange(mechanics);
            }
            else if (cat == "創造")
            {
                action_name_cb.Items.AddRange(create);
            }
            else if (cat == "音效")
            {
                action_name_cb.Items.AddRange(sound);
            }
            else if (cat == "與敵人相關")
            {
                action_name_cb.Items.AddRange(enemy);
            }
            else if (cat == "字串")
            {
                action_name_cb.Items.AddRange(str);
            }
            else if (cat == "劇情")
            {
                action_name_cb.Items.AddRange(plot);
            }
            else if (cat == "邏輯")
            {
                action_name_cb.Items.AddRange(logic);
            }
            else if (cat == "除錯")
            {
                action_name_cb.Items.AddRange(debug);
            }

            action_name_cb.Enabled = true;
            action_panel.Controls.Clear();
        }

        private void action_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            action_panel.Controls.Clear();
            baseAF = null;
            cmd = ((ComboBox)sender).SelectedItem.ToString();

            if (cat == "視覺")
            {
                if (cmd == "Light") baseAF = new Light_Form();
                else if (cmd == "FadeIn") baseAF = new Fade_Form(0);
                else if (cmd == "FadeOut") baseAF = new Fade_Form(1);
                else if (cmd == "Camera") baseAF = new Camera_Form();
                else if (cmd == "Anima") baseAF = new Anima_Form();
            }
            else if (cat == "力學")
            {
            }
            else if (cat == "創造")
            {
            }
            else if (cat == "音效")
            {
            }
            else if (cat == "與敵人相關")
            {
            }
            else if (cat == "字串")
            {
            }
            else if (cat == "劇情")
            {
            }
            else if (cat == "邏輯")
            {
            }
            else if (cat == "除錯")
            {
            }

            if(baseAF != null)
            {
                action_panel.Controls.Add(baseAF);
                baseAF.Show();
            }
        }
    }
}
