using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoScriptVisualTool
{
    public partial class Setting_Form : Form
    {
        public Setting_Form()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void add_act_btn_Click(object sender, EventArgs e)
        {            
            Player_Form player_Form = new Player_Form();
            if (player_Form.ShowDialog() == DialogResult.OK)
            {
                event_list.Items.Add(player_Form.actstr);
            }            
        }

        private void outfile_btn_Click(object sender, EventArgs e)
        {
            if (event_list.Items.Count == 0)
            {
                MessageBox.Show("檔案不能為空", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string path = "";
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show(this, "資料夾路徑不能為空", "提示");
                        return;
                    }
                    path = dialog.SelectedPath;
                }
                FileInfo finfo = new FileInfo(path + "/player.txt");
                StreamWriter sw = finfo.CreateText();
                foreach (object line in event_list.Items)
                {
                    sw.WriteLine(line.ToString());
                    sw.Flush();
                }
                sw.Close();
                DialogResult result = MessageBox.Show("檔案輸出成功!是否加密?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Cipher.encode(path + "/player.txt", path + "/player.txt", (char)0X8C);
                    MessageBox.Show("檔案加密完成!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
    }
}
