using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Logic
{
    public partial class SetVar_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * SetVar     --> mod = 0
         * SetRandom  --> mod = 1
         */
        int mod;

        public SetVar_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 0)
            {
                this.Controls.Add(new Label
                {
                    Text = "value :",
                    AutoSize = true,
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(12, 155)
                });
                this.Controls.Add(new TextBox
                {
                    Name = "value_tb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Size = new Size(75, 27),
                    Location = new Point(75, 152),
                    TextAlign = HorizontalAlignment.Right
                });
            }
            else if (mod == 1)
            {
                this.Controls.Add(new Label
                {
                    Text = "最小值 :",
                    AutoSize = true,
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(12, 155)
                });
                this.Controls.Add(new TextBox
                {
                    Name = "min_tb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Size = new Size(75, 27),
                    Location = new Point(87, 152),
                    TextAlign = HorizontalAlignment.Right
                });
                this.Controls.Add(new Label
                {
                    Text = "最大值 :",
                    AutoSize = true,
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(12, 191)
                });
                this.Controls.Add(new TextBox
                {
                    Name = "max_tb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Size = new Size(75, 27),
                    Location = new Point(87, 188),
                    TextAlign = HorizontalAlignment.Right
                });
            }
        }

        private void g_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            l_cb.Checked = !flag;
        }

        private void l_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            g_cb.Checked = !flag;
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            string modify = (g_cb.Checked) ? "public" : "private";
            if (mod == 0)
                actstr = String.Format(" # SetVar {0} {1} {2}",
                    modify, index_tb.Text, this.Controls["value_tb"].Text);
            else if (mod == 1)
                actstr = String.Format(" # SetRandom {0} {1} {2},{3}",
                    modify, index_tb.Text, this.Controls["min_tb"].Text, this.Controls["max_tb"].Text);
            return actstr;
        }
    }
}
