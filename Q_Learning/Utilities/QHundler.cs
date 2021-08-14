using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T_T_T.GameManager;
using T_T_T.GameManager.Utilities;
using T_T_T.Tools;

namespace T_T_T.Q_Learning.Utilities
{
    public class QHundler : GameClass
    {
        private CellField CellField { get; set; }
        public Tic_Tac_Toe Game { get; set; }
        public new GameField GameField { get => Game.GameField; }
        private bool CanMove { get; set; } = false;
        public List<BotPlayer> BotPlayers { get; set; } = new List<BotPlayer>();
        private int TurnBotPlayer { get; set; } = -1;
        public Dictionary<int, List<int>> WinningCells { get; set; } = new Dictionary<int, List<int>>();
        public QHundler(CellField cellField)
        {
            this.CellField = cellField;
        }

        public override FieldChanges ClickHundler(int cellNumber) 
        {
            if (CanMove)
                PauseGame();
            else
                UnpauseGame();

            return new FieldChanges();
        }

        public override void StartGame()
        {
            CanMove = true;
        }

        public FieldChanges DoTurn()
        {
            bool isEnded = InProgress(out FieldChanges fieldChanges);

            if (isEnded)
                EndGame();

            UpdateField(fieldChanges);

            return fieldChanges;
        }

        private bool InProgress(out FieldChanges fieldChanges)
        {
            fieldChanges = new FieldChanges();
            if (Game.CheckIsFullField())
            {
                fieldChanges.IsClearingField = true;
                return true;
            }

            TurnBotPlayer = ++TurnBotPlayer % BotPlayers.Count;
            int move = BotPlayers[TurnBotPlayer].GetPlayerMove();
            fieldChanges = new FieldChanges(BotPlayers[TurnBotPlayer].Symbol, move);

            if (WinningCells.TryGetValue(move, out List<int> changesCell))
            {
                fieldChanges.ChangesCell = changesCell;
                fieldChanges.IsPaintingField = true;
                fieldChanges.IsClearingField = true;
                return true;
            }

            return false;
        }

        public void PauseGame()
        {
            CanMove = false;
        }

        public void UnpauseGame()
        {
            CanMove = true;
        }

        public override void EndGame()
        {
            foreach (var bot in BotPlayers)
            {
                bot.ClearValues();
            }
        }

        public void UpdateField(FieldChanges fieldChanges)
        {
            WinningCells = new Dictionary<int, List<int>>();
            Game.ChangeGameField(fieldChanges);
        }
    }
}
