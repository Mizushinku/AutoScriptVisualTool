namespace AutoScriptVisualTool.ActionForms.Logic
{
    partial class Eval_Form
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
            this.exp_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.var_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.var_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exp_tb
            // 
            this.exp_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exp_tb.Location = new System.Drawing.Point(15, 54);
            this.exp_tb.Name = "exp_tb";
            this.exp_tb.Size = new System.Drawing.Size(391, 27);
            this.exp_tb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "運算式 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "設定 :";
            // 
            // var_cb
            // 
            this.var_cb.AutoSize = true;
            this.var_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.var_cb.Location = new System.Drawing.Point(70, 109);
            this.var_cb.Name = "var_cb";
            this.var_cb.Size = new System.Drawing.Size(123, 20);
            this.var_cb.TabIndex = 50;
            this.var_cb.Text = "代入指定變數";
            this.var_cb.UseVisualStyleBackColor = true;
            this.var_cb.CheckedChanged += new System.EventHandler(this.var_cb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Variable Name :";
            this.label3.Visible = false;
            // 
            // var_tb
            // 
            this.var_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.var_tb.Location = new System.Drawing.Point(143, 167);
            this.var_tb.Name = "var_tb";
            this.var_tb.Size = new System.Drawing.Size(124, 27);
            this.var_tb.TabIndex = 52;
            this.var_tb.Visible = false;
            // 
            // Eval_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.var_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.var_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exp_tb);
            this.Controls.Add(this.label1);
            this.Name = "Eval_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exp_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox var_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox var_tb;
    }
}
