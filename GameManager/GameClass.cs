using T_T_T.GameManager.Utilities;
using T_T_T.Tools;

namespace T_T_T.GameManager
{
    public abstract class GameClass
    {
        public bool CanMakeMove { get; set; }
        public GameField GameField { get; set; }
        public GameClass()
        {

        }

        public abstract FieldChanges ClickHundler(int cellNumber);
        public abstract void StartGame();
        public abstract void EndGame();
    }
}
