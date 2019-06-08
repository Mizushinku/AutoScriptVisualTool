using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool.PlayerForms
{
    public partial class Item : BasePlayerForm
    {
        private string cmd;
        public Item()
        {
            InitializeComponent();
        }
        public override string make_actstr()
        {
            return "item " + cmd;
        }

        private void add_Click(object sender, EventArgs e)
        {
            cmd += no.Text + "," + amount.Text + " ";
            added_list.Items.Add("編號: " + no.Text + " 數量: " + amount.Text);
            no.Text = "";
            amount.Text = "";
        }
    }
}
