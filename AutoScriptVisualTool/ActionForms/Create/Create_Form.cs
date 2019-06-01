using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoScriptVisualTool.ActionForms.Create
{
    public partial class Create_Form : AutoScriptVisualTool.BaseActionForm
    {
        Dictionary<int, string[]> objs = new Dictionary<int, string[]>
        {
            {0, new string[]
            {
                "AngelStatue : 天使雕像", "Asteriod : 小行星", "Ball : 球體", "Ball2 : 球體二", "Barrel : 木桶",
                "Bed1 : 床一", "Bed2 : 床二", "Bench : 長椅", "Boat : 小船", "Book : 書",
                "Bottle : 瓶子", "Box_Brown : 棕色盒子", "BrickColumn : 磚柱", "BrickWall : 一段磚牆", "Bridge : 橋",
                "Bucket : 水桶", "Bush : 小型灌木", "Cabinet : 櫃子", "Cage : 籠子", "Capsule : 電力膠囊",
                "Capsule : 電力膠囊", "Chain : 鐵鏈", "Chair : 椅子", "Chest : 寶箱", "Chest2 : 寶箱二",
                "Crate : 水泥塊", "Door : 門", "Doorway : 拱門", "DragonStatue : 龍雕像", "ElectroPanel : 電子控制器",
                "Gate : 鐵柵欄", "Ghost : 鬼", "GlassTable : 玻璃桌", "Ground : 石頭和草地面", "Hammer : 鎚子",
                "Hover : 電子平臺", "Jar : 玻璃罐", "Ladder : 梯子", "Lamp : 檯燈", "Log : 木柱",
                "Keys : 鑰匙", "Notebook : 筆記本", "PC : 電腦", "Pencil : 鉛筆", "PowerCube : 電箱",
                "Pillar : 石柱", "Rifle : 來福槍", "Rock : 石頭", "Rock2 : 石頭二", "Rock3 : 石頭三",
                "Rock4 : 石頭四", "Rubble : 垃圾堆", "SailBoat : 帆船", "Scale : 磅秤", "Scissor : 剪刀",
                "Segment : 塊狀建築體", "Sink : 洗手臺", "Sofa : 沙發", "Speaker : 擴音器", "Spear : 長矛",
                "Stool : 凳子", "Switch : 開關", "Ram : 衝撞器", "Table_Big : 大桌子", "Table_Small : 小桌子",
                "Table3 : 鐵桌", "Torch : 火把", "Totem : 圖騰柱", "Tower : 高塔", "Tray : 金屬盒子",
                "Tree : 樹", "Tree2 : 樹二", "Tree3 : 樹三", "Tree_House : 樹屋", "Trolley : 手推車",
                "Turret : 砲塔", "TV : 電視", "TV2 : 電視二", "Weight : 砝碼"
            }},
            {1, new string[]
            {
                "Archer 弓箭手", "Azure 扁帽", "Blackman 黑人", "Deer 鹿怪", "Ganful 狼人",
                "Girl0 少女0", "GreenBear 綠熊", "Lich 巫妖", "Mei 中國女孩", "Monova 中年婦女",
                "RedHood 小紅帽", "Remy 男孩0", "Sportman 武術家", "Vanguard 守衛", "White 白髮男子",
                "Zombie 殭屍"
            }}
        };

        int mod;

        public Create_Form(int mod)
        {
            InitializeComponent();
            this.mod = mod;
            obj_name_cb.Items.AddRange(objs[mod]);
        }

        private void ref_cb_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            label7.Visible = flag;
            ref_name_tb.Visible = flag;
        }

        public override string make_actstr()
        {
            string actstr = String.Empty;
            if(mod == 0)
            {
                actstr = String.Format(" # Create {0}", obj_name_cb.SelectedItem.ToString().Split(' ')[0]);
            }
            else if(mod == 1)
            {
                actstr = String.Format(" # NPC {0}", obj_name_cb.SelectedItem.ToString().Split(' ')[0]);
            }

            if (ref_cb.Checked)
            {
                actstr = String.Format("{0} in {1} {2},{3},{4} as {5}",
                    actstr, ref_name_tb.Text, x_tb.Text, y_tb.Text, z_tb.Text, class_name_tb.Text);
            }
            else
            {
                actstr = String.Format("{0} at {1},{2},{3} as {4}",
                    actstr, x_tb.Text, y_tb.Text, z_tb.Text, class_name_tb.Text);
            }

            if (clear_cb.Checked) actstr += " clear";

            return actstr;
        }
    }
}
