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
            //             if (CurrentRoom.Name == "Walk In Freezer")
            //             {
            //                 System.Console.WriteLine("Hurry enter a four digit code!");
            //                 string input = Console.ReadLine();
            //                 int code = 0;
            //                 bool valid = int.TryParse(input, out code);
            //                 if (valid)
            //                 {
            //                     if (code == 1121)
            //                     {
            //                         System.Console.WriteLine("The door opens");
            //                     }
            //                     else
            //                     {
            //                         System.Console.WriteLine(@"
            // You entered the wrong code, and eventually freeze 
            // to death...");
            //                     }
            //                 }
            //                 else
            //                 {
            //                     System.Console.WriteLine(@"
            // You entered the wrong code, and eventually freeze 
            // to death...");
            //                 }
            //             }
            if (success && CurrentRoom.Name == "Upstairs")
            {
                if (itemName == "key")
                {
                    System.Console.WriteLine(@"
You use the key you found in the north Hallway to unlock the door, 
and much to your surprise it works! You slowly open the door and 
realize its not over yet. You need to sneek through the main 
house and get out so you can get help");
                    return true;
                }
                else
                {
                    System.Console.WriteLine(@"
Your attempt to open the door fails, you hear footsteps rushing 
towards you. He heard you try to open the door, you turn around to 
run but its too late. Your dead...");
                    return false;
                }
            }
            if (success && CurrentRoom.Name == "The Road")
            {
                if (itemName == "pocket watch")
                {
                    System.Console.WriteLine(@"
You pull out the pocket watch you found from the house, and ask if 
he will accept it as payment");
                    System.Console.WriteLine(@"
The cab driver agrees. You get in the cab and take your first deep 
breathe. Its over, You Won!");
                    return true;
                }
                else
                {
                    System.Console.WriteLine(@"
You inform the cab driver you will pay him once you get there. The cab 
driver replies angrily at your response and drives off. Your kidnapper's 
caught up by now, he shoots at you from behind. You fall to the ground. 
So close... You lost.");
                    return false;
                }
            }
            if (success && CurrentRoom.Name == "The Crypt")
            {
                if (itemName == "wrench")
                {
                    System.Console.WriteLine(@"You use the wrench to loosen the pipe and leverage 
against it to break free. You quickly run to the door and open it...");
                    WrenchUsed = true;
                    return true;
                }
                else
                {
                    System.Console.WriteLine("Unable to use that item at this time");
                    return true;
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
You dont not have that item in your inventory enter 
inventory to see what items you have");
                return true;
            }
            // if (CurrentRoom.Name == "The Crematorium" || CurrentRoom.Name == "The Front Door")
            // {
            //     SearchRoom();
            // }
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
            if (CurrentPlayer.Inventory.Count > 0)
            {
                var item = CurrentRoom.Items.Find(i => i.Name.ToLower() == itemName);
                if (item != null)
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
            if (CurrentRoom.Name == "The Crypt")
            {
                // bool valid = false;
                // for (int i = 0; i < CurrentPlayer.Inventory.Count; i++)
                // {
                //     string item = CurrentPlayer.Inventory[i].Name;
                //     if (item == "Wrench")
                //     {
                //         System.Console.WriteLine("You use the wrench to loosen the pipe and leverage against it to break free. You quickly run to the door and open it...");
                //         CurrentRoom = CurrentRoom.Directions[direction];
                //         valid = true;
                //         SearchRoom();
                //     }
                // }
                if (!WrenchUsed)
                {
                    System.Console.WriteLine(@"You cant get out of the room, you need to get yourself free 
from the pipe.");
                }
                else if (WrenchUsed)
                {
                    if (CurrentRoom.Directions.ContainsKey(direction))
                    {
                        SearchRoom();
                        CurrentRoom = CurrentRoom.Directions[direction];
                    }
                    else
                    {
                        System.Console.WriteLine("Not a valid Option.");
                    }
                }
            }
            if (CurrentRoom.Name == "The Back Door")
            {
                var walkie = CurrentPlayer.Inventory.Find(i => i.Name == "Walkie Talkie");
                if (walkie != null)
                {
                    System.Console.WriteLine(@"On your run to the door the walkie talkie you grabbed from the 
Broom Closet goes off... He hears this noise and quickly runs to you.
You cant turn the handle fast enough and you meet your fate...");
                }
                else
                {
                    System.Console.WriteLine(@"You turn the handle get outside and notice a road to the north.");
                }
            }
            if (CurrentRoom.Name == "The Road")
            {
                var wine = CurrentPlayer.Inventory.Find(i => i.Name == "Wine");
                var mask = CurrentPlayer.Inventory.Find(i => i.Name == "Gas Mask");
                if (wine != null && mask != null)
                {
                    System.Console.WriteLine(@"The wine and gas mask you stole from the house slow you down
on your way to the road, and your kidnapper catches up to you. 
Tired of dealing with you he kills you. You lose...");
                }
                else
                {
                    System.Console.WriteLine(@"You see headlights heading 
in your direction. You wave your arms histarically hoping they'll stop. 
The car comes to an abrupt stop just in time. It's a cab the driver rolls 
down the window and asks where your headed you respond with the police 
station please. He proceeds to ask if you have money to pay for it. You 
have no money.");
                }
            }
            else if (CurrentRoom.Directions.ContainsKey(direction) && CurrentRoom.Name != "The Crypt")
            {
                CurrentRoom = CurrentRoom.Directions[direction];
                SearchRoom();
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