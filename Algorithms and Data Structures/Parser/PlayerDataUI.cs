using System;
using Newtonsoft.Json;
using System.IO;

namespace JsonParserConsolApp
{
    class PlayerDataUI
    {
        public static void ShowUserInfo()
        {
            

            string jsonData = File.ReadAllText(MainPlayerData.filePath);

            PlayerDataLogic[] players = JsonConvert.DeserializeObject<PlayerDataLogic[]>(jsonData);

            while (true)
            {
                Console.WriteLine("Enter the ID to check:");
                int inputId = Convert.ToInt32(Console.ReadLine());
                if (inputId == -1)
                {
                    break;
                }
                bool found = false;
                foreach (PlayerDataLogic player in players)
                {
                    if (player.ID == inputId)
                    {
                        Console.WriteLine($"Username: {player.Username}");
                        Console.WriteLine($"Guild: {player.Guild}");
                        Console.WriteLine($"Level: {player.Level}");
                        Console.WriteLine($"SkinID: {player.SkinID}");
                        Console.WriteLine($"Item: {player.Item}");
                        Console.WriteLine();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Player with the provided ID does not exist.");
                }
            }
        }
    }
}