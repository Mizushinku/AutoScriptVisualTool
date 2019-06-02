namespace AutoScriptVisualTool.ActionForms.Plot
{
    partial class Bind_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bind_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.obj_tb = new System.Windows.Forms.TextBox();
            this.auto_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "種類 :";
            // 
            // type_cb
            // 
            this.type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Items.AddRange(new object[] {
            "down:按下時發生",
            "press:持續按住時發生",
            "up:放開按鍵時發生"});
            this.type_cb.Location = new System.Drawing.Point(70, 32);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(168, 24);
            this.type_cb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key Name :";
            // 
            // keyname_tb
            // 
            this.keyname_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.keyname_tb.Location = new System.Drawing.Point(111, 92);
            this.keyname_tb.Name = "keyname_tb";
            this.keyname_tb.Size = new System.Drawing.Size(79, 27);
            this.keyname_tb.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(226, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 182);
            this.label3.TabIndex = 28;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bind Object :";
            // 
            // obj_tb
            // 
            this.obj_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.obj_tb.Location = new System.Drawing.Point(122, 312);
            this.obj_tb.Name = "obj_tb";
            this.obj_tb.Size = new System.Drawing.Size(187, 27);
            this.obj_tb.TabIndex = 30;
            // 
            // auto_cb
            // 
            this.auto_cb.AutoSize = true;
            this.auto_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.auto_cb.Location = new System.Drawing.Point(12, 375);
            this.auto_cb.Name = "auto_cb";
            this.auto_cb.Size = new System.Drawing.Size(155, 20);
            this.auto_cb.TabIndex = 31;
            this.auto_cb.Text = "自動產生虛擬物件";
            this.auto_cb.UseVisualStyleBackColor = true;
            // 
            // Bind_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.auto_cb);
            this.Controls.Add(this.obj_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyname_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type_cb);
            this.Controls.Add(this.label1);
            this.Name = "Bind_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox obj_tb;
        private System.Windows.Forms.CheckBox auto_cb;
    }
}
