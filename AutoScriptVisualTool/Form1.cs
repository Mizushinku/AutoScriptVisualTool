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
                inputBox.StartPosition = FormStartPosition.CenterParent;
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
    }
}
