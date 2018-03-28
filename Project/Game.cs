using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        // public Dictionary<string, Game> Directions { get; set; }
        public void Setup()
        {

        }
        public void Reset(Quest quest)
        {
            quest.Start();
        }
        public void UseItem(string itemName)
        {

        }
        public void ListInventory()
        {
            if (CurrentPlayer.Inventory.Count > 0)
            {

                for (int i = 0; i < CurrentPlayer.Inventory.Count; i++)
                {
                    string item = CurrentPlayer.Inventory[i].Name;
                    System.Console.WriteLine($"Enter: Use {item}");
                }
            }
            else
            {
                System.Console.WriteLine("You dont have any items in your inventory");
            }
        }
        public void ListDirections()
        {
            if (CurrentRoom.Directions.Count > 0)
            {
                foreach (var item in CurrentRoom.Directions)
                {
                    System.Console.WriteLine($"Enter: Go {item.Key}");
                }
            }
            else
            {
                System.Console.WriteLine("No Directions Avaliable.");
            }
        }
        public void TakeItem(string itemName)
        {
            bool valid = false;
            for (var i = 0; i < CurrentRoom.Items.Count; i++)
            {
                string name = CurrentRoom.Items[i].Name.ToLower();
                if (name == itemName)
                {
                    CurrentPlayer.Inventory.Add(CurrentRoom.Items[i]);
                    System.Console.WriteLine("Item Added to Your Inventory");
                    valid = true;
                }
            }
            if (!valid)
            {
                System.Console.WriteLine($"There is no {itemName} to take. Try a different Name?");
            }

        }
        public void updateCurrentRoom(string direction)
        {
            bool valid = false;
            if(CurrentRoom.Name == "The Crypts")
            {
                for (int i = 0; i < CurrentPlayer.Inventory.Count; i++)
                {
                    string item = CurrentPlayer.Inventory[i].Name;
                    if(item == "Key")
                    {
                        CurrentRoom = CurrentRoom.Directions[direction];
                        valid = true;
                        SearchRoom();
                    }
                }
            }
            if(!valid)
            {
                System.Console.WriteLine("The Door is locked, it looks like you need to find a key to unlock it");
            }
            if (CurrentRoom.Directions[direction] != null)
            {
                CurrentRoom = CurrentRoom.Directions[direction];
                SearchRoom();
            }
            else
            {
                System.Console.WriteLine("Not a valid Option.");
            }
        }
        public void SearchRoom()
        {
            Console.Clear();
            System.Console.WriteLine($@"
            You've entered: {CurrentRoom.Name}
            {CurrentRoom.Description}");
        }
        public Game(Room currentRoom, Player currentPlayer)
        {
            CurrentRoom = currentRoom;
            CurrentPlayer = currentPlayer;
        }
    }
}