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
                bool main_script_flag = add_Form.main_script_flag;
                if (which == 1)
                {
                    add_new_script(start_list, "start", which, main_script_flag);
                }
                else if(which == 2)
                {
                    add_new_script(trigger_list, "trigger", which, main_script_flag);
                }
                else if(which == 3)
                {
                    add_new_script(destroy_list, "destroy", which, main_script_flag);
                }
                else if(which == 4)
                {
                    add_new_script(update_list, "update", which, main_script_flag);
                }
                else if(which == 6)
                {
                    add_new_script(function_list, "function", which, main_script_flag);
                }
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

        private void add_new_script(ListBox list, String cat, int which, bool flag)
        {
            bool has_main_script = false;
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

        private void make_sc(int script_num)
        {
            map.Clear();

            if (script_num == 1) {
                ///////////////////////////////////////
                ListBox list = new ListBox();
                string[] items =
                {
                    "start0","start1"
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
