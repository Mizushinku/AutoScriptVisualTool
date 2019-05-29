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
    public partial class Anima_Form : BaseActionForm
    {
        Dictionary<int, string[]> character = new Dictionary<int, string[]>
        {
            {0, new string[]
            {
                "Skill0 : 出拳", "Skill1 : 用力推",
            }},
            {1, new string[]
            {
                "Skill4 : 施法", "Skill7 : 掌擊",
            }},
            {2, new string[]
            {
                "Agony : 疼痛", "Block : 格檔",
            }}
        };

        public Anima_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Anima {0} {1}", role_cb.SelectedItem, anima_cb.SelectedItem);
            return actstr;
        }

        private void role_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            anima_cb.Enabled = true;
            anima_cb.Items.Clear();
            int who = ((ComboBox)sender).SelectedIndex;
            anima_cb.Items.AddRange(character[who]);

        }
    }
}
