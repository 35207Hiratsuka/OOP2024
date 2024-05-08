using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new song[] {
                new song("Let it be", "The Beatles",243),
                new song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new song("c", "f", 3),
                new song("d", "g", 4),
                new song("e", "h", 5),
                };
            PrintSongs(songs);
        }




        // 2.1.4
        public static void PrintSongs(song[] songs) {


            //ヒント　　Console.WriteLine(@"{0:hh\:mm\:ss}", TimeSpan.FromSeconds(153));
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:hh\:mm\:ss}", song.Title, song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}