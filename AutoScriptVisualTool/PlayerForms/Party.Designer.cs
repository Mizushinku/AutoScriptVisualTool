namespace AutoScriptVisualTool.PlayerForms
{
    partial class Party
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
            this.add = new System.Windows.Forms.Button();
            this.order_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.role_no = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(355, 51);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 35);
            this.add.TabIndex = 44;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // order_list
            // 
            this.order_list.FormattingEnabled = true;
            this.order_list.ItemHeight = 15;
            this.order_list.Location = new System.Drawing.Point(76, 101);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(257, 274);
            this.order_list.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(114, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "順序:";
            // 
            // role_no
            // 
            this.role_no.Location = new System.Drawing.Point(192, 28);
            this.role_no.Name = "role_no";
            this.role_no.Size = new System.Drawing.Size(114, 25);
            this.role_no.TabIndex = 41;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_label.Location = new System.Drawing.Point(72, 27);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(99, 20);
            this.role_label.TabIndex = 40;
            this.role_label.Text = "角色編號:";
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.add);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role_no);
            this.Controls.Add(this.role_label);
            this.Name = "Party";
            this.Text = "Party";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox order_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox role_no;
        private System.Windows.Forms.Label role_label;
    }
}