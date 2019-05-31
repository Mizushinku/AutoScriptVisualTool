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
                "Skill0 : 出拳", "Skill1 : 用力推", "Skill2 : 投擲", "Attack : 攻擊", "Boxing : 拳擊",
                "Butt : 頭槌", "Hit : 被打中的反應", "Kick : 踢", "Look : 環顧四周", "Punch : 出拳2",
                "React : 被打中的反應2", "Salute : 敬禮", "StandUp : 爬起來", "Throw : 投擲二",
            }},
            {1, new string[]
            {
                "Skill4 : 施法", "Skill7 : 掌擊", "Evade : 逃避", "Hit : 被擊中", "HoldDown : 撿東西",
                "No : 拒絕", "Pray : 祈禱", "Punch : 出拳", "Show : 炫耀", "Strong : 強化",
                "Sweep : 揮擊", "Throw : 投擲",
            }},
            {2, new string[]
            {
                "Agony : 疼痛", "Block : 格檔", "Defeat : 挫敗", "Elbow : 肘擊", "Excite : 興奮",
                "Golf : 揮桿", "Jump : 向後跳", "Look : 環視四周", "Point : 伸出手指", "React : 被擊中的反應",
                "Skill8 : 投擲", "Skill9 : 施法", "Skill10 : 施法2",
            }}
        };

        public Anima_Form()
        {
            InitializeComponent();
        }

        public override string make_actstr()
        {
            string actstr = String.Format(" # Anima {0} {1}",
                role_cb.SelectedItem.ToString().Split(' ')[0],
                anima_cb.SelectedItem.ToString().Split(' ')[0]);
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
