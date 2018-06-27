using System;
using System.Collections.Generic;
using System.Text;

namespace VocaDbContracts {
	public class SongForApiContract {
		public string ArtistString { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public LyricsForSongContract[] Lyrics { get; set; }
	}
}
