using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class ChangeImage_Form : AutoScriptVisualTool.BaseActionForm
    {
        public ChangeImage_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "選擇圖片";
            ofd.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
            ofd.RestoreDirectory = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                source_tb.Text = System.IO.Path.GetFullPath(ofd.FileName);
            }
        }

        private void color_pick_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                red_tb.Text = colorDialog1.Color.R.ToString();
                green_tb.Text = colorDialog1.Color.G.ToString();
                blue_tb.Text = colorDialog1.Color.B.ToString();
                color_pl.BackColor = colorDialog1.Color;
            }
        }

        private void color_tb_textChanged(object sender, EventArgs e)
        {
            int r, g, b;
            if (int.TryParse(red_tb.Text, out r) && 0 <= r && r <= 255 &&
                int.TryParse(green_tb.Text, out g) && 0 <= g && g <= 255 &&
                int.TryParse(blue_tb.Text, out b) && 0 <= b && b <= 255)
            {
                color_pl.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                color_pl.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void alpha_tb_TextChanged(object sender, EventArgs e)
        {
            int a;
            if(int.TryParse(alpha_tb.Text, out a) && 0 <= a && a <= 255)
            {
                color_pl.BackColor = Color.FromArgb(a, color_pl.BackColor);
            }
            else
            {
                color_pl.BackColor = Color.FromArgb(255, color_pl.BackColor);
            }
        }

        public override string make_actstr()
        {
            string actstr;
            string path = (source_tb.Text == String.Empty) ? "reserve" : source_tb.Text;
            string pos = (pos_x_tb.Text == String.Empty || pos_y_tb.Text == String.Empty ||
                            width_tb.Text == String.Empty || height_tb.Text == String.Empty) ?
                    "reserve" : String.Format("{0},{1},{2},{3}",pos_x_tb.Text, pos_y_tb.Text, width_tb.Text, height_tb.Text);
            string color = (red_tb.Text == String.Empty || green_tb.Text == String.Empty || blue_tb.Text == String.Empty
                            || alpha_tb.Text == String.Empty) ?
                    "reserve" : String.Format("{0},{1},{2},{3}", red_tb.Text, green_tb.Text, blue_tb.Text, alpha_tb.Text);

            actstr = String.Format(" # ChangeImage {0} {1} {2} {3} {4}",
                name_tb.Text, path, pos, color, exist_time_tb.Text);

            return actstr;
        }
    }
}
