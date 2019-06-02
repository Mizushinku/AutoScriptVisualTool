using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class PRTDOL_Form : AutoScriptVisualTool.BaseActionForm
    {
        /* PRTDOL = Pause, Restart, Trigger, Damage, OpenShop, LoadScene
         * Pause      --> mod = 0
         * Restart    --> mod = 1
         * Trigger    --> mod = 2
         * Damage     --> mod = 3
         * OpenShop   --> mod = 4
         * LoadScene  --> mod = 5
         */
        int mod;
        string action = String.Empty;
        public PRTDOL_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            label2.Text = String.Empty;

            if(mod == 0)
            {
                label1.Text = "時間 :";
                action = "Pause";
            }
            else if(mod == 1 || mod == 2)
            {
                label1.Text = "物件 :";
                param_tb.Size = new Size(205, 27);
                param_tb.TextAlign = HorizontalAlignment.Left;
                if (mod == 1) action = "Restart";
                else action = "Trigger";
            }
            else if (mod == 3)
            {
                label1.Text = "角色 :";
                label2.Text = "如輸入負值，則為治療效果";
                action = "Damage";
            }
            else if (mod == 4)
            {
                label1.Text = "商店 :";
                param_tb.Size = new Size(205, 27);
                param_tb.TextAlign = HorizontalAlignment.Left;
                label2.Text = "使用前需使用Shop指令來建立商店";
                action = "OpenShop";
            }
            else if (mod == 5)
            {
                label1.Text = "場景 :";
                param_tb.Visible = false;
                param_cb.Visible = true;
                action = "LoadScene";
            }
        }

        public override string make_actstr()
        {
            if(mod != 5)
            {
                return String.Format(" # {0} {1}", action, param_tb.Text);
            }
            else
            {
                return String.Format(" # {0} {1}", action, param_cb.Text.Split(':')[0]);
            }
        }
    }
}
