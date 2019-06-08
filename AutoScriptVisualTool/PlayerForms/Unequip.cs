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
    public partial class Unequip : BasePlayerForm
    {
        private string cmd;
        public Unequip()
        {
            InitializeComponent();
            cmd = "unequip";

        }

        private void add_Click(object sender, EventArgs e)
        {
            eq_list.Items.Add("裝備: " + eq_no.Text + " 數量: " + amount.Text);
            cmd += " " + eq_no.Text + "," + amount.Text;
            eq_no.Text = "";
            amount.Text = "";
        }
        public override string make_actstr()
        {
            return cmd;
        }
    }
}
