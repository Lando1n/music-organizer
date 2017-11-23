using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace Music_Organizer
{
    class Song
    {
        public string filePath, title, artist, album;

        public Song(string location, Runner run)
        {
            filePath = location;
            try
            {
                TagLib.File currSong = TagLib.File.Create(filePath);
                album = currSong.Tag.Album;
                title = currSong.Tag.Title;

                string[] possibleArtistName = { currSong.Tag.FirstAlbumArtist, currSong.Tag.FirstPerformer, "Unknown Artist" };

                foreach (string tryArtistName in possibleArtistName)
                {
                    if (artist == null)
                    {
                        artist = tryArtistName;
                    }
                }
                
                if (album == null)
                {
                    album = "Unknown Album";
                }
                if (title == null)
                {
                    title = Path.GetFileNameWithoutExtension(filePath);
                }
                if (run.removeFeat)
                {
                    removeFeatArtists();
                }
                removeBadChars();
            }
            catch
            {
                artist = "Unknown Artist";
                album = "Unknown Album";
            }
                
            //get rid of featured artists
        }

        private void removeFeatArtists()
        {
            string[] remove = { " Feat ", " feat ", " ft " };
            foreach (string item in remove)
            {
                int resultIndex = artist.IndexOf(item);
                if (resultIndex != -1)
                {
                    artist = artist.Substring(0, resultIndex);
                }
            }
        }

        private void removeBadChars() //some characters are not valid in File.Move Paths, this function removes them.
        {
            List<string> badchar = new List<string>{ "(", ")", ",", ".", ";", ":", "\"", "?", "[", "]", "*", "!", "_" };
            
            badchar.ForEach(bad => artist = artist.Replace(bad, String.Empty));
            badchar.ForEach(bad => album = album.Replace(bad, String.Empty));
            badchar.ForEach(bad => title = title.Replace(bad, String.Empty));
        }

        public bool moveSong(string destRoot)
        {
            bool moved = false;
            string moveToLoc = destRoot + @"\" + artist + @"\" + album + @"\" + title + Path.GetExtension(filePath);

            try
            {
                if (!string.Equals(Path.GetFullPath(moveToLoc).ToUpperInvariant(), Path.GetFullPath(filePath).ToUpperInvariant(), StringComparison.OrdinalIgnoreCase))
                {
                    if (!Directory.Exists(Path.GetDirectoryName(moveToLoc)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(moveToLoc));
                        File.Move(filePath, moveToLoc);
                        moved = true;
                    }
                    else
                    {
                        if (!File.Exists(moveToLoc))
                        {
                            File.Move(filePath, moveToLoc);
                            moved = true;
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                //MessageBox.Show(moveToLoc);
                using (StreamWriter log = new StreamWriter(destRoot + @"\moving error log.txt",true))
                {
                    log.WriteLine("Error with: " + filePath);
                    log.WriteLine("Moving to: " + destRoot);
                    log.WriteLine("Exception: " + exc + "\n");
                   
                }
            }
            return moved;
        }
    }
}
