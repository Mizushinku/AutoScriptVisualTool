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
    public partial class Equip : BasePlayerForm
    {
        public Equip()
        {
            InitializeComponent();
        }
        public override string make_actstr()
        {
            string s = role_no.Text + " " + head.Text + "," + hand.Text + "," + body.Text + "," + foot.Text + "," + acc.Text;
            return "equip " + s;
        }
    }
}
