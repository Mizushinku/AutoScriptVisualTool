namespace AutoScriptVisualTool.PlayerForms
{
    partial class Item
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
            this.added_list = new System.Windows.Forms.ListBox();
            this.no_label = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.item_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(177, 82);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(114, 25);
            this.amount.TabIndex = 47;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(317, 79);
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
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "以新增道具:";
            // 
            // added_list
            // 
            this.added_list.FormattingEnabled = true;
            this.added_list.ItemHeight = 15;
            this.added_list.Location = new System.Drawing.Point(75, 169);
            this.added_list.Name = "added_list";
            this.added_list.Size = new System.Drawing.Size(257, 274);
            this.added_list.TabIndex = 44;
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.no_label.Location = new System.Drawing.Point(99, 79);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(57, 20);
            this.no_label.TabIndex = 43;
            this.no_label.Text = "數量:";
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(177, 34);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(114, 25);
            this.no.TabIndex = 42;
            // 
            // item_label
            // 
            this.item_label.AutoSize = true;
            this.item_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.item_label.Location = new System.Drawing.Point(57, 33);
            this.item_label.Name = "item_label";
            this.item_label.Size = new System.Drawing.Size(99, 20);
            this.item_label.TabIndex = 41;
            this.item_label.Text = "道具編號:";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.added_list);
            this.Controls.Add(this.no_label);
            this.Controls.Add(this.no);
            this.Controls.Add(this.item_label);
            this.Name = "Item";
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox added_list;
        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label item_label;
    }
}