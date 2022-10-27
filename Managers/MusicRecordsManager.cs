using DanmarksRadio.Models;

namespace DanmarksRadio.Managers
{
    public class MusicRecordsManager
    {       
        private static readonly List<MusicRecord> Data = new List<MusicRecord>
        {   
             new MusicRecord {Title = "LaFamilia", Artist = "Sisu",  Duration = 204 , PublicationYear = 2003 },
             new MusicRecord {Title = "HaarpCord", Artist = "Puya", Duration = 202, PublicationYear = 2005},
             new MusicRecord {Title = "StradaVarius", Artist = "Cedry2k", Duration = 183, PublicationYear = 2002 },
             new MusicRecord {Title = "HaarpCord", Artist = "Dan", Duration = 178, PublicationYear = 2003 }
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<MusicRecord> GetAll()
        {
            return new List<MusicRecord>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }
    }
}
