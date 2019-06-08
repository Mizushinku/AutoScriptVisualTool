namespace AutoScriptVisualTool.PlayerForms
{
    partial class Level
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
            this.level_lb = new System.Windows.Forms.Label();
            this.role2 = new System.Windows.Forms.TextBox();
            this.role1 = new System.Windows.Forms.TextBox();
            this.role0 = new System.Windows.Forms.TextBox();
            this.role2_lb = new System.Windows.Forms.Label();
            this.role1_lb = new System.Windows.Forms.Label();
            this.role0_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // level_lb
            // 
            this.level_lb.AutoSize = true;
            this.level_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.level_lb.Location = new System.Drawing.Point(143, 41);
            this.level_lb.Name = "level_lb";
            this.level_lb.Size = new System.Drawing.Size(51, 20);
            this.level_lb.TabIndex = 41;
            this.level_lb.Text = "等級";
            // 
            // role2
            // 
            this.role2.Location = new System.Drawing.Point(135, 197);
            this.role2.Name = "role2";
            this.role2.Size = new System.Drawing.Size(69, 25);
            this.role2.TabIndex = 40;
            // 
            // role1
            // 
            this.role1.Location = new System.Drawing.Point(135, 142);
            this.role1.Name = "role1";
            this.role1.Size = new System.Drawing.Size(69, 25);
            this.role1.TabIndex = 39;
            // 
            // role0
            // 
            this.role0.Location = new System.Drawing.Point(135, 89);
            this.role0.Name = "role0";
            this.role0.Size = new System.Drawing.Size(69, 25);
            this.role0.TabIndex = 38;
            // 
            // role2_lb
            // 
            this.role2_lb.AutoSize = true;
            this.role2_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role2_lb.Location = new System.Drawing.Point(61, 196);
            this.role2_lb.Name = "role2_lb";
            this.role2_lb.Size = new System.Drawing.Size(67, 20);
            this.role2_lb.TabIndex = 37;
            this.role2_lb.Text = "角色2:";
            // 
            // role1_lb
            // 
            this.role1_lb.AutoSize = true;
            this.role1_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role1_lb.Location = new System.Drawing.Point(61, 141);
            this.role1_lb.Name = "role1_lb";
            this.role1_lb.Size = new System.Drawing.Size(67, 20);
            this.role1_lb.TabIndex = 36;
            this.role1_lb.Text = "角色1:";
            // 
            // role0_lb
            // 
            this.role0_lb.AutoSize = true;
            this.role0_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role0_lb.Location = new System.Drawing.Point(61, 89);
            this.role0_lb.Name = "role0_lb";
            this.role0_lb.Size = new System.Drawing.Size(67, 20);
            this.role0_lb.TabIndex = 35;
            this.role0_lb.Text = "角色0:";
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.level_lb);
            this.Controls.Add(this.role2);
            this.Controls.Add(this.role1);
            this.Controls.Add(this.role0);
            this.Controls.Add(this.role2_lb);
            this.Controls.Add(this.role1_lb);
            this.Controls.Add(this.role0_lb);
            this.Name = "Level";
            this.Text = "Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label level_lb;
        private System.Windows.Forms.TextBox role2;
        private System.Windows.Forms.TextBox role1;
        private System.Windows.Forms.TextBox role0;
        private System.Windows.Forms.Label role2_lb;
        private System.Windows.Forms.Label role1_lb;
        private System.Windows.Forms.Label role0_lb;
    }
}