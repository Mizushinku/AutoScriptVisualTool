using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoScriptVisualTool
{
    public partial class Setting_Form : Form
    {
        public Setting_Form()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void add_act_btn_Click(object sender, EventArgs e)
        {            
            Player_Form player_Form = new Player_Form();
            if (player_Form.ShowDialog() == DialogResult.OK)
            {
                event_list.Items.Add(player_Form.actstr);
            }            
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
    }
}
