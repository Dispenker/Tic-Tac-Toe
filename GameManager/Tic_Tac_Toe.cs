using System;
using System.Collections.Generic;
using T_T_T.GameManager.PlayerManager;
using T_T_T.GameManager.Utilities;
using T_T_T.Tools;

namespace T_T_T.GameManager
{
    public class Tic_Tac_Toe : GameClass
    {
        public List<Player> Players { get; set; }
        private int PlayersMoveCounter { get; set; } = -1;
        private int CountCellsToWin { get; set; } = 5;

        public Tic_Tac_Toe(int cellsCount, params Player[] players)
        {
            GameField = new GameField(cellsCount);
            Players = new List<Player>(players);
        }

        public override FieldChanges ClickHundler(int cellNumber)
        {
            if (!CanMakeMove)
                return new FieldChanges();

            if (GameField.Field[cellNumber] != PlayerSymbol.Zero)
                return new FieldChanges();

            Player outgoingPlayer = Players[PlayersMoveCounter];
            FieldChanges fieldChanges = new FieldChanges(outgoingPlayer.Symbol);
            PlayerMove playerMove = new PlayerMove(outgoingPlayer, outgoingPlayer.Number, cellNumber);

            CellsDirection[] cellsDirections = CheckPlayersLine(playerMove);
            if (cellsDirections[outgoingPlayer.Number].CellsCount >= CountCellsToWin)
            {
                fieldChanges.IsPaintingField = true;
                fieldChanges.IsClearingField = true;
                fieldChanges.ChangesCell.AddRange(cellsDirections[outgoingPlayer.Number].Cells);
            }
            fieldChanges.Cell = cellNumber;

            ChangePlayersCounter();

            ChangeGameField(fieldChanges);

            return fieldChanges;
        }

        public override void StartGame()
        {
            CanMakeMove = true;
            ChangePlayersCounter();
        }

        public override void EndGame()
        {
            CanMakeMove = false;
        }

        private void ChangePlayersCounter()
        {
            PlayersMoveCounter = ++PlayersMoveCounter % Players.Count;
        }

        public CellsDirection[] CheckPlayersLine(PlayerMove move)
        {
            CellsDirection[] playersCells = new CellsDirection[Players.Count];
            foreach (var player in Players)
            {
                playersCells[player.Number] = CheckLine(move.PlayerStep, player.Symbol);
            }

            playersCells[move.PlayerNumber].Cells.Add(move.PlayerStep);
            playersCells[move.PlayerNumber].CellsCount += 1;

            return playersCells;
        }

        private CellsDirection CheckLine(int cell, PlayerSymbol symbol)
        {
            CellsDirection playerBestLine = new CellsDirection();

            playerBestLine.CompareValueCells(CheckLineOnDirection(cell, symbol, CheckDirection.Horizontal));
            playerBestLine.CompareValueCells(CheckLineOnDirection(cell, symbol, CheckDirection.RightDiagonal));
            playerBestLine.CompareValueCells(CheckLineOnDirection(cell, symbol, CheckDirection.Vertical));
            playerBestLine.CompareValueCells(CheckLineOnDirection(cell, symbol, CheckDirection.LeftDiagonal));

            return playerBestLine;
        }

        private CellsDirection CheckLineOnDirection(int cell, PlayerSymbol symbol, CheckDirection checkDirection)
        {
            CellsDirection playerLine = new CellsDirection();

            CheckLeftPositions(cell, playerLine, checkDirection, symbol);
            CheckRightPositions(cell, playerLine, checkDirection, symbol);

            playerLine.CellsCount = playerLine.Cells.Count;

            return playerLine;
        }

        private void CheckLeftPositions(int cell, CellsDirection playerLine, CheckDirection checkDirection, PlayerSymbol symbol)
        {
            int oldValue = cell;
            cell -= (int)checkDirection;
            while (Math.Abs((oldValue % GameField.CellCount) - (cell % GameField.CellCount)) <= 1)
            {
                if ((cell >= 0) && (GameField.Field[cell] == symbol))
                    playerLine.Cells.Add(cell);
                else
                    break;
                oldValue = cell;
                cell -= (int)checkDirection;
            }
        }

        private void CheckRightPositions(int cell, CellsDirection playerLine, CheckDirection checkDirection, PlayerSymbol symbol)
        {
            int oldValue = cell;
            cell += (int)checkDirection;
            while (Math.Abs((oldValue % GameField.CellCount) - (cell % GameField.CellCount)) <= 1)
            {
                if ((cell < GameField.Field.Count) && (GameField.Field[cell] == symbol))
                    playerLine.Cells.Add(cell);
                else
                    break;
                oldValue = cell;
                cell += (int)checkDirection;
            }
        }

        public bool CheckIsFullField()
        {
            foreach (var cell in GameField.Field)
                if (cell == PlayerSymbol.Zero)
                    return false;

            return true;
        }

        public void ChangeGameField(FieldChanges fieldChanges)
        {
            if (fieldChanges.Cell != -1)
                GameField.Field[fieldChanges.Cell] = fieldChanges.Symbol;

            if (fieldChanges.IsClearingField)
            {
                GameField.ClearField();
                EndGame();
            }
        }
    }
}
