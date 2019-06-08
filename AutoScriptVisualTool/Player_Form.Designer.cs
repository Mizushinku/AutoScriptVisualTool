namespace AutoScriptVisualTool
{
    partial class Player_Form
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
            this.role_set = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.next_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // role_set
            // 
            this.role_set.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_set.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_set.FormattingEnabled = true;
            this.role_set.ItemHeight = 20;
            this.role_set.Location = new System.Drawing.Point(84, 47);
            this.role_set.Margin = new System.Windows.Forms.Padding(4);
            this.role_set.Name = "role_set";
            this.role_set.Size = new System.Drawing.Size(160, 28);
            this.role_set.TabIndex = 2;
            this.role_set.SelectedIndexChanged += new System.EventHandler(this.role_set_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 479);
            this.panel1.TabIndex = 3;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(502, 604);
            this.next_btn.Margin = new System.Windows.Forms.Padding(4);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(100, 29);
            this.next_btn.TabIndex = 5;
            this.next_btn.Text = "下一步";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(363, 604);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 29);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 646);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.role_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Player_Form";
            this.Text = "Player_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox role_set;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}