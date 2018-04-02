using System;
using System.Collections.Generic;
using System.Text;

namespace VocaDbContracts {
	public class LyricsForSongContract {
		public string cultureCode { get; set; }
		public string source { get; set; }
		public string value { get; set; }
	}
}
