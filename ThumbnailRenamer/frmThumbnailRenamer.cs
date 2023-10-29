using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThumbnailRenamer
{
    public partial class frmThumbnailRenamer : Form
    {
        public frmThumbnailRenamer()
        {
            InitializeComponent();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtSourceFolder.Text = fbd.SelectedPath;
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtDestinationFolder.Text = fbd.SelectedPath;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string source = txtSourceFolder.Text;
            string destionation = txtDestinationFolder.Text;
            string tag = txtTag.Text;
            string overrideExtension = txtOverride.Text;

            if (string.IsNullOrEmpty(source))
            {
                MessageBox.Show("You need to select a Source folder");
                return;
            }

            if (string.IsNullOrEmpty(destionation))
            {
                MessageBox.Show("You need to select a Destination folder");
                return;
            }

            if (string.IsNullOrEmpty(tag))
            {
                MessageBox.Show("You need to select a Tag");
                return;
            }

            if (string.IsNullOrEmpty(overrideExtension))
            {
                MessageBox.Show("You need to select an Override Extension");
                return;
            }

            string[] files = Directory.GetFiles(source);

            pgBar.Minimum = 0;
            pgBar.Maximum = files.Length;
            pgBar.Value = 0;

            foreach (string file in files)
            {
                string name = System.IO.Path.GetFileNameWithoutExtension(file);
                string extension = System.IO.Path.GetExtension(file).Replace(".", "");

                string finalName = string.Empty;

                if (rbPrefix.Checked)
                {
                    finalName = string.Format("{0};{1}.{2}.{3}", tag, name, overrideExtension, extension);
                }
                else
                {
                    finalName = string.Format("{0};{1}.{2}.{3}", name, tag, overrideExtension, extension);
                }

                string finalPath = System.IO.Path.Combine(destionation, finalName);

                System.IO.File.Copy(file, finalPath, true);

                pgBar.Value++;

                Application.DoEvents();

            }

            pgBar.Value = 0;
            MessageBox.Show("JOB FINISHED!");

        }
    }
}
