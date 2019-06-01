using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Mechanics
{
    public partial class RSTAR_Form : AutoScriptVisualTool.BaseActionForm
    {
        /* RSTAR :
         * Rotate   --> mod = 0
         * Scale    --> mod = 1
         * Teleport --> mod = 2
         * AddForce --> mod = 3
         * Rigid    --> mod = 4
         */

        int mod;

        public RSTAR_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;

            if(mod == 1)
            {
                label2.Text = "縮放 :";
                label6.Text = "設定縮放 :";
                org_cb.Text = "初始化縮放";
            }
            else if(mod == 2)
            {
                label2.Text = "位置 :";
                label6.Text = "設定參考 :";
                org_cb.Text = "設定參考物件";
            }
            else if(mod == 3)
            {
                label2.Text = "施力 :";
                panel2.Visible = false;
            }
            else if(mod == 4)
            {
                panel1.Visible = false;
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;

            if (mod == 0)
            {
                actstr = String.Format(" # Rotate {0} {1},{2},{3}",
                    name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
                if (org_cb.Checked)
                    actstr += " org";
            }
            else if(mod == 1)
            {
                actstr = String.Format(" # Scale {0} {1},{2},{3}",
                    name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
                if (org_cb.Checked)
                    actstr += " org";
            }
            else if(mod == 2)
            {
                actstr = String.Format(" # Teleport {0}", name_tb.Text);
                if(org_cb.Checked)
                {
                    // has ref object
                    actstr = String.Format("{0} in {1} {2},{3},{4}",
                        actstr, ref_name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
                }
                else
                {
                    actstr = String.Format("{0} at {1},{2},{3}",
                        actstr, x_tb.Text, y_tb.Text, z_tb.Text);
                }
            }
            else if (mod == 3)
            {
                actstr = String.Format(" # AddForce {0} {1},{2},{3}",
                    name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
            }
            else if (mod == 4)
            {
                actstr = String.Format(" # Rigid {0}", name_tb.Text);
            }

            return actstr;
        }

        private void org_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (mod != 2) return;

            bool flag = ((CheckBox)sender).Checked;
            if(flag)
            {
                label7.Visible = true;
                ref_name_tb.Visible = true;
            }
            else
            {
                label7.Visible = false;
                ref_name_tb.Visible = false;
            }
        }
    }
}
