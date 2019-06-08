namespace AutoScriptVisualTool.PlayerForms
{
    partial class Learn
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
            this.skill_no = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.skill_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.role_no = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skill_no
            // 
            this.skill_no.Location = new System.Drawing.Point(187, 94);
            this.skill_no.Name = "skill_no";
            this.skill_no.Size = new System.Drawing.Size(114, 25);
            this.skill_no.TabIndex = 40;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(366, 84);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 35);
            this.add.TabIndex = 39;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "以新增技能:";
            // 
            // skill_list
            // 
            this.skill_list.FormattingEnabled = true;
            this.skill_list.ItemHeight = 15;
            this.skill_list.Location = new System.Drawing.Point(85, 181);
            this.skill_list.Name = "skill_list";
            this.skill_list.Size = new System.Drawing.Size(257, 274);
            this.skill_list.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(109, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "技能:";
            // 
            // role_no
            // 
            this.role_no.Location = new System.Drawing.Point(187, 46);
            this.role_no.Name = "role_no";
            this.role_no.Size = new System.Drawing.Size(114, 25);
            this.role_no.TabIndex = 35;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_label.Location = new System.Drawing.Point(67, 45);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(99, 20);
            this.role_label.TabIndex = 34;
            this.role_label.Text = "角色編號:";
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.skill_no);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skill_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role_no);
            this.Controls.Add(this.role_label);
            this.Name = "Learn";
            this.Text = "Learn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox skill_no;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox skill_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox role_no;
        private System.Windows.Forms.Label role_label;
    }
}