﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using dbqf.WinForms.Advanced;
using dbqf.Display.Advanced;

namespace dbqf.WinForms
{
    public partial class AdvancedView : UserControl
    {
        private AdvancedAdapter<Control> _adapter;
        public AdvancedAdapter<Control> Adapter
        {
            get { return _adapter; }
        }

        public AdvancedView(AdvancedAdapter<Control> adapter)
        {
            InitializeComponent();
            _adapter = adapter;
            var ctl = new AdvancedPartView(_adapter.Part);
            ctl.Dock = DockStyle.Fill;
            layout.Controls.Add(ctl, 0, 0);
        }
    }
}
