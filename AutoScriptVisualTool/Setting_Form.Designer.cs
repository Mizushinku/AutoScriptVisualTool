namespace AutoScriptVisualTool
{
    partial class Setting_Form
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
            this.add_act_btn = new System.Windows.Forms.Button();
            this.event_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // add_act_btn
            // 
            this.add_act_btn.Location = new System.Drawing.Point(27, 52);
            this.add_act_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_act_btn.Name = "add_act_btn";
            this.add_act_btn.Size = new System.Drawing.Size(103, 66);
            this.add_act_btn.TabIndex = 0;
            this.add_act_btn.Text = "Add\r\nAction";
            this.add_act_btn.UseVisualStyleBackColor = true;
            this.add_act_btn.Click += new System.EventHandler(this.add_act_btn_Click);
            // 
            // event_list
            // 
            this.event_list.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.event_list.FormattingEnabled = true;
            this.event_list.ItemHeight = 20;
            this.event_list.Location = new System.Drawing.Point(155, 52);
            this.event_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.event_list.Name = "event_list";
            this.event_list.Size = new System.Drawing.Size(857, 584);
            this.event_list.TabIndex = 1;
            this.event_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.event_list_KeyDown);
            this.event_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.event_list_MouseDown);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 662);
            this.Controls.Add(this.event_list);
            this.Controls.Add(this.add_act_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Setting_Form";
            this.Text = "Setting_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_act_btn;
        internal System.Windows.Forms.ListBox event_list;
    }
}