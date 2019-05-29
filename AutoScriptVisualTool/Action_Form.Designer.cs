namespace AutoScriptVisualTool
{
    partial class Action_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.action_cat_cb = new System.Windows.Forms.ComboBox();
            this.action_name_cb = new System.Windows.Forms.ComboBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.action_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // action_cat_cb
            // 
            this.action_cat_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_cat_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.action_cat_cb.FormattingEnabled = true;
            this.action_cat_cb.Items.AddRange(new object[] {
            "視覺",
            "力學",
            "創造",
            "音效",
            "與敵人相關",
            "字串",
            "劇情",
            "邏輯",
            "除錯"});
            this.action_cat_cb.Location = new System.Drawing.Point(36, 45);
            this.action_cat_cb.Name = "action_cat_cb";
            this.action_cat_cb.Size = new System.Drawing.Size(121, 24);
            this.action_cat_cb.TabIndex = 0;
            this.action_cat_cb.SelectedIndexChanged += new System.EventHandler(this.action_cat_cb_SelectedIndexChanged);
            // 
            // action_name_cb
            // 
            this.action_name_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_name_cb.Enabled = false;
            this.action_name_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.action_name_cb.FormattingEnabled = true;
            this.action_name_cb.Location = new System.Drawing.Point(200, 45);
            this.action_name_cb.Name = "action_name_cb";
            this.action_name_cb.Size = new System.Drawing.Size(121, 24);
            this.action_name_cb.TabIndex = 1;
            this.action_name_cb.SelectedIndexChanged += new System.EventHandler(this.action_name_cb_SelectedIndexChanged);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(457, 618);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(561, 618);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 3;
            this.next_btn.Text = "下一步";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // action_panel
            // 
            this.action_panel.Location = new System.Drawing.Point(36, 95);
            this.action_panel.Name = "action_panel";
            this.action_panel.Size = new System.Drawing.Size(600, 500);
            this.action_panel.TabIndex = 4;
            // 
            // Action_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 653);
            this.Controls.Add(this.action_panel);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.action_name_cb);
            this.Controls.Add(this.action_cat_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Action_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Action";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox action_cat_cb;
        private System.Windows.Forms.ComboBox action_name_cb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel action_panel;
    }
}