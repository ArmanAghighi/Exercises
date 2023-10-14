using TreasureHunt.Services;

namespace TreasureHunt
{
    internal class InputService : IInputService
    {
        public int GetSizeInput()
        {
            int size;
            do
            {
                Console.WriteLine("Enter the size of the dungeon:");
            }
            while (!int.TryParse(Console.ReadLine(), out size));
            return size;
        }

        public int GetMovesInput()
        {
            int moves;
            do
            {
                Console.WriteLine("Enter the number of moves:");
            }
            while (!int.TryParse(Console.ReadLine(), out moves));
            return moves;
        }
    }
}
