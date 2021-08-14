using System;
using System.Collections.Generic;

namespace T_T_T.GameManager.Utilities
{
    public class CellsDirection
    {
        public List<int> Cells { get; set; } = new List<int>();
        public int CellsCount { get; set; } = 0;
        public CellsDirection()
        {

        }

        public CellsDirection CompareValueCells(CellsDirection comparedItem)
        {
            if (comparedItem.CellsCount >= 4)
            {
                this.Cells.AddRange(comparedItem.Cells);
                this.CellsCount = 4;
            }
            else
               this.CellsCount = Math.Max(this.CellsCount, comparedItem.CellsCount);

            return this;
        }
    }
    
    public enum CheckDirection
    {
        Horizontal = 1,
        Count = 4,
        RightDiagonal = 6,
        Vertical = 7,
        LeftDiagonal = 8
    }
}
