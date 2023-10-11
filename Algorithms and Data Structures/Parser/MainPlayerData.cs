using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParserConsolApp
{
    internal class MainPlayerData
    {
        static public string filePath = "C:/Users/arman/OneDrive/Desktop/player.json";
        public static void Main()
        {
            PlayerDataLogic.AddUserInfo();
            PlayerDataUI.ShowUserInfo();
        }
    }
}
