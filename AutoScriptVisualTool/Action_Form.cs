using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScriptVisualTool.ActionForms.Vision;
using AutoScriptVisualTool.ActionForms.Mechanics;
using AutoScriptVisualTool.ActionForms.Create;
using AutoScriptVisualTool.ActionForms.Sound;
using AutoScriptVisualTool.ActionForms.Enemy;
using AutoScriptVisualTool.ActionForms.Str;
using AutoScriptVisualTool.ActionForms.Plot;
using AutoScriptVisualTool.ActionForms.Logic;
using AutoScriptVisualTool.ActionForms.LC;

namespace AutoScriptVisualTool
{
    public partial class Action_Form : Form
    {
        public String actstr { get; set; } = String.Empty;

        String cat = String.Empty, cmd = String.Empty;
        BaseActionForm baseAF = null;

        private string[] vision = new string[]
        {
            "使物體發光", "畫面淡入", "畫面淡出", "更換視點", "撥放角色動畫",
            "顯示文字", "更改顯示文字", "展示圖片", "從指定路徑展示圖片", "變更圖片",
            "向使用者展示指定訊息",
        };

        private string[] mechanics = new string[]
        {
            "旋轉物體", "縮放物體", "瞬間改變物體位置", "對物體施力", "成為剛體",
        };

        private string[] create = new string[]
        {
            "創造不可視物件", "創造物件並定義其類別", "創造非玩家操控角色", "修改NPC屬性", "製作敵人攻擊方式", "產生特定粒子",
        };

        private string[] sound = new string[]
        {
            "播放效果音", "從指定路徑播放效果音", "變更背景音樂", "從指定路徑變更背景音樂",
        };

        private string[] enemy = new string[]
        {
            "在指定位置生成特定怪物",
        };

        private string[] str = new string[]
        {
            "定義字串",
        };

        private string[] plot = new string[]
        {
            "建立鍵位對應", "建立互動式按鈕", "變更按鈕", "建立互動式文字方塊", "取得文字",
            "讓角色走路", "讓角色向前走", "讓角色倒退走", "讓角色向左旋轉", "讓角色向右旋轉",
            "讓角色停止走路", "規畫NPC巡邏動線", "將語句加入佇列", "開始對話", "暫時不執行下面的程式碼",
            "重新執行一個物件的start函數", "直接觸發物件", "傷害當前角色", "打開主選單", "打開交易介面",
            "建立商店物件", "增減持有道具", "增減持有裝備", "更換成下一位成員", "打開煉金模組",
            "替角色更名", "切換場景",
        };

        private string[] logic = new string[]
        {
            "根據名稱呼叫函數", "根據索引值呼叫函數", "取得特殊變量", "跳至指定行", "將變數賦值",
            "將變數賦隨機值", "評估運算式", "設定特殊變量", "讓物件停止執行update事件", "摧毀物件",
            "離開函式", "關閉組件",
        };

        private string[] debug = new string[]
        {
            "印出指定訊息", "在編輯器中印出指定的變數的值",
        };

