﻿namespace AutoScriptVisualTool.ActionForms.Plot
{
    partial class Shop_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index_tb = new System.Windows.Forms.TextBox();
            this.copies_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sell_cb = new System.Windows.Forms.CheckBox();
            this.buy_cb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ac_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_tb.Location = new System.Drawing.Point(77, 32);
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
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "品項 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "商品索引 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "庫存數量 :";
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
            this.listView1.Location = new System.Drawing.Point(31, 222);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 148);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // c1
            // 
            this.c1.Text = "商品索引";
            this.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1.Width = 76;
            // 
            // c2
            // 
            this.c2.Text = "庫存數量";
            this.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c2.Width = 76;
            // 
            // index_tb
            // 
            this.index_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.index_tb.Location = new System.Drawing.Point(114, 138);
            this.index_tb.Name = "index_tb";
            this.index_tb.Size = new System.Drawing.Size(59, 27);
            this.index_tb.TabIndex = 59;
            this.index_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // copies_tb
            // 
            this.copies_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.copies_tb.Location = new System.Drawing.Point(114, 171);
            this.copies_tb.Name = "copies_tb";
            this.copies_tb.Size = new System.Drawing.Size(59, 27);
            this.copies_tb.TabIndex = 60;
            this.copies_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(204, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 61;
            this.button1.Text = "加入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "設定 :";
            // 
            // sell_cb
            // 
            this.sell_cb.AutoSize = true;
            this.sell_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sell_cb.Location = new System.Drawing.Point(70, 399);
            this.sell_cb.Name = "sell_cb";
            this.sell_cb.Size = new System.Drawing.Size(48, 20);
            this.sell_cb.TabIndex = 63;
            this.sell_cb.Text = "sell";
            this.sell_cb.UseVisualStyleBackColor = true;
            this.sell_cb.CheckedChanged += new System.EventHandler(this.sell_cb_CheckedChanged);
            // 
            // buy_cb
            // 
            this.buy_cb.AutoSize = true;
            this.buy_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buy_cb.Location = new System.Drawing.Point(124, 399);
            this.buy_cb.Name = "buy_cb";
            this.buy_cb.Size = new System.Drawing.Size(51, 20);
            this.buy_cb.TabIndex = 64;
            this.buy_cb.Text = "buy";
            this.buy_cb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Accept Type :";
            this.label6.Visible = false;
            // 
            // ac_cb
            // 
            this.ac_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ac_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ac_cb.FormattingEnabled = true;
            this.ac_cb.Items.AddRange(new object[] {
            "common:一般道具",
            "equip:裝備",
            "mat:素材",
            "book:技能書"});
            this.ac_cb.Location = new System.Drawing.Point(127, 447);
            this.ac_cb.Name = "ac_cb";
            this.ac_cb.Size = new System.Drawing.Size(163, 24);
            this.ac_cb.TabIndex = 66;
            this.ac_cb.Visible = false;
            // 
            // Shop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 918);
            this.Controls.Add(this.ac_cb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buy_cb);
            this.Controls.Add(this.sell_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copies_tb);
            this.Controls.Add(this.index_tb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Shop_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.TextBox index_tb;
        private System.Windows.Forms.TextBox copies_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox sell_cb;
        private System.Windows.Forms.CheckBox buy_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ac_cb;
    }
}
