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
                Song song1 = new Song("Baki", "shdfgs", "Turkiye");
                Song song2 = new Song("Oten Gunler", "Hip-Hop", "ashfjsdh");
                Song song3 = new Song("Oten Gun","saggddas","gywtbh");
                playlist.Add(song1);
                playlist.Add(song2);
                playlist.Add(song3);

                Console.WriteLine(playlist.Songs[0].Name);
                Console.WriteLine(playlist.Songs[1].Name);
                Console.WriteLine(playlist.Songs[2].Name);
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
            public void Add(Song song)
            {
                for (int i=0, j = 1; i < Songs.Count; i++)
                {
                    if(song.Name == Songs[j-1].Name)
                    {
                        throw new Exception("Bu ad daxil edilib!!!!!!!!!");
                    }
                    
                    j++;
                }
                
                
                if (song.Genre == "Hip-Hop" || song.Country == "Iran")
                {
                    throw new Exception("Gnre ve Olke yaxsi deyil!");
                }
                else
                {
                    Songs.Add(song);
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