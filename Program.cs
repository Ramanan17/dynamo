using System;
using System.IO;
using System.Dynamic;

namespace course_hero
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "PlayerScore.csv";
            StreamReader sr = new StreamReader(File.OpenRead(filename));
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            str = sr.ReadLine();
            while (str != null & str!="")
            {
                string[] data = str.Split(",");
                dynamic player = new ExpandoObject();
                player.Player = data[0];
                player.Score = Convert.ToInt32(data[1]);
                Console.WriteLine($"{player.Player} has a score of {player.Score}");
                
                str = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
