
namespace T_T_T.GameManager.PlayerManager
{
    public class PlayerMove
    {
        public Player Player { get; set; }
        public int PlayerNumber { get; set; }
        public int PlayerStep { get; set; }
        public PlayerMove(Player player, int playerNumber, int playerStep) 
        {
            this.Player = player;
            this.PlayerNumber = playerNumber;
            this.PlayerStep = playerStep;
        }
    }
}
