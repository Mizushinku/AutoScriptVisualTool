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
    public partial class Scene : BasePlayerForm
    {
        private string[] item_field = new string[]
        {
            "主選單","山地","機器人實驗室","小教室","小房間","大房間",
            "走廊","淹水的農莊","森林城鎮","湖邊","海港"
        };
        public Scene()
        {
            InitializeComponent();
            scene_name.Items.AddRange(item_field);
        }
        public override string make_actstr()
        {
            return "scene " + scene_name.SelectedIndex;
        }
    }
}
