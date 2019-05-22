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

        public void class_list_ItemAdded()
        {
            map.Add(class_list.Items[class_list.Items.Count - 1], new Event_Form(this.which));
        }

        public int pre_slt { get; set; } = -1;
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
    }
}
