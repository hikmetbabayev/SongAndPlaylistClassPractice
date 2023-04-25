using System.Reflection.Emit;

namespace SongVePlaylistClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Playlist playlist = new Playlist();
                Song song1 = new Song("fdghf", "shdfgs", "Turkiye");
                Song song2 = new Song("dfghdg", "asddfa");

                playlist.Add(song1);
                playlist.Add(song2);
                Console.WriteLine(playlist.Songs[0].Genre);
            }        
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }       
        class Playlist
        {
            public List<Song> Songs { get; set; }

            public Playlist()
            {
                Songs = new List<Song>();
            }   
            public void Add(Song songName)
            {
                if (songName.Genre == "hip-hop" || songName.Country == "Iran")
                {
                    throw new Exception("!");
                        }
                else
                {
                    Songs.Add(songName);
                }
            }


        }
        class Song
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public string Country { get; set; }
            public Song(string name, string genre, string country)
            {
                Name = name;
                Genre = genre;
                Country = country;
            }
            public Song(string name,string genre)
            {
                Name=name;
                Genre=genre;
            }
            public Song(string name)
            {
                Name =name;
            }
            public Song()
            {

            }



        }
    }
    
}