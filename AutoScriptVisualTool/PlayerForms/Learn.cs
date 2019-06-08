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
    public partial class Learn : BasePlayerForm
    {
        private string cmd;
        private string role;
        public Learn()
        {
            InitializeComponent();
            cmd = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            role = role_no.Text;
            cmd = cmd + " " + skill_no.Text;
            skill_list.Items.Add("技能" + skill_no.Text);
            role_no.Enabled = false;
            skill_no.Text = "";
        }
        public override string make_actstr()
        {
            return "learn " + role + " " + cmd;
        }
    }
}
