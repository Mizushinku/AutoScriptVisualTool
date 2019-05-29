namespace AutoScriptVisualTool.ActionForms.Vision
{
    partial class Fade_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fade_time_tb = new System.Windows.Forms.TextBox();
            this.wait_time_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.color_pl = new System.Windows.Forms.Panel();
            this.color_pick_btn = new System.Windows.Forms.Button();
            this.blue_tb = new System.Windows.Forms.TextBox();
            this.green_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.red_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fade_time_tb);
            this.panel1.Controls.Add(this.wait_time_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.color_pl);
            this.panel1.Controls.Add(this.color_pick_btn);
            this.panel1.Controls.Add(this.blue_tb);
            this.panel1.Controls.Add(this.green_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.red_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            // 
            // fade_time_tb
            // 
            this.fade_time_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fade_time_tb.Location = new System.Drawing.Point(104, 152);
            this.fade_time_tb.Name = "fade_time_tb";
            this.fade_time_tb.Size = new System.Drawing.Size(61, 27);
            this.fade_time_tb.TabIndex = 44;
            this.fade_time_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // wait_time_tb
            // 
            this.wait_time_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wait_time_tb.Location = new System.Drawing.Point(104, 92);
            this.wait_time_tb.Name = "wait_time_tb";
            this.wait_time_tb.Size = new System.Drawing.Size(61, 27);
            this.wait_time_tb.TabIndex = 43;
            this.wait_time_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "淡入時長 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "維持時間 :";
            // 
            // color_pl
            // 
            this.color_pl.BackColor = System.Drawing.Color.White;
            this.color_pl.Location = new System.Drawing.Point(322, 32);
            this.color_pl.Name = "color_pl";
            this.color_pl.Size = new System.Drawing.Size(41, 27);
            this.color_pl.TabIndex = 40;
            // 
            // color_pick_btn
            // 
            this.color_pick_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color_pick_btn.Location = new System.Drawing.Point(386, 32);
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
            this.blue_tb.Location = new System.Drawing.Point(259, 32);
            this.blue_tb.Name = "blue_tb";
            this.blue_tb.Size = new System.Drawing.Size(40, 27);
            this.blue_tb.TabIndex = 38;
            this.blue_tb.Text = "0";
            this.blue_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.blue_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // green_tb
            // 
            this.green_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.green_tb.Location = new System.Drawing.Point(181, 32);
            this.green_tb.Name = "green_tb";
            this.green_tb.Size = new System.Drawing.Size(40, 27);
            this.green_tb.TabIndex = 37;
            this.green_tb.Text = "0";
            this.green_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.green_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(227, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "B :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(148, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "G :";
            // 
            // red_tb
            // 
            this.red_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.red_tb.Location = new System.Drawing.Point(102, 32);
            this.red_tb.Name = "red_tb";
            this.red_tb.Size = new System.Drawing.Size(40, 27);
            this.red_tb.TabIndex = 34;
            this.red_tb.Text = "0";
            this.red_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.red_tb.TextChanged += new System.EventHandler(this.color_tb_textChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(70, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "R :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "顏色 :";
            // 
            // Fade_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 835);
            this.Controls.Add(this.panel1);
            this.Name = "Fade_Form";
            this.Text = "FadeIn_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel color_pl;
        private System.Windows.Forms.Button color_pick_btn;
        private System.Windows.Forms.TextBox blue_tb;
        private System.Windows.Forms.TextBox green_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox red_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fade_time_tb;
        private System.Windows.Forms.TextBox wait_time_tb;
    }
}