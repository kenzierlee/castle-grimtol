using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public bool Map { get; set; }
        public bool WrenchUsed { get; set; }
        // public Dictionary<string, Game> Directions { get; set; }
        public void Setup()
        {

        }
        public void Reset(Quest quest)
        {
            quest.Start();
        }
        public bool UseItem(string itemName)
        {
            bool success = false;
            for (var i = 0; i < CurrentPlayer.Inventory.Count; i++)
            {
                string item = CurrentPlayer.Inventory[i].Name.ToLower();
                if (item == itemName)
                {
                    success = true;
                }
            }
            if (success && CurrentRoom.Name != "The Crypt")
            {
                if (itemName == "paper")
                {
                    System.Console.WriteLine(@"
      N
    W   E
      S

                              Lab
                               |
        Broom Closet --------------------N. Hallway-----------------|
                |       |                                               *
                |----Nursery                                            |
                |                                                       |
            W. Hallway                                              E. Hallway
                |           Wine Cellar                                 |
 Trophy Room----|                |                                      |   
              Crypt----------------------S. Hallway----------------------
                |                                      |
           Crematorium                          Walk in Freezer
                    ");
                    return true;
                }
            }
            if (success && CurrentRoom.Name == "Upstairs")
            {
                if (itemName == "key")
                {
                    System.Console.WriteLine(@"
You use the key you found in the North Hallway to unlock the door, 
and much to your surprise it works! You slowly open the door and 
realize it's not over yet. You need to sneak through the main 
house and get out so you can get help. 'Should I take the front
door to the North? or the back door to the South?'");
                    return true;
                }
                else
                {
                    System.Console.WriteLine(@"
Your attempt to open the door fails, you hear footsteps rushing 
towards you. He heard you try to open the door, you turn around to 
run but it's too late. You're dead...");
                    return false;
                }
            }
            if (success && CurrentRoom.Name == "The Road")
            {
                if (itemName == "pocket watch")
                {
                    System.Console.WriteLine(@"
You pull out the pocket watch you found in the house, and ask if 
he will accept it as payment");
                    System.Console.WriteLine(@"
The cab driver agrees. You get in the cab and take your first deep 
breath. It's over, You Won!");
                    return false;
                }
                else if(itemName != "pocket watch")
                {
                    System.Console.WriteLine(@"
You inform the cab driver you will pay him once you get there. The cab 
driver replies angrily at your response and drives off. Your captor has 
caught up by now, he shoots at you from behind. You fall to the ground. 
So close... You lost.");
                    return false;
                }
            }
            if (success && CurrentRoom.Name == "The Crypt")
            {
                if (itemName == "wrench")
                {
                    System.Console.WriteLine(@"You use the wrench to loosen the pipe and use 
it as leverage to break free. You quickly run to the door and open it...");
                    WrenchUsed = true;
                    return true;
                }
                else
                {
                    System.Console.WriteLine("Unable to use that item at this time");
                    return true;
                }
            }
            if (success && CurrentRoom.Name == "The South Hallway")
            {
                if (itemName == "lighter")
                {
                    System.Console.WriteLine(@"You use the lighter to illuminate the wall, showing
the number sequence 1121. 'What could this be used for?'");
                    return true;
                }
                else
                {
                    System.Console.WriteLine("Unable to use that item at this time");
                    return true;
                }
            }
            if (CurrentRoom.Name == "The North Hallway")
            {
                if (success && itemName == "shoes")
                {
                    System.Console.WriteLine(@"You put the shoes on.");
                    return true;
                }
                else
                {
                    System.Console.WriteLine(@"You attempt to walk across the glass covered
hallway. As the pieces of glass pierce your feet, you stumble to your 
knees from the unimaginable pain. You enter a state of shock, and 
shortly after bleed out");
                    return false;
                }
            }
            else if (success)
            {
                System.Console.WriteLine("Unable to use that item at this time");
                return true;
            }
            else
            {
                System.Console.WriteLine(@"
You don't have that item in your inventory, enter 
inventory to see what items you have");
                return true;
            }
        }
        public void ListInventory()
        {
            if (CurrentPlayer.Inventory.Count > 0)
            {
                System.Console.WriteLine("Enter: ");
                for (int i = 0; i < CurrentPlayer.Inventory.Count; i++)
                {
                    string item = CurrentPlayer.Inventory[i].Name;
                    System.Console.WriteLine($"Use {item}");
                }
            }
            else
            {
                System.Console.WriteLine("You don't have any items in your inventory");
            }
        }
        public void ListDirections()
        {
            if (CurrentRoom.Directions.Count > 0)
            {
                if (WrenchUsed)
                {
                    System.Console.WriteLine("Enter: ");
                    foreach (var item in CurrentRoom.Directions)
                    {
                        System.Console.WriteLine($"Go {item.Key}");
                    }
                }
                else
                {
                    System.Console.WriteLine("No Directions Avaliable.");
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
            if (CurrentPlayer.Inventory.Count > 0)
            {
                var item = CurrentRoom.Items.Find(i => i.Name.ToLower() == itemName);
                if (CurrentPlayer.Inventory.Contains(item))
                {
                    System.Console.WriteLine("You already have that item in your inventory");
                    valid = true;
                }
            }
            for (var i = 0; i < CurrentRoom.Items.Count; i++)
            {
                string name = CurrentRoom.Items[i].Name.ToLower();
                if (name == itemName)
                {
                    if (itemName == "paper")
                    {
                        Map = true;
                    }
                    CurrentPlayer.Inventory.Add(CurrentRoom.Items[i]);
                    System.Console.WriteLine(@"
Item Added to Your Inventory");
                    System.Console.WriteLine($@"Name: {CurrentRoom.Items[i].Name} 
Description: {CurrentRoom.Items[i].Description}");
                    valid = true;
                    CurrentRoom.Items.Remove(CurrentRoom.Items[i]);
                }
            }
            if (!valid)
            {
                System.Console.WriteLine($"There is no {itemName} to take. Try a different Name?");
            }

        }
        public void updateCurrentRoom(string direction)
        {
            Console.Clear();
            if (CurrentRoom.Directions.ContainsKey(direction) && CurrentRoom.Name != "The Crypt")
            {
                CurrentRoom = CurrentRoom.Directions[direction];
                SearchRoom();
            }
            else if (CurrentRoom.Name == "The Crypt")
            {
                if (!WrenchUsed)
                {
                    System.Console.WriteLine(@"You can't get out of the room, you need to get yourself free 
from the pipe.");
                }
                else if (WrenchUsed)
                {
                    if (CurrentRoom.Directions.ContainsKey(direction))
                    {
                        CurrentRoom = CurrentRoom.Directions[direction];
                        SearchRoom();
                    }
                    else
                    {
                        System.Console.WriteLine("Not a Valid Option.");
                    }
                }
            }
            else
            {
                if (CurrentRoom.Name != "The Crypt")
                {
                    System.Console.WriteLine("Not a valid Option.");
                }
            }
        }
        public void SearchRoom()
        {
            System.Console.WriteLine($@"
Room Name: {CurrentRoom.Name}
            {CurrentRoom.Description}");
        }
        public Game(Room currentRoom, Player currentPlayer)
        {
            CurrentRoom = currentRoom;
            CurrentPlayer = currentPlayer;
        }
    }
}