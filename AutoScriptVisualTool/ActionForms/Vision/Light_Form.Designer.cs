namespace AutoScriptVisualTool.ActionForms.Vision
{
    partial class Light_Form
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
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.range_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.color_pl = new System.Windows.Forms.Panel();
            this.color_pick_btn = new System.Windows.Forms.Button();
            this.blue_tb = new System.Windows.Forms.TextBox();
            this.green_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.red_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intensity_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.obj_name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // type_cb
            // 
            this.type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Items.AddRange(new object[] {
            "point",
            "spot",
            "all"});
            this.type_cb.Location = new System.Drawing.Point(129, 265);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(105, 24);
            this.type_cb.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(71, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "類型 :";
            // 
            // range_tb
            // 
            this.range_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.range_tb.Location = new System.Drawing.Point(129, 208);
            this.range_tb.Name = "range_tb";
            this.range_tb.Size = new System.Drawing.Size(52, 27);
            this.range_tb.TabIndex = 33;
            this.range_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(71, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "範圍 :";
            // 
            // color_pl
            // 
            this.color_pl.BackColor = System.Drawing.Color.White;
            this.color_pl.Location = new System.Drawing.Point(381, 93);
            this.color_pl.Name = "color_pl";
            this.color_pl.Size = new System.Drawing.Size(41, 27);
            this.color_pl.TabIndex = 31;
            // 
            // color_pick_btn
            // 
            this.color_pick_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color_pick_btn.Location = new System.Drawing.Point(445, 93);
            this.color_pick_btn.Name = "color_pick_btn";
            this.color_pick_btn.Size = new System.Drawing.Size(75, 23);
            this.color_pick_btn.TabIndex = 30;
            this.color_pick_btn.Text = "選擇";
            this.color_pick_btn.UseVisualStyleBackColor = true;
            this.color_pick_btn.Click += new System.EventHandler(this.color_pick_btn_Click);
            // 
            // blue_tb
            // 
            this.blue_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blue_tb.Location = new System.Drawing.Point(318, 93);
            this.blue_tb.Name = "blue_tb";
            this.blue_tb.Size = new System.Drawing.Size(40, 27);
            this.blue_tb.TabIndex = 29;
            this.blue_tb.Text = "0";
            this.blue_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.blue_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // green_tb
            // 
            this.green_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.green_tb.Location = new System.Drawing.Point(240, 93);
            this.green_tb.Name = "green_tb";
            this.green_tb.Size = new System.Drawing.Size(40, 27);
            this.green_tb.TabIndex = 28;
            this.green_tb.Text = "0";
            this.green_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.green_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(286, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "B :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(207, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "G :";
            // 
            // red_tb
            // 
            this.red_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.red_tb.Location = new System.Drawing.Point(161, 93);
            this.red_tb.Name = "red_tb";
            this.red_tb.Size = new System.Drawing.Size(40, 27);
            this.red_tb.TabIndex = 25;
            this.red_tb.Text = "0";
            this.red_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.red_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(129, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "R :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "顏色 :";
            // 
            // intensity_tb
            // 
            this.intensity_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.intensity_tb.Location = new System.Drawing.Point(129, 152);
            this.intensity_tb.Name = "intensity_tb";
            this.intensity_tb.Size = new System.Drawing.Size(52, 27);
            this.intensity_tb.TabIndex = 22;
            this.intensity_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(71, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "強度 :";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(200, 143);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(181, 45);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // obj_name_tb
            // 
            this.obj_name_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.obj_name_tb.Location = new System.Drawing.Point(129, 32);
            this.obj_name_tb.Name = "obj_name_tb";
            this.obj_name_tb.Size = new System.Drawing.Size(181, 27);
            this.obj_name_tb.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Object Name :";
            // 
            // Light_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 796);
            this.Controls.Add(this.type_cb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.range_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.color_pl);
            this.Controls.Add(this.color_pick_btn);
            this.Controls.Add(this.blue_tb);
            this.Controls.Add(this.green_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.red_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intensity_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.obj_name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Light_Form";
            this.Text = "Light_Form_2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox range_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel color_pl;
        private System.Windows.Forms.Button color_pick_btn;
        private System.Windows.Forms.TextBox blue_tb;
        private System.Windows.Forms.TextBox green_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox red_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intensity_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox obj_name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}