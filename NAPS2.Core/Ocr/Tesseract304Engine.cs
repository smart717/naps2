﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NAPS2.Config;
using NAPS2.Dependencies;

namespace NAPS2.Ocr
{
    public class Tesseract304Engine : TesseractBaseEngine
    {
        public Tesseract304Engine(AppConfigManager appConfigManager) : base(appConfigManager)
        {
        }

        protected override string TesseractBasePath => Path.Combine(ExternalComponent.BasePath, "tesseract-3.0.4");

        protected override string TesseractExePath => "tesseract.exe";

        protected override string TesseractHocrExtension => ".hocr";

        protected override PlatformSupport PlatformSupport => PlatformSupport.ModernWindows;

        public override bool IsUpgradable => false;

        public override bool CanInstall => true;

        protected override DownloadInfo DownloadInfo => new DownloadInfo("tesseract.exe.gz", TesseractMirrors, 1.32, "0b0fd21cd886c04c60ed5c3f38b9120b408139b3", DownloadFormat.Gzip);
    }
}
