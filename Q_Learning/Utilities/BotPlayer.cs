using System;
using System.Collections.Generic;
using T_T_T.GameManager;
using T_T_T.GameManager.PlayerManager;
using T_T_T.GameManager.Utilities;

namespace T_T_T.Q_Learning.Utilities
{
    public class BotPlayer : Player
    {
        private int NumberNextPlayer { get => (Number + 1) % QHundler.BotPlayers.Count; }
        public int CountGames { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int WinRate { get; set; } = 0;
        private QHundler QHundler { get; set; }
        private QLearning QLearning { get; set; }
        public QRewards QRewards { get; set; }
        public BotPlayer(int number, string name, QHundler qHundler, QLearning qLearning) : base(number, name)
        {
            Number = number;
            Name = name;
            this.QHundler = qHundler;
            this.QRewards = new QRewards(this);
            this.QLearning = qLearning;
        }

        public int GetPlayerMove()
        {
            int move = QLearning.MoveHundler(QHundler.GameField, QRewards);

            return move;
        }

        public void GetCells(int cellNumber, out int countYourCells, out int[] countOppCells)
        {
            countYourCells = 0;
            countOppCells = new int[] { };

            PlayerMove playerMove = new PlayerMove(this, Number, cellNumber);
            if (!(QHundler.Game is Tic_Tac_Toe))
                return;
            Tic_Tac_Toe game = QHundler.Game as Tic_Tac_Toe;

            if (game.GameField.Field[cellNumber] != PlayerSymbol.Zero)
            {
                countYourCells = -7;
                return;
            }

            var cells = game.CheckPlayersLine(playerMove);

            CalculateCells(cells, out countYourCells, out countOppCells);
        }

        public int GetFutureCells(int cellNumber)
        {
            Tic_Tac_Toe game = QHundler.Game;
            if (game.GameField.Field[cellNumber] != PlayerSymbol.Zero)
                return 6;

            game.GameField.Field[cellNumber] = (PlayerSymbol)Number;

            int maxCountCells = 0;
            for (int i = 0; i < game.GameField.Field.Count; i++)
            {
                if (game.GameField.Field[i] != PlayerSymbol.Zero)
                    continue;

                PlayerMove playerMove = new PlayerMove(QHundler.BotPlayers[NumberNextPlayer], NumberNextPlayer, i);

                var cells = game.CheckPlayersLine(playerMove);
                if (cells[NumberNextPlayer].CellsCount > maxCountCells)
                    maxCountCells = cells[NumberNextPlayer].CellsCount;
            }

            game.GameField.Field[cellNumber] = PlayerSymbol.Zero;

            return maxCountCells;
        }

        private void CalculateCells(CellsDirection[] cellsDirections, out int countYourCells, out int[] countOppCells)
        {
            countYourCells = 0;
            List<int> timeCountOppCells = new List<int>();

            for (int i = 0; i < cellsDirections.Length; i++)
            {
                if (i == Number)
                    countYourCells = cellsDirections[i].CellsCount;
                else
                    timeCountOppCells.Add(cellsDirections[i].CellsCount);
            }
            countOppCells = timeCountOppCells.ToArray();

            if (countYourCells >= 5)
            {
                QHundler.WinningCells[cellsDirections[Number].Cells[countYourCells - 1]] = cellsDirections[Number].Cells;
            }
        }

        public void ClearValues()
        {
            CountGames++;
            QRewards.LastReward = 0;
        }
    }
}
