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
    public partial class Event_Form : Form
    {
        private int which;
        private NumericUpDown nud = null;
        private TextBox tb = null;
        private CheckBox cb = null;
        public Event_Form(int which)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.which = which;
            if(which == 1)
            {
                //start class
                add_cb_in_p1("static_cb", "static");
            }
            else if(which == 2)
            {
                //trigger class
                add_lb_in_p1("觸發範圍", 12, 12, 22);
                add_nud_in_p1("range_nud", 12, 47);
                add_lb_in_p1("提示文字", 12, 172, 22);
                add_tb_in_p1("hint_tb", 172, 47);
            }
            else if(which == 3)
            {
                //destroy class
            }
            else if(which == 4)
            {
                //update
                add_lb_in_p1("執行週期(s)", 12, 12, 22);
                add_tb_in_p1("freq_tb", 12, 47);
            }
            else if(which == 6)
            {
                //function class
            }
            else if(which == 7)
            {
                add_cb_in_p1("static_cb", "static");
            }
        }
        public string getAdditionalString()
        {
            if(which == 1)
            {
                if (cb.Checked) return "static";
            }
            else if(which == 2)
            {
                return nud.Value.ToString() + "," + tb.Text;
            }
            else if (which == 4)
            {
                return tb.Text;
            }
            return "";
        }
        private void add_cb_in_p1(String name, String text)
        {
            cb = new CheckBox
            {
                Name = name,
                Text = text,
                Dock = DockStyle.Left,
                Padding = new Padding(10, 0, 0, 0)
            };
            splitContainer1.Panel1.Controls.Add(cb);
        }

        private void add_lb_in_p1(String text,int text_size, int x, int y)
        {
            splitContainer1.Panel1.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("新細明體", text_size, FontStyle.Regular),
                Location = new Point(x, y)
            });
        }

        private void add_nud_in_p1(String name, int x, int y)
        {
            nud = new NumericUpDown
            {
                Name = name,
                Location = new Point(x, y)
            };
            splitContainer1.Panel1.Controls.Add(nud);
        }

        private void add_tb_in_p1(String name, int x, int y)
        {
            tb = new TextBox
            {
                Name = name,
                Location = new Point(x, y)
            };
            splitContainer1.Panel1.Controls.Add(tb);
        }

        private void event_list_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = event_list.IndexFromPoint(e.X, e.Y);
                if (index == -1) return;
                string msg = "確定刪除 " + event_list.Items[index] + " 嗎?";
                if (MessageBox.Show(msg, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    object rm_item = event_list.Items[index] as object;
                    event_list.Items.Remove(rm_item);
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                
            }
        }

        private void event_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (event_list.SelectedIndex >= 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    move_item(-1);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    move_item(1);
                    e.Handled = true;
                }
            }
        }

        private void move_item(int direction)
        {
            int new_index = event_list.SelectedIndex + direction;
            if (new_index < 0 || new_index >= event_list.Items.Count)
                return;

            object item = event_list.SelectedItem;
            event_list.Items.RemoveAt(event_list.SelectedIndex);
            event_list.Items.Insert(new_index, item);
            event_list.SetSelected(new_index, true);
        }

        private void event_list_VisibleChanged(object sender, EventArgs e)
        {
            event_list.ClearSelected();
        }

        public void set_static_cb(bool flag)
        {
            ((CheckBox)this.splitContainer1.Panel1.Controls["static_cb"]).Checked = flag;
        }

        public void set_range_nud(int range)
        {
            ((NumericUpDown)this.splitContainer1.Panel1.Controls["range_nud"]).Value = range;
        }

        public void set_hint_tb(string hint)
        {
            ((TextBox)this.splitContainer1.Panel1.Controls["hint_tb"]).Text = hint;
        }

        public void set_freq_tb(float freq)
        {
            ((TextBox)this.splitContainer1.Panel1.Controls["freq_tb"]).Text = freq.ToString();
        }
    }
}
