namespace AutoScriptVisualTool.ActionForms.Plot
{
    partial class Talk_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.index_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.file_cb = new System.Windows.Forms.CheckBox();
            this.index_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ch_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.con_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.path_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.index_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.file_cb);
            this.panel1.Controls.Add(this.index_cb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ch_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.con_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 402);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(135, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 14);
            this.label6.TabIndex = 59;
            this.label6.Text = "不須輸入$字號，數字即可";
            this.label6.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(431, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 58;
            this.button1.Text = "選擇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // path_tb
            // 
            this.path_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.path_tb.Location = new System.Drawing.Point(70, 253);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(355, 27);
            this.path_tb.TabIndex = 57;
            this.path_tb.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "路徑 :";
            this.label5.Visible = false;
            // 
            // index_tb
            // 
            this.index_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.index_tb.Location = new System.Drawing.Point(70, 212);
            this.index_tb.Name = "index_tb";
            this.index_tb.Size = new System.Drawing.Size(59, 27);
            this.index_tb.TabIndex = 55;
            this.index_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.index_tb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "索引 :";
            this.label4.Visible = false;
            // 
            // file_cb
            // 
            this.file_cb.AutoSize = true;
            this.file_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.file_cb.Location = new System.Drawing.Point(151, 154);
            this.file_cb.Name = "file_cb";
            this.file_cb.Size = new System.Drawing.Size(75, 20);
            this.file_cb.TabIndex = 53;
            this.file_cb.Text = "從檔案";
            this.file_cb.UseVisualStyleBackColor = true;
            this.file_cb.CheckedChanged += new System.EventHandler(this.file_cb_CheckedChanged);
            // 
            // index_cb
            // 
            this.index_cb.AutoSize = true;
            this.index_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.index_cb.Location = new System.Drawing.Point(70, 154);
            this.index_cb.Name = "index_cb";
            this.index_cb.Size = new System.Drawing.Size(75, 20);
            this.index_cb.TabIndex = 52;
            this.index_cb.Text = "從索引";
            this.index_cb.UseVisualStyleBackColor = true;
            this.index_cb.CheckedChanged += new System.EventHandler(this.index_cb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "角色 :";
            // 
            // ch_tb
            // 
            this.ch_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ch_tb.Location = new System.Drawing.Point(70, 92);
            this.ch_tb.Name = "ch_tb";
            this.ch_tb.Size = new System.Drawing.Size(202, 27);
            this.ch_tb.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "角色 :";
            // 
            // con_tb
            // 
            this.con_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.con_tb.Location = new System.Drawing.Point(70, 32);
            this.con_tb.Name = "con_tb";
            this.con_tb.Size = new System.Drawing.Size(375, 27);
            this.con_tb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "內文 :";
            // 
            // Talk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.panel1);
            this.Name = "Talk_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox con_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ch_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox file_cb;
        private System.Windows.Forms.CheckBox index_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox index_tb;
        private System.Windows.Forms.Label label6;
    }
}
