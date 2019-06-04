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
using AutoScriptVisualTool.ActionForms.Mechanics;
using AutoScriptVisualTool.ActionForms.Create;
using AutoScriptVisualTool.ActionForms.Sound;
using AutoScriptVisualTool.ActionForms.Enemy;
using AutoScriptVisualTool.ActionForms.Str;
using AutoScriptVisualTool.ActionForms.Plot;

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
            "Virtual", "Create", "NPC", "ChangeNPC", "SpnParticle",
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
                else if (cmd == "ShowText") baseAF = new Text_Form(0);
                else if (cmd == "ChangeText") baseAF = new Text_Form(1);
                else if (cmd == "ShowImage") baseAF = new ShowImage_Form(false);
                else if (cmd == "ShowImageFrom") baseAF = new ShowImage_Form(true);
                else if (cmd == "ChangeImage") baseAF = new ChangeImage_Form();
                else if (cmd == "Broadcast") baseAF = new Broadcast_Form();
            }
            else if (cat == "力學")
            {
                if (cmd == "Rotate") baseAF = new RSTAR_Form(0);
                else if (cmd == "Scale") baseAF = new RSTAR_Form(1);
                else if (cmd == "Teleport") baseAF = new RSTAR_Form(2);
                else if (cmd == "AddForce") baseAF = new RSTAR_Form(3);
                else if (cmd == "Rigid") baseAF = new RSTAR_Form(4);
            }
            else if (cat == "創造")
            {
                if (cmd == "Virtual") baseAF = new Virtual_Form();
                else if (cmd == "Create") baseAF = new Create_Form(0);
                else if (cmd == "NPC") baseAF = new Create_Form(1);
                else if (cmd == "ChangeNPC") baseAF = new ChangeNPC_Form();
                else if (cmd == "SpnParticle") baseAF = new Particle_Form();
            }
            else if (cat == "音效")
            {
                if (cmd == "PlaySound") baseAF = new Music_Form(0);
                else if (cmd == "PSfrom") baseAF = new Music_Form(1);
                else if (cmd == "ChBGM") baseAF = new Music_Form(2);
                else if (cmd == "ChBGMfrom") baseAF = new Music_Form(3);
            }
            else if (cat == "與敵人相關")
            {
                if (cmd == "GenMonster") baseAF = new Monster_Form();
            }
            else if (cat == "字串")
            {
                if (cmd == "DefineStr") baseAF = new DefineStr_Form();
            }
            else if (cat == "劇情")
            {
                if (cmd == "Bind") baseAF = new Bind_Form();
                else if (cmd == "ShowButton") baseAF = new Button_Form(0);
                else if (cmd == "ChangeButton") baseAF = new Button_Form(1);
                else if (cmd == "ShowInput") baseAF = new Input_Form();
                else if (cmd == "GetText") baseAF = new GetText_Form();
                else if (cmd == "Walk") baseAF = new Walk_Form(0);
                else if (cmd == "WalkForward") baseAF = new Walk_Form(1);
                else if (cmd == "WalkBackward") baseAF = new Walk_Form(2);
                else if (cmd == "WalkLeft") baseAF = new Walk_Form(3);
                else if (cmd == "WalkRight") baseAF = new Walk_Form(4);
                else if (cmd == "StopWalk") baseAF = new Walk_Form(5);
                else if (cmd == "Route") baseAF = new Route_Form();
                else if (cmd == "PushTalk") baseAF = new Talk_Form(0);
                else if (cmd == "StartTalk") baseAF = new Talk_Form(1);
                else if (cmd == "Menu") baseAF = new MNA_Form(0);
                else if (cmd == "NextOne") baseAF = new MNA_Form(1);
                else if (cmd == "Alchemy") baseAF = new MNA_Form(2);
                else if (cmd == "Pause") baseAF = new PRTDOL_Form(0);
                else if (cmd == "Restart") baseAF = new PRTDOL_Form(1);
                else if (cmd == "Trigger") baseAF = new PRTDOL_Form(2);
                else if (cmd == "Damage") baseAF = new PRTDOL_Form(3);
                else if (cmd == "OpenShop") baseAF = new PRTDOL_Form(4);
                else if (cmd == "LoadScene") baseAF = new PRTDOL_Form(5);
                else if (cmd == "Shop") baseAF = new Shop_Form();
                else if (cmd == "AddItem") baseAF = new Item_Form(0);
                else if (cmd == "AddEquip") baseAF = new Item_Form(1);
                else if (cmd == "Rename") baseAF = new Rename_Form();
            }
            else if (cat == "邏輯")
            {
                ;
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
