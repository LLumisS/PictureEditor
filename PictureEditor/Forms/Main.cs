﻿using PictureEditor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureEditor
{
    public partial class Main : Form
    {
        private Brightness brightnessDialog = new Brightness();
        private Contrast contrastDialog = new Contrast();
        private RGB rgbDialog = new RGB();

        private Files files = new Files();
        private ToolBar toolBar = new ToolBar();

        public Main()
        {
            InitializeComponent();
        }

        private void OpenButton(object sender, EventArgs e)
        {
            files.OnOpen(openFileDialog, pictureBox1);
        }

        private void SaveButton(object sender, EventArgs e)
        {
            files.OnSave(pictureBox1);
        }

        private void SaveAsButton(object sender, EventArgs e)
        {
            files.OnSaveAs(pictureBox1);
        }

        private void BrightnessToolButton(object sender, EventArgs e)
        {
            toolBar.Start(brightnessTool, pictureBox1, brightnessDialog);
        }

        private void ContrastToolButton(object sender, EventArgs e)
        {
            toolBar.Start(contrastTool, pictureBox1, contrastDialog);
        }

        private void RgbToolButton(object sender, EventArgs e)
        {
            toolBar.Start(rgbTool, pictureBox1, rgbDialog);
        }

        private void ExitButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}