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
    public partial class BaseActionForm : Form
    {
        public BaseActionForm()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        public virtual string make_actstr()
        {
            return "Make By Base Action";
        }
    }
}
