using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Str
{
    public partial class DefineStr_Form : AutoScriptVisualTool.BaseActionForm
    {
        public DefineStr_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type_cb.SelectedIndex != -1 && value_tb.Text != String.Empty)
            {
                if (param_tb.Text.Length == 0 ||  param_tb.Text[param_tb.Text.Length - 1] == ' ')
                    param_tb.Text += type_cb.SelectedItem.ToString() + value_tb.Text;
                else
                    param_tb.Text += " " + type_cb.SelectedItem.ToString() + value_tb.Text;
            }
            else
                MessageBox.Show("參數格式錯誤", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            type_cb.SelectedIndex = -1;
            value_tb.Text = String.Empty;
        }

        public override string make_actstr()
        {
            return String.Format(" # DefineStr {0} {1}", index_tb.Text, param_tb.Text);
        }
    }
}
