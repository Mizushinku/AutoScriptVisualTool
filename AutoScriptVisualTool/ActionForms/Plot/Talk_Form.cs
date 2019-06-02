using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Talk_Form : AutoScriptVisualTool.BaseActionForm
    {
        /*
         * PushTalk  --> mod = 0
         * StartTalk --> mod = 1
         */
        int mod;

        public Talk_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if (mod == 1)
            {
                panel1.Visible = false;
                this.Controls.Add(new Label
                {
                    Text = "依據PushTalk的順序顯示對話框",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Location = new Point(12, 35)
                });
            }
            else
            {
                index_cb.Checked = true;
            }
        }

        private void index_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            if (flag) file_cb.Checked = false;
            label4.Visible = flag;
            index_tb.Visible = flag;
            label6.Visible = flag;
        }

        private void file_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            if (flag) index_cb.Checked = false;
            label5.Visible = flag;
            path_tb.Visible = flag;
            button1.Visible = flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "選擇圖片";
            ofd.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
            ofd.RestoreDirectory = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_tb.Text = System.IO.Path.GetFullPath(ofd.FileName);
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if(mod == 0)
            {
                actstr = String.Format(" # PushTalk {0} {1}", con_tb.Text, ch_tb.Text);
                if (index_cb.Checked)
                    actstr = String.Format("{0} ${1}", actstr, index_tb.Text);
                else if (file_cb.Checked)
                    actstr = String.Format("{0} {1}", actstr, path_tb.Text);
            }
            else
            {
                actstr = " # StartTalk";
            }
            return actstr;
        }
    }
}
