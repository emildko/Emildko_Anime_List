using Emildko_Anime_List.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Emildko_Anime_List
{
    class ListFilter
    {
        public static void ScoreFinder()
        {
            string Path = Environment.CurrentDirectory + @"\AnimeList.xml";
            List<(string, string, string)> animeList = new List<(string, string, string)>();
            List<(string, string, string)> anime10List = new List<(string, string, string)>();

            XmlDocument doc = new XmlDocument();
            doc.Load(Path);
            XmlNodeList seriesList = doc.SelectNodes("myanimelist/anime/series_title");
            XmlNodeList scoreList = doc.SelectNodes("myanimelist/anime/my_score");
            XmlNodeList dbidList = doc.SelectNodes("myanimelist/anime/series_animedb_id");

            for (int i = 0; i < seriesList.Count; i++)
            {
                animeList.Add((seriesList[i].FirstChild.InnerText, scoreList[i].FirstChild.InnerText, dbidList[i].FirstChild.InnerText));
            }
            Modules.AnimeCommands.anime = animeList;
            Modules.AnimeCommands.anime10 = animeList.Where(i => i.Item2 == "10").ToList();
            Modules.AnimeCommands.anime9 = animeList.Where(i => i.Item2 == "9").ToList();
            Modules.AnimeCommands.anime8 = animeList.Where(i => i.Item2 == "8").ToList();
            Modules.AnimeCommands.anime7 = animeList.Where(i => i.Item2 == "7").ToList();
            Modules.AnimeCommands.anime6 = animeList.Where(i => i.Item2 == "6").ToList();

        }
    }
}
