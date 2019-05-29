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
    public partial class Light_Form : BaseActionForm
    {
        public Light_Form()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            intensity_tb.Text = (((TrackBar)sender).Value / 1000.0).ToString();
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
            string actstr = String.Format(" # Light {0} {1},{2},{3} {4} {5} {6}",
                        obj_name_tb.Text,
                        red_tb.Text,
                        green_tb.Text,
                        blue_tb.Text,
                        intensity_tb.Text,
                        range_tb.Text,
                        type_cb.SelectedItem);
            return actstr;
        }
    }
}
