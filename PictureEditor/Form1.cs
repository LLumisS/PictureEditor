﻿using System;
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
    public partial class Form1 : Form
    {
        private FileManip fileManip = new FileManip();
        private ToolBar toolBar = new ToolBar();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton(object sender, EventArgs e)
        {
            fileManip.OnOpen(openFileDialog, pictureBox1);
        }

        private void SaveButton(object sender, EventArgs e)
        {
            fileManip.OnSave(pictureBox1);
        }

        private void SaveAsButton(object sender, EventArgs e)
        {
            fileManip.OnSaveAs(pictureBox1);
        }

        private void LightningToolButton(object sender, EventArgs e)
        {
            toolBar.OnLightning(lightningTool);
        }

        private void ContrastToolButton(object sender, EventArgs e)
        {
            toolBar.OnContrast(contrastTool);
        }

        private void RgbToolButton(object sender, EventArgs e)
        {
            toolBar.OnRGB(rgbTool);
        }

        private void ExitButton(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
