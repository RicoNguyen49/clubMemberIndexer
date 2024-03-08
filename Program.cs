using System;

namespace clubMemberIndexer
{
    public class ClubMembers
    {
        public const int Size = 15;  // global variable

        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // Default constructor
        public ClubMembers()
        {
            ClubType = "";
            ClubLocation = "";
            MeetingDate = "";
        }

        // Indexer get and set methods
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= Size - 1)
                {
                    tmp = Members[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);

            }
            set
            {
                if (index >= 0 && index <= Size -1)
                    Members[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();

            // Add values to the Members indexer
            club[0] = "kyrie Irving";
            club[1] = "Devin Booker";
            club[2] = "stephen Curry";

            // Add values to the ClubType, ClubLocation, and MeetingDate properties
            club.ClubType = "Basketball Club";
            club.ClubLocation = "NMC gym";
            club.MeetingDate = "Weekends";

            // Display the club information
            Console.WriteLine("Club Information:");
            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Club Location: {club.ClubLocation}");
            Console.WriteLine($"Meeting Date: {club.MeetingDate}");

            Console.WriteLine("");

            Console.WriteLine("Club Members:");
            for (int i = 0; i < ClubMembers.Size; i++)
            {
                if (club[i] != string.Empty && club[i] != null)
                {
                    Console.WriteLine($"Member {i}: {club[i]}");
                }
            }

        }
    }
}
