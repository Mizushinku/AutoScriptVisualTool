using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScriptVisualTool.PlayerForms;

namespace AutoScriptVisualTool
{
    public partial class Player_Form : Form
    {
        public String actstr { get; set; } = String.Empty;

        String cat = String.Empty, cmd = String.Empty;
        BasePlayerForm basePF = null;
        private string[] roleSet = new string[]
        {
            "初始裝備", "初始道具","初始場景", "初始金錢", "初始等級", "初始隊伍",
            "初期擁有道具","初始技能", "角色習得技能", "更改裝備屬性", "更改道具屬性", "更改技能屬性"
        };
        public Player_Form()
        {
            InitializeComponent();
            this.AcceptButton = next_btn;
            this.CancelButton = cancel_btn;
            role_set.Items.AddRange(roleSet);
        }
        private void role_set_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            basePF = null;
            String tmp = ((ComboBox)sender).SelectedItem.ToString();
            
            if (tmp == "初始裝備") basePF = new Equip();
            else if (tmp == "初始道具") basePF = new Item();
            else if (tmp == "初始場景") basePF = new Scene();
            else if (tmp == "初始金錢") basePF = new Money();
            else if (tmp == "初始等級") basePF = new Level();
            else if (tmp == "初始隊伍") basePF = new Party();
            else if (tmp == "初期擁有道具") basePF = new Unequip();
            else if (tmp == "初始技能") basePF = new Skill();
            else if (tmp == "角色習得技能") basePF = new Learn();
            else if (tmp == "更改裝備屬性") basePF = new Modeq(0);
            else if (tmp == "更改道具屬性") basePF = new Modeq(1);
            else if (tmp == "更改技能屬性") basePF = new Modeq(2);
            if (basePF != null)
            {
                panel1.Controls.Add(basePF);
                basePF.Show();
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (basePF != null)
            {
                this.actstr = basePF.make_actstr();
                //MessageBox.Show(actstr);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Action參數錯誤", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
    }
}
