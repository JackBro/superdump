﻿using System.Collections.Generic;

namespace SuperDumpService {
	public class SuperDumpSettings {
		public string LocalSymbolCache { get; set; }
		public string SymStoreExex86 { get; set; }
		public string SymStoreExex64 { get; set; }
		public int MaxConcurrentAnalysis { get; set; }
		public int MaxConcurrentBundleExtraction { get; set; }
		public string DumpsDir { get; set; }
		public string UploadDir { get; set; }
		public string HangfireLocalDbDir { get; set; }
		public string SuperDumpSelectorExePath { get; set; }
		public bool DeleteDumpAfterAnalysis { get; set; }
		public bool DumpDownloadable { get; set; } = true;
		public int MaxUploadSizeMB { get; set; } = 16000;
		public bool IncludeOtherFilesInReport { get; set; }
		public string LinuxCommandTemplate { get; set; }
		public IEnumerable<string> BinPath { get; set; }
		public string Cdbx86 { get; set; }
		public string Cdbx64 { get; set; }
	}
}
