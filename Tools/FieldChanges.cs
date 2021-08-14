using System.Collections.Generic;
using T_T_T.GameManager.PlayerManager;

namespace T_T_T.Tools
{
    public class FieldChanges
    {
        public LearningSpeed LearningSpeed { get; set; }
        public bool IsPaintingField { get; set; } = false;
        public int PaintSleep { get => this.LearningSpeed.ActualSpeed * 4; }
        public bool IsClearingField { get; set; } = false;
        public int ClearSleep { get => this.LearningSpeed.ActualSpeed * 6; }
        public PlayerSymbol Symbol { get; set; }
        public List<int> ChangesCell { get; set; } = new List<int>();
        public int Cell { get; set; }
        public int CellSleep { get => this.LearningSpeed.ActualSpeed / 2; }
        public FieldChanges(PlayerSymbol playerSymbol = PlayerSymbol.Zero, int cell = -1)
        {
            this.Symbol = playerSymbol;
            this.Cell = cell;
        }
    }
}
