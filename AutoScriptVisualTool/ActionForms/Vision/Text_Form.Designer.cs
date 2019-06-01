namespace AutoScriptVisualTool.ActionForms.Vision
{
    partial class Text_Form
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
            this.label13 = new System.Windows.Forms.Label();
            this.exist_time_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.font_style_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.font_size_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.font_index_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.color_pl = new System.Windows.Forms.Panel();
            this.color_pick_btn = new System.Windows.Forms.Button();
            this.blue_tb = new System.Windows.Forms.TextBox();
            this.green_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.red_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pos_y_tb = new System.Windows.Forms.TextBox();
            this.pos_x_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.content_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name_tb = new System.Windows.Forms.TextBox();
            this.text_name_lb = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.exist_time_tb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.font_style_cb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.font_size_tb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.font_index_tb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.color_pl);
            this.panel1.Controls.Add(this.color_pick_btn);
            this.panel1.Controls.Add(this.blue_tb);
            this.panel1.Controls.Add(this.green_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.red_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pos_y_tb);
            this.panel1.Controls.Add(this.pos_x_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.content_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_name_tb);
            this.panel1.Controls.Add(this.text_name_lb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(169, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "(-1表示永久)";
            // 
            // exist_time_tb
            // 
            this.exist_time_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exist_time_tb.Location = new System.Drawing.Point(104, 332);
            this.exist_time_tb.Name = "exist_time_tb";
            this.exist_time_tb.Size = new System.Drawing.Size(59, 27);
            this.exist_time_tb.TabIndex = 48;
            this.exist_time_tb.Text = "-1";
            this.exist_time_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(12, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "存在時間 :";
            // 
            // font_style_cb
            // 
            this.font_style_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.font_style_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.font_style_cb.FormattingEnabled = true;
            this.font_style_cb.Items.AddRange(new object[] {
            "N : 正常",
            "I : 斜體",
            "B :粗體"});
            this.font_style_cb.Location = new System.Drawing.Point(379, 272);
            this.font_style_cb.Name = "font_style_cb";
            this.font_style_cb.Size = new System.Drawing.Size(80, 24);
            this.font_style_cb.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(319, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Style :";
            // 
            // font_size_tb
            // 
            this.font_size_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.font_size_tb.Location = new System.Drawing.Point(236, 272);
            this.font_size_tb.Name = "font_size_tb";
            this.font_size_tb.Size = new System.Drawing.Size(40, 27);
            this.font_size_tb.TabIndex = 44;
            this.font_size_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(178, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "大小 :";
            // 
            // font_index_tb
            // 
            this.font_index_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.font_index_tb.Location = new System.Drawing.Point(104, 272);
            this.font_index_tb.Name = "font_index_tb";
            this.font_index_tb.Size = new System.Drawing.Size(40, 27);
            this.font_index_tb.TabIndex = 42;
            this.font_index_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "字型編號 :";
            // 
            // color_pl
            // 
            this.color_pl.BackColor = System.Drawing.Color.White;
            this.color_pl.Location = new System.Drawing.Point(322, 212);
            this.color_pl.Name = "color_pl";
            this.color_pl.Size = new System.Drawing.Size(41, 27);
            this.color_pl.TabIndex = 40;
            // 
            // color_pick_btn
            // 
            this.color_pick_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color_pick_btn.Location = new System.Drawing.Point(386, 212);
            this.color_pick_btn.Name = "color_pick_btn";
            this.color_pick_btn.Size = new System.Drawing.Size(75, 23);
            this.color_pick_btn.TabIndex = 39;
            this.color_pick_btn.Text = "選擇";
            this.color_pick_btn.UseVisualStyleBackColor = true;
            this.color_pick_btn.Click += new System.EventHandler(this.color_pick_btn_Click);
            // 
            // blue_tb
            // 
            this.blue_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blue_tb.Location = new System.Drawing.Point(259, 212);
            this.blue_tb.Name = "blue_tb";
            this.blue_tb.Size = new System.Drawing.Size(40, 27);
            this.blue_tb.TabIndex = 38;
            this.blue_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.blue_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // green_tb
            // 
            this.green_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.green_tb.Location = new System.Drawing.Point(181, 212);
            this.green_tb.Name = "green_tb";
            this.green_tb.Size = new System.Drawing.Size(40, 27);
            this.green_tb.TabIndex = 37;
            this.green_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.green_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(227, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "B :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(148, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "G :";
            // 
            // red_tb
            // 
            this.red_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.red_tb.Location = new System.Drawing.Point(102, 212);
            this.red_tb.Name = "red_tb";
            this.red_tb.Size = new System.Drawing.Size(40, 27);
            this.red_tb.TabIndex = 34;
            this.red_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.red_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(70, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "R :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(12, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "顏色 :";
            // 
            // pos_y_tb
            // 
            this.pos_y_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pos_y_tb.Location = new System.Drawing.Point(222, 152);
            this.pos_y_tb.Name = "pos_y_tb";
            this.pos_y_tb.Size = new System.Drawing.Size(59, 27);
            this.pos_y_tb.TabIndex = 8;
            this.pos_y_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pos_x_tb
            // 
            this.pos_x_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pos_x_tb.Location = new System.Drawing.Point(103, 152);
            this.pos_x_tb.Name = "pos_x_tb";
            this.pos_x_tb.Size = new System.Drawing.Size(59, 27);
            this.pos_x_tb.TabIndex = 7;
            this.pos_x_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(189, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(70, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "位置 :";
            // 
            // content_tb
            // 
            this.content_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.content_tb.Location = new System.Drawing.Point(70, 92);
            this.content_tb.Name = "content_tb";
            this.content_tb.Size = new System.Drawing.Size(373, 27);
            this.content_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "內文 :";
            // 
            // text_name_tb
            // 
            this.text_name_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_name_tb.Location = new System.Drawing.Point(116, 32);
            this.text_name_tb.Name = "text_name_tb";
            this.text_name_tb.Size = new System.Drawing.Size(158, 27);
            this.text_name_tb.TabIndex = 1;
            // 
            // text_name_lb
            // 
            this.text_name_lb.AutoSize = true;
            this.text_name_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_name_lb.Location = new System.Drawing.Point(12, 35);
            this.text_name_lb.Name = "text_name_lb";
            this.text_name_lb.Size = new System.Drawing.Size(98, 16);
            this.text_name_lb.TabIndex = 0;
            this.text_name_lb.Text = "(textName) :";
            // 
            // Text_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1228, 835);
            this.Controls.Add(this.panel1);
            this.Name = "Text_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label text_name_lb;
        private System.Windows.Forms.TextBox text_name_tb;
        private System.Windows.Forms.TextBox content_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel color_pl;
        private System.Windows.Forms.Button color_pick_btn;
        private System.Windows.Forms.TextBox blue_tb;
        private System.Windows.Forms.TextBox green_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox red_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox font_style_cb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox font_size_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox font_index_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox exist_time_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pos_y_tb;
        private System.Windows.Forms.TextBox pos_x_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
