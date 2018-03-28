using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public int Score { get; set; }
        public List<Item> Inventory { get; set; } = new List<Item>();
        public Player()
        {
            Score = 0;
        }
    }
}