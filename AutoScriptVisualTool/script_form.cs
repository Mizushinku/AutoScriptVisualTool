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
    public partial class Script_form : Form
    {
        private Dictionary<object, Event_Form> map = new Dictionary<object, Event_Form>();
        private Event_Form cur_form = null;
        private int which;
        public int pre_slt { get; set; } = -1;

        public Script_form(int which)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.which = which;

            if (which == 1)
            {
                //start script
                this.tlp.Controls.Add(new CheckBox {
                    Name = "no_default_cb",
                    Text = "NoDefault",
                    Anchor = AnchorStyles.None
                }, 0, 0);
            }
        }

        private void class_list_VisibleChanged(object sender, EventArgs e)
        {
            this.class_list.ClearSelected();
            pre_slt = -1;
            class_panel.Controls.Clear();
            cur_form = null;
        }

        public void class_list_ItemAdded(object item)
        {
            map.Add(item, new Event_Form(this.which));
        }

        public void class_list_ItemAdded(int p, object item)
        {
            Event_Form event_Form = new Event_Form(p);
            map.Add(item, event_Form);
            cur_form = event_Form;
        }
        
        private void class_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slt = class_list.SelectedIndex;
            if (slt == pre_slt) return;
            pre_slt = slt;
            if (slt == -1) return;

            class_panel.Controls.Clear();
            cur_form = map[class_list.SelectedItem];
            class_panel.Controls.Add(cur_form);
            cur_form.Show();
        }

        public Event_Form get_sub_form()
        {
            return cur_form;
        }
        public Dictionary<object, Event_Form> get_dict()
        {
            return map;
        }
        private void class_list_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int prev = pre_slt;
                int index = class_list.IndexFromPoint(e.X, e.Y);
                if (index == -1) return;
                string msg = "確定刪除 " + class_list.Items[index] + " 嗎?";
                if (MessageBox.Show(msg, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    class_list.ClearSelected();
                    cur_form = null;

                    object rm_item = class_list.Items[index] as object;
                    map.Remove(rm_item);
                    class_list.Items.Remove(rm_item);

                    if (0 <= prev && prev < index) class_list.SetSelected(prev, true);
                    else if (prev == index) class_panel.Controls.Clear();
                    else if (prev > index) class_list.SetSelected(prev - 1, true);
                }
            }
        }
    }
}
