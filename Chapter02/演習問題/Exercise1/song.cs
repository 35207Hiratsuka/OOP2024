using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class song {

        public string Title {
            get; set;
        }

        public string ArtistName {
            get; set;
        }

        public int Length {
            get; set;
        }

        public song(string title, string artistName, int length) {
            this.Title = title;
            this.ArtistName = artistName;
            this.Length = length;
        }
    }
}