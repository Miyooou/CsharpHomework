using System;
using System.Drawing;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();
        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            txt1.Dock = System.Windows.Forms.DockStyle.Left;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求积";
            lbl.Text = "显示结果";
            this.Size = new Size(300, 120);
            btn.Click += new System.EventHandler(this.button1_Click);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string s = txt1.Text;
            string v = txt2.Text;
            double a = double.Parse(s);
            double b = double.Parse(v);
            double c = a * b;
            lbl.Text = a + "与" + b + "的乘积是:" + c;
        }
        static void Main()
        {
            Form1 f = new Form1();
            f.Text = "计算乘积";
            f.init();
            Application.Run(f);
        }

    }
}
