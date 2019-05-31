using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class ShowImage_Form : AutoScriptVisualTool.BaseActionForm
    {
        bool from_path;

        public ShowImage_Form(bool from_path)
        {
            InitializeComponent();

            this.from_path = from_path;
            if(from_path)
            {
                label1.Text = "Path :";
                source_tb.Size = new Size(368, 56);
                source_tb.TextAlign = HorizontalAlignment.Left;
                button1.Visible = true;
                label8.Visible = true;
                name_tb.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "選擇圖片";
            ofd.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
            ofd.RestoreDirectory = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                source_tb.Text = System.IO.Path.GetFullPath(ofd.FileName);
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # ShowImage {0} {1},{2},{3},{4} {5}",
                    source_tb.Text, pos_x_tb.Text, pos_y_tb.Text, width_tb.Text, height_tb.Text, exist_time_tb.Text);

            if (from_path && name_tb.Text != String.Empty)
            {
                actstr = String.Format("{0} as {1}", actstr, name_tb.Text);
            }

            return actstr;
        }
    }
}
