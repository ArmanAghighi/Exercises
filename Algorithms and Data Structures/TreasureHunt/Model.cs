
namespace TreasureHunt
{
    internal class Model 
    {
        public static char[,] grid { get; set; }
        public static int playerRow { get; set; }
        public static int playerCol { get; set; }
        public static int trapRow { get; set; }
        public static int trapCol { get; set; }
        public static int treasureRow { get; set; }
        public static int treasureCol { get; set; }
        public static bool trapRevealed { get; set; }
        public static bool treasureRevealed { get; set; }
        public static int movesLeft { get; set; }
    }
}
