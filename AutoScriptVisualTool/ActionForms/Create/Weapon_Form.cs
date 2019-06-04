using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Create
{
    public partial class Weapon_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Weapon_Form()
        {
            InitializeComponent();
        }

        private void attr_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string attr = ((ComboBox)sender).Text;
            if (attr == "Gravity") add_reg_value("是否受重力影響", "0 = 不受影響");
            else if (attr == "Static") add_reg_value("物件是否觸發", "0 = 不觸發");
            else if (attr == "Lifetime") add_reg_value("生產後銷毀時間", "-1 = 不銷毀");
            else if (attr == "Durable") add_reg_value("撞擊角色後銷毀時間", "-1 = 不銷毀");
            else if (attr == "Exec") add_reg_value("觸發物件名稱", "", 1);
            else if (attr == "As") add_reg_value("該物件名稱", "", 1);
            else if (attr == "Force")
            {
                panel1.Controls.Add(new Label
                {
                    Text = "推力",
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(5, 10),
                    AutoSize = true
                });
                add_one_lbtb("向前 :", 5, 40, "f_tb", 59, 37);
                add_one_lbtb("向上 :", 5, 74, "u_tb", 59, 71);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = attr_cb.SelectedIndex;
            if (0 <= index && index <= 5)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    "", attr_cb.Text, panel1.Controls["value_tb"].Text
                });
                listView1.Items.Add(item);
            }
            else if(index == 6)
            {
                string value = String.Format("{0},{1}",
                    panel1.Controls["f_tb"].Text, panel1.Controls["u_tb"].Text);
                ListViewItem item = new ListViewItem(new string[] { "", "Force", value });
                listView1.Items.Add(item);
            }

        }

        private void add_reg_value(string hint, string info, int mod = 0)
        {
            panel1.Controls.Add(new Label
            {
                Text = hint,
                Font = new Font("新細明體", 12, FontStyle.Bold),
                Location = new Point(5, 10),
                AutoSize = true
            });
            panel1.Controls.Add(new TextBox
            {
                Name = "value_tb",
                Font = new Font("新細明體", 12, FontStyle.Regular),
                Location = new Point(5, 35),
                TextAlign = HorizontalAlignment.Right,
                Size = new Size(75, Size.Height)
            });
            panel1.Controls.Add(new Label
            {
                Text = info,
                Location = new Point(5, 75),
                AutoSize = true,
            });

            if(mod == 1)
            {
                ((TextBox)panel1.Controls["value_tb"]).TextAlign = HorizontalAlignment.Left;
                ((TextBox)panel1.Controls["value_tb"]).Size = new Size(150, 27);
            }
        }

        private void add_one_lbtb(string lbt, int x1, int y1, string tbn, int x2, int y2)
        {
            panel1.Controls.Add(new Label
            {
                Text = lbt,
                Font = new Font("新細明體", 12, FontStyle.Regular),
                Location = new Point(x1, y1),
                AutoSize = true,
            });
            panel1.Controls.Add(new TextBox
            {
                Name = tbn,
                Text = "0",
                Font = new Font("新細明體", 12, FontStyle.Regular),
                Location = new Point(x2, y2),
                Size = new Size(79, Size.Height),
                TextAlign = HorizontalAlignment.Right
            });
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Weapon {0} {1},{2},{3}",
                name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                actstr = String.Format("{0} {1} {2}",
                    actstr, item.SubItems[1].Text, item.SubItems[2].Text);
            }

            return actstr;
        }
    }
}
