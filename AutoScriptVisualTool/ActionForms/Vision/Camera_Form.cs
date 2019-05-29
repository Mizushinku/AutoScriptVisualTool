using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Vision
{
    public partial class Camera_Form : BaseActionForm
    {
        public Camera_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Camera {0}", obj_name_tb.Text);
            return actstr;
        }
    }
}
