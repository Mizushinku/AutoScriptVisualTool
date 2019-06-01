using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Sound
{
    public partial class Music_Form : AutoScriptVisualTool.BaseActionForm
    {
        /* PlaySound --> mod = 0
         * PSfrom    --> mod = 1
         * ChBGM     --> mod = 2
         * ChBGMfrom --> mod = 3
         */
        int mod;

        public Music_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            if(mod == 1 || mod == 3)
            {
                label1.Text = "File :";
                label2.Visible = true;
                button1.Visible = true;
                source_tb.Size = new Size(202, source_tb.Size.Height);
                source_tb.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "選擇音源";
            ofd.RestoreDirectory = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                source_tb.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;

            if (mod == 0) actstr = String.Format(" # PlaySound {0}", source_tb.Text);
            else if (mod == 1) actstr = String.Format(" # PSfrom {0}", source_tb.Text);
            else if (mod == 2) actstr = String.Format(" # ChBGM {0}", source_tb.Text);
            else if (mod == 3) actstr = String.Format(" # ChBGMfrom {0}", source_tb.Text);

            return actstr;
        }
    }
}