        public Action_Form()
        {
            InitializeComponent();
            this.AcceptButton = next_btn;
            this.CancelButton = cancel_btn;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (baseAF != null)
            {
                this.actstr = baseAF.make_actstr();
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

        private void action_cat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cat = ((ComboBox)sender).SelectedItem.ToString();

            action_name_cb.Items.Clear();
            if (cat == "視覺")
            {
                action_name_cb.Items.AddRange(vision);
            }
            else if (cat == "力學")
            {
                action_name_cb.Items.AddRange(mechanics);
            }
            else if (cat == "創造")
            {
                action_name_cb.Items.AddRange(create);
            }
            else if (cat == "音效")
            {
                action_name_cb.Items.AddRange(sound);
            }
            else if (cat == "與敵人相關")
            {
                action_name_cb.Items.AddRange(enemy);
            }
            else if (cat == "字串")
            {
                action_name_cb.Items.AddRange(str);
            }
            else if (cat == "劇情")
            {
                action_name_cb.Items.AddRange(plot);
            }
            else if (cat == "邏輯")
            {
                action_name_cb.Items.AddRange(logic);
            }
            else if (cat == "除錯")
            {
                action_name_cb.Items.AddRange(debug);
            }

            action_name_cb.Enabled = true;
            action_panel.Controls.Clear();
        }

        private void action_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            action_panel.Controls.Clear();
            baseAF = null;
            cmd = ((ComboBox)sender).SelectedItem.ToString();

            if (cat == "視覺")
            {
                if (cmd == "使物體發光") baseAF = new Light_Form();
                else if (cmd == "畫面淡入") baseAF = new Fade_Form(0);
                else if (cmd == "畫面淡出") baseAF = new Fade_Form(1);
                else if (cmd == "更換視點") baseAF = new Camera_Form();
                else if (cmd == "撥放角色動畫") baseAF = new Anima_Form();
                else if (cmd == "顯示文字") baseAF = new Text_Form(0);
                else if (cmd == "更改顯示文字") baseAF = new Text_Form(1);
                else if (cmd == "展示圖片") baseAF = new ShowImage_Form(false);
                else if (cmd == "從指定路徑展示圖片") baseAF = new ShowImage_Form(true);
                else if (cmd == "變更圖片") baseAF = new ChangeImage_Form();
                else if (cmd == "向使用者展示指定訊息") baseAF = new Broadcast_Form();
            }
            else if (cat == "力學")
            {
                if (cmd == "旋轉物體") baseAF = new RSTAR_Form(0);
                else if (cmd == "縮放物體") baseAF = new RSTAR_Form(1);
                else if (cmd == "瞬間改變物體位置") baseAF = new RSTAR_Form(2);
                else if (cmd == "對物體施力") baseAF = new RSTAR_Form(3);
                else if (cmd == "成為剛體") baseAF = new RSTAR_Form(4);
            }
            else if (cat == "創造")
            {
                if (cmd == "創造不可視物件") baseAF = new Virtual_Form();
                else if (cmd == "創造物件並定義其類別") baseAF = new Create_Form(0);
                else if (cmd == "創造非玩家操控角色") baseAF = new Create_Form(1);
                else if (cmd == "修改NPC屬性") baseAF = new ChangeNPC_Form();
                else if (cmd == "製作敵人攻擊方式") baseAF = new Weapon_Form();
                else if (cmd == "產生特定粒子") baseAF = new Particle_Form();
            }
            else if (cat == "音效")
            {
                if (cmd == "播放效果音") baseAF = new Music_Form(0);
                else if (cmd == "從指定路徑播放效果音") baseAF = new Music_Form(1);
                else if (cmd == "變更背景音樂") baseAF = new Music_Form(2);
                else if (cmd == "從指定路徑變更背景音樂") baseAF = new Music_Form(3);
            }
            else if (cat == "與敵人相關")
            {
                if (cmd == "在指定位置生成特定怪物") baseAF = new Monster_Form();
            }
            else if (cat == "字串")
            {
                if (cmd == "定義字串") baseAF = new DefineStr_Form();
            }
            else if (cat == "劇情")
            {
                if (cmd == "建立鍵位對應") baseAF = new Bind_Form();
                else if (cmd == "建立互動式按鈕") baseAF = new Button_Form(0);
                else if (cmd == "變更按鈕") baseAF = new Button_Form(1);
                else if (cmd == "建立互動式文字方塊") baseAF = new Input_Form();
                else if (cmd == "取得文字") baseAF = new GetText_Form();
                else if (cmd == "讓角色走路") baseAF = new Walk_Form(0);
                else if (cmd == "讓角色向前走") baseAF = new Walk_Form(1);
                else if (cmd == "讓角色倒退走") baseAF = new Walk_Form(2);
                else if (cmd == "讓角色向左旋轉") baseAF = new Walk_Form(3);
                else if (cmd == "讓角色向右旋轉") baseAF = new Walk_Form(4);
                else if (cmd == "讓角色停止走路") baseAF = new Walk_Form(5);
                else if (cmd == "規畫NPC巡邏動線") baseAF = new Route_Form();
                else if (cmd == "將語句加入佇列") baseAF = new Talk_Form(0);
                else if (cmd == "開始對話") baseAF = new Talk_Form(1);
                else if (cmd == "打開主選單") baseAF = new MNA_Form(0);
                else if (cmd == "更換成下一位成員") baseAF = new MNA_Form(1);
                else if (cmd == "打開煉金模組") baseAF = new MNA_Form(2);
                else if (cmd == "暫時不執行下面的程式碼") baseAF = new PRTDOL_Form(0);
                else if (cmd == "重新執行一個物件的start函數") baseAF = new PRTDOL_Form(1);
                else if (cmd == "直接觸發物件") baseAF = new PRTDOL_Form(2);
                else if (cmd == "傷害當前角色") baseAF = new PRTDOL_Form(3);
                else if (cmd == "打開交易介面") baseAF = new PRTDOL_Form(4);
                else if (cmd == "切換場景") baseAF = new PRTDOL_Form(5);
                else if (cmd == "建立商店物件") baseAF = new Shop_Form();
                else if (cmd == "增減持有道具") baseAF = new Item_Form(0);
                else if (cmd == "增減持有裝備") baseAF = new Item_Form(1);
                else if (cmd == "替角色更名") baseAF = new Rename_Form();
            }
            else if (cat == "邏輯")
            {
                if (cmd == "根據名稱呼叫函數") baseAF = new Function_Form(0);
                else if (cmd == "根據索引值呼叫函數") baseAF = new Function_Form(1);
                else if (cmd == "取得特殊變量") baseAF = new GetSp_Form();
                else if (cmd == "跳至指定行") baseAF = new GSDRD_Form(0);
                else if (cmd == "讓物件停止執行update事件") baseAF = new GSDRD_Form(1);
                else if (cmd == "摧毀物件") baseAF = new GSDRD_Form(2);
                else if (cmd == "離開函式") baseAF = new GSDRD_Form(3);
                else if (cmd == "關閉組件") baseAF = new GSDRD_Form(4);
                else if (cmd == "將變數賦值") baseAF = new SetVar_Form(0);
                else if (cmd == "將變數賦隨機值") baseAF = new SetVar_Form(1);
                else if (cmd == "評估運算式") baseAF = new Eval_Form();
                else if (cmd == "設定特殊變量") baseAF = new SetSp_Form();
            }
            else if (cat == "除錯")
            {
                if (cmd == "印出指定訊息") baseAF = new LC_Form(0);
                else if (cmd == "在編輯器中印出指定的變數的值") baseAF = new LC_Form(1);
            }

            if(baseAF != null)
            {
                action_panel.Controls.Add(baseAF);
                baseAF.Show();
            }
        }
    }
}
