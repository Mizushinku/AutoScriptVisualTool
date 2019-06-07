using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            player_list.Items.Add("player");
            map.Add(player_list.Items[0], new Script_form(5));
            default_list.Items.Add("default");
            map.Add(default_list.Items[0], new Script_form(7));
        
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
                    add_new_script(start_list, "start" + num, which);
                }
                else if(which == 2)
                {
                    add_new_script(trigger_list, "trigger" + num, which);
                }
                else if(which == 3)
                {
                    add_new_script(destroy_list, "destroy" + num, which);
                }
                else if(which == 4)
                {
                    add_new_script(update_list, "update" + num, which);
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

        private void add_new_script(ListBox list, string name, int which)
        {
            /*
            if (list.Items.Count > 0)
            {
                has_main_script = list.Items[0].ToString() == (cat + "0") ? true : false;
            }
            if (flag)
            {
                if (has_main_script)
                {
                    MessageBox.Show("這個分類已經擁有程式進入點的Script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list.Items.Insert(0, cat + "0");
                    map.Add(list.Items[0], new Script_form(which));
                }
            }
            else
            {
                int item_cnt = list.Items.Count;
                String format = cat + "{0}";
                if (has_main_script)
                {
                    list.Items.Add(String.Format(format, item_cnt));
                }
                else
                {
                    list.Items.Add(String.Format(format, item_cnt + 1));
                }
                map.Add(list.Items[item_cnt], new Script_form(which));
            }
            if (cat == "start" && start_pre_slt != -1) ++start_pre_slt;
            else if (cat == "trigger" && trigger_pre_slt != -1) ++trigger_pre_slt;
            else if (cat == "destroy" && destroy_pre_slt != -1) ++destroy_pre_slt;
            else if (cat == "update" && update_pre_slt != -1) ++update_pre_slt;
            else if (cat == "function" && function_pre_slt != -1) ++function_pre_slt;
            */
            if (list.Items.Contains(name))
            {
                MessageBox.Show("已擁有同名的Script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                object item = name as object;
                map.Add(item, new Script_form(which));
                list.Items.Add(item);
                re_map(list);
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
                    cur_form.class_list.Items.Add(inputBox.textBox1.Text);
                    cur_form.class_list_ItemAdded();
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
                
                //ReMap
                map.Remove(list.Items[index]);
                List<Form> forms = new List<Form>();
                for(int i = index + 1; i < list.Items.Count; ++i)
                {
                    forms.Add(map[list.Items[i]]);
                    map.Remove(list.Items[i]);
                }
                list.Items.RemoveAt(index);
                for(int i = index, j = 0; i < list.Items.Count; ++i, ++j)
                {
                    map.Add(list.Items[i], forms[j]);
                }

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
                    "start0", "start1"
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
                    foreach (string s in dic[k])
                    {
                        sub.class_list.Items.Add(s);
                        sub.class_list_ItemAdded(num);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);
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
                        sub.class_list.Items.Add(s);
                        sub.class_list_ItemAdded(num1);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);
                        ++q1;
                    }
                    ++k1;
                }
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
                Dictionary<int, string[]> dic2 = new Dictionary<int, string[]>
                {
                    {0, new string[]{
                        "true # ChangeText Caption 勇者達拉崩巴 reserve 255,255,0 0,120,B -1",
                        "true # ChangeText Start/Text 開始遊戲 reserve 255,0,0 reserve -1",
                        "true # ChangeText Load/Text 繼續遊戲 reserve 0,0,255 reserve -1",
                        "true # ChangeText Quit/Text 離開遊戲 reserve 0,255,0 reserve -1",
                        "true # ChangeImage Back brave.jfif reserve 255,255,255,1 -1",
                        "true # Virtual Slider at 0,0,0",
                        "true # ChBGMfrom Kao"
                    }},
                    {1, new string[]{
                        "true # SetVar public 99 0",
                        "true # ShowText 無名小村 1700,1000 0,255,0 1,48,B -1 as Place",
                        "true # ChBGMfrom Kao",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Blackman in role 0,-10,10 as NPC1",
                        "true # NPC Zombie in role 10,-10,0 as NPC2",
                        "true # NPC Remy in role 0,-10,20 as NPC3",
                        "true # NPC Azure in role 0,-10,0 as NPC4",
                        "true # NPC Mei in role 10,-10,10 as NCP5",
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
                        "true # ShowText 昆圖庫塔卡提考特蘇瓦西拉松龍穴 1700,1000 0,255,0 1,30,B -1 as Place",
                        "true # Virtual Default at 0,0,0",
                        "true # Virtual DontMove at 0,0,0",
                        "true # Virtual CanMove at 0,0,0",
                        "true # NPC Greenbear in role -15,0,-10 as Monster",
                        "true # NPC Girl0 in role -22,0,-10 as Princess",
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
                    foreach (string s in dic[k])
                    {
                        sub.class_list.Items.Add(s);
                        sub.class_list_ItemAdded(num);
                        sub.get_sub_form().event_list.Items.AddRange(dic2[q]);
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
                        sub.class_list.Items.Add(s);
                        sub.class_list_ItemAdded(num1);
                        sub.get_sub_form().event_list.Items.AddRange(dic4[q1]);
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
                        sub.class_list.Items.Add(s);
                        sub.class_list_ItemAdded(num2);
                        sub.get_sub_form().event_list.Items.AddRange(dic6[q2]);
                        ++q2;
                    }
                    ++k2;
                }
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
