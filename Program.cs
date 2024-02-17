using System;

namespace FunWithMusic
{
    class Program
    {
        
        enum MusicGenre
        {
            Rock,
            Pop,
            HipHop,
            Jazz,
            Electronic
        }

        
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private TimeSpan Length;
            private MusicGenre? Genre;

            public Music(string title, string artist, string album, TimeSpan length, MusicGenre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void SetTitle(string title)
            {
                Title = title;
            }

            public void SetLength(TimeSpan length)
            {
                Length = length;
            }

            public string Display()
            {
                return $"Title: {Title}\nArtist: {Artist}\nAlbum: {Album}\nLength: {Length}\nGenre: {Genre}";
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter music information for the first song:");

            Console.Write("Title: ");
            string tempTitle = Console.ReadLine();

            Console.Write("Artist: ");
            string tempArtist = Console.ReadLine();

            Console.Write("Album: ");
            string tempAlbum = Console.ReadLine();

            Console.Write("Length (in format hh:mm:ss): ");
            string lengthInput = Console.ReadLine();
            TimeSpan tempLength = TimeSpan.Parse(lengthInput);

            Console.WriteLine("Select Genre:");
            Console.WriteLine("R - Rock\nP - Pop\nH - HipHop\nJ - Jazz\nE - Electronic");
            MusicGenre tempGenre = MusicGenre.Rock;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = MusicGenre.Rock;
                    break;
                case 'P':
                    tempGenre = MusicGenre.Pop;
                    break;
                case 'H':
                    tempGenre = MusicGenre.HipHop;
                    break;
                case 'J':
                    tempGenre = MusicGenre.Jazz;
                    break;
                case 'E':
                    tempGenre = MusicGenre.Electronic;
                    break;
            }

            
            Music firstMusic = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine("\nFirst Song Information:");
            Console.WriteLine(firstMusic.Display());

            
            Console.WriteLine("\nEnter new title and length for the second song:");

            Console.Write("Title: ");
            string secondTitle = Console.ReadLine();

            Console.Write("Length (in format hh:mm:ss): ");
            string secondLengthInput = Console.ReadLine();
            TimeSpan secondLength = TimeSpan.Parse(secondLengthInput);

            
            Music secondMusic = firstMusic;
            secondMusic.SetTitle(secondTitle);
            secondMusic.SetLength(secondLength);

            
            Console.WriteLine("\nSecond Song Information:");
            Console.WriteLine(secondMusic.Display());

            
        }
    }
}
