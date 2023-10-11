
using Newtonsoft.Json;

namespace JsonParserConsolApp
{
    internal class PlayerDataLogic
    {
        [JsonProperty]
        public string Username { get; set; }
        [JsonProperty]
        public string Guild { get; set; }
        [JsonProperty]
        public int Level { get; set; }
        [JsonProperty]
        public int SkinID { get; set; }
        [JsonProperty]
        public string Item { get; set; }
        [JsonProperty]
        public int ID { get; set; }
        [JsonIgnore]
        public int Coins { get; set; }

        [JsonIgnore]
        public int QuestsCompleted { get; set; }


        public PlayerDataLogic(int id = 0, string username = "Player", string guild = "Human", 
                               int level = 0, int skinID = 0, string item = "Default Item")
        {
            ID = id;
            Username = username;
            Guild = guild;
            Level = level;
            SkinID = skinID;
            Item = item;
        }

        public static void AddUserInfo()
        {
            PlayerDataLogic[] players;

            if (File.Exists(MainPlayerData.filePath))
            {
                string jsonData = File.ReadAllText(MainPlayerData.filePath);
                players = JsonConvert.DeserializeObject<PlayerDataLogic[]>(jsonData);
            }
            else
            {
                Random random = new Random();
                players = new PlayerDataLogic[5];

                players[0] = new PlayerDataLogic(random.Next(1000, 9999), "John", "Warriors", 13, 1235, "Sword");
                players[1] = new PlayerDataLogic(random.Next(1000, 9999), "Steve", "Elf", 18, 4114, "Knife");
                players[2] = new PlayerDataLogic(random.Next(1000, 9999), "John", "Wizard", 21, 1695, "SilverSword");
                players[3] = new PlayerDataLogic(random.Next(1000, 9999), "Garult", "Witcher", 33, 1485, "SteelSword");
                players[4] = new PlayerDataLogic(random.Next(1000, 9999), "Sam", "Human", 23, 1889, "Bow");
            }

            foreach (PlayerDataLogic player in players)
            {
                if (player.ID == 0)
                {
                    Random random = new Random();
                    player.ID = random.Next(1000, 9999);
                }
            }

            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(MainPlayerData.filePath, json);
        }
    }
}
