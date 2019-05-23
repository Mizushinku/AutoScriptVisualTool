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
            //find the checked rb
            RadioButton rb = logics_gb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if(rb == null)
            {
                MessageBox.Show("未選擇條件", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String crb_name = rb.Text;
            condstr = crb_name;
            if(make_condstr(rb.TabIndex))
            {
                MessageBox.Show(condstr);
            }
            else
            {
                MessageBox.Show("條件參數錯誤", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.DialogResult = DialogResult.OK;
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
                panel2.Controls.Clear();
            }
            else
            {
                int index = rb.TabIndex;
                if (index == (int)Logics.FOUND) draw_panel(1);
                else if (index >= (int)Logics.GT && index <= (int)Logics.SEQ) draw_panel(2, rb.Text);
                else if (index >= (int)Logics.AND && index <= (int)Logics.NOT) draw_panel(3, rb.Text);
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
                panel1.Controls["found_range_tb"].Focus();
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
                panel1.Controls["val_1_tb"].Focus();
            }
            else if(type ==3)
            {
                panel2.Controls.Add(new TreeView
                {
                    Name = "logic_tree_view",
                    Dock = DockStyle.Fill,
                    Font = new Font("新細明體", 12, FontStyle.Regular),
                });
                TreeView tv = (TreeView)panel2.Controls["logic_tree_view"];
                tv.AfterSelect += new TreeViewEventHandler(tree_view_AfterSelect);
                tv.Nodes.Add(new TreeNode(logic));
                if(logic == "not")
                {
                    tv.Nodes[0].Nodes.Add(makeNode("Cond"));
                }
                else
                {
                    tv.Nodes[0].Nodes.Add(makeNode("Cond1"));
                    tv.Nodes[0].Nodes.Add(makeNode("Cond2"));
                }
                tv.Nodes[0].Expand();
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

        private bool make_condstr(int index)
        {
            if (index == (int)Logics.FOUND)
            {
                String param1 = panel1.Controls["found_range_tb"].Text;
                if (param1 == String.Empty) return false;
                condstr = String.Format("{0} {1}", condstr, param1);
            }
            else if (index >= (int)Logics.GT && index <= (int)Logics.SEQ)
            {
                String param1 = panel1.Controls["val_1_tb"].Text;
                String param2 = panel1.Controls["val_2_tb"].Text;
                if (param1 == String.Empty || param2 == String.Empty) return false;
                condstr = String.Format("{0} {1} {2}", condstr, param1, param2);
            }

            return true;
        }

        private TreeNode makeNode(String text)
        {
            TreeNode tn = new TreeNode
            {
                Text = text,
                NodeFont = new Font("新細明體", 12, FontStyle.Bold)
            };
            return tn;
        }

        private void tree_view_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "Cond1")
            {
                ;
            }
            else if(e.Node.Text == "Cond2" || e.Node.Text == "Cond")
            {
                ;
            }
            else
            {
                ;
            }
        }
    }
}
