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
    public partial class Party : BasePlayerForm
    {

        private void add_Click(object sender, EventArgs e)
        {
            order_list.Items.Add(role_no.Text);
            role_no.Text = "";
        }

        public Party()
        {
            InitializeComponent();
        }
        public override string make_actstr()
        {
            string cmd = "party";
            foreach (object i in order_list.Items)
            {
                cmd += " ";
                cmd += i.ToString();
            }
            return cmd;
        }
    }
}
