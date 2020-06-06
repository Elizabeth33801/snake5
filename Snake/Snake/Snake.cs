using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Snake
{
  public partial class Snake : Form
  {
    public Snake()
    {
      InitializeComponent();
    }

        private void Snake_Load(object sender, EventArgs e)
        {
      pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Desktop\Snake50\Snake\Snake\bin\Debug\snake2.gif");
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    private void button1_Click(object sender, EventArgs e)
    {
      Form1 frm2 = new Form1();

      frm2.Show();
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(@"C:\Users\pc\Desktop\Snake50\Snake\Snake\bin\Debug\Informacion.docx");
    }
  }
}
