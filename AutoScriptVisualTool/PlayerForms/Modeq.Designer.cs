namespace AutoScriptVisualTool.PlayerForms
{
    partial class Modeq
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
            this.value = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.added_list = new System.Windows.Forms.ListBox();
            this.field_cb = new System.Windows.Forms.ComboBox();
            this.field_label = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.No_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(195, 124);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(114, 25);
            this.value.TabIndex = 34;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.value_label.Location = new System.Drawing.Point(117, 123);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(57, 20);
            this.value_label.TabIndex = 33;
            this.value_label.Text = "數值:";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(374, 72);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(78, 35);
            this.add_btn.TabIndex = 32;
            this.add_btn.Text = "新增";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(54, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "以新增項目:";
            // 
            // added_list
            // 
            this.added_list.FormattingEnabled = true;
            this.added_list.ItemHeight = 15;
            this.added_list.Location = new System.Drawing.Point(92, 211);
            this.added_list.Name = "added_list";
            this.added_list.Size = new System.Drawing.Size(257, 274);
            this.added_list.TabIndex = 30;
            // 
            // field_cb
            // 
            this.field_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.field_cb.FormattingEnabled = true;
            this.field_cb.Location = new System.Drawing.Point(195, 79);
            this.field_cb.Name = "field_cb";
            this.field_cb.Size = new System.Drawing.Size(121, 28);
            this.field_cb.TabIndex = 29;
            // 
            // field_label
            // 
            this.field_label.AutoSize = true;
            this.field_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.field_label.Location = new System.Drawing.Point(117, 79);
            this.field_label.Name = "field_label";
            this.field_label.Size = new System.Drawing.Size(57, 20);
            this.field_label.TabIndex = 28;
            this.field_label.Text = "屬性:";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(195, 34);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(114, 25);
            this.number.TabIndex = 27;
            // 
            // No_label
            // 
            this.No_label.AutoSize = true;
            this.No_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.No_label.Location = new System.Drawing.Point(75, 33);
            this.No_label.Name = "No_label";
            this.No_label.Size = new System.Drawing.Size(57, 20);
            this.No_label.TabIndex = 26;
            this.No_label.Text = "編號:";
            // 
            // Modeq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.value);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.added_list);
            this.Controls.Add(this.field_cb);
            this.Controls.Add(this.field_label);
            this.Controls.Add(this.number);
            this.Controls.Add(this.No_label);
            this.Name = "Modeq";
            this.Text = "Modeq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox added_list;
        private System.Windows.Forms.ComboBox field_cb;
        private System.Windows.Forms.Label field_label;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label No_label;
    }
}