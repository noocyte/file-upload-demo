﻿using System.Collections.Generic;

namespace WebApp.Models
{
    public class UploadFilesViewModel
    {
        public IList<ScanResult> Results { get; set; }
    }

    public class ScanResult
    {
        public string FileName { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public string RawResult { get; set; }
    }
}
