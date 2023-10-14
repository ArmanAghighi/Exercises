using Microsoft.Extensions.DependencyInjection;
using TreasureHunt.Services;

namespace TreasureHunt
{
    class Program
    {
        public static void Main()
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IPlayerService, PlayerService>()
            .AddSingleton<ISetupService, SetupService>()
            .AddSingleton<IInputService, InputService>()
            .AddSingleton<IUIService , UIService>()
            .BuildServiceProvider();

            var _playerService = serviceProvider.GetService<IPlayerService>();
            var _setupService = serviceProvider.GetService<ISetupService>();
            var _inputService = serviceProvider.GetService<IInputService>();
            var _uiService = serviceProvider.GetService<IUIService>();

            _uiService.ShowMessage("Welcome");
            _uiService.ShowMessage("Size");
            int size = _inputService.GetSizeInput();
            _uiService.ShowMessage("Moves");
            int moves = _inputService.GetMovesInput();
            _setupService.SetupGame(size, moves);
            while (true)
            {
                Console.Clear();
                _uiService.DrawGrid();

                if (!Model.trapRevealed && !Model.treasureRevealed)
                {
                    _uiService.ShowMessage("Help");
                }
                _uiService.ShowMessage("Discribtion");
                char input = Console.ReadKey(true).KeyChar;
                _playerService.HandleInput(input);
                if (Model.movesLeft == 0)
                {
                    _uiService.ShowMessage("NoMoves");
                    break;
                }

                if (Model.playerRow == Model.treasureRow && Model.playerCol == Model.treasureCol)
                {
                    _uiService.ShowMessage("Win");
                    break;
                }
            }

            _uiService.ShowMessage("GameOver");
        }
    }
}