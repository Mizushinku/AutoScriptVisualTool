using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Plot
{
    public partial class Shop_Form : AutoScriptVisualTool.BaseActionForm
    {
        public Shop_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index, copies;
            if(int.TryParse(index_tb.Text, out index) && int.TryParse(copies_tb.Text, out copies))
            {
                ListViewItem item = new ListViewItem(new string[] { "", index_tb.Text, copies_tb.Text });
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("品項參數錯誤", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            index_tb.Text = String.Empty;
            copies_tb.Text = String.Empty;
        }

        public override string make_actstr()
        {
            string actstr = String.Empty, index = String.Empty, copies = String.Empty;
            bool first = true;
            foreach (ListViewItem item in listView1.Items)
            {
                if(first)
                {
                    index = item.SubItems[1].Text;
                    copies = item.SubItems[2].Text;
                    first = false;
                    continue;
                }
                index = String.Format("{0},{1}", index, item.SubItems[1].Text);
                copies = String.Format("{0},{1}", copies, item.SubItems[2].Text);
            }
            actstr = String.Format(" # Shop {0} {1} {2}",  name_tb.Text, index,  copies);
            actstr += (sell_cb.Checked) ? " sell" : "  nosell";
            actstr += (buy_cb.Checked) ? " buy" : " nobuy";
            if (sell_cb.Checked && ac_cb.SelectedIndex != -1) actstr += " " + ac_cb.Text.Split(':')[0];
            else MessageBox.Show("-1");

            return actstr;
        }

        private void sell_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            label6.Visible = flag;
            ac_cb.Visible = flag;
        }
    }
}
