namespace AutoScriptVisualTool
{
    partial class Script_form
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
            this.no_default_cb = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.class_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_default_cb
            // 
            this.no_default_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.no_default_cb.AutoSize = true;
            this.no_default_cb.Location = new System.Drawing.Point(51, 27);
            this.no_default_cb.Name = "no_default_cb";
            this.no_default_cb.Size = new System.Drawing.Size(72, 16);
            this.no_default_cb.TabIndex = 0;
            this.no_default_cb.Text = "NoDefualt";
            this.no_default_cb.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.no_default_cb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.class_list, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.65597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.34403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 561);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // class_list
            // 
            this.class_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.class_list.FormattingEnabled = true;
            this.class_list.ItemHeight = 21;
            this.class_list.Location = new System.Drawing.Point(3, 74);
            this.class_list.Name = "class_list";
            this.class_list.Size = new System.Drawing.Size(168, 484);
            this.class_list.TabIndex = 1;
            // 
            // Script_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Script_form";
            this.Text = "start_form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox no_default_cb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListBox class_list;
    }
}