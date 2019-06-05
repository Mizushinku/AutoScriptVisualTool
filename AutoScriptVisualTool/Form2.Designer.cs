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
            this.function_btn = new System.Windows.Forms.Button();
            this.main_script_cb = new System.Windows.Forms.CheckBox();
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
            // function_btn
            // 
            this.function_btn.Enabled = false;
            this.function_btn.Location = new System.Drawing.Point(129, 29);
            this.function_btn.Name = "function_btn";
            this.function_btn.Size = new System.Drawing.Size(78, 47);
            this.function_btn.TabIndex = 5;
            this.function_btn.Text = "Function";
            this.function_btn.UseVisualStyleBackColor = true;
            this.function_btn.Click += new System.EventHandler(this.function_btn_Click);
            // 
            // main_script_cb
            // 
            this.main_script_cb.AutoSize = true;
            this.main_script_cb.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_script_cb.Location = new System.Drawing.Point(21, 265);
            this.main_script_cb.Name = "main_script_cb";
            this.main_script_cb.Size = new System.Drawing.Size(123, 23);
            this.main_script_cb.TabIndex = 6;
            this.main_script_cb.Text = "程式進入點";
            this.main_script_cb.UseVisualStyleBackColor = true;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 354);
            this.Controls.Add(this.main_script_cb);
            this.Controls.Add(this.function_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.destroy_btn);
            this.Controls.Add(this.trigger_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Add_Form";
            this.Text = "Add Script";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button trigger_btn;
        private System.Windows.Forms.Button destroy_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button function_btn;
        private System.Windows.Forms.CheckBox main_script_cb;
    }
}