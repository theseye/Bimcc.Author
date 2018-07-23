﻿using System.Windows.Forms;

namespace Bimangle.ForgeAuthor.Inspector
{
    partial class FormProgress : Form
    {
        public FormProgress()
        {
            this.InitializeComponent();
        }

        public FormProgress(string title) : this()
        {
            if(title != null) label1.Text = title;
        }
    }
}
