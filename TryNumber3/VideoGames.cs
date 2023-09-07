using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DollingerKyahReview
{
    public class VideoGames : IComparable<VideoGames>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Pub { get; set; }
        public decimal NASales { get; set; }
        public decimal EUSales { get; set; }
        public decimal JPSales { get; set; }
        public decimal OtherSales { get; set; }
        public decimal GlobalSales { get; set; }

        public VideoGames(string name, string platform, int year, string genre, string pub, decimal naSales, decimal euSales, decimal jpSales, decimal otherSales, decimal globalSales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Pub = pub;
            NASales = naSales;
            EUSales = euSales;
            JPSales = jpSales;
            OtherSales = otherSales;
            GlobalSales = globalSales;
        }

        public int CompareTo(VideoGames? other)
        {
            int result = Name.CompareTo(other.Name);
            return result;
        }

        public override string ToString()
        {
            string msg = $"{Name}, {Platform},{Year},{Genre},{Pub},{NASales},{EUSales},{JPSales},{OtherSales},{GlobalSales}";
            return msg;
        }
    }
}
