﻿namespace AutoScriptVisualTool
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
            this.outfile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_act_btn
            // 
            this.add_act_btn.Location = new System.Drawing.Point(27, 53);
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
            this.event_list.Location = new System.Drawing.Point(155, 53);
            this.event_list.Name = "event_list";
            this.event_list.Size = new System.Drawing.Size(858, 584);
            this.event_list.TabIndex = 1;
            // 
            // outfile_btn
            // 
            this.outfile_btn.Location = new System.Drawing.Point(27, 148);
            this.outfile_btn.Name = "outfile_btn";
            this.outfile_btn.Size = new System.Drawing.Size(103, 66);
            this.outfile_btn.TabIndex = 2;
            this.outfile_btn.Text = "Output\r\nFile";
            this.outfile_btn.UseVisualStyleBackColor = true;
            this.outfile_btn.Click += new System.EventHandler(this.outfile_btn_Click);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 663);
            this.Controls.Add(this.outfile_btn);
            this.Controls.Add(this.event_list);
            this.Controls.Add(this.add_act_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting_Form";
            this.Text = "Setting_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_act_btn;
        private System.Windows.Forms.ListBox event_list;
        private System.Windows.Forms.Button outfile_btn;
    }
}