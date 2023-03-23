﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;

namespace Jastech.Framework.Winform.VisionPro.Controls
{
    public partial class CogPatternMatchingParamControl : UserControl
    {
        public ICogImage TargetImage { get; set; } = null;

        public CogPMAlignTool Tool { get; set; } = null;

        public CogPatternMatchingParamControl()
        {
            InitializeComponent();
        }

        private void lblAddPattern_Click(object sender, EventArgs e)
        {
            if (TargetImage == null || Tool == null)
                return;


        }
    }
}