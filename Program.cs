using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NBAPlayer> players = LoadRecords("../players.csv");
            NBAPlayer mostPoints = players[0];
            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
            foreach (var player in players)
            {
                if (mostPoints.Points < player.Points)
                    mostPoints = player;
            }
            Console.WriteLine($"{mostPoints.Name} has the most points -- {mostPoints.Points}");
        }

        public static List<NBAPlayer> LoadRecords(string fileName)
        {
            List<NBAPlayer> players = new List<NBAPlayer>();
            StreamReader textIn = null;
            string line;
            try
            {
                fileName = "../../" + fileName;
                textIn = new StreamReader(fileName);
                //your code here!!!
                line = textIn.ReadLine();
                while ((line = textIn.ReadLine()) != null)
                {
                    string[] prop = line.Split(",");
                    Console.WriteLine(prop[0]);
                    NBAPlayer player = new NBAPlayer(prop[0], prop[1], 
                        float.Parse(prop[2]),  float.Parse(prop[3]),  float.Parse(prop[4]),  float.Parse(prop[5]),
                        float.Parse(prop[6]),  float.Parse(prop[7]),  float.Parse(prop[8]),  float.Parse(prop[9]),
                        float.Parse(prop[10]), float.Parse(prop[11]), float.Parse(prop[12]), float.Parse(prop[13]),
                        float.Parse(prop[14]), float.Parse(prop[15]), float.Parse(prop[16]), float.Parse(prop[17]), float.Parse(prop[18]));
                    players.Add(player);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file: " + fileName);
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (textIn != null)   textIn.Close();
            }
            return players;
        }
    }
}