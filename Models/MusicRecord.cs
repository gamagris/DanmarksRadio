using System.Drawing;

namespace DanmarksRadio.Models
{
    public class MusicRecord
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }



        public void ValidateTitle()
        {
            if (Title == null)
            {
                throw new ArgumentNullException("You need to type a title");
            }
            else if (Title.Length > 50)
            {
                throw new ArgumentOutOfRangeException("Title name is too long");
            }
            else if (Title.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Title name is too short");
            }
        }

        public void ValidateArtist()
        {
            if (Artist == null)
            {
                throw new ArgumentNullException("You need to type an artist");
            }
            else if (Artist.Length > 50)
            {
                throw new ArgumentOutOfRangeException("Artist name is too long");
            }
            else if (Artist.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Artist name is too short");
            }
        }
        public void ValidateDuration()
        {
            if (Duration == null)
            {
                throw new ArgumentNullException("The duration of the record cannot be null");
            }
        }
        public void ValidateProductionYear()
        {
            if (PublicationYear == null)
            {
                throw new ArgumentNullException("The publication year cannot be null");
            }
        }

        public void Validate()
        {   ValidateTitle();
            ValidateArtist();
            ValidateDuration();
            ValidateProductionYear();
        }
    }
}
