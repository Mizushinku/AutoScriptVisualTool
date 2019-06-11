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
using System.IO;

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
            map.Add(item, new Setting_Form());

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
                    refresh_main_panel();
                }
                else if (which == 8)
                {
                    make_sc(2);
                    refresh_main_panel();
                }
                else if (which == 9)
                {
                    make_sc(3);
                    refresh_main_panel();
                }
                else if (which == 10)
                {
                    make_sc(4);
                    refresh_main_panel();
                }
            }
        }

        private void refresh_main_panel()
        {
            tabControl1_SelectedIndexChanged(null, null);
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
            Setting_Form set_form = (Setting_Form)map[player_list.SelectedItem];
            main_panel.Controls.Add(set_form);
            set_form.Show();
            panel1.Visible = false;
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
            panel1.Visible = true;
            if (pre_tab == 0)
            {
                start_list.ClearSelected();
                start_pre_slt = -1;
            }
            else if(pre_tab == 1)
            {
                trigger_list.ClearSelected();
                trigger_pre_slt = -1;
            }
            else if(pre_tab == 2)
            {
                destroy_list.ClearSelected();
                destroy_pre_slt = -1;
            }
            else if (pre_tab == 3)
            {
                update_list.ClearSelected();
                update_pre_slt = -1;
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
                string msg = "確定刪除 " + list.Items[index] + " 嗎?";
                if (MessageBox.Show(msg, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
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
                    "start0", "start1"
                };
                bool[] is_NoDefault =
                {
                    true, false
                };
                Dictionary<int, string[]> dic = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "SceneStart"
                    }},
                    {1, new string[]{
                        "SceneStart", "KEsc"
                    }}
                };
                bool[] is_static =
                {
                    false, false, true
                };
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # ChangeText Caption ~無雙~ reserve 255,255,0 0,120,B -1",
                        "true # ChangeText Start/Text 開始新遊戲 reserve 255,0,0 reserve -1",
                        "true # ChangeText Load/Text 繼續遊戲 reserve 0,0,255 reserve -1",
                        "true # ChangeText Quit/Text 離開遊戲 reserve 0,255,0 reserve -1",
                        "true # ChangeImage Back zombie.jfif reserve 255,255,255,1 -1",
                        "true # Virtual Slider at 0,0,0",
                        "true # ChBGMfrom Kao"
                    }},
                    {1, new string[]{
                        "true # Rename role 0 開無雙啦RRRR",
                        "true # SetVar public 99 0",
                        "true # ShowText ??? 1700,1000 0,255,0 1,48,B -1 as Place",
                        "true # ChBGMfrom Kao",
                        "true # Virtual Default at 0,0,0",
                        "true # NPC Ganful in role 0,-10,5 as Soldier1",
                        "true # ChangeNPC Soldier1 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 0,-10,-5 as Soldier2",
                        "true # ChangeNPC Soldier2 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 5,-10,0 as Soldier3",
                        "true # ChangeNPC Soldier3 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -5,-10,0 as Soldier4",
                        "true # ChangeNPC Soldier4 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 5,-10,5 as Soldier5",
                        "true # ChangeNPC Soldier5 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 5,-10,-5 as Soldier6",
                        "true # ChangeNPC Soldier6 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -5,-10,5 as Soldier7",
                        "true # ChangeNPC Soldier7 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -5,-10,-5 as Soldier8",
                        "true # ChangeNPC Soldier8 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 2.5,-10,5 as Soldier9",
                        "true # ChangeNPC Soldier9 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 2.5,-10,-5 as Soldier10",
                        "true # ChangeNPC Soldier10 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 5,-10,2.5 as Soldier11",
                        "true # ChangeNPC Soldier11 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -5,-10,2.5 as Soldier12",
                        "true # ChangeNPC Soldier12 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -2.5,-10,5 as Soldier13",
                        "true # ChangeNPC Soldier13 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -2.5,-10,-5 as Soldier14",
                        "true # ChangeNPC Soldier14 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role 5,-10,-2.5 as Soldier15",
                        "true # ChangeNPC Soldier15 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Ganful in role -5,-10,-2.5 as Soldier16",
                        "true # ChangeNPC Soldier16 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 0,-10,5 as Soldier17",
                        "true # ChangeNPC Soldier17 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 0,-10,-5 as Soldier18",
                        "true # ChangeNPC Soldier18 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 5,-10,0 as Soldier19",
                        "true # ChangeNPC Soldier19 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -5,-10,0 as Soldier20",
                        "true # ChangeNPC Soldier20 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 5,-10,5 as Soldier21",
                        "true # ChangeNPC Soldier21 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 5,-10,-5 as Soldier22",
                        "true # ChangeNPC Soldier22 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -5,-10,5 as Soldier23",
                        "true # ChangeNPC Soldier23 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -5,-10,-5 as Soldier24",
                        "true # ChangeNPC Soldier24 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 2.5,-10,5 as Soldier25",
                        "true # ChangeNPC Soldier25 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 2.5,-10,-5 as Soldier26",
                        "true # ChangeNPC Soldier26 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 5,-10,2.5 as Soldier27",
                        "true # ChangeNPC Soldier27 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -5,-10,2.5 as Soldier28",
                        "true # ChangeNPC Soldier28 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -2.5,-10,5 as Soldier29",
                        "true # ChangeNPC Soldier29 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -2.5,-10,-5 as Soldier30",
                        "true # ChangeNPC Soldier30 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role 5,-10,-2.5 as Soldier31",
                        "true # ChangeNPC Soldier31 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # NPC Deer in role -5,-10,-2.5 as Soldier32",
                        "true # ChangeNPC Soldier32 AI Chase Sight 10 Att 1 CD 2 Target 1",
                        "true # Bind down Esc KEsc +"
                    }},
                    {2, new string[]
                    {
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
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

                    // set NoDefault for start scripts
                    sub.set_no_default_cb(is_NoDefault[k]);

                    foreach (string s in dic[k])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);

                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static[q]);

                        ++q;
                    }
                    ++k;
                }
                /////////////////////////////////////////
                ListBox list1 = new ListBox();
                string[] items1 =
                {
                    "default"
                };
                Dictionary<int, string[]> dic3 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Default",
                        "KeyDownH",
                        "KeyPressH",
                        "KeyUpH",
                        "KTab",
                        "Skill0",
                        "XS",
                        "CS",
                        "VS",
                        "myWalk",
                        "myBack",
                        "myLeft",
                        "myRight",
                        "myJump",
                        "stopWalk",
                        "SpeedUp",
                        "SpeedDown"
                    }}
                };
                bool[] is_static2 =
                {
                    false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
                };
                Dictionary<int, string[]> dic4 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 使用預設檔案",
                        "true # Bind down H KeyDownH +",
                        "true # Bind press H KeyPressH +",
                        "true # Bind up H KeyUpH +",
                        "true # Bind down Tab KTab +",
                        "true # Bind down Z Skill0 +",
                        "true # Bind down X XS +",
                        "true # Bind down C CS +",
                        "true # Bind down V VS +",
                        "true # Bind down O OS +",
                        "true # Bind down Shift SpeedUp +",
                        "true # Bind up Shift SpeedDown +",
                        "true # Bind press W myWalk +",
                        "true # Bind press S myBack +",
                        "true # Bind press A myLeft +",
                        "true # Bind press D myRight +",
                        "true # Bind down A GasA +",
                        "true # Bind down B GasB +",
                        "true # Bind down C GasC +",
                        "true # Bind down D GasD +",
                        "true # Bind up W stopWalk +",
                        "true # Bind up S stopWalk",
                        "true # Bind down Space myJump +"
                    }},
                    {1, new string[]{
                        "true # Eval 0 to g2"
                    }},
                    {2, new string[]{
                        "true # Eval 1 + g2 to g2"
                    }},
                    {3, new string[]{
                        "true # Cast g2"
                    }},
                    {4, new string[]{
                        "true # NextOne"
                    }},
                    {5, new string[]{
                        "true # UseSkill 0"
                    }},
                    {6, new string[]{
                        "true # UseSkill 1"
                    }},
                    {7, new string[]{
                        "true # UseSkill 2"
                    }},
                    {8, new string[]{
                        "true # UseSkill 3"
                    }},
                    {9, new string[]{
                        "true # WalkForward"
                    }},
                    {10, new string[]{
                        "true # WalkBackward"
                    }},
                    {11, new string[]{
                        "true # WalkLeft"
                    }},
                    {12, new string[]{
                        "true # WalkRight"
                    }},
                    {13, new string[]{
                        "== l1 1 # Return",
                        "true # StopWalk",
                        "true # AddForce role 0,40000,0",
                        "true # SetVar private 1 1",
                        "true # Pause 1",
                        "true # SetVar private 1 0"
                    }},
                    {14, new string[]{
                        "true # StopWalk"
                    }},
                    {15, new string[]{
                        "true # Broadcast 加速！",
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 * 2 to l2",
                        "< l2 15 # SetSp 4 $speed l2"
                    }},
                    {16, new string[]{
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 / 2 to l2",
                        "true # Cast l2",
                        "true # SetSp 4 $speed l2"
                    }}
                };

                list1.Items.AddRange(items1);
                default_list.Items.Clear();
                default_list.Items.AddRange(list1.Items);

                int k1 = 0, q1 = 0, num1 = 7; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in default_list.Items)
                {
                    map.Add(i, new Script_form(num1));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic3[k1])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num1, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);

                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static2[q1]);

                        ++q1;
                    }
                    ++k1;
                }

                map.Add(player_list.Items[0], new Setting_Form());
                ListBox player_events = ((Setting_Form)map[player_list.Items[0]]).event_list;
                player_events.Items.Clear();

                string[] player_items =
                {
                    "level 3 11 9",
                    "skill 0 4 9 6 21 3",
                    "skill 1 4 5 6 7 1",
                    "skill 2 8 9 10 21 2",
                    "learn 0 5 7 8",
                    "learn 1 20 21 22",
                    "learn 2 23 24",
                    "learnp 0 5 6",
                    "learnp 1 7 8 9",
                    "learnp 2 10 11 12",
                    "party 2 1 0",
                    "item 0,9 1,7 2,8",
                    "equip 2 3,7,11,15,19",
                    "unequip 1,3 4,3 6,3 8,3 10,3",
                    "modeq 1 name:聖獸庇護 text:戴上的那一剎那，你已經獲得聖獸的祝福。 rare:3",
                    "moditem 1 type:common name:醬油 text:家庭必備調味品。 amount:60",
                    "modskill 6 name:疾風迅雷 cost:0",
                    "modp 2 name:如火如荼 text:縮短你的靈核爆破需時",
                    "scene 1"
                };

                player_events.Items.AddRange(player_items);



                /////////////////////////////////////////
            }
            else if (script_num == 2)
            {
                /////////////////////////////////////////
                ListBox list = new ListBox();
                string[] items =
                {
                    "start0", "start1", "start2", "start10"
                };
                bool[] is_NoDefault =
                {
                    true, false, false, false
                };
                Dictionary<int, string[]> dic = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "SceneStart"
                    }},
                    {1, new string[]{
                        "SceneStart", "DontMove", "CanMove", "KEsc"
                    }},
                    {2, new string[]{
                        "SceneStart", "DontMove", "CanMove", "KEsc"
                    }},
                    {3, new string[]{
                        "SceneStart", "DontMove", "CanMove", "KEsc"
                    }}
                };
                bool[] is_static =
                {
                    false, false, true, true, true, false, true, true, true, false, true, true, true
                };
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # ChangeText Caption 勇者達拉崩巴 reserve 255,255,0 0,120,B -1",
                        "true # ChangeText Start/Text 開始遊戲 reserve 255,0,0 reserve -1",
                        "true # ChangeText Load/Text 繼續遊戲 reserve 0,0,255 reserve -1",
                        "true # ChangeText Quit/Text 離開遊戲 reserve 0,255,0 reserve -1",
                        "true # ChangeImage Back brave.jfif reserve 255,255,255,1 -1",
                        "true # Virtual Slider at 0,0,0",

                    }},
                    {1, new string[]{
                        "true # Rename role 0 達拉崩巴",
                        "true # SetVar public 99 0",
                        "true # ShowText 無名小村 1700,1000 0,255,0 1,48,B -1 as Place",
                        "true # ChBGMfrom Strike",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Blackman in role 0,-10,10 as NPC1",
                        "true # NPC Zombie in role 10,-10,0 as NPC2",
                        "true # NPC Remy in role 0,-10,20 as NPC3",
                        "true # NPC Azure in role 0,-10,0 as NPC4",
                        "true # NPC Mei in role 10,-10,10 as NPC5",
                        "true # NPC White in role 5,-10,20 as NPC6",
                        "true # Route NPC1 0,0,0 10,0,0",
                        "true # Route NPC2 0,0,0 0,0,20",
                        "true # Route NPC3 0,0,0 5,0,0",
                        "true # Route NPC5 0,0,0 0,0,-10",
                        "true # Route NPC6 0,0,0 5,0,3",
                        "true # Create Door in role 0,-10,15 as Door",
                        "true # Bind down Esc KEsc +"
                    }},
                    {2, new string[]{
                        "true # Bind press W null",
                        "true # Bind press S null",
                        "true # Bind press A null",
                        "true # Bind press D null",
                        "true # Bind up W null",
                        "true # Bind up S null"
                    }},
                    {3, new string[]{
                        "true # Bind press W myWalk",
                        "true # Bind press S myBack",
                        "true # Bind press A myLeft",
                        "true # Bind press D myRight",
                        "true # Bind up W stopWalk",
                        "true # Bind up S stopWalk"
                    }},
                    {4, new string[]
                    {
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {5, new string[]
                    {
                        "true # ShowText 昆圖庫塔卡提考特蘇瓦西拉松龍穴 1700,1000 0,255,0 1,30,B -1 as Place",
                        "true # ChBGMfrom Strike",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Greenbear in role -15,0,-10 as Monster",
                        "true # NPC Girl0 in role -22,0,-10 as Princess",
                        "true # Bind down Esc KEsc +"
                    }},
                    {6, new string[]
                    {
                        "true # Bind press W null",
                        "true # Bind press S null",
                        "true # Bind press A null",
                        "true # Bind press D null",
                        "true # Bind up W null",
                        "true # Bind up S null"
                    }},
                    {7, new string[]
                    {
                        "true # Bind press W myWalk",
                        "true # Bind press S myBack",
                        "true # Bind press A myLeft",
                        "true # Bind press D myRight",
                        "true # Bind up W stopWalk",
                        "true # Bind up S stopWalk"
                    }},
                    {8, new string[]
                    {
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {9, new string[]
                    {
                        "true # ShowText 蒙達魯克硫斯伯古比奇巴勒城 1700,1000 0,255,0 1,30,B -1 as Place",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC White in role -5,-5.5,5 as King",
                        "true # NPC Vanguard in role -6,-5.5,1 as Guard1",
                        "true # NPC Vanguard in role -4,-5.5,1 as Guard2",
                        "true # NPC Vanguard in role -6,-5.5,9 as Guard3",
                        "true # NPC Vanguard in role -4,-5.5,9 as Guard4",
                        "true # Create AngelStatue in role -4,-5.5,15 as Statue",
                        "true # Bind down Esc KEsc +"
                    }},
                    {10, new string[]
                    {
                        "true # Bind press W null",
                        "true # Bind press S null",
                        "true # Bind press A null",
                        "true # Bind press D null",
                        "true # Bind up W null",
                        "true # Bind up S null"
                    }},
                    {11, new string[]
                    {
                        "true # Bind press W myWalk",
                        "true # Bind press S myBack",
                        "true # Bind press A myLeft",
                        "true # Bind press D myRight",
                        "true # Bind up W stopWalk",
                        "true # Bind up S stopWalk"
                    }},
                    {12, new string[]
                    {
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
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

                    // set NoDefault for start scripts
                    sub.set_no_default_cb(is_NoDefault[k]);

                    foreach (string s in dic[k])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);

                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static[q]);

                        ++q;
                    }
                    ++k;
                }
                /////////////////////////////////////////
                ListBox list1 = new ListBox();
                string[] items1 =
                {
                    "default"
                };
                Dictionary<int, string[]> dic3 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Default",
                        "KeyDownH",
                        "KeyPressH",
                        "KeyUpH",
                        "KTab",
                        "Skill0",
                        "XS",
                        "CS",
                        "VS",
                        "myWalk",
                        "myBack",
                        "myLeft",
                        "myRight",
                        "myJump",
                        "stopWalk",
                        "SpeedUp",
                        "SpeedDown"
                    }}
                };
                bool[] is_static2 =
                {
                    false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
                };
                Dictionary<int, string[]> dic4 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 使用預設檔案",
                        "true # Bind down H KeyDownH +",
                        "true # Bind press H KeyPressH +",
                        "true # Bind up H KeyUpH +",
                        "true # Bind down Tab KTab +",
                        "true # Bind down Z Skill0 +",
                        "true # Bind down X XS +",
                        "true # Bind down C CS +",
                        "true # Bind down V VS +",
                        "true # Bind down O OS +",
                        "true # Bind down Shift SpeedUp +",
                        "true # Bind up Shift SpeedDown +",
                        "true # Bind press W myWalk +",
                        "true # Bind press S myBack +",
                        "true # Bind press A myLeft +",
                        "true # Bind press D myRight +",
                        "true # Bind down A GasA +",
                        "true # Bind down B GasB +",
                        "true # Bind down C GasC +",
                        "true # Bind down D GasD +",
                        "true # Bind up W stopWalk +",
                        "true # Bind up S stopWalk",
                        "true # Bind down Space myJump +"
                    }},
                    {1, new string[]{
                        "true # Eval 0 to g2"
                    }},
                    {2, new string[]{
                        "true # Eval 1 + g2 to g2"
                    }},
                    {3, new string[]{
                        "true # Cast g2"
                    }},
                    {4, new string[]{
                        "true # NextOne"
                    }},
                    {5, new string[]{
                        "true # UseSkill 0"
                    }},
                    {6, new string[]{
                        "true # UseSkill 1"
                    }},
                    {7, new string[]{
                        "true # UseSkill 2"
                    }},
                    {8, new string[]{
                        "true # UseSkill 3"
                    }},
                    {9, new string[]{
                        "true # WalkForward"
                    }},
                    {10, new string[]{
                        "true # WalkBackward"
                    }},
                    {11, new string[]{
                        "true # WalkLeft"
                    }},
                    {12, new string[]{
                        "true # WalkRight"
                    }},
                    {13, new string[]{
                        "== l1 1 # Return",
                        "true # StopWalk",
                        "true # AddForce role 0,40000,0",
                        "true # SetVar private 1 1",
                        "true # Pause 1",
                        "true # SetVar private 1 0"
                    }},
                    {14, new string[]{
                        "true # StopWalk"
                    }},
                    {15, new string[]{
                        "true # Broadcast 加速！",
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 * 2 to l2",
                        "< l2 15 # SetSp 4 $speed l2"
                    }},
                    {16, new string[]{
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 / 2 to l2",
                        "true # Cast l2",
                        "true # SetSp 4 $speed l2"
                    }}
                };

                list1.Items.AddRange(items1);
                default_list.Items.Clear();
                default_list.Items.AddRange(list1.Items);

                int k1 = 0, q1 = 0, num1 = 7; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in default_list.Items)
                {
                    map.Add(i, new Script_form(num1));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic3[k1])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num1, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);
                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static2[q1]);
                        ++q1;
                    }
                    ++k1;
                }
                /////////////////////////////////////////
                ListBox list2 = new ListBox();
                string[] items2 =
                {
                    "trigger1", "trigger2","trigger10"
                };
                Dictionary<int, string[]> dic5 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Door", "NPC4"
                    }},
                    {1, new string[]{
                        "Monster", "Princess"
                    }},
                    {2, new string[]{
                        "King", "Statue"
                    }}
                };
                int[] ranges =
                {
                    4, 3, 2, 2, 4, 4
                };
                string[] hints =
                {
                    "傳送門", "村民", "昆圖庫塔卡提考特蘇瓦西拉松", "米婭莫拉蘇娜丹妮謝莉红", "國王", "傳送門"
                };
                Dictionary<int, string[]> dic6 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 傳送",
                        "true # LoadScene 10"
                    }},
                    {1, new string[]{
                        "true # PushTalk 喔!天啊!看天上那是什麼？ 村民 $7",
                        "true # PushTalk 看起來像是一條龍呢 勇者 $10",
                        "true # PushTalk 他的爪子是不是還抓著什麼? 村民 $7",
                        "true # PushTalk 嗯...看起來像是個女人... 勇者 $10",
                        "true # PushTalk 注意!注意! 傳令兵 $6",
                        "true # PushTalk 惡龍昆圖庫塔卡提考特蘇瓦西拉松抓走了公主米婭莫拉蘇娜丹妮謝莉红! 傳令兵 $6",
                        "true # PushTalk 國王急徵勇者前往營救! 傳令兵 $6",
                        "true # PushTalk 找到傳送門前往王都報到吧! 傳令兵 $6",
                        "true # PushTalk 太好了，輪到我達拉崩巴斑得貝迪卜多比鲁翁出場了! 勇者 $10",
                        "true # StartTalk"
                    }},
                    {2, new string[]{
                        "true # PushTalk 我是昆圖庫塔卡提考特蘇瓦西拉松 惡龍 dragon.jpg",
                        "true # PushTalk 再來一次 惡龍 dragon.jpg",
                        "true # PushTalk 昆圖庫塔卡提考特蘇瓦西拉松 惡龍 dragon.jpg",
                        "true # PushTalk 是不是昆特牌提琴烤蛋達蘇打馬拉松 勇者 $10",
                        "true # PushTalk 不對，是昆圖庫塔卡提考特蘇瓦西拉松 惡龍 dragon.jpg",
                        "true # PushTalk 於是，達拉崩巴斑得貝迪卜多比鲁翁，砍向 旁白 White.png",
                        "true # PushTalk 昆圖庫塔卡提考特蘇瓦西拉松 旁白 White.png",
                        "true # PushTalk 然後，昆圖庫塔卡提考特蘇瓦西拉松，咬了 旁白 White.png",
                        "true # PushTalk 達拉崩巴斑得貝迪卜多比鲁翁 旁白 White.png",
                        "true # PushTalk 最後，達拉崩巴斑得貝迪卜多比鲁翁，他戰勝了 旁白 White.png",
                        "true # PushTalk 昆圖庫塔卡提考特蘇瓦西拉松 旁白 White.png",
                        "true # PushTalk 救出了，公主米婭莫拉蘇娜丹妮謝莉红 旁白 White.png",
                        "true # StartTalk",
                        "true # Destroy 0"
                    }},
                    {3, new string[]{
                        "true # PushTalk 我是公主米婭莫拉蘇娜丹妮謝莉红 公主 princess.jpg",
                        "true # PushTalk 安安你好給虧嗎 公主 princess.jpg",
                        "true # StartTalk"
                    }},
                    {4, new string[]{
                        "true # PushTalk 我要帶上最好的劍 勇者 $10",
                        "true # PushTalk 翻過最高的山 勇者 $10",
                        "true # PushTalk 闖進最深的森林 勇者 $10",
                        "true # PushTalk 把公主帶回到面前 勇者 $10",
                        "true # PushTalk 朕非常高興，汝姓名為何 國王 king.jpg",
                        "true # PushTalk 陛下我叫達拉崩巴班得貝迪卜多比魯翁 勇者 $10",
                        "true # PushTalk 是不是達拉崩巴班得貝迪卜多比魯翁 國王 king.jpg",
                        "true # PushTalk 對對達拉崩巴班得貝迪卜多比魯翁 勇者 $10",
                        "true # PushTalk 本來按照歌詞你要慢慢打怪升級 國王 king.jpg",
                        "true # PushTalk 可是demo時間有限，你直接走傳送門吧-> 國王 king.jpg",
                        "true # StartTalk"
                    }},
                    {5, new string[]{
                        "true # Broadcast 傳送",
                        "true # LoadScene 2"
                    }}
                };

                list2.Items.AddRange(items2);
                trigger_list.Items.Clear();
                trigger_list.Items.AddRange(list2.Items);

                int k2 = 0, q2 = 0, num2 = 2; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in trigger_list.Items)
                {
                    map.Add(i, new Script_form(num2));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic5[k2])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num2, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic6[q2]);

                        // set trigger range and hint for a class in trigger
                        sub.get_sub_form().set_range_nud(ranges[q2]);
                        sub.get_sub_form().set_hint_tb(hints[q2]);

                        ++q2;
                    }
                    ++k2;
                }
                /*
               player_list.Items.Clear();
               object item = "player" as object;
               player_list.Items.Add(item);
               */
                map.Add(player_list.Items[0], new Setting_Form());
                ListBox player_events = ((Setting_Form)map[player_list.Items[0]]).event_list;
                player_events.Items.Clear();

                string[] player_items =
                {
                    "level 3 11 9",
                    "skill 0 4 9 6 21 3",
                    "skill 1 4 5 6 7 1",
                    "skill 2 8 9 10 21 2",
                    "learn 0 5 7 8",
                    "learn 1 20 21 22",
                    "learn 2 23 24",
                    "learnp 0 5 6",
                    "learnp 1 7 8 9",
                    "learnp 2 10 11 12",
                    "party 2 1 0",
                    "item 0,9 1,7 2,8",
                    "equip 2 3,7,11,15,19",
                    "unequip 1,3 4,3 6,3 8,3 10,3",
                    "modeq 1 name:聖獸庇護 text:戴上的那一剎那，你已經獲得聖獸的祝福。 rare:3",
                    "moditem 1 type:common name:醬油 text:家庭必備調味品。 amount:60",
                    "modskill 6 name:疾風迅雷 cost:0",
                    "modp 2 name:如火如荼 text:縮短你的靈核爆破需時",
                    "scene 1"
                };

                player_events.Items.AddRange(player_items);
                /////////////////////////////////////////////////////
            }
            else if (script_num == 3)
            {
                /////////////////////////////////////////
                ListBox list = new ListBox();
                string[] items =
                {
                    "start0", "start1"
                };
                bool[] is_NoDefault =
                {
                    true, false
                };
                Dictionary<int, string[]> dic = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "SceneStart"
                    }},
                    {1, new string[]{
                        "SceneStart", "DontMove", "CanMove", "KEsc"
                    }}
                };
                bool[] is_static =
                {
                    false, false, true, true, true
                };
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # ChangeText Caption 末日求生 reserve 255,255,0 0,120,B -1",
                        "true # ChangeText Start/Text 開始新遊戲 reserve 255,0,0 reserve -1",
                        "true # ChangeText Load/Text 繼續遊戲 reserve 0,0,255 reserve -1",
                        "true # ChangeText Quit/Text 離開遊戲 reserve 0,255,0 reserve -1",
                        "true # ChangeImage Back zombie.jfif reserve 255,255,255,1 -1",
                        "true # Virtual Slider at 0,0,0",
                        "true # ChBGMfrom so116"
                    }},
                    {1, new string[]{
                        "true # Rename role 0 求生者",
                        "true # SetVar public 99 0",
                        "true # ShowText ??? 1700,1000 0,255,0 1,48,B -1 as Place",
                        "true # ChBGMfrom so116",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Blackman in role 0,-10,10 as Zombie1",
                        "true # NPC Zombie in role 10,-10,0 as Zombie2",
                        "true # NPC Remy in role 0,-10,20 as Zombie3",
                        "true # NPC Azure in role 20,-10,-10 as Zombie4",
                        "true # NPC Mei in role 10,-10,10 as Zombie5",
                        "true # NPC White in role 5,-10,20 as Zombie6",
                        "true # Route Zombie1 0,0,0 10,0,0",
                        "true # Route Zombie2 0,0,0 0,0,20",
                        "true # Route Zombie3 0,0,0 5,0,0",
                        "true # Route Zombie5 0,0,0 0,0,-10",
                        "true # Route Zombie6 0,0,0 5,0,3",
                        "true # Create Rock in role 10,-10,10 as Rock",
                        "true # Create Rock2 in role 10,-10,20 as Rock2",
                        "true # Create Tree in role 10,-10,5 as Tree",
                        "true # Create Chest in role 15,-10,5 as Chest",
                        "true # Create Brickwall in role 20,-10,5 as Brickwall",
                        "true # Bind down Esc KEsc +"
                    }},
                    {2, new string[]{
                        "true # Bind press W null",
                        "true # Bind press S null",
                        "true # Bind press A null",
                        "true # Bind press D null",
                        "true # Bind up W null",
                        "true # Bind up S null"
                    }},
                    {3, new string[]{
                        "true # Bind press W myWalk",
                        "true # Bind press S myBack",
                        "true # Bind press A myLeft",
                        "true # Bind press D myRight",
                        "true # Bind up W stopWalk",
                        "true # Bind up S stopWalk"
                    }},
                    {4, new string[]
                    {
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
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
                    // set NoDefault for start scripts
                    sub.set_no_default_cb(is_NoDefault[k]);
                    foreach (string s in dic[k])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);
                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static[q]);
                        ++q;
                    }
                    ++k;
                }
                /////////////////////////////////////////
                ListBox list1 = new ListBox();
                string[] items1 =
                {
                    "default"
                };
                Dictionary<int, string[]> dic3 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Default",
                        "KeyDownH",
                        "KeyPressH",
                        "KeyUpH",
                        "KTab",
                        "Skill0",
                        "XS",
                        "CS",
                        "VS",
                        "myWalk",
                        "myBack",
                        "myLeft",
                        "myRight",
                        "myJump",
                        "stopWalk",
                        "SpeedUp",
                        "SpeedDown"
                    }}
                };
                bool[] is_static2 =
                {
                    false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
                };
                Dictionary<int, string[]> dic4 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 使用預設檔案",
                        "true # Bind down H KeyDownH +",
                        "true # Bind press H KeyPressH +",
                        "true # Bind up H KeyUpH +",
                        "true # Bind down Tab KTab +",
                        "true # Bind down Z Skill0 +",
                        "true # Bind down X XS +",
                        "true # Bind down C CS +",
                        "true # Bind down V VS +",
                        "true # Bind down O OS +",
                        "true # Bind down Shift SpeedUp +",
                        "true # Bind up Shift SpeedDown +",
                        "true # Bind press W myWalk +",
                        "true # Bind press S myBack +",
                        "true # Bind press A myLeft +",
                        "true # Bind press D myRight +",
                        "true # Bind down A GasA +",
                        "true # Bind down B GasB +",
                        "true # Bind down C GasC +",
                        "true # Bind down D GasD +",
                        "true # Bind up W stopWalk +",
                        "true # Bind up S stopWalk",
                        "true # Bind down Space myJump +"
                    }},
                    {1, new string[]{
                        "true # Eval 0 to g2"
                    }},
                    {2, new string[]{
                        "true # Eval 1 + g2 to g2"
                    }},
                    {3, new string[]{
                        "true # Cast g2"
                    }},
                    {4, new string[]{
                        "true # NextOne"
                    }},
                    {5, new string[]{
                        "true # UseSkill 0"
                    }},
                    {6, new string[]{
                        "true # UseSkill 1"
                    }},
                    {7, new string[]{
                        "true # UseSkill 2"
                    }},
                    {8, new string[]{
                        "true # UseSkill 3"
                    }},
                    {9, new string[]{
                        "true # WalkForward"
                    }},
                    {10, new string[]{
                        "true # WalkBackward"
                    }},
                    {11, new string[]{
                        "true # WalkLeft"
                    }},
                    {12, new string[]{
                        "true # WalkRight"
                    }},
                    {13, new string[]{
                        "== l1 1 # Return",
                        "true # StopWalk",
                        "true # AddForce role 0,40000,0",
                        "true # SetVar private 1 1",
                        "true # Pause 1",
                        "true # SetVar private 1 0"
                    }},
                    {14, new string[]{
                        "true # StopWalk"
                    }},
                    {15, new string[]{
                        "true # Broadcast 加速！",
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 * 2 to l2",
                        "< l2 15 # SetSp 4 $speed l2"
                    }},
                    {16, new string[]{
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 / 2 to l2",
                        "true # Cast l2",
                        "true # SetSp 4 $speed l2"
                    }}
                };

                list1.Items.AddRange(items1);
                default_list.Items.Clear();
                default_list.Items.AddRange(list1.Items);

                int k1 = 0, q1 = 0, num1 = 7; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in default_list.Items)
                {
                    map.Add(i, new Script_form(num1));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic3[k1])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num1, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);
                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static2[q1]);
                        ++q1;
                    }
                    ++k1;
                }
                /////////////////////////////////////////
                ListBox list2 = new ListBox();
                string[] items2 =
                {
                    "trigger1"
                };
                Dictionary<int, string[]> dic5 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Rock", "Rock2", "Tree1", "Chest", "Brickwall"
                    }}
                };
                int[] ranges =
                {
                    2, 2, 2, 2, 2
                };
                string[] hints =
                {
                    "石頭1", "石頭2", "木頭1", "寶箱1", "磚頭1"
                };
                Dictionary<int, string[]> dic6 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 正在採集石材",
                        "true # Trigger DontMove",
                        "true # Pause 3",
                        "true # Destroy 1",
                        "true # 採集完成",
                        "true # Restart CanMove"
                    }},
                    {1, new string[]{
                        "true # Broadcast 正在採集石材",
                        "true # Trigger DontMove",
                        "true # Pause 3",
                        "true # Destroy 1",
                        "true # 採集完成",
                        "true # Restart CanMove"
                    }},
                    {2, new string[]{
                        "true # Broadcast 正在採集木材",
                        "true # Trigger DontMove",
                        "true # Pause 4",
                        "true # Destroy 1",
                        "true # 採集完成",
                        "true # Restart CanMove"
                    }},
                    {3, new string[]{
                        "true # Broadcast 正在尋找物資",
                        "true # Trigger DontMove",
                        "true # Pause 7",
                        "true # Destroy 1",
                        "true # 採集完成",
                        "true # Restart CanMove"
                    }},
                    {4, new string[]{
                        "true # Broadcast 正在採集磚塊",
                        "true # Trigger DontMove",
                        "true # Pause 6",
                        "true # Destroy 1",
                        "true # 採集完成",
                        "true # Restart CanMove"
                    }}
                };

                list2.Items.AddRange(items2);
                trigger_list.Items.Clear();
                trigger_list.Items.AddRange(list2.Items);

                int k2 = 0, q2 = 0, num2 = 2; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in trigger_list.Items)
                {
                    map.Add(i, new Script_form(num2));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic5[k2])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num2, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic6[q2]);
                        // set trigger range and hint for a class in trigger
                        sub.get_sub_form().set_range_nud(ranges[q2]);
                        sub.get_sub_form().set_hint_tb(hints[q2]);
                        ++q2;
                    }
                    ++k2;
                }
                /////////////////////////////////////////////////////
                ListBox list3 = new ListBox();
                string[] items3 =
                {
                    "update1"
                };
                Dictionary<int, string[]> dic7 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Zombie1", "Zombie2", "Zombie3", "Zombie4", "Zombie5", "Zombie6"
                    }}
                };
                float[] freqs =
                {
                    1, 1, 1, 1, 1, 1
                };
                Dictionary<int, string[]> dic8 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }},
                    {1, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }},
                    {2, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }},
                    {3, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }},
                    {4, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }},
                    {5, new string[]{
                        "found 1 # Broadcast 您被感染，遊戲結束",
                        "as # Pause 1",
                        "as # Damage 10000"
                    }}
                };

                list3.Items.AddRange(items3);
                update_list.Items.Clear();
                update_list.Items.AddRange(list3.Items);

                int k3 = 0, q3 = 0, num3 = 4; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in update_list.Items)
                {
                    map.Add(i, new Script_form(num3));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic7[k3])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num3, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic8[q3]);

                        // set update freqence for a class in update
                        sub.get_sub_form().set_freq_tb(freqs[q3]);

                        ++q3;
                    }
                    ++k3;
                }
                /*
               player_list.Items.Clear();
               object item = "player" as object;
               player_list.Items.Add(item);
               */
                map.Add(player_list.Items[0], new Setting_Form());
                ListBox player_events = ((Setting_Form)map[player_list.Items[0]]).event_list;
                player_events.Items.Clear();

                string[] player_items =
                {
                    "level 3 11 9",
                    "skill 0 4 9 6 21 3",
                    "skill 1 4 5 6 7 1",
                    "skill 2 8 9 10 21 2",
                    "learn 0 5 7 8",
                    "learn 1 20 21 22",
                    "learn 2 23 24",
                    "learnp 0 5 6",
                    "learnp 1 7 8 9",
                    "learnp 2 10 11 12",
                    "party 2 1 0",
                    "item 0,9 1,7 2,8",
                    "equip 2 3,7,11,15,19",
                    "unequip 1,3 4,3 6,3 8,3 10,3",
                    "modeq 1 name:聖獸庇護 text:戴上的那一剎那，你已經獲得聖獸的祝福。 rare:3",
                    "moditem 1 type:common name:醬油 text:家庭必備調味品。 amount:60",
                    "modskill 6 name:疾風迅雷 cost:0",
                    "modp 2 name:如火如荼 text:縮短你的靈核爆破需時",
                    "scene 1"
                };

                player_events.Items.AddRange(player_items);
                /////////////////////////////////////////////////////
            }
            else if (script_num == 4)
            {
                /////////////////////////////////////////
                ListBox list = new ListBox();
                string[] items =
                {
                    "start0", "start1"
                };
                bool[] is_NoDefault =
                {
                    true, false
                };
                Dictionary<int, string[]> dic = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "SceneStart"
                    }},
                    {1, new string[]{
                        "SceneStart", "OS", "AddMoney", "AddRate", "DontMove", "CanMove", "Translate",
                        "GasA", "GasB", "GasC", "GasD", "K0", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9",
                        "KEnter", "KEsc"
                    }}
                };
                bool[] is_static =
                {
                    false, false, true, true, true, true, true, true, true, true, true, true,
                    true, true, true, true, true, true, true, true, true, true, true, true
                };
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # ChangeText Caption 征服宇宙大作戰 reserve 255,255,0 0,120,B -1",
                        "true # ChangeText Start/Text 準備發財 reserve 255,0,0 reserve -1",
                        "true # ChangeText Load/Text 繼續作夢 reserve 0,0,255 reserve -1",
                        "true # ChangeText Quit/Text 不敢作夢 reserve 0,255,0 reserve -1",
                        "true # ShowText 高雄發大財！ 1700,900 0,255,0 1,48,B -1 as FaChai",
                        "true # ShowImageFrom FaChai.jpg 250,250,500,500 -1 as FaDaChai",
                        "true # ChangeImage Back universe.jpg reserve 255,255,255,1 -1",
                        "true # Virtual Slider at 0,0,0",
                        "true # ChBGMfrom Kao"
                    }},
                    {1, new string[]{
                        "true # SetVar public 99 0",
                        "true # ShowText 高雄市 1700,1000 0,255,0 1,48,B -1 as Place",
                        "true # ChBGMfrom Kao",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual AddMoney at 0,0,0",
                        "true # Virtual AddRate at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Blackman in role 0,-10,0 as People",
                        "true # NPC Zombie at 419.7,1.53,253.7 as Reporter",
                        "true # NPC Azure at 428.7,1.53,309 as Dachen",
                        "true # NPC White at 435.7,1.53,315 as Hen",
                        "true # NPC Mei at 430.7,1.53,255 as Zuki",
                        "true # NPC RedHood at 440.7,1.53,255 as Ano",
                        "true # Route People 0,0,0 0,0,3",
                        "true # ShowText __ 1500,900 0,255,0 0,48,B -1 as gameTime",
                        "true # Create Rock at 432,0,299 as Gasoline",
                        "true # Create Bucket at 428,1,305 as River",
                        "true # Create Door at 424,0,341 as Door",
                        "true # Light River 0,174,35 0,7 2 point",
                        "true # Bind down 0 K0 +",
                        "true # Bind down 1 K1 +",
                        "true # Bind down 2 K2 +",
                        "true # Bind down 3 K3 +",
                        "true # Bind down 0 K4 +",
                        "true # Bind down 1 K5 +",
                        "true # Bind down 2 K6 +",
                        "true # Bind down 3 K7 +",
                        "true # Bind down 0 K8 +",
                        "true # Bind down 1 K9 +",
                        "true # Bind down Esc KEsc +",
                        "true # Bind down Enter KEnter +"
                    }},
                    {2, new string[]{
                        "true # GetSp l3 $x",
                        "true # DefineStr 3 ( $l3",
                        "true # GetSp l3 $y",
                        "true # DefineStr 3 $str3 , $l3",
                        "true # GetSp l3 $z",
                        "true # DefineStr 3 $str3 , $l3 )",
                        "true # ChangeText gameTime $3 1500,900 1,255,0 0,48,B -1"
                    }},
                    {3, new string[]{
                        "true # DefineStr 3 發財金： $g3 萬元",
                        "true # ChangeText Money $3 1600,800 255,255,0 1,48,B -1"
                    }},
                    {4, new string[]{
                        "true # DefineStr 3 民調： $g4 %",
                        "true # ChangeText Rate $3 reserve 0,255,255 1,48,B -1"
                    }},
                    {5, new string[]{
                        "true # Bind press W null",
                        "true # Bind press S null",
                        "true # Bind press A null",
                        "true # Bind press D null",
                        "true # Bind up W null",
                        "true # Bind up S null"
                    }},
                    {6, new string[]{
                        "true # Bind press W myWalk",
                        "true # Bind press S myBack",
                        "true # Bind press A myLeft",
                        "true # Bind press D myRight",
                        "true # Bind up W stopWalk",
                        "true # Bind up S stopWalk"
                    }},
                    {7, new string[]{
                        "== g10 1 Return",
                        "true # ShowText 翻譯結果：替含總募集1億的發財金，含總才能被黨徵召。 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # Pause 3",
                        "true # ChangeText Msg 高雄發大財，台灣發大財！！！ 900,900 0,255,255 1,48,B 3",
                        "true # Pause 2",
                        "true # ShowText 發財金：0元 1700,800 255,255,0 1,48,B -1 as Money",
                        "true # ShowText 民調：60% 1700,700 0,255,255 1,48,B -1 as Rate",
                        "true # SetVar public 4 60",
                        "true # SetVar public 0 2",
                        "true # SetVar public 10 0",
                        "true # Destroy 0"
                    }},
                    {8, new string[]{
                        "== g99 1 # Goto event1",
                        "== g99 2 # Goto event2",
                        "== g99 3 # Goto event3",
                        "== g99 4 # Goto event4",
                        "true # Return",
                        "event1:",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg 由於用力過猛，你把手弄傷了。 900,900 0,255,255 1,48,B 3",
                        "true # Damage 100",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event2:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 這水好喝到一個讓人啞口無言的境界了！ 孫小千 $7",
                        "true # PushTalk 下個月再來吧，現在水已經被含粉搶光了。 孫小千 $7",
                        "true # StartTalk",
                        "true # ChangeText Msg 市民感到幸福，含總民調上升！ 900,900 0,255,255 1,48,B 2",
                        "true # Eval + g4 + 5 to g4",
                        "true # Restart AddRate",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event3:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 我已經感受到你的心意了！不是為了個人，而是整個高雄市民。 經紀人 $9",
                        "true # PushTalk 我回去就更改子棋的行程！。 經紀人 $9",
                        "true # StartTalk",
                        "true # ChangeText Msg 凳子棋代言高雄，帶來了龐大商機！ 900,900 0,255,255 1,48,B -1",
                        "true # Pause 2",
                        "true # ChangeText Msg 獲得發財金2000萬元！ 900,900 0,255,255 1,48,B 2",
                        "true # Eval + g3 + 2000 to g3",
                        "true # Restart AddMoney",
                        "true # SetVar public 10 0",
                        "true # SetVar public 14 2",
                        "true # Restart CanMove",
                        "true # Return",
                        "event4:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 高雄是港埠型都市，商業機能非常發達。 席韓娥 $10",
                        "true # PushTalk 阿No來這裡將能引發另一波經濟奇蹟。 席韓娥 $10",
                        "true # PushTalk 但我聽說的好像不是這樣。 經紀人 $9",
                        "true # PushTalk 新市長上任之後，這裡已經轉型成農業都市了。 經紀人 $9",
                        "true # PushTalk 這聽起來並不會很吸引阿No。 經紀人 $9",
                        "true # StartTalk",
                        "true # ChangeText Msg $0 900,900 0,255,255 1,48,B 2",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return"
                    }},
                    {9, new string[]{
                        "== g99 1 # Goto event1",
                        "== g99 2 # Goto event2",
                        "== g99 3 # Goto event3",
                        "== g99 4 # Goto event4",
                        "true # Return",
                        "event1:",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg 由於你破壞市容，含總的民調下降了。 900,900 0,255,255 1,48,B 3",
                        "true # Eval + g4 - 5 to g4",
                        "true # Restart AddRate",
                        "true # SetVar public 10 0",
                        "true # SetVar public 11 1",
                        "true # Restart CanMove",
                        "true # Return",
                        "event2:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 有一種甘甘的味道。 席韓娥 $10",
                        "true # PushTalk 真的是含流發威！才短短幾個月，這水質就變得如此清甜。 孫小千 $7",
                        "true # PushTalk 這筆用來治水的追加經費用不到了。你拿去用在更好的地方吧。 孫小千 $7",
                        "true # StarTalk",
                        "true # ChangeText Msg 獲得發財金2000萬元！ 900,900 0,255,255 1,48,B -1",
                        "true # Eval + g3 2000 to g3",
                        "true # Restart AddMoney",
                        "true # Pause 3",
                        "true # ChangeText Msg 含總治水有成，民調大幅提升！ 900,900 0,255,255 1,48,B 3",
                        "true # Eval + g4 + 10 to g4",
                        "true # Restart AddRate",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event3:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 子棋被你弄哭了，看你要怎麼辦！ 經紀人 $9",
                        "true # StartTalk",
                        "true # ChangeText Msg 子棋與經紀公司解約，引起輿論譁然！ 900,900 0,255,255 1,48,B -1",
                        "true # Pause 2",
                        "true # ChangeText Msg 外界批評聲浪不斷，含總民調下降！ 900,900 0,255,255 1,48,B 2",
                        "true # Eval + g4 - 5 to g4",
                        "true # Restart AddRate",
                        "true # SetVar public 10 0",
                        "true # SetVar public 14 1",
                        "true # Restart CanMove",
                        "true # Return",
                        "event4:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 高雄發大財！ 席韓娥 $10",
                        "true # PushTalk 原來如此，這項計畫不僅能替阿No帶來利益，還能讓市民發財嗎？ 經紀人 $9",
                        "true # PushTalk 阿No也有當市長的經驗，是能苦民所苦的。 經紀人 $9",
                        "true # PushTalk 知道了，我會盡快知會阿No。 經紀人 $9",
                        "true # StartTalk",
                        "true # ChangeText Msg 阿No代言高雄，帶來了龐大商機！ 900,900 0,255,255 1,48,B -1",
                        "true # Pause 2",
                        "true # ChangeText Msg 獲得發財金2000萬元！ 900,900 0,255,255 1,48,B 2",
                        "true # Eval + g3 + 2000 to g3",
                        "true # Restart AddMoney",
                        "true # SetVar public 10 0",
                        "true # SetVar public 16 1",
                        "true # Restart CanMove",
                        "true # Return"
                    }},
                    {10, new string[]{
                        "== g99 1 # Goto event1",
                        "== g99 2 # Goto event2",
                        "== g99 3 # Goto event3",
                        "== g99 4 # Goto event4",
                        "true # Return",
                        "event1:",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg $0 900,900 0,255,255 1,48,B 1",
                        "true # PushTalk 真可惜。如果真的沒東西也沒辦法了。 席韓娥 $10",
                        "true # Restart CanMove",
                        "true # StartTalk",
                        "true # SetVar public 10 0",
                        "true # Return",
                        "event2:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 你竟敢這樣說，一定是假含粉！ 孫小千 $7",
                        "true # PushTalk 等著被含粉出征吧！ 孫小千 $7",
                        "true # StartTalk",
                        "true # SpnParticle 9 in Role 0,0,0 0,90,0 3",
                        "true # Damage 200",
                        "true # ShowText 含粉大出征，高雄市陷入混亂！ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Pause 2",
                        "true # ShowText 含市長的民調因此下滑了！ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Eval + g4 - 5 to g4",
                        "true # Restart AddRate",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event3:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 那麼這個月，就決定是子棋免費替高雄代言了。 席韓娥 $10",
                        "true # PushTalk 所以請你至少說明一下這個合作案對雙方的利害為何？ 經紀人 $9",
                        "true # PushTalk 還要請子棋盡快和市府喬時間。 席韓娥 $10",
                        "true # StartTalk",
                        "true # ChangeText Msg 經紀人不再說話，只是給了你一個大大的白眼。 900,900 0,255,255 1,48,B 2",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event4:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 高雄是魅力四射的影城。 席韓娥 $10",
                        "true # PushTalk 在含總的念力下，每個人都生活得很開心。 席韓娥 $10",
                        "true # PushTalk 的確含先生導演的能力，連阿No也很佩服。 經紀人 $9",
                        "true # PushTalk 但他目前已經有另一項拍戲的計畫了。他可能會無法兼顧。 經紀人 $9",
                        "true # StartTalk",
                        "true # ChangeText Msg $0 900,900 0,255,255 1,48,B 2",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return"

                    }},
                    {11, new string[]{
                        "== g99 1 # Goto event1",
                        "== g99 2 # Goto event2",
                        "true # Return",
                        "Gas:",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg 你的誠心引發了奇蹟，大量石油泉湧而出！ 900,900 0,255,255 1,48,B 2",
                        "true # SetVar public 11 2",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "Two:",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg 什麼也沒發生。 900,900 0,255,255 1,48,B 3",
                        "true # PushTalk 不能放棄！只要相信高雄一定會發大財就行了！ 席韓娥 $10",
                        "true # StartTalk",
                        "true # Eval + l1 1 to l1",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event1:",
                        "== l1 4 # Goto Gas",
                        "== l1 2 # Goto Two",
                        "true # SetVar public 99 0",
                        "true # ChangeText Msg 什麼也沒發生。 900,900 0,255,255 1,48,B 3",
                        "true # PushTalk 難道是我的決心不夠？還是這是含黑的陰謀？ 席韓娥 $10",
                        "true # StartTalk",
                        "true # Eval + l1 1 to l1",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return",
                        "event2:",
                        "true # SetVar public 99 0",
                        "true # PushTalk 沒錯，讓高雄市民產生幸福感和光榮感，就是我們的使命。 孫小千 $7",
                        "true # StartTalk",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return"
                    }},
                    {12, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {13, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 1",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {14, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 2",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {15, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 3",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {16, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 4",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {17, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 5",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {18, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 6",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {19, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 7",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {20, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 8",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {21, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str5 9",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
                    }},
                    {22, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Return",
                        "event1:",
                        "true # ChangeText Msg $0 900,900 0,255,255 1,48,B -1",
                        "Str== $5 1124 # Goto Right # Goto Wrong",
                        "Right:",
                        "true # PushTalk 今天是11月24日。 席韓娥 $10",
                        "true # PushTalk 所有人都說11月24號已經過了。但只有你肯說真話。 釘手中 $0",
                        "true # PushTalk 在我當台北市長的任內，希望能和含市長維持友好關係。 釘手中 $0",
                        "true # StartTalk",
                        "true # SetVar public 17 1",
                        "true # ChangeText Msg 釘手中贊助高雄市 900,900 0,255,255 1,48,B -1",
                        "true # Pause 2",
                        "true # ChangeText Msg 獲得發財金3000萬元！ 900,900 0,255,255 1,48,B 2",
                        "true # Eval + g3 + 3000 to g3",
                        "true # Restart AddMoney",
                        "true # Goto over",
                        "Wrong:",
                        "true # PushTalk 這就是今天的日期。 席韓娥 $10",
                        "true # PushTalk 你竟敢明目張膽的騙人！今天明明就是11月24！ 釘手中 $0",
                        "true # PushTalk 我不理你們這些玩弄小人步數的傢伙了！ 釘手中 $0",
                        "true # StartTalk",
                        "true # SetVar public 17 2",
                        "true # ChangeText Msg 釘手中生氣了，雖然好像不會怎樣... 900,900 0,255,255 1,48,B 2",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 99 0",
                        "true # SetVar public 10 0",
                        "true # Restart CanMove",
                        "true # Return"
                    }},
                    {23, new string[]{
                        "== g99 5 # Goto event1",
                        "true # Menu",
                        "true # Return",
                        "event1:",
                        "true # DefineStr 5 $str0",
                        "true # ChangeText Msg $5 900,900 0,255,255 1,48,B -1",
                        "true # Return"
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
                    // set NoDefault for start scripts
                    sub.set_no_default_cb(is_NoDefault[k]);
                    foreach (string s in dic[k])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);
                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static[q]);
                        ++q;
                    }
                    ++k;
                }
                /////////////////////////////////////////
                ListBox list1 = new ListBox();
                string[] items1 =
                {
                    "default"
                };
                Dictionary<int, string[]> dic3 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "Default",
                        "KeyDownH",
                        "KeyPressH",
                        "KeyUpH",
                        "KTab",
                        "Skill0",
                        "XS",
                        "CS",
                        "VS",
                        "myWalk",
                        "myBack",
                        "myLeft",
                        "myRight",
                        "myJump",
                        "stopWalk",
                        "SpeedUp",
                        "SpeedDown"
                    }}
                };
                bool[] is_static2 =
                {
                    false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
                };
                Dictionary<int, string[]> dic4 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 使用預設檔案",
                        "true # Bind down H KeyDownH +",
                        "true # Bind press H KeyPressH +",
                        "true # Bind up H KeyUpH +",
                        "true # Bind down Tab KTab +",
                        "true # Bind down Z Skill0 +",
                        "true # Bind down X XS +",
                        "true # Bind down C CS +",
                        "true # Bind down V VS +",
                        "true # Bind down O OS +",
                        "true # Bind down Shift SpeedUp +",
                        "true # Bind up Shift SpeedDown +",
                        "true # Bind press W myWalk +",
                        "true # Bind press S myBack +",
                        "true # Bind press A myLeft +",
                        "true # Bind press D myRight +",
                        "true # Bind down A GasA +",
                        "true # Bind down B GasB +",
                        "true # Bind down C GasC +",
                        "true # Bind down D GasD +",
                        "true # Bind up W stopWalk +",
                        "true # Bind up S stopWalk",
                        "true # Bind down Space myJump +"
                    }},
                    {1, new string[]{
                        "true # Eval 0 to g2"
                    }},
                    {2, new string[]{
                        "true # Eval 1 + g2 to g2"
                    }},
                    {3, new string[]{
                        "true # Cast g2"
                    }},
                    {4, new string[]{
                        "true # NextOne"
                    }},
                    {5, new string[]{
                        "true # UseSkill 0"
                    }},
                    {6, new string[]{
                        "true # UseSkill 1"
                    }},
                    {7, new string[]{
                        "true # UseSkill 2"
                    }},
                    {8, new string[]{
                        "true # UseSkill 3"
                    }},
                    {9, new string[]{
                        "true # WalkForward"
                    }},
                    {10, new string[]{
                        "true # WalkBackward"
                    }},
                    {11, new string[]{
                        "true # WalkLeft"
                    }},
                    {12, new string[]{
                        "true # WalkRight"
                    }},
                    {13, new string[]{
                        "== l1 1 # Return",
                        "true # StopWalk",
                        "true # AddForce role 0,40000,0",
                        "true # SetVar private 1 1",
                        "true # Pause 1",
                        "true # SetVar private 1 0"
                    }},
                    {14, new string[]{
                        "true # StopWalk"
                    }},
                    {15, new string[]{
                        "true # Broadcast 加速！",
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 * 2 to l2",
                        "< l2 15 # SetSp 4 $speed l2"
                    }},
                    {16, new string[]{
                        "true # GetSp l2 $speed 4",
                        "true # Eval + l2 / 2 to l2",
                        "true # Cast l2",
                        "true # SetSp 4 $speed l2"
                    }}
                };

                list1.Items.AddRange(items1);
                default_list.Items.Clear();
                default_list.Items.AddRange(list1.Items);

                int k1 = 0, q1 = 0, num1 = 7; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in default_list.Items)
                {
                    map.Add(i, new Script_form(num1));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic3[k1])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num1, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);
                        // set static for a start class
                        sub.get_sub_form().set_static_cb(is_static2[q1]);
                        ++q1;
                    }
                    ++k1;
                }
                /////////////////////////////////////////
                ListBox list2 = new ListBox();
                string[] items2 =
                {
                    "trigger1"
                };
                Dictionary<int, string[]> dic5 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "People", "Peporter", "Hen", "Ano", "Door", "Zuki", "River", "Dachen", "Gasoline"
                    }}
                };
                int[] ranges =
                {
                    2, 2, 2, 2, 2, 2, 2, 2, 2
                };
                string[] hints =
                {
                    "財神市長", "寒天記者", "潘橫旭", "阿No經紀人", "與釘手中交談",
                    "凳子棋經紀人", "試喝", "孫小千", "調查岩石"
                };
                Dictionary<int, string[]> dic6 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "== g0 0 # Goto start",
                        "== g0 1 # Goto hate",
                        "== g0 2 # Goto normal",
                        "true # Goto over",
                        "normal:",
                        "true # SetRandom private 0 0,2",
                        "== l0 1 # PushTalk 高雄發大財！ 難含魚 Han.jpg # PushTalk 只有台灣好，高雄才會真正好起來！ 難含魚 Han.jpg",
                        "true # StartTalk",
                        "true # Goto over",
                        "start:",
                        "true # PushTalk 含總，您需要我幫您做什麼嗎？ 席韓娥 $10",
                        "true # PushTalk 高雄發大財！ 難含魚 Han.jpg",
                        "true # PushTalk 高雄發大財！ 難含魚 Han.jpg",
                        "true # PushTalk 總之我們的目標就是高雄發大財！ 難含魚 Han.jpg",
                        "true # StartTalk",
                        "true # Broadcast 按下T鍵來翻譯含總的話",
                        "true # Bind down T Translate +",
                        "true # SetVar public 0 1",
                        "true # Goto over",
                        "hate:",
                        "true # PushTalk 總之就是要發財，你們這些小牙籤不要一直戳。 難含魚 Han.jpg",
                        "true # StartTalk",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {1, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "and == g0 2 ; == l1 0 ; # Goto normal # Goto start",
                        "start:",
                        "true # PushTalk 我們正在準備明天要播放的24小時含市長的新聞。 寒天記者 $7",
                        "true # PushTalk 沒事的話就一邊去！ 寒天記者 $7",
                        "true # StartTalk",
                        "true # Goto over",
                        "normal:",
                        "true # SetVar private 1 1",
                        "true # PushTalk 我們的節目一直收視長紅，榮登綜藝節目冠軍。 寒天記者 $7",
                        "true # PushTalk 這些是營收的營餘，你就替含總收著吧。 寒天記者 $7",
                        "true # StartTalk",
                        "true # ShowText 獲得發財金一千萬元！ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Eval + g3 1000 to g3",
                        "true # Restart AddMoney",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {2, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "or == g14 2 | == g16 1 | # Goto success",
                        "and == g0 2 ; == l1 1 ; # Goto normal # Goto start",
                        "start:",
                        "true # PushTalk 局長，這個月要請阿No和子棋來代言是真的嗎？ 席韓娥 $10",
                        "true # PushTalk 是的，我們已經決定讓他們免費代言高雄了。 潘橫旭 $8",
                        "true # PushTalk 雖然經紀人還沒有答應，但我相信本人並沒有那麼貪財。 潘橫旭 $8",
                        "true # StartTalk",
                        "true # SetVar private 1 1",
                        "true # Goto over",
                        "normal:",
                        "true # PushTalk 可以的話可以幫我聯絡他們的經紀人嗎？ 潘橫旭 $8",
                        "true # PushTalk 光是接洽貓熊就忙不過來了。 潘橫旭 $8",
                        "true # PushTalk 我知道了，一定會讓他們擔任高雄的代言人！ 席韓娥 $10",
                        "true # StartTalk",
                        "true # SetVar public 15 1",
                        "true # Goto over",
                        "success:",
                        "true # PushTalk 辛苦你了。含總一定會很高興。 潘橫旭 $8",
                        "true # StartTalk",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {3, new string[]{
                        "== g10 1 # Return",
                        "== g16 1 # Goto success",
                        "== g15 1 # Goto normal",
                        "true # Goto start",
                        "start:",
                        "true # PushTalk 阿No這個月什麼時候要來高雄？ 席韓娥 $10",
                        "true # PushTalk 很抱歉，我們不知道有這個計畫。 經紀人 $6",
                        "true # StartTalk",
                        "true # Goto over",
                        "normal:",
                        "true # PushTalk 阿No這個月可以...？ 席韓娥 $10",
                        "true # PushTalk 我知道你的意思。所以可以不必再說了。 經紀人 $6",
                        "true # PushTalk 高雄有什麼特別的，值得阿No騰出時間？ 經紀人 $6",
                        "true # StartTalk",
                        "true # ShowText 高雄是... 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Restart DontMove",
                        "true # Pause 2",
                        "true # DefineStr 2 (A)商業繁榮的大都會區__ (B)高雄發大財__ (C)魅力四射的影城__",
                        "true # ShowText $2 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # SetVar public 99 4",
                        "true # Goto over",
                        "success:",
                        "true # PushTalk 剛才已經和阿No確定了，他下星期就能來高雄。 經紀人 $6",
                        "true # StartTalk",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {4, new string[]{
                        "== g10 1 # Return",
                        "== g17 1 # Goto success",
                        "== g17 2 # Goto fail",
                        "true # SetVar public 10 1",
                        "== g0 2 # Goto normal",
                        "true # Goto start",
                        "start:",
                        "true # PushTalk 目前正要北上前往投票所投票，謝絕訪客。 釘手中 $0",
                        "true # StartTalk",
                        "true # Goto over",
                        "normal:",
                        "true # SetVar private 1 1",
                        "true # PushTalk 哎呀？今天幾月幾號了？ 釘手中 $0",
                        "true # StartTalk",
                        "true # ShowText 怎麼回答？ 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # Restart DontMove",
                        "true # SetVar public 99 5",
                        "true # Goto over",
                        "fail:",
                        "true # PushTalk 該請含市長管管你們這些假含粉了！ 釘手中 $0",
                        "true # StartTalk",
                        "true # Goto over",
                        "success:",
                        "true # PushTalk 接下來還要忙著就職典禮，但還是歡迎含市長來交流。 釘手中 $0",
                        "true # StartTalk",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {5, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "== g14 1 # Goto fail",
                        "== g14 2 # Goto success",
                        "== g15 1 # Goto normal",
                        "true # Goto start",
                        "start:",
                        "true # PushTalk 子棋這個月要替高雄代言？ 席韓娥 $10",
                        "true # PushTalk 很抱歉，我們並沒有接到任何通知。 經紀人 $9",
                        "true # StartTalk",
                        "true # Goto over",
                        "normal:",
                        "true # SetVar private 1 1",
                        "true # PushTalk 子棋擔任這個月高雄的代言人可以嗎？ 席韓娥 $10",
                        "true # PushTalk 這麼這麼突然？這個月都過一半了。 經紀人 $9",
                        "true # PushTalk 你們願意不收取任何費用，真是太感謝了！ 席韓娥 $10",
                        "true # PushTalk 誰說可以的。你必須說服我！ 經紀人 $9",
                        "true # StartTalk",
                        "true # ShowText 怎麼回答？ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Restart DontMove",
                        "true # Pause 2",
                        "true # DefineStr 2 (A)高雄發大財__ (B)本人應沒有那麼貪財__ (C)跳針",
                        "true # ShowText $2 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # SetVar public 99 3",
                        "true # Goto over",
                        "fail:",
                        "true # PushTalk 子棋已經和我們解約了，別再來煩了！ 經紀人 $9",
                        "true # StartTalk",
                        "success:",
                        "true # PushTalk 如果可以的話，下個月子棋也可以繼續代言喔！ 經紀人 $9",
                        "true # StartTalk",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {6, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "== g13 0 # Goto start",
                        "== g13 1 # Goto drink",
                        "true # Goto over",
                        "start:",
                        "true # PushTalk 這水看起來好髒，我才不要碰。 席韓娥 $10",
                        "true # StartTalk",
                        "true # Goto over",
                        "drink:",
                        "true # Disable River Light",
                        "true # ShowText 你喝了一大口，感到了些微的異樣感。 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # PushTalk 怎麼樣？愛河的水很優質吧！ 孫小千 $7",
                        "true # SetVar public 13 2",
                        "true # StartTalk",
                        "true # ShowText 怎麼回答？ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Restart DontMove",
                        "true # Pause 2",
                        "true # DefineStr 2 (A)不予置評__ (B)甘甘__ (C)這水有毒__ (D)高雄發大財",
                        "true # ShowText $2 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # SetVar public 10 1",
                        "true # SetVar public 99 2",
                        "true # Return",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {7, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "and == g0 2 ; == g13 0 ; # Goto drink",
                        "and == g0 2 ; == g13 1 ; # Goto annoy",
                        "true # Goto start",
                        "start:",
                        "true # PushTalk 貨出得去，人進得來，高雄發大財！ 孫小千 $7",
                        "true # StartTalk",
                        "true # Goto over",
                        "drink:",
                        "true # PushTalk 這是我們新採樣的愛河的水。你要不要評價一下？ 孫小千 $7",
                        "true # PushTalk 太好了！我受寵若驚。 席韓娥 $10",
                        "true # SetVar public 13 1",
                        "true # StartTalk",
                        "true # Goto over",
                        "annoy:",
                        "true # PushTalk 你到底要不要試喝？還有很多含粉在排隊。 孫小千 $7",
                        "true # StartTalk",
                        "true # Goto over",
                        "over:",
                        "true # SetVar public 10 0"
                    }},
                    {8, new string[]{
                        "== g10 1 # Return",
                        "true # SetVar public 10 1",
                        "== g11 1 # Goto fail",
                        "== g11 2 # Goto success",
                        "and == g0 2 ; == l1 0 ; # Goto normal # Goto start",
                        "start:",
                        "true # PushTalk 這堆石頭放在這裡那麼久了，還沒辦法清乾淨。果真是前朝遺毒。 席韓娥 $10",
                        "true # PushTalk 別再磨蹭了。快去聆聽含市長的開示吧。 席韓娥 $10",
                        "true # StartTalk",
                        "true # Goto over",
                        "fail:",
                        "true # PushTalk 這塊石頭疑似卡含，即將被路平，請勿靠近。 都發局 $7",
                        "true # StartTalk",
                        "true # Goto over",
                        "success:",
                        "true # PushTalk 多麼漂亮的油田。這下子那些吉娃娃無話可說了。 席韓娥 $10",
                        "true # StartTalk",
                        "true # Goto over",
                        "normal:",
                        "true # PushTalk 咦，這微微滲出的蒸氣是... 席韓娥 $10",
                        "true # PushTalk 該不會這下面有什麼寶藏吧？ 席韓娥 $10",
                        "true # StartTalk",
                        "true # ShowText 現在怎麼辦？ 900,900 0,255,255 1,48,B 2 as Msg",
                        "true # Pause 2",
                        "true # DefineStr 2 (A)用手挖掘__ (B)拿小牙籤戳__ (C)放棄離開__ (D)高雄發大財",
                        "true # SetVar public 99 1",
                        "true # ShowText $2 900,900 0,255,255 1,48,B -1 as Msg",
                        "true # Restart DontMove",
                        "true # SetVar public 10 1",
                        "true # Return",
                        "over:",
                        "true # SetVar public 10 0"
                    }}
                };

                list2.Items.AddRange(items2);
                trigger_list.Items.Clear();
                trigger_list.Items.AddRange(list2.Items);

                int k2 = 0, q2 = 0, num2 = 2; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in trigger_list.Items)
                {
                    map.Add(i, new Script_form(num2));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic5[k2])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num2, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic6[q2]);
                        // set trigger range and hint for a class in trigger
                        sub.get_sub_form().set_range_nud(ranges[q2]);
                        sub.get_sub_form().set_hint_tb(hints[q2]);
                        ++q2;
                    }
                    ++k2;
                }
                /////////////////////////////////////////////////////
                ListBox list3 = new ListBox();
                string[] items3 =
                {
                    "update0"
                };
                Dictionary<int, string[]> dic7 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "SceneStart", "Slider"
                    }}
                };
                float[] freqs =
                {
                    2, 0.3f
                };
                Dictionary<int, string[]> dic8 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "== l1 1 # ChangeText Caption 征服宇宙大作戰 reserve 255,255,0 0,120,B -1 # ChangeText Caption 征服宇宙大作戰 reserve 255,0,0 0,120,B -1",
                        "as # SetVar private 1 0 # SetVar private 1 1"
                    }},
                    {1, new string[]{
                        "true # Eval + l2 30 to l2",
                        "> l2 1900 # SetVar private 2 0",
                        "true # ChangeText FaChai 高雄發大財！ l2,900 0,255,0 1,48,B -1"
                    }}
                };

                list3.Items.AddRange(items3);
                update_list.Items.Clear();
                update_list.Items.AddRange(list3.Items);

                int k3 = 0, q3 = 0, num3 = 4; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in update_list.Items)
                {
                    map.Add(i, new Script_form(num3));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic7[k3])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num3, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic8[q3]);
                        // set update freqence for a class in update
                        sub.get_sub_form().set_freq_tb(freqs[q3]);
                        ++q3;
                    }
                    ++k3;
                }
                /////////////////////////////////////////////////////
                ListBox list4 = new ListBox();
                string[] items4 =
                {
                    "destroy1"
                };
                Dictionary<int, string[]> dic9 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "GreenBear"
                    }}
                };
                Dictionary<int, string[]> dic10 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # Broadcast 國家感謝您的協助。"
                    }}
                };

                list4.Items.AddRange(items4);
                destroy_list.Items.Clear();
                destroy_list.Items.AddRange(list4.Items);

                int k4 = 0, q4 = 0, num4 = 3; // start=1, trigger 2, destroy 3, update 4, player 5, default 7

                foreach (object i in destroy_list.Items)
                {
                    map.Add(i, new Script_form(num4));
                    Script_form sub = (Script_form)map[i];
                    foreach (string s in dic9[k4])
                    {
                        object obj = s as object;
                        sub.class_list.Items.Add(obj);
                        sub.class_list_ItemAdded(num4, obj);
                        sub.get_sub_form().event_list.Items.AddRange(dic10[q4]);
                        ++q4;
                    }
                    ++k4;
                }
                /*
               player_list.Items.Clear();
               object item = "player" as object;
               player_list.Items.Add(item);
               */
                map.Add(player_list.Items[0], new Setting_Form());
                ListBox player_events = ((Setting_Form)map[player_list.Items[0]]).event_list;
                player_events.Items.Clear();

                string[] player_items =
                {
                    "level 3 11 9",
                    "skill 0 4 9 6 21 3",
                    "skill 1 4 5 6 7 1",
                    "skill 2 8 9 10 21 2",
                    "learn 0 5 7 8",
                    "learn 1 20 21 22",
                    "learn 2 23 24",
                    "learnp 0 5 6",
                    "learnp 1 7 8 9",
                    "learnp 2 10 11 12",
                    "party 2 1 0",
                    "item 0,9 1,7 2,8",
                    "equip 2 3,7,11,15,19",
                    "unequip 1,3 4,3 6,3 8,3 10,3",
                    "modeq 1 name:聖獸庇護 text:戴上的那一剎那，你已經獲得聖獸的祝福。 rare:3",
                    "moditem 1 type:common name:醬油 text:家庭必備調味品。 amount:60",
                    "modskill 6 name:疾風迅雷 cost:0",
                    "modp 2 name:如火如荼 text:縮短你的靈核爆破需時",
                    "scene 1"
                };

                player_events.Items.AddRange(player_items);
                /////////////////////////////////////////////////////
            }
        }

        private void output_file_btn_Click(object sender, EventArgs e)
        {                         
            string path = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();                
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "資料夾路徑不能為空", "提示");
                    return;
                }
                path = dialog.SelectedPath;
            }
            TabControl.TabPageCollection pages = tabControl1.TabPages;
            foreach (TabPage page in pages)
            {
                if (page.Name == "Player") continue;
                ListBox list = page.Controls[0] as ListBox;
                foreach (object obj in list.Items)
                {
                    string scriptName = obj.ToString();
                    try
                    {
                        FileInfo finfo = new FileInfo(path + "/" + scriptName + ".auto");
                        StreamWriter sw = finfo.CreateText();
                        if (scriptName == "player")
                        {
                            Setting_Form setting_form = (Setting_Form)map[obj];                       
                            foreach (object line in setting_form.event_list.Items)
                            {
                                sw.WriteLine(line.ToString());
                                sw.Flush();
                            }
                            sw.Close();
                        }
                        else
                        {
                            Script_form script_form = (Script_form)map[obj];                            
                            foreach (object cls in script_form.class_list.Items)
                            {
                                Dictionary<object, Event_Form> dict = script_form.get_dict();
                                Event_Form sub_form = dict[cls];
                                if (script_form.get_which() == 1)
                                {
                                    if(script_form.get_NoDefault_checked())
                                        sw.WriteLine("NoDefault");
                                }
                                string tmp = "class " + cls.ToString() + " " + sub_form.getAdditionalString();
                                sw.WriteLine(tmp);
                                foreach (object evnt in sub_form.event_list.Items)
                                {
                                    sw.WriteLine(evnt.ToString());
                                }
                                sw.WriteLine("end class");
                                sw.WriteLine();
                                sw.Flush();
                            }
                            sw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
                   
            DialogResult result= MessageBox.Show("檔案輸出成功!是否加密?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                InputBox input = new InputBox("密碼", "請輸入金鑰(16進位制):");
                char key = '\0';
                if (input.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        key = (char)int.Parse(input.textBox1.Text, System.Globalization.NumberStyles.HexNumber);
                        foreach (TabPage page in pages)
                        {
                            ListBox list = page.Controls[0] as ListBox;
                            foreach (object obj in list.Items)
                            {
                                string scriptName = obj.ToString();
                                Cipher.encode(path + "/" + scriptName + ".auto", path + "/" + scriptName + ".auto", key);
                            }
                        }
                        MessageBox.Show("檔案加密完成!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }                
            }
        }

        private void decode_btn_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("密碼", "請輸入金鑰(16進位制):");
            char key='\0';
            if(input.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    key = (char)int.Parse(input.textBox1.Text, System.Globalization.NumberStyles.HexNumber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "請選擇檔案";
            dialog.Filter = "文字檔案(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                Cipher.decode(file, file, key);
                MessageBox.Show("檔案解密完成!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
