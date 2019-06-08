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
    public partial class Skill : BasePlayerForm
    {
        private string[] role = new string[] { "0", "1", "2" };
        public Skill()
        {
            InitializeComponent();
            role_cb.Items.AddRange(role);
        }
        public override string make_actstr()
        {
            String cmd = "";
            if (role_cb.SelectedIndex != -1)
            {
                cmd = "skill " + role_cb.SelectedIndex + " " + z_skill.Text + " " + x_skill.Text + " " + c_skill.Text + " " + v_skill.Text + " " + p_skill.Text;
            }
            return cmd;
        }
    }
}
