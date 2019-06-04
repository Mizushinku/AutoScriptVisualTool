namespace AutoScriptVisualTool.ActionForms.Create
{
    partial class ChangeNPC_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attr_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_tb.Location = new System.Drawing.Point(114, 32);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(202, 27);
            this.name_tb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "NPC Name :";
            // 
            // attr_cb
            // 
            this.attr_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attr_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attr_cb.FormattingEnabled = true;
            this.attr_cb.Items.AddRange(new object[] {
            "Sight",
            "AttSight",
            "Hp",
            "Att",
            "Def",
            "Level",
            "Exp",
            "CD",
            "AI",
            "Target",
            "Weapon",
            "WeaponOut",
            "WeaponOffset"});
            this.attr_cb.Location = new System.Drawing.Point(70, 92);
            this.attr_cb.Name = "attr_cb";
            this.attr_cb.Size = new System.Drawing.Size(169, 24);
            this.attr_cb.TabIndex = 49;
            this.attr_cb.SelectedIndexChanged += new System.EventHandler(this.attr_cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "屬性 :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 307);
            this.panel1.TabIndex = 51;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.c1,
            this.c2});
            this.listView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(223, 145);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 163);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // c1
            // 
            this.c1.Text = "屬性";
            this.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.Text = "值";
            this.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c2.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 54;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeNPC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attr_cb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "ChangeNPC_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox attr_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.Button button1;
    }
}
