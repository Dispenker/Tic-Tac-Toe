
namespace T_T_T.GameManager.PlayerManager
{
    public class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PlayerSymbol Symbol { get => (PlayerSymbol)Number; }
        public Player(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
    
    public enum PlayerSymbol
    {
        Zero = -1,
        Krestik = 0,
        Nolik = 1,
        Minus = 2,
        Plus = 3
    }
}
