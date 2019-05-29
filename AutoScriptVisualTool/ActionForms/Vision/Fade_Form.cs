using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class Fade_Form : BaseActionForm
    {
        int in_or_out;

        public Fade_Form(int in_or_out)
        {
            InitializeComponent();
            // fadein = 0, fadeout = 1
            this.in_or_out = in_or_out;
            if (in_or_out == 1)
            {
                label1.Text = "等待時間";
                label2.Text = "淡出長常";
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

        public override string make_actstr()
        {
            string actstr;
            if (in_or_out == 0)
            {
                actstr = String.Format(" # FadeIn {0},{1},{2} {3} {4}",
                    red_tb.Text, green_tb.Text, blue_tb.Text, wait_time_tb.Text, fade_time_tb.Text);
            }
            else
            {
                actstr = String.Format(" # FadeOut {0},{1},{2} {3} {4}",
                    red_tb.Text, green_tb.Text, blue_tb.Text, wait_time_tb.Text, fade_time_tb.Text);
            }
            return actstr;
        }
    }
}
