using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AutoScriptVisualTool
{
    public partial class mainForm : Form
    {
        private Dictionary<object, Form> map = new Dictionary<object, Form>();
        private Script_form cur_form = null;

        public mainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            object item = "player" as object;
            player_list.Items.Add(item);
            map.Add(item, new Script_form(5));

            object item2 = "default" as object;
            default_list.Items.Add(item2);
            map.Add(item2, new Script_form(7));
        
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.StartPosition = FormStartPosition.CenterParent;
            if(add_Form.ShowDialog(this) == DialogResult.OK)
            {
                int which = add_Form.which;
                string num = add_Form.num;
                if (which == 1)
                {
                    add_new_script(start_list, "start", which, num);
                }
                else if(which == 2)
                {
                    add_new_script(trigger_list, "trigger", which, num);
                }
                else if(which == 3)
                {
                    add_new_script(destroy_list, "destroy", which, num);
                }
                else if(which == 4)
                {
                    add_new_script(update_list, "update", which, num);
                }
                /*
                else if(which == 6)
                {
                    add_new_script(function_list, "function", which);
                }
                */
                else if(which == 7)
                {
                    make_sc(1);
                }
                else if (which == 8)
                {
                    make_sc(2);
                }
                else if (which == 9)
                {
                    make_sc(3);
                }
                else if (which == 10)
                {
                    make_sc(4);
                }
            }
        }

        private void add_new_script(ListBox list, string cat, int which, string num)
        {
            string name = cat + num;
            if (list.Items.Contains(name))
            {
                MessageBox.Show("已擁有同名的Script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                object item = name as object;
                map.Add(item, new Script_form(which));
                if (list.Items.Count == 0)
                {
                    list.Items.Add(item);
                }
                else
                {
                    bool added = false;
                    for (int i = 0; i < list.Items.Count; ++i)
                    {
                        int cur = int.Parse(Regex.Match(list.Items[i].ToString(), @"\d+").Value);
                        if (cur > int.Parse(num))
                        {
                            list.Items.Insert(i, item);
                            added = true;
                            maintain_index(list, i);
                            break;
                        }
                    }
                    if (!added) list.Items.Add(item);
                }
            }
        }

        private void maintain_index(ListBox list, int changed_index)
        {
            if (list.Equals(start_list))
            {
                if (start_pre_slt >= changed_index) ++start_pre_slt;
            }
            else if (list.Equals(trigger_list))
            {
                if (trigger_pre_slt >= changed_index) ++trigger_pre_slt;
            }
            else if (list.Equals(destroy_list))
            {
                if (destroy_pre_slt >= changed_index) ++destroy_pre_slt;
            }
            else if (list.Equals(update_list))
            {
                if (update_pre_slt >= changed_index) ++update_pre_slt;
            }
        }

        int start_pre_slt = -1;
        private void start_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\npre = " + start_pre_slt + "\nselected = " + start_list.SelectedIndex);
            if (start_list.SelectedIndex == start_pre_slt) return;
            start_pre_slt = start_list.SelectedIndex;
            if (start_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[start_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        int trigger_pre_slt = -1;
        private void trigger_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trigger_list.SelectedIndex == trigger_pre_slt) return;
            trigger_pre_slt = trigger_list.SelectedIndex;
            if (trigger_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[trigger_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        int destroy_pre_slt = -1;
        private void destroy_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (destroy_list.SelectedIndex == destroy_pre_slt) return;
            destroy_pre_slt = destroy_list.SelectedIndex;
            if (destroy_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[destroy_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        int update_pre_slt = -1;
        private void update_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update_list.SelectedIndex == update_pre_slt) return;
            update_pre_slt = update_list.SelectedIndex;
            if (update_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[update_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        int function_pre_slt = -1;
        private void function_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (function_list.SelectedIndex == function_pre_slt) return;
            function_pre_slt = function_list.SelectedIndex;
            if (function_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[function_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        private void player_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[player_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        private void default_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (default_list.SelectedIndex == -1) return;

            main_panel.Controls.Clear();
            cur_form = (Script_form)map[default_list.SelectedItem];
            main_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        private void newClass_btn_Click(object sender, EventArgs e)
        {
            if(cur_form == null)
            {
                MessageBox.Show("請選擇一個Script檔案","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputBox inputBox = new InputBox("New Class", "請輸入新項目名稱");
                if(inputBox.ShowDialog() == DialogResult.OK)
                {
                    object item = inputBox.textBox1.Text as object;
                    cur_form.class_list.Items.Add(item);
                    cur_form.class_list_ItemAdded(item);
                }
            }
        }

        int pre_tab = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pre_tab == 0)
            {
                start_list.ClearSelected();
            }
            else if(pre_tab == 1)
            {
                trigger_list.ClearSelected();
            }
            else if(pre_tab == 2)
            {
                destroy_list.ClearSelected();
            }
            else if (pre_tab == 3)
            {
                update_list.ClearSelected();
            }
            else if(pre_tab == 4)
            {
                player_list.ClearSelected();
            }
            else if(pre_tab == 5)
            {
                function_list.ClearSelected();
            }
            else if(pre_tab == 6)
            {
                default_list.ClearSelected();
            }

            pre_tab = tabControl1.SelectedIndex;
            main_panel.Controls.Clear();
            cur_form = null;
        }

        private void add_cond_btn_Click(object sender, EventArgs e)
        {
            
            if(cur_form == null || cur_form.pre_slt == -1)
            {
                MessageBox.Show("請選擇一個class", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Condition_Form condition_Form = new Condition_Form();
                if(condition_Form.ShowDialog() == DialogResult.OK)
                {
                    Event_Form sub_form = cur_form.get_sub_form();
                    sub_form.event_list.Items.Add(condition_Form.condstr);
                }
            }
        }

        private void add_action_btn_Click(object sender, EventArgs e)
        {
            if(cur_form != null && cur_form.pre_slt != -1)
            {
                ListBox list = cur_form.get_sub_form().event_list;
                if(list.SelectedIndex != -1)
                {
                    string event_str = list.SelectedItem.ToString();
                    if(event_str.Length == 0)
                    {
                        MessageBox.Show("請先新增一個條件", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int cnt = event_str.Split('#').Length - 1;
                    if(cnt < 2)
                    {
                        Action_Form action = new Action_Form();
                        if(action.ShowDialog() == DialogResult.OK)
                        {
                            list.Items[list.SelectedIndex] += action.actstr;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Action過多", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("請選擇一個event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請選擇一個class", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //new Action_Form().ShowDialog();
        }

        private void add_label_btn_Click(object sender, EventArgs e)
        {
            if (cur_form == null || cur_form.pre_slt == -1)
            {
                MessageBox.Show("請選擇一個class", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputBox inputBox = new InputBox("New Label", "請輸入新Label名稱");
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    Event_Form sub_form = cur_form.get_sub_form();
                    sub_form.event_list.Items.Add(inputBox.textBox1.Text + ":");
                }
            }
        }

        private void list_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListBox list = null;
                int prev = -2;
                if (sender.Equals(start_list))
                {
                    list = start_list;
                    prev = start_pre_slt;
                }
                else if (sender.Equals(trigger_list))
                {
                    list = trigger_list;
                    prev = trigger_pre_slt;
                }
                else if (sender.Equals(destroy_list))
                {
                    list = destroy_list;
                    prev = destroy_pre_slt;
                }
                else if (sender.Equals(update_list))
                {
                    list = update_list;
                    prev = update_pre_slt;
                }
                int index = list.IndexFromPoint(e.X, e.Y);
                if (index == -1 || prev == -2) return;
                list.ClearSelected();
                cur_form = null;

                object rm_item = list.Items[index] as object;
                map.Remove(rm_item);
                list.Items.Remove(rm_item);

                if (0 <= prev && prev < index) list.SetSelected(prev, true);
                if (prev == index) main_panel.Controls.Clear();
                else if (prev > index) list.SetSelected(prev - 1, true);
            }
        }

        private void re_map(ListBox list)
        {
            ;
        }

        private void make_sc(int script_num)
        {
            map.Clear();

            if (script_num == 1) {
                ///////////////////////////////////////
                ListBox list = new ListBox();
                string[] items =
                {
                    "s0","s1"
                };
                Dictionary<int, string[]> dic = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "c1"
                    }},
                    {1, new string[]{
                        "c3"
                    }}
                };
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "c1", "true # SetVar public 99 0"
                    }},
                    {1, new string[]{
                        "c3", "c4", "c5"
                    }}
                };


                list.Items.AddRange(items);
                start_list.Items.Clear();
                start_list.Items.AddRange(list.Items);

                int k = 0, q = 0, num = 1; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in start_list.Items)
                {
                    map.Add(i, new Script_form(num));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic[k])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);
                        ++q;
                    }
                    ++k;
                }
                /////////////////////////////////////////
            }
            else if (script_num == 2)
            {

            }
            else if (script_num == 3)
            {

            }
            else if (script_num == 4)
            {

            }
        }
    }
}
