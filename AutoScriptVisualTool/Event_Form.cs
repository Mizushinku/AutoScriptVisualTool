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
    public partial class Event_Form : Form
    {
        public Event_Form(int which)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            if(which == 1)
            {
                //start class
                add_cb_in_p1("static_cb", "static");
            }
            else if(which == 2)
            {
                //trigger class
                add_lb_in_p1("觸發範圍", 12, 12, 22);
                add_nud_in_p1("range_nud", 12, 47);
                add_lb_in_p1("提示文字", 12, 172, 22);
                add_tb_in_p1("hint_tb", 172, 47);
            }
            else if(which == 3)
            {
                //destroy class
            }
            else if(which == 4)
            {
                //update
                add_lb_in_p1("執行週期(s)", 12, 12, 22);
                add_tb_in_p1("freq_tb", 12, 47);
            }
        }

        private void add_cb_in_p1(String name, String text)
        {
            splitContainer1.Panel1.Controls.Add(new CheckBox
            {
                Name = name,
                Text = text,
                Dock = DockStyle.Left,
                Padding = new Padding(10, 0, 0, 0)
            });
        }

        private void add_lb_in_p1(String text,int text_size, int x, int y)
        {
            splitContainer1.Panel1.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("新細明體", text_size, FontStyle.Regular),
                Location = new Point(x, y)
            });
        }

        private void add_nud_in_p1(String name, int x, int y)
        {
            splitContainer1.Panel1.Controls.Add(new NumericUpDown
            {
                Name = name,
                Location = new Point(x, y)
            });
        }

        private void add_tb_in_p1(String name, int x, int y)
        {
            splitContainer1.Panel1.Controls.Add(new TextBox
            {
                Name = name,
                Location = new Point(x, y)
            });
        }
    }
}
