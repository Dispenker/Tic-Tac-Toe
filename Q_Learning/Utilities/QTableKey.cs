using System;
using System.Collections.Generic;
using T_T_T.GameManager;

namespace T_T_T.Q_Learning.Utilities
{
    public class QTableKey
    {
        private const int Notation = 3;
        public string CreateTableKey(GameField gameField)
        {
            string key = "";

            for (int i = 0; i < gameField.CellCount; i++)
            {
                int number = 0;
                int multiplier = 1;
                for (int j = 0; j < gameField.CellCount; j++)
                {
                    number += ((int)gameField.Field[i * gameField.CellCount + j] + 1) * multiplier;
                    multiplier *= Notation;
                }
                key += ConvertNumberToKey(number);
            }

            return key;
        }

        private string ConvertNumberToKey(int number)
        {
            return ConvertTo16(number);
        }

        private string ConvertTo16(int number)
        {
            string convertedNumber = ";";
            while (number != 0)
            {
                convertedNumber = Notation16[number % 16] + convertedNumber;
                number /= 16;
            }

            return (convertedNumber == ";") ? "0;" : convertedNumber;
        }

        private Dictionary<int, string> Notation16 = new Dictionary<int, string>
        {
            { 0, "0" }, { 1, "1" }, { 2, "2" }, { 3, "3" }, { 4, "4" }, { 5, "5" }, { 6, "6" }, { 7, "7" },
            { 8, "8" }, { 9, "9" }, { 10, "A" }, { 11, "B" }, { 12, "C" }, { 13, "D" }, { 14, "E" }, { 15, "F" }
        };
    }
}
