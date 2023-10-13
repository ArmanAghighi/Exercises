namespace TreasureHunt.Services
{
    internal interface IPlayerService 
    {
        public void HandleInput(char input);
        public void MovePlayer(int rowOffset, int colOffset);
    }
}
