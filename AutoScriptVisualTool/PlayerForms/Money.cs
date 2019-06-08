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
    public partial class Money : BasePlayerForm
    {
        public Money()
        {
            InitializeComponent();
        }
        public override string make_actstr()
        {
            return "money " + amount.Text;
        }
    }
}
