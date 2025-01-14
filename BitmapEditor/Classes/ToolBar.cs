﻿using BitmapEditor.Classes;
using System.Windows.Forms;

namespace BitmapEditor
{
    internal class ToolBar : ErrorMsg
    {
        private ToolStripButton previousTool;
        private ToolStripMenuItem previousMenu;
        private Form previousDialog;
        private readonly Form parent;

        private ToolBar() { }

        public ToolBar (Form _parent)
        {
            parent = _parent;
        }

        public void Start(
            ToolStripButton tool, 
            ToolStripMenuItem menu, 
            PictureBox pictureBox, 
            Form dialog)
        {
            if (pictureBox.Image == null)
            {
                tool.Checked = false;
                Error("Please select a picture firstly");
                return;
            }

            UncheckPrevious(tool, menu);
            SetSubWindowPos(dialog, pictureBox);
        }

        private void SetSubWindowPos(Form dialog, PictureBox pictureBox)
        {
            if (previousDialog != null) previousDialog.Hide();
            previousDialog = dialog;

            dialog.Show();
            dialog.Activate();

            const int indent = 5;
            dialog.Left = parent.Left + parent.Width + indent;
            dialog.Top = parent.Top;
        }

        private void UncheckPrevious(ToolStripButton tool, ToolStripMenuItem menu)
        {
            if (previousTool != null) previousTool.Checked = false;
            previousTool = tool;
            tool.Checked = true;

            if (previousMenu != null) previousMenu.Checked = false;
            previousMenu = menu;
            menu.Checked = true;
        }
    }
}
