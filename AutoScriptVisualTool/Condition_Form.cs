using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptVisualTool
{
    public partial class Condition_Form : Form
    {
        public String condstr { get; set; } = "";
        private bool firstChecked = false;
        private enum Logics { GT, LT, GET, LET, EQ, SEQ, AS, UNLIKE, AND, OR, NOT, FOUND };

        public Condition_Form()
        {
            InitializeComponent();
            this.AcceptButton = OK_btn;
            this.CancelButton = cancel_btn;
            foreach(RadioButton rb in logics_gb.Controls.OfType<RadioButton>().ToList())
            {
                rb.CheckedChanged += new EventHandler(rb_CheckedChanged);
            }
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            //find the checked rb's name
            String crb_name = logics_gb.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text;
            condstr = crb_name;
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!firstChecked)
            {
                firstChecked = true;
                rb.Checked = false;
                return;
            }
            if (rb.Checked == false)
            {
                panel1.Controls.Clear();
            }
            else
            {
                int index = rb.TabIndex;
                if (index == (int)Logics.FOUND) draw_panel(1);
                if (index >= (int)Logics.GT && index <= (int)Logics.SEQ) draw_panel(2, rb.Text); 
            }
        }

        private void draw_panel(int type, String logic = "")
        {
            if(type == 1)
            {
                panel1.Controls.Add(new Label
                {
                    Text = "搜索範圍 :",
                    AutoSize = true,
                    Location = new Point(4, 4),
                });
                panel1.Controls.Add(new TextBox
                {
                    Name = "found_range_tb",
                    Location = new Point(70, 4),
                });
                set_mid();
            }
            else if(type == 2)
            {
                panel1.Controls.Add(new TextBox
                {
                    Name = "val_1_tb",
                    Location = new Point(4, 4),
                });
                panel1.Controls.Add(new Label
                {
                    Name = "logic_lb",
                    Text = logic,
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                    Size = new Size(41, 16),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(110, 4),
                });
                panel1.Controls.Add(new TextBox
                {
                    Name = "val_2_tb",
                    Location = new Point(158, 4),
                });
                set_mid();
            }
        }

        private void set_mid()
        {
            int mid = panel1.Height / 2;
            foreach (Control obj in panel1.Controls)
            {
                obj.Location = new Point(obj.Location.X, mid - obj.Height / 2);
            }
        }
    }
}
