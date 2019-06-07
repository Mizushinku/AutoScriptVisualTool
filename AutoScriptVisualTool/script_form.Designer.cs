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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.class_list = new System.Windows.Forms.ListBox();
            this.class_panel = new System.Windows.Forms.Panel();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.Controls.Add(this.class_list, 0, 1);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.65597F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.34403F));
            this.tlp.Size = new System.Drawing.Size(174, 561);
            this.tlp.TabIndex = 1;
            // 
            // class_list
            // 
            this.class_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.class_list.FormattingEnabled = true;
            this.class_list.ItemHeight = 21;
            this.class_list.Location = new System.Drawing.Point(3, 73);
            this.class_list.Name = "class_list";
            this.class_list.Size = new System.Drawing.Size(168, 485);
            this.class_list.TabIndex = 1;
            this.class_list.SelectedIndexChanged += new System.EventHandler(this.class_list_SelectedIndexChanged);
            this.class_list.VisibleChanged += new System.EventHandler(this.class_list_VisibleChanged);
            this.class_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.class_list_MouseDown);
            // 
            // class_panel
            // 
            this.class_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_panel.Location = new System.Drawing.Point(174, 0);
            this.class_panel.Margin = new System.Windows.Forms.Padding(0);
            this.class_panel.Name = "class_panel";
            this.class_panel.Size = new System.Drawing.Size(690, 561);
            this.class_panel.TabIndex = 2;
            // 
            // Script_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.class_panel);
            this.Controls.Add(this.tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Script_form";
            this.tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp;
        public System.Windows.Forms.ListBox class_list;
        private System.Windows.Forms.Panel class_panel;
    }
}