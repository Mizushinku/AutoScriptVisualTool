namespace AutoScriptVisualTool.PlayerForms
{
    partial class Scene
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
            this.scene_name = new System.Windows.Forms.ComboBox();
            this.role_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scene_name
            // 
            this.scene_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scene_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scene_name.FormattingEnabled = true;
            this.scene_name.Location = new System.Drawing.Point(199, 83);
            this.scene_name.Name = "scene_name";
            this.scene_name.Size = new System.Drawing.Size(159, 28);
            this.scene_name.TabIndex = 12;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.role_label.Location = new System.Drawing.Point(82, 87);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(99, 20);
            this.role_label.TabIndex = 11;
            this.role_label.Text = "場景名稱:";
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.scene_name);
            this.Controls.Add(this.role_label);
            this.Name = "Scene";
            this.Text = "Scene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox scene_name;
        private System.Windows.Forms.Label role_label;
    }
}