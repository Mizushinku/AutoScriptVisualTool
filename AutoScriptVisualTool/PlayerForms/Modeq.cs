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
    public partial class Modeq : BasePlayerForm
    {
        private string[] eq_field = new string[]
       {
            "裝備名字","裝備說明","裝備稀有度","攻擊力加成","防禦力加成","智力加成",
            "抗性加成","感染力加成","跑速加成","治癒量","裝備價格"
       };
        private string[] eq_cmd = new string[]
       {
            "name:","text:","rare:","att:","def:","int:",
            "res:","inf:","mov:","heal:","price:"
       };
        private string[] item_field = new string[]
       {
            "道具名字","道具說明","道具賦值","道具效果","道具分類","道具價格"
       };
        private string[] item_cmd = new string[]
       {
            "name:","text:","amount:","effect:","type:","price:"
       };
        private string[] skill_field = new string[]
       {
            "招式名字","招式說明","招式賦值","消耗魔力","招式冷卻時間"
       };
        private string[] skill_cmd = new string[]
       {
            "name:","text:","amount:","cost:","coldtime:"
       };
        private int type;
        private string cmd = "";
        private string no;
        public Modeq(int type)
        {
            /* 0 = modeq
             * 1 = moditem
             * 2 = modskill*/
            InitializeComponent();
            if (type == 0)
            {
                No_label.Text = "裝備編號:";
                field_cb.Items.AddRange(eq_field);
                this.type = type;
            }
            else if (type == 1)
            {
                No_label.Text = "道具編號:";
                field_cb.Items.AddRange(item_field);
                this.type = type;
            }
            else if (type == 2)
            {
                No_label.Text = "技能編號:";
                field_cb.Items.AddRange(skill_field);
                this.type = type;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string s = "屬性: " + field_cb.SelectedItem.ToString() + " 數值: " + value.Text + " ";
            added_list.Items.Add(s);
            no = number.Text;
            if (type == 0) cmd += eq_cmd[field_cb.SelectedIndex] + value.Text + " ";
            else if (type == 1) cmd += item_cmd[field_cb.SelectedIndex] + value.Text + " ";
            else if (type == 2) cmd += skill_cmd[field_cb.SelectedIndex] + value.Text + " ";
            number.Enabled = false;
            value.Text = "";
            field_cb.SelectedIndex = -1;
        }
        public override string make_actstr()
        {
            String s = "";
            if (type == 0) s = "modeq " + no + " " + cmd;
            else if (type == 1) s = "moditem " + no + " " + cmd;
            else if (type == 2) s = "modskill " + no + " " + cmd;
            return s;
        }
    }
}
