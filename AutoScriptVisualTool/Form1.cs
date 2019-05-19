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
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            if(add_Form.ShowDialog(this) == DialogResult.OK)
            {
                int which = add_Form.which;
                int item_cnt = 0;
                if (which == 1)
                {
                    item_cnt = start_list.Items.Count;
                    start_list.Items.Add(String.Format("{0}. start[{0}]", item_cnt));
                    map.Add(start_list.Items[item_cnt], new Script_form());
                }
                else if(which == 2)
                {
                    item_cnt = trigger_list.Items.Count;
                    trigger_list.Items.Add(String.Format("{0}. trigger[{0}]", item_cnt));
                    map.Add(trigger_list.Items[item_cnt], new Script_form());
                }
                else if(which == 3)
                {
                    item_cnt = destroy_list.Items.Count;
                    destroy_list.Items.Add(String.Format("{0}. destroy[{0}]", item_cnt));
                    map.Add(destroy_list.Items[item_cnt], new Script_form());
                }
                else if(which == 4)
                {
                    item_cnt = update_list.Items.Count;
                    update_list.Items.Add(String.Format("{0}. update[{0}]", item_cnt));
                    map.Add(update_list.Items[item_cnt], new Script_form());
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

        private void newClass_btn_Click(object sender, EventArgs e)
        {
            if(cur_form == null)
            {
                MessageBox.Show("請選擇一個Script檔案","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cur_form.class_list.Items.Add("new class");
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
    }
}
