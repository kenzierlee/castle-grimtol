using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void Reset(Quest quest);

        //No need to Pass a room since Items can only be used in the CurrentRoom
        bool UseItem(string itemName);

    }
}
