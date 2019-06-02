namespace AutoScriptVisualTool.ActionForms.Plot
{
    partial class PRTDOL_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.param_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.param_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "時間 :";
            // 
            // param_tb
            // 
            this.param_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.param_tb.Location = new System.Drawing.Point(70, 32);
            this.param_tb.Name = "param_tb";
            this.param_tb.Size = new System.Drawing.Size(60, 27);
            this.param_tb.TabIndex = 53;
            this.param_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(67, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            // 
            // param_cb
            // 
            this.param_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.param_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.param_cb.FormattingEnabled = true;
            this.param_cb.Items.AddRange(new object[] {
            "0:主選單",
            "1:山地",
            "2:機器人實驗室",
            "3:小教室",
            "4:小房間",
            "5:大房間",
            "6:走廊",
            "7:淹水的農莊",
            "8:森林城鎮",
            "9:湖邊",
            "10:海港"});
            this.param_cb.Location = new System.Drawing.Point(70, 32);
            this.param_cb.Name = "param_cb";
            this.param_cb.Size = new System.Drawing.Size(154, 24);
            this.param_cb.TabIndex = 55;
            this.param_cb.Visible = false;
            // 
            // PRTDOL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.param_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.param_tb);
            this.Controls.Add(this.label1);
            this.Name = "PRTDOL_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox param_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox param_cb;
    }
}
