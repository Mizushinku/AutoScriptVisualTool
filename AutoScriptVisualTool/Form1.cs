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
                int item_cnt = 0;
                if (which == 1)
                {
                    item_cnt = start_list.Items.Count;
                    start_list.Items.Add(String.Format("start{0}", item_cnt));
                    map.Add(start_list.Items[item_cnt], new Script_form(which));
                }
                else if(which == 2)
                {
                    item_cnt = trigger_list.Items.Count;
                    trigger_list.Items.Add(String.Format("trigger{0}", item_cnt));
                    map.Add(trigger_list.Items[item_cnt], new Script_form(which));
                }
                else if(which == 3)
                {
                    item_cnt = destroy_list.Items.Count;
                    destroy_list.Items.Add(String.Format("destroy{0}", item_cnt));
                    map.Add(destroy_list.Items[item_cnt], new Script_form(which));
                }
                else if(which == 4)
                {
                    item_cnt = update_list.Items.Count;
                    update_list.Items.Add(String.Format("update{0}", item_cnt));
                    map.Add(update_list.Items[item_cnt], new Script_form(which));
                }
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
