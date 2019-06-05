namespace AutoScriptVisualTool
{
    partial class mainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.start_page = new System.Windows.Forms.TabPage();
            this.start_list = new System.Windows.Forms.ListBox();
            this.trigger_page = new System.Windows.Forms.TabPage();
            this.trigger_list = new System.Windows.Forms.ListBox();
            this.destroy_page = new System.Windows.Forms.TabPage();
            this.destroy_list = new System.Windows.Forms.ListBox();
            this.update_page = new System.Windows.Forms.TabPage();
            this.update_list = new System.Windows.Forms.ListBox();
            this.player_page = new System.Windows.Forms.TabPage();
            this.player_list = new System.Windows.Forms.ListBox();
            this.function_page = new System.Windows.Forms.TabPage();
            this.function_list = new System.Windows.Forms.ListBox();
            this.default_page = new System.Windows.Forms.TabPage();
            this.default_list = new System.Windows.Forms.ListBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_action_btn = new System.Windows.Forms.Button();
            this.add_cond_btn = new System.Windows.Forms.Button();
            this.newClass_btn = new System.Windows.Forms.Button();
            this.add_label_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.start_page.SuspendLayout();
            this.trigger_page.SuspendLayout();
            this.destroy_page.SuspendLayout();
            this.update_page.SuspendLayout();
            this.player_page.SuspendLayout();
            this.function_page.SuspendLayout();
            this.default_page.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1086, 630);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.main_panel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1080, 561);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.start_page);
            this.tabControl1.Controls.Add(this.trigger_page);
            this.tabControl1.Controls.Add(this.destroy_page);
            this.tabControl1.Controls.Add(this.update_page);
            this.tabControl1.Controls.Add(this.player_page);
            this.tabControl1.Controls.Add(this.function_page);
            this.tabControl1.Controls.Add(this.default_page);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 26);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(210, 555);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // start_page
            // 
            this.start_page.Controls.Add(this.start_list);
            this.start_page.Location = new System.Drawing.Point(4, 56);
            this.start_page.Name = "start_page";
            this.start_page.Padding = new System.Windows.Forms.Padding(3);
            this.start_page.Size = new System.Drawing.Size(202, 495);
            this.start_page.TabIndex = 0;
            this.start_page.Text = "Start";
            this.start_page.UseVisualStyleBackColor = true;
            // 
            // start_list
            // 
            this.start_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start_list.FormattingEnabled = true;
            this.start_list.ItemHeight = 21;
            this.start_list.Location = new System.Drawing.Point(3, 3);
            this.start_list.Name = "start_list";
            this.start_list.Size = new System.Drawing.Size(196, 489);
            this.start_list.TabIndex = 0;
            this.start_list.SelectedIndexChanged += new System.EventHandler(this.start_list_SelectedIndexChanged);
            // 
            // trigger_page
            // 
            this.trigger_page.Controls.Add(this.trigger_list);
            this.trigger_page.Location = new System.Drawing.Point(4, 56);
            this.trigger_page.Name = "trigger_page";
            this.trigger_page.Padding = new System.Windows.Forms.Padding(3);
            this.trigger_page.Size = new System.Drawing.Size(202, 495);
            this.trigger_page.TabIndex = 1;
            this.trigger_page.Text = "Trigger";
            this.trigger_page.UseVisualStyleBackColor = true;
            // 
            // trigger_list
            // 
            this.trigger_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trigger_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trigger_list.FormattingEnabled = true;
            this.trigger_list.ItemHeight = 21;
            this.trigger_list.Location = new System.Drawing.Point(3, 3);
            this.trigger_list.Name = "trigger_list";
            this.trigger_list.Size = new System.Drawing.Size(196, 489);
            this.trigger_list.TabIndex = 1;
            this.trigger_list.SelectedIndexChanged += new System.EventHandler(this.trigger_list_SelectedIndexChanged);
            // 
            // destroy_page
            // 
            this.destroy_page.Controls.Add(this.destroy_list);
            this.destroy_page.Location = new System.Drawing.Point(4, 56);
            this.destroy_page.Name = "destroy_page";
            this.destroy_page.Padding = new System.Windows.Forms.Padding(3);
            this.destroy_page.Size = new System.Drawing.Size(202, 495);
            this.destroy_page.TabIndex = 2;
            this.destroy_page.Text = "Destroy";
            this.destroy_page.UseVisualStyleBackColor = true;
            // 
            // destroy_list
            // 
            this.destroy_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destroy_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.destroy_list.FormattingEnabled = true;
            this.destroy_list.ItemHeight = 21;
            this.destroy_list.Location = new System.Drawing.Point(3, 3);
            this.destroy_list.Name = "destroy_list";
            this.destroy_list.Size = new System.Drawing.Size(196, 489);
            this.destroy_list.TabIndex = 1;
            this.destroy_list.SelectedIndexChanged += new System.EventHandler(this.destroy_list_SelectedIndexChanged);
            // 
            // update_page
            // 
            this.update_page.Controls.Add(this.update_list);
            this.update_page.Location = new System.Drawing.Point(4, 56);
            this.update_page.Name = "update_page";
            this.update_page.Padding = new System.Windows.Forms.Padding(3);
            this.update_page.Size = new System.Drawing.Size(202, 495);
            this.update_page.TabIndex = 3;
            this.update_page.Text = "Update";
            this.update_page.UseVisualStyleBackColor = true;
            // 
            // update_list
            // 
            this.update_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_list.FormattingEnabled = true;
            this.update_list.ItemHeight = 21;
            this.update_list.Location = new System.Drawing.Point(3, 3);
            this.update_list.Name = "update_list";
            this.update_list.Size = new System.Drawing.Size(196, 489);
            this.update_list.TabIndex = 1;
            this.update_list.SelectedIndexChanged += new System.EventHandler(this.update_list_SelectedIndexChanged);
            // 
            // player_page
            // 
            this.player_page.Controls.Add(this.player_list);
            this.player_page.Location = new System.Drawing.Point(4, 56);
            this.player_page.Name = "player_page";
            this.player_page.Padding = new System.Windows.Forms.Padding(3);
            this.player_page.Size = new System.Drawing.Size(202, 495);
            this.player_page.TabIndex = 4;
            this.player_page.Text = "Player";
            this.player_page.UseVisualStyleBackColor = true;
            // 
            // player_list
            // 
            this.player_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player_list.FormattingEnabled = true;
            this.player_list.ItemHeight = 21;
            this.player_list.Location = new System.Drawing.Point(3, 3);
            this.player_list.Name = "player_list";
            this.player_list.Size = new System.Drawing.Size(196, 489);
            this.player_list.TabIndex = 0;
            this.player_list.SelectedIndexChanged += new System.EventHandler(this.player_list_SelectedIndexChanged);
            // 
            // function_page
            // 
            this.function_page.Controls.Add(this.function_list);
            this.function_page.Location = new System.Drawing.Point(4, 56);
            this.function_page.Name = "function_page";
            this.function_page.Padding = new System.Windows.Forms.Padding(3);
            this.function_page.Size = new System.Drawing.Size(202, 495);
            this.function_page.TabIndex = 5;
            this.function_page.Text = "Function";
            this.function_page.UseVisualStyleBackColor = true;
            // 
            // function_list
            // 
            this.function_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.function_list.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.function_list.FormattingEnabled = true;
            this.function_list.ItemHeight = 21;
            this.function_list.Location = new System.Drawing.Point(3, 3);
            this.function_list.Name = "function_list";
            this.function_list.Size = new System.Drawing.Size(196, 489);
            this.function_list.TabIndex = 0;
            this.function_list.SelectedIndexChanged += new System.EventHandler(this.function_list_SelectedIndexChanged);
            // 
            // default_page
            // 
            this.default_page.Controls.Add(this.default_list);
            this.default_page.Location = new System.Drawing.Point(4, 56);
            this.default_page.Name = "default_page";
            this.default_page.Padding = new System.Windows.Forms.Padding(3);
            this.default_page.Size = new System.Drawing.Size(202, 495);
            this.default_page.TabIndex = 6;
            this.default_page.Text = "Default";
            this.default_page.UseVisualStyleBackColor = true;
            // 
            // default_list
            // 
            this.default_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.default_list.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.default_list.FormattingEnabled = true;
            this.default_list.ItemHeight = 21;
            this.default_list.Location = new System.Drawing.Point(3, 3);
            this.default_list.Name = "default_list";
            this.default_list.Size = new System.Drawing.Size(196, 489);
            this.default_list.TabIndex = 0;
            this.default_list.SelectedIndexChanged += new System.EventHandler(this.default_list_SelectedIndexChanged);
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(216, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(864, 561);
            this.main_panel.TabIndex = 1;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.add_btn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1080, 57);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_btn.Location = new System.Drawing.Point(3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(68, 51);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_label_btn);
            this.panel1.Controls.Add(this.add_action_btn);
            this.panel1.Controls.Add(this.add_cond_btn);
            this.panel1.Controls.Add(this.newClass_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 57);
            this.panel1.TabIndex = 5;
            // 
            // add_action_btn
            // 
            this.add_action_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_action_btn.Location = new System.Drawing.Point(150, 0);
            this.add_action_btn.Name = "add_action_btn";
            this.add_action_btn.Size = new System.Drawing.Size(75, 57);
            this.add_action_btn.TabIndex = 2;
            this.add_action_btn.Text = "Add\r\nAction";
            this.add_action_btn.UseVisualStyleBackColor = true;
            this.add_action_btn.Click += new System.EventHandler(this.add_action_btn_Click);
            // 
            // add_cond_btn
            // 
            this.add_cond_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_cond_btn.Location = new System.Drawing.Point(75, 0);
            this.add_cond_btn.Name = "add_cond_btn";
            this.add_cond_btn.Size = new System.Drawing.Size(75, 57);
            this.add_cond_btn.TabIndex = 1;
            this.add_cond_btn.Text = "Add\r\nCondition";
            this.add_cond_btn.UseVisualStyleBackColor = true;
            this.add_cond_btn.Click += new System.EventHandler(this.add_cond_btn_Click);
            // 
            // newClass_btn
            // 
            this.newClass_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newClass_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.newClass_btn.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newClass_btn.Location = new System.Drawing.Point(0, 0);
            this.newClass_btn.Name = "newClass_btn";
            this.newClass_btn.Size = new System.Drawing.Size(75, 57);
            this.newClass_btn.TabIndex = 0;
            this.newClass_btn.Text = "New Class";
            this.newClass_btn.UseVisualStyleBackColor = false;
            this.newClass_btn.Click += new System.EventHandler(this.newClass_btn_Click);
            // 
            // add_label_btn
            // 
            this.add_label_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_label_btn.Location = new System.Drawing.Point(225, 0);
            this.add_label_btn.Name = "add_label_btn";
            this.add_label_btn.Size = new System.Drawing.Size(75, 57);
            this.add_label_btn.TabIndex = 3;
            this.add_label_btn.Text = "Add\r\nLabel";
            this.add_label_btn.UseVisualStyleBackColor = true;
            this.add_label_btn.Click += new System.EventHandler(this.add_label_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "ASVisualTool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.start_page.ResumeLayout(false);
            this.trigger_page.ResumeLayout(false);
            this.destroy_page.ResumeLayout(false);
            this.update_page.ResumeLayout(false);
            this.player_page.ResumeLayout(false);
            this.function_page.ResumeLayout(false);
            this.default_page.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newClass_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage start_page;
        private System.Windows.Forms.ListBox start_list;
        private System.Windows.Forms.TabPage trigger_page;
        private System.Windows.Forms.ListBox trigger_list;
        private System.Windows.Forms.TabPage destroy_page;
        private System.Windows.Forms.ListBox destroy_list;
        private System.Windows.Forms.TabPage update_page;
        private System.Windows.Forms.ListBox update_list;
        private System.Windows.Forms.TabPage player_page;
        private System.Windows.Forms.TabPage function_page;
        private System.Windows.Forms.TabPage default_page;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button add_cond_btn;
        private System.Windows.Forms.ListBox default_list;
        private System.Windows.Forms.ListBox player_list;
        private System.Windows.Forms.ListBox function_list;
        private System.Windows.Forms.Button add_action_btn;
        private System.Windows.Forms.Button add_label_btn;
    }
}

