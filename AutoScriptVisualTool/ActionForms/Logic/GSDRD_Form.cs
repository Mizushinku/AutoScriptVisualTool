using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class GSDRD_Form : AutoScriptVisualTool.BaseActionForm
    {
        /* GSDRD = Goto, Stop, Destroy, Return, Disable
         * Goto     --> mod = 0
         * Stop     --> mod = 1
         * Destroy  --> mod = 2
         * Return   --> mod = 3
         * Disable  --> mod = 4
         */
        int mod;
        public GSDRD_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 0)
            {
                label1.Text = "Label Name :";
            }
            else if (mod == 1)
            {
                label1.Text = "Object Name :";
            }
            else if (mod == 2)
            {
                label1.Text = "時間 :";
                name_tb.Size = new Size(75, 27);
                name_tb.TextAlign = HorizontalAlignment.Right;
            }
            else if (mod == 3)
            {
                this.Controls.Clear();
                this.Controls.Add(new Label
                {
                    Text = "立即跳出目前正在執行的函式",
                    AutoSize = true,
                    Location = new Point(12, 35),
                    Font = new Font("新細明體", 12, FontStyle.Regular)
                });
            }
            else if (mod == 4)
            {
                label1.Text = "Object Name :";
                this.Controls.Add(new Label
                {
                    Text = "Term :",
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(12, 105),
                    AutoSize = true,
                });
                string[] terms = { "Rigid", "Light", "Camera" };
                ComboBox cb = new ComboBox
                {
                    Name = "term_cb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Location = new Point(15, 124),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cb.Items.AddRange(terms);
                this.Controls.Add(cb);
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if (mod == 0)
            {
                actstr = String.Format(" # Goto {0}", name_tb.Text);
            }
            else if (mod == 1)
            {
                actstr = String.Format(" # Stop {0}", name_tb.Text);
            }
            else if (mod == 2)
            {
                actstr = String.Format(" # Destroy {0}", name_tb.Text);
            }
            else if (mod == 3)
            {
                actstr = " # Return";
            }
            else if (mod == 4)
            {
                actstr = String.Format(" # Disable {0} {1}",
                    name_tb.Text, this.Controls["term_cb"].Text);
            }
            return actstr;
        }
    }
}
