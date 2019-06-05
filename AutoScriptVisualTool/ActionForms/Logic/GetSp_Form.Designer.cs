namespace AutoScriptVisualTool.ActionForms.Logic
{
    partial class GetSp_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.index_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_tb.Location = new System.Drawing.Point(143, 32);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(157, 27);
            this.name_tb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Variable Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sp :";
            // 
            // sp_cb
            // 
            this.sp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sp_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sp_cb.FormattingEnabled = true;
            this.sp_cb.Items.AddRange(new object[] {
            "$hp 角色的生命值",
            "$maxhp 角色的生命值上限",
            "$hpratio 角色生命值的比值",
            "$mp 角色的法力",
            "$maxmp 角色的法力上限",
            "$mpratio 角色法力的比值",
            "$att 攻擊力",
            "$def 防禦力",
            "$int 智力",
            "$luck 幸運",
            "$inf 感染",
            "$res 抗性",
            "$speed 移動速度",
            "$level 角色的等級",
            "$zskill 技能1",
            "$xskill 技能2",
            "$cskill 技能3",
            "$vskill 技能4",
            "$head 角色頭部裝備的索引",
            "$hand 手部裝備的索引",
            "$body 身體裝備的索引",
            "$foot 腳部裝備的索引",
            "$acc 飾品裝備的索引",
            "$money 隊伍的金錢",
            "$x 角色目前的x座標",
            "$y 角色目前的y座標",
            "$z 角色目前的z座標",
            "$who 目前正在操縱第幾個位置的角色"});
            this.sp_cb.Location = new System.Drawing.Point(54, 92);
            this.sp_cb.Name = "sp_cb";
            this.sp_cb.Size = new System.Drawing.Size(268, 24);
            this.sp_cb.TabIndex = 50;
            this.sp_cb.SelectedIndexChanged += new System.EventHandler(this.sp_cb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Index :";
            this.label3.Visible = false;
            // 
            // index_tb
            // 
            this.index_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.index_tb.Location = new System.Drawing.Point(77, 152);
            this.index_tb.Name = "index_tb";
            this.index_tb.Size = new System.Drawing.Size(73, 27);
            this.index_tb.TabIndex = 52;
            this.index_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.index_tb.Visible = false;
            // 
            // GetSp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.index_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sp_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "GetSp_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sp_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox index_tb;
    }
}
