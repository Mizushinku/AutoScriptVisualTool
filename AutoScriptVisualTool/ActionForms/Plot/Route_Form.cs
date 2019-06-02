using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Route_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Route_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point_list.Items.Add(pos_x_tb.Text + "," + pos_y_tb.Text + "," + pos_z_tb.Text);
            pos_x_tb.Text = String.Empty;
            pos_y_tb.Text = String.Empty;
            pos_z_tb.Text = String.Empty;
        }

        public override string make_actstr()
        {
            string points = String.Empty;
            foreach (string p in point_list.Items)
            {
                if (points == String.Empty)
                    points = p;
                else
                {
                    points = String.Format("{0} {1}", points, p);
                }
            }
            string actstr = String.Format(" # Route {0} {1}", name_tb.Text, points);

            return actstr;
        }
    }
}
