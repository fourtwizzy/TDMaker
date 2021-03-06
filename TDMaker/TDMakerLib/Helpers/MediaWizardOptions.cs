﻿using System.Windows.Forms;

namespace TDMakerLib
{
    public class MediaWizardOptions
    {
        public bool CreateScreenshots { get; set; }
        public bool UploadScreenshots { get; set; }
        public bool CreateTorrent { get; set; }
        public MediaType MediaTypeChoice { get; set; }

        public bool ShowWizard { get; set; }
        public bool PromptShown { get; set; }
        public DialogResult DialogResult { get; set; }
    }
}