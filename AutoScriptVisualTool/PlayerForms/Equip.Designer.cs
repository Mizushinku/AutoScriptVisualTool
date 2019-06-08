namespace AutoScriptVisualTool.PlayerForms
{
    partial class Equip
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
            this.acc = new System.Windows.Forms.TextBox();
            this.foot = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.hand = new System.Windows.Forms.TextBox();
            this.head = new System.Windows.Forms.TextBox();
            this.role_no = new System.Windows.Forms.TextBox();
            this.head_label = new System.Windows.Forms.Label();
            this.acc_label = new System.Windows.Forms.Label();
            this.foot_label = new System.Windows.Forms.Label();
            this.body_label = new System.Windows.Forms.Label();
            this.hand_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(192, 343);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(108, 25);
            this.acc.TabIndex = 29;
            // 
            // foot
            // 
            this.foot.Location = new System.Drawing.Point(192, 279);
            this.foot.Name = "foot";
            this.foot.Size = new System.Drawing.Size(108, 25);
            this.foot.TabIndex = 28;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(192, 222);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(108, 25);
            this.body.TabIndex = 27;
            // 
            // hand
            // 
            this.hand.Location = new System.Drawing.Point(192, 158);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(108, 25);
            this.hand.TabIndex = 26;
            // 
            // head
            // 
            this.head.Location = new System.Drawing.Point(192, 97);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(108, 25);
            this.head.TabIndex = 25;
            // 
            // role_no
            // 
            this.role_no.Location = new System.Drawing.Point(192, 29);
            this.role_no.Name = "role_no";
            this.role_no.Size = new System.Drawing.Size(108, 25);
            this.role_no.TabIndex = 24;
            // 
            // head_label
            // 
            this.head_label.AutoSize = true;
            this.head_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.head_label.Location = new System.Drawing.Point(64, 96);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(99, 20);
            this.head_label.TabIndex = 23;
            this.head_label.Text = "頭部裝備:";
            // 
            // acc_label
            // 
            this.acc_label.AutoSize = true;
            this.acc_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.acc_label.Location = new System.Drawing.Point(98, 348);
            this.acc_label.Name = "acc_label";
            this.acc_label.Size = new System.Drawing.Size(57, 20);
            this.acc_label.TabIndex = 22;
            this.acc_label.Text = "飾品:";
            // 
            // foot_label
            // 
            this.foot_label.AutoSize = true;
            this.foot_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foot_label.Location = new System.Drawing.Point(64, 279);
            this.foot_label.Name = "foot_label";
            this.foot_label.Size = new System.Drawing.Size(99, 20);
            this.foot_label.TabIndex = 21;
            this.foot_label.Text = "腳部裝備:";
            // 
            // body_label
            // 
            this.body_label.AutoSize = true;
            this.body_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.body_label.Location = new System.Drawing.Point(64, 222);
            this.body_label.Name = "body_label";
            this.body_label.Size = new System.Drawing.Size(99, 20);
            this.body_label.TabIndex = 20;
            this.body_label.Text = "身體裝備:";
            // 
            // hand_label
            // 
            this.hand_label.AutoSize = true;
            this.hand_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hand_label.Location = new System.Drawing.Point(64, 158);
            this.hand_label.Name = "hand_label";
            this.hand_label.Size = new System.Drawing.Size(99, 20);
            this.hand_label.TabIndex = 19;
            this.hand_label.Text = "手部裝備:";
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_label.Location = new System.Drawing.Point(64, 34);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(99, 20);
            this.role_label.TabIndex = 18;
            this.role_label.Text = "角色編號:";
            // 
            // Equip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.foot);
            this.Controls.Add(this.body);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.head);
            this.Controls.Add(this.role_no);
            this.Controls.Add(this.head_label);
            this.Controls.Add(this.acc_label);
            this.Controls.Add(this.foot_label);
            this.Controls.Add(this.body_label);
            this.Controls.Add(this.hand_label);
            this.Controls.Add(this.role_label);
            this.Name = "Equip";
            this.Text = "Equip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.TextBox foot;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox hand;
        private System.Windows.Forms.TextBox head;
        private System.Windows.Forms.TextBox role_no;
        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Label acc_label;
        private System.Windows.Forms.Label foot_label;
        private System.Windows.Forms.Label body_label;
        private System.Windows.Forms.Label hand_label;
        private System.Windows.Forms.Label role_label;
    }
}