namespace AutoScriptVisualTool.ActionForms.Vision
{
    partial class Anima_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.role_cb = new System.Windows.Forms.ComboBox();
            this.anima_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "動作 :";
            // 
            // role_cb
            // 
            this.role_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_cb.FormattingEnabled = true;
            this.role_cb.Items.AddRange(new object[] {
            "角色0 : (背包男性)",
            "角色1 : (扁帽)",
            "角色2 : (女性)"});
            this.role_cb.Location = new System.Drawing.Point(70, 32);
            this.role_cb.Name = "role_cb";
            this.role_cb.Size = new System.Drawing.Size(157, 24);
            this.role_cb.TabIndex = 2;
            this.role_cb.SelectedIndexChanged += new System.EventHandler(this.role_cb_SelectedIndexChanged);
            // 
            // anima_cb
            // 
            this.anima_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anima_cb.Enabled = false;
            this.anima_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.anima_cb.FormattingEnabled = true;
            this.anima_cb.Items.AddRange(new object[] {
            "角色0 : (背包男性)",
            "角色1 : (扁帽)",
            "角色2 : (女性)"});
            this.anima_cb.Location = new System.Drawing.Point(70, 92);
            this.anima_cb.Name = "anima_cb";
            this.anima_cb.Size = new System.Drawing.Size(202, 24);
            this.anima_cb.TabIndex = 3;
            // 
            // Anima_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.anima_cb);
            this.Controls.Add(this.role_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Anima_Form";
            this.Text = "Anima_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox role_cb;
        private System.Windows.Forms.ComboBox anima_cb;
    }
}