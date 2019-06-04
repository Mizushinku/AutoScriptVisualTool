using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Create
{
    public partial class ChangeNPC_Form : AutoScriptVisualTool.BaseActionForm
    {
        public ChangeNPC_Form()
        {
            InitializeComponent();
        }

        private void attr_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string attr = ((ComboBox)sender).Text;
            if (attr == "Sight") add_reg_value("視野");
            else if (attr == "AttSight") add_reg_value("攻擊範圍");
            else if (attr == "Hp") add_reg_value("生命值");
            else if (attr == "Att") add_reg_value("攻擊力");
            else if (attr == "Def") add_reg_value("防禦力");
            else if (attr == "Level") add_reg_value("等級");
            else if (attr == "Exp") add_reg_value("擊殺後獲得經驗");
            else if (attr == "CD") add_reg_value("攻擊間隔");
            else if (attr == "AI")
            {
                string[] mods = { "Chase", "Shy", "Portal" };
                add_hint1_to_p1("模式");
                ComboBox cb = new ComboBox
                {
                    Name = "ai_mod_cb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Location = new Point(5, 35),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                };
                cb.Items.AddRange(mods);
                panel1.Controls.Add(cb);
            }
            else if (attr == "Target")
            {
                add_hint1_to_p1("設定");
                panel1.Controls.Add(new CheckBox
                {
                    Name = "is_target_cb",
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(5, 35),
                    Text = "可被攻擊",
                });
            }
            else if (attr == "Weapon")
            {
                add_hint1_to_p1("Type");
                string[] mods = { "load", "self" };
                string[] weapons = { "enemyBigFire", "enenyBlueSpray", "enenyYellowSpray",
                    "enemyFront0", "enemyGreenFire", "enemyGreenFire" };

                ComboBox cb = new ComboBox
                {
                    Name = "type_cb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Location = new Point(5, 35),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                };
                cb.Items.AddRange(mods);
                panel1.Controls.Add(cb);

                panel1.Controls.Add(new Label
                {
                    Text = "Weapon Name",
                    Font = new Font("新細明體", 12, FontStyle.Bold),
                    Location = new Point(5, 95),
                    AutoSize = true
                });
                ComboBox cb2 = new ComboBox
                {
                    Name = "wn_cb",
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Location = new Point(5, 115),
                    Size = new Size(150, Size.Height),
                };
                panel1.Controls.Add(cb2);

                cb.SelectedIndexChanged += new EventHandler((object sender2, EventArgs e2) =>
                {
                    ((ComboBox)panel1.Controls["wn_cb"]).Text = String.Empty;
                    if (((ComboBox)sender2).SelectedIndex == 0)
                        ((ComboBox)panel1.Controls["wn_cb"]).Items.AddRange(weapons);
                    else
                        ((ComboBox)panel1.Controls["wn_cb"]).Items.Clear();
                });
            }
            else if (attr == "WeaponOut") add_reg_value("初始距離");
            else if (attr == "WeaponOffset")
            {
                add_hint1_to_p1("初始距離 (X,Y,Z)");
                add_one_lbtb("X :", 8, 40, "x_tb", 41, 37);
                add_one_lbtb("Y :", 8, 73, "y_tb", 41, 70);
                add_one_lbtb("Z :", 8, 106, "z_tb", 41, 103);
            }
        }

        private void add_reg_value(string hint)
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
        }

        private void add_hint1_to_p1(string hint)
        {
            panel1.Controls.Add(new Label
            {
                Text = hint,
                Font = new Font("新細明體", 12, FontStyle.Bold),
                Location = new Point(5, 10),
                AutoSize = true
            });
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
                Font = new Font("新細明體", 12, FontStyle.Regular),
                Location = new Point(x2, y2),
                Size = new Size(79, Size.Height),
                TextAlign = HorizontalAlignment.Right
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = attr_cb.SelectedIndex;
            if (0 <= index && index <= 7 || index == 11)
            {
                string attr = attr_cb.Text;
                string value = panel1.Controls["value_tb"].Text;
                ListViewItem item = new ListViewItem(new string[] { "", attr, value});
                listView1.Items.Add(item);
            }
            else if (index == 8)
            {
                // AI
                string value = panel1.Controls["ai_mod_cb"].Text;
                ListViewItem item = new ListViewItem(new string[] { "", "AI", value });
                listView1.Items.Add(item);
            }
            else if (index == 9)
            {
                // Target
                int t = (((CheckBox)panel1.Controls["is_target_cb"]).Checked) ? 1 : 0;
                ListViewItem item = new ListViewItem(new string[] { "", "Target", t.ToString() });
                listView1.Items.Add(item);
            }
            else if (index == 10)
            {
                // Weapon
                string value = String.Format("{0}:{1}",
                    panel1.Controls["type_cb"].Text, panel1.Controls["wn_cb"].Text);
                ListViewItem item = new ListViewItem(new string[] { "", "Weapon", value });
                listView1.Items.Add(item);
            }
            else if (index == 12)
            {
                // WeaponOffset
                string value = String.Format("{0},{1},{2}",
                    panel1.Controls["x_tb"].Text, panel1.Controls["y_tb"].Text, panel1.Controls["z_tb"].Text);
                ListViewItem item = new ListViewItem(new string[] { "", "WeaponOffset", value });
                listView1.Items.Add(item);
            }
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # ChangeNPC {0}", name_tb.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                actstr = String.Format("{0} {1} {2}",
                    actstr, item.SubItems[1].Text, item.SubItems[2].Text);
            }

            return actstr;
        }
    }
}
