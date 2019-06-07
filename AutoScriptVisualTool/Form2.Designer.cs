namespace AutoScriptVisualTool
{
    partial class Add_Form
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
            this.start_btn = new System.Windows.Forms.Button();
            this.trigger_btn = new System.Windows.Forms.Button();
            this.destroy_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.S2_btn = new System.Windows.Forms.Button();
            this.S1_btn = new System.Windows.Forms.Button();
            this.S3_btn = new System.Windows.Forms.Button();
            this.S4_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(21, 29);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(78, 47);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // trigger_btn
            // 
            this.trigger_btn.Location = new System.Drawing.Point(21, 82);
            this.trigger_btn.Name = "trigger_btn";
            this.trigger_btn.Size = new System.Drawing.Size(78, 47);
            this.trigger_btn.TabIndex = 1;
            this.trigger_btn.Text = "Trigger";
            this.trigger_btn.UseVisualStyleBackColor = true;
            this.trigger_btn.Click += new System.EventHandler(this.trigger_btn_Click);
            // 
            // destroy_btn
            // 
            this.destroy_btn.Location = new System.Drawing.Point(21, 135);
            this.destroy_btn.Name = "destroy_btn";
            this.destroy_btn.Size = new System.Drawing.Size(78, 47);
            this.destroy_btn.TabIndex = 2;
            this.destroy_btn.Text = "Destroy";
            this.destroy_btn.UseVisualStyleBackColor = true;
            this.destroy_btn.Click += new System.EventHandler(this.destroy_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(21, 188);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(78, 47);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(143, 309);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 33);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // S2_btn
            // 
            this.S2_btn.Location = new System.Drawing.Point(129, 81);
            this.S2_btn.Name = "S2_btn";
            this.S2_btn.Size = new System.Drawing.Size(78, 47);
            this.S2_btn.TabIndex = 5;
            this.S2_btn.Text = "勇者";
            this.S2_btn.UseVisualStyleBackColor = true;
            this.S2_btn.Click += new System.EventHandler(this.S2_btn_Click);
            // 
            // S1_btn
            // 
            this.S1_btn.Location = new System.Drawing.Point(129, 29);
            this.S1_btn.Name = "S1_btn";
            this.S1_btn.Size = new System.Drawing.Size(78, 47);
            this.S1_btn.TabIndex = 7;
            this.S1_btn.Text = "無雙";
            this.S1_btn.UseVisualStyleBackColor = true;
            this.S1_btn.Click += new System.EventHandler(this.S1_btn_Click);
            // 
            // S3_btn
            // 
            this.S3_btn.Location = new System.Drawing.Point(129, 135);
            this.S3_btn.Name = "S3_btn";
            this.S3_btn.Size = new System.Drawing.Size(78, 47);
            this.S3_btn.TabIndex = 8;
            this.S3_btn.Text = "喪屍";
            this.S3_btn.UseVisualStyleBackColor = true;
            this.S3_btn.Click += new System.EventHandler(this.S3_btn_Click);
            // 
            // S4_btn
            // 
            this.S4_btn.Location = new System.Drawing.Point(129, 188);
            this.S4_btn.Name = "S4_btn";
            this.S4_btn.Size = new System.Drawing.Size(78, 47);
            this.S4_btn.TabIndex = 9;
            this.S4_btn.Text = "發大財";
            this.S4_btn.UseVisualStyleBackColor = true;
            this.S4_btn.Click += new System.EventHandler(this.S4_btn_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 354);
            this.Controls.Add(this.S4_btn);
            this.Controls.Add(this.S3_btn);
            this.Controls.Add(this.S1_btn);
            this.Controls.Add(this.S2_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.destroy_btn);
            this.Controls.Add(this.trigger_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Add_Form";
            this.Text = "Add Script";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button trigger_btn;
        private System.Windows.Forms.Button destroy_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button S2_btn;
        private System.Windows.Forms.Button S1_btn;
        private System.Windows.Forms.Button S3_btn;
        private System.Windows.Forms.Button S4_btn;
    }
}