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

namespace WebDev2
{
    public partial class Starter : Form
    {
        public Form1 FE_f = new Form1();
        public string file_path = null;
        public Starter()
        {
            InitializeComponent();
        }

        private void _DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.Text))
            //    e.Effect = DragDropEffects.Copy;
            //else
            //    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.Copy;
        }

        private void dragndroparea_DragDrop(object sender, DragEventArgs e)
        {
            //textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void FE_btn_Click(object sender, EventArgs e)
        {
            if (file_path != null)
                FE_f.filepath = file_path;
            this.Hide();
            FE_f.ShowDialog();
            this.Show();


        }

        private void _DragDrop(object sender, DragEventArgs e)
        {
            //textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
            label1.Text = "Dropped";
            
            try
            {
                file_path = (e.Data.GetData(DataFormats.FileDrop, true) as string[])[0];
                label1.Text = file_path;
            }
            catch (Exception)
            {
                label1.Text = "file drop failed!";
                label1.ForeColor = Color.Red;
            }
            
            

        }

        private void close_clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Starter_Load(object sender, EventArgs e)
        {
            if (file_path != null)
            {
                label1.Text = file_path;
            }
        }
    }
}
