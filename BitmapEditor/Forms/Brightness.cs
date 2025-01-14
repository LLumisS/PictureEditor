﻿using BitmapEditor.Classes;
using System;
using System.Windows.Forms;

namespace BitmapEditor.Forms
{
    public partial class Brightness : Editor
    {
        public Brightness(ToolStripButton _tool, ToolStripMenuItem _menu)
        {
            InitializeComponent();
            tool = _tool;
            menu = _menu;
        }

        private void OKButton(object sender, EventArgs e)
        {
            changes.bright = trackBar1.Value * 128 / 100;
            ApplyChanges();
        }

        private void TextInput(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = Int32.Parse(textBox1.Text);
            }
            catch
            {
                ScrollChaged(sender, e);
            }
        }

        private void ScrollChaged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        public override void Reset()
        {
            Uncheck();
            Hide();

            trackBar1.Value = 0;
            textBox1.Text = "0";
        }

        private void ExitButton(object sender, EventArgs e)
        {
            Uncheck();
            Hide();
        }

        private void CloseButton(object sender, FormClosingEventArgs e)
        {
            Uncheck();
        }
    }
}
