namespace AutoScriptVisualTool.ActionForms.Logic
{
    partial class SetVar_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.index_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.g_cb = new System.Windows.Forms.CheckBox();
            this.l_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Index :";
            // 
            // index_tb
            // 
            this.index_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.index_tb.Location = new System.Drawing.Point(77, 32);
            this.index_tb.Name = "index_tb";
            this.index_tb.Size = new System.Drawing.Size(73, 27);
            this.index_tb.TabIndex = 49;
            this.index_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "設定 :";
            // 
            // g_cb
            // 
            this.g_cb.AutoSize = true;
            this.g_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.g_cb.Location = new System.Drawing.Point(70, 94);
            this.g_cb.Name = "g_cb";
            this.g_cb.Size = new System.Drawing.Size(66, 20);
            this.g_cb.TabIndex = 51;
            this.g_cb.Text = "public";
            this.g_cb.UseVisualStyleBackColor = true;
            this.g_cb.CheckedChanged += new System.EventHandler(this.g_cb_CheckedChanged);
            // 
            // l_cb
            // 
            this.l_cb.AutoSize = true;
            this.l_cb.Checked = true;
            this.l_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.l_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_cb.Location = new System.Drawing.Point(151, 94);
            this.l_cb.Name = "l_cb";
            this.l_cb.Size = new System.Drawing.Size(70, 20);
            this.l_cb.TabIndex = 52;
            this.l_cb.Text = "private";
            this.l_cb.UseVisualStyleBackColor = true;
            this.l_cb.CheckedChanged += new System.EventHandler(this.l_cb_CheckedChanged);
            // 
            // SetVar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.l_cb);
            this.Controls.Add(this.g_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.index_tb);
            this.Controls.Add(this.label2);
            this.Name = "SetVar_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox index_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox g_cb;
        private System.Windows.Forms.CheckBox l_cb;
    }
}
