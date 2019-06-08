namespace AutoScriptVisualTool.PlayerForms
{
    partial class Unequip
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
            this.amount = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eq_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eq_no = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(180, 70);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(114, 25);
            this.amount.TabIndex = 47;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(320, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 35);
            this.add.TabIndex = 46;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "以新增項目:";
            // 
            // eq_list
            // 
            this.eq_list.FormattingEnabled = true;
            this.eq_list.ItemHeight = 15;
            this.eq_list.Location = new System.Drawing.Point(78, 157);
            this.eq_list.Name = "eq_list";
            this.eq_list.Size = new System.Drawing.Size(257, 274);
            this.eq_list.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "數量:";
            // 
            // eq_no
            // 
            this.eq_no.Location = new System.Drawing.Point(180, 22);
            this.eq_no.Name = "eq_no";
            this.eq_no.Size = new System.Drawing.Size(114, 25);
            this.eq_no.TabIndex = 42;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_label.Location = new System.Drawing.Point(60, 21);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(99, 20);
            this.role_label.TabIndex = 41;
            this.role_label.Text = "裝備編號:";
            // 
            // Unequip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eq_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eq_no);
            this.Controls.Add(this.role_label);
            this.Name = "Unequip";
            this.Text = "Unequip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox eq_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eq_no;
        private System.Windows.Forms.Label role_label;
    }
}