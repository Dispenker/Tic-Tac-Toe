using System.Collections.Generic;
using System.Linq;
using T_T_T.GameManager.PlayerManager;

namespace T_T_T.GameManager
{
    public class GameField
    {
        public int CellCount { get; set; }
        public List<PlayerSymbol> Field { get; set; }

        public GameField(int cellCount)
        {
            CellCount = cellCount;
            Field = Enumerable.Repeat(PlayerSymbol.Zero, CellCount * CellCount).ToList();
        }

        public GameField ClearField()
        {
            Field = Enumerable.Repeat(PlayerSymbol.Zero, CellCount * CellCount).ToList();
            return this;
        }
    }
}
