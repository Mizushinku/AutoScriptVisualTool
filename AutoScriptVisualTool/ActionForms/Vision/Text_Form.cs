using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class Text_Form : AutoScriptVisualTool.BaseActionForm
    {
        private int mod;

        public Text_Form(int mod)
        {
            InitializeComponent();

            // mod == 0 --> show mod, mod == 1 --> change mod
            this.mod = mod;
            if (mod == 1) text_name_lb.Text = "textName :";

            //font_style_cb.SelectedItem = font_style_cb.Items[0];
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

        public override string make_actstr()
        {
            string actstr;

            if(mod == 0)
            {
                string style = font_style_cb.SelectedItem.ToString().Split(' ')[0];

                actstr = String.Format(" # ShowText {0} {1},{2} {3},{4},{5} {6},{7},{8} {9}",
                    content_tb.Text, pos_x_tb.Text, pos_y_tb.Text,
                    red_tb.Text, green_tb.Text, blue_tb.Text,
                    font_index_tb.Text, font_size_tb.Text, style, exist_time_tb.Text);
                if(text_name_tb.Text != String.Empty)
                {
                    actstr = String.Format("{0} as {1}", actstr, text_name_tb.Text);
                }
            }
            else
            {
                string content = (content_tb.Text == String.Empty) ? "$reserve" : content_tb.Text;
                string pos = (pos_x_tb.Text == String.Empty || pos_y_tb.Text == String.Empty) ?
                    "reserve" : String.Format("{0},{1}", pos_x_tb.Text, pos_y_tb.Text);
                string color = (red_tb.Text == String.Empty || green_tb.Text == String.Empty || blue_tb.Text == String.Empty) ?
                    "reserve" : String.Format("{0},{1},{2}", red_tb.Text, green_tb.Text, blue_tb.Text);
                string font = (font_index_tb.Text == String.Empty || font_size_tb.Text == String.Empty || font_style_cb.SelectedItem == null) ?
                    "reserve" : String.Format("{0},{1},{2}", font_index_tb.Text, font_size_tb.Text, font_style_cb.SelectedItem.ToString().Split(' ')[0]);

                actstr = String.Format(" # ChangeText {0} {1} {2} {3} {4} {5}",
                    text_name_tb.Text, content, pos, color, font, exist_time_tb.Text);
            }

            return actstr;
        }
    }
}
