/////////////////////////////
///////制作By DTSDAO/////////
///////重写于2016.2.2////////
/////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZBTool
{
    public partial class Console : Form
    {
        public Console()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("前面的是宽，后面的是高，请输入一个整数!Minecraft窗口大小：长854宽480");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.Show();
            f.Hide();

            if (checkBox1.Checked == true)
            {
                if (label6.Text != "<未选择>")//判断图标是否选择
                    f.Icon = new Icon(label6.Text);//通过label6也就是选择的文件的路径设置窗口图标
                else MessageBox.Show("您还没有选择图标！");//处理错误
            }

            if (checkBox2.Checked == true)
            {
                if (label9.Text != "<未选择>")//判断图片是否选择
                    f.BackgroundImage = Image.FromFile(label9.Text);//通过label9也就是选择的文件的路径设置窗口背景
                else MessageBox.Show("您还没有选择图片！");//处理错误
                //上面更改背景///////////////////////////////下面更改样式
                if (radioButton1.Checked)
                    f.BackgroundImageLayout = ImageLayout.None;
                else if (radioButton2.Checked)
                    f.BackgroundImageLayout = ImageLayout.Tile;
                else if (radioButton3.Checked)
                    f.BackgroundImageLayout = ImageLayout.Center;
                else if (radioButton4.Checked)
                    f.BackgroundImageLayout = ImageLayout.Stretch;
                else if (radioButton5.Checked)
                    f.BackgroundImageLayout = ImageLayout.Zoom;
            }
            
            if (checkBox3.Checked == true)
                f.Text = textBox1.Text;//修改窗口标题为textbox1的文本

            if (checkBox4.Checked == true)
            {
                try//测试是否可以转换
                {
                    int width = int.Parse(textBox2.Text);//转换数字
                    int height = int.Parse(textBox3.Text);//转换数字
                    f.Width = width;//设置窗口宽度
                    f.Height = height;//设置窗口高度
                }
                catch
                {
                    MessageBox.Show("请输入整数!");//处理错误
                }
            }

            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "图标文件(*.ico)|*.ico";//设置获取文件的文件类型
            this.openFileDialog1.FileName = "icon.ico";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)//创建选择文件窗口
            {
                string iconfile = this.openFileDialog1.FileName;//获取选择的文件的路径
                label6.Text = iconfile;//把路径输出
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog2.Filter = "图片文件(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";//设置获取文件的文件类型
            this.openFileDialog2.FileName = "background.jpg";//默认文件
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)//创建选择文件窗口
            {
                string imgfile = this.openFileDialog2.FileName;//获取选择的文件的路径
                label9.Text = imgfile;//把路径输出
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bitbug.net");//图标制作网站
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://me.nutcore.net");//作者主页
        }

        private void label13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wpa.qq.com/msgrd?v=3&uin=1713679348&site=qq&menu=yes");//作者QQ
        }

        private void label15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:dtsdao@aliyun.com");//作者邮箱
        }
    }
}
