using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T_T_T.GameManager;
using T_T_T.Q_Learning;

namespace T_T_T.Q_Learning.Utilities
{
    public class QTable
    {
        private QTableKey QTableKey { get; set; } = new QTableKey();
        private Dictionary<string, QActions> Table { get; set; } = new Dictionary<string, QActions>();
        private int CountActions { get; set; }
        public QTable(int countActions)
        {
            this.CountActions = countActions;
        }

        public QActions GetActions(string key)
        {
            Table.TryGetValue(key, out QActions actions);
            if (actions == null)
                Table.Add(key, new QActions(CountActions));

            return Table[key];
        }

        public string GetTableKey(GameField gameField)
        {
            return QTableKey.CreateTableKey(gameField);
        }
    }
}
