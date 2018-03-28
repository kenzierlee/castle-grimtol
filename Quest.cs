using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Quest
    {
        public Game game { get; set; }
        public bool Playing = true;
        public Room CreateRooms
        {
            get
            {
                Room northHallway = new Room()
                {
                    Name = "The north Hallway",
                    Description = @"
Another long hallway, only this ones filled 
with shattered glass scattered all across the floor. You 
see something shinning at the end of it... It looks like 
a key? Hmmm..."
                };
                Room westHallway = new Room()
                {
                    Name = "The west Hallway",
                    Description = @"
Its a long narrow hallway, you hear 
yelling in the distance followed by what sounded 
like 3 gunshots. You start running towards what looks 
to be a source of light. You trip, when you like to see 
what you stumbled on you discover its an arm... Just an 
arm, clutched in the arms hand looks to be a pocket watch."
                };
                Room southHallway = new Room()
                {
                    Name = "The south Hallway",
                    Description = @"
The hallways stacked high with what 
seems to be clothing, and shoes. You hear someone coming 
you need to hurry up they're getting closer. You crawl 
over the waist high piles of clothing for what seems to 
be forever, you reach for something to help you along and 
notice a shimmering object amidst the blood stained clothes. 
You take a closer look and notice its a lighter. You finally 
reach the end of the hallway. You gather yourself and stand 
up. Quick where to next???"
                };
                Room eastHallway = new Room()
                {
                    Name = "The east Hallway",
                    Description = @"
The Hallway is at a steep incline, you 
get on your hands and knees to attempt the climb."
                };
                Room lab = new Room()
                {
                    Name = "The Lab",
                    Description = @"
The room is poorly lit but you can make 
out what looks to be a lab. There's a table filled with 
surgical tools, and a table in the center of the room with 
what looks to be restraints for arms. You panic as you fear 
you will be the next victim strapped to the table as someone 
performs some sort of experiment on you. You quickly look 
around the room for something that might help you get out of 
this nightmare of a place. All you see is eerie World War 2 
memorabilia, including a gas mask."
                };
                Room broomCloset = new Room()
                {
                    Name = "Broom Closet",
                    Description = @"
It seems you've entered into a closet filled 
with cleaning supplies. You take a quick look around the room, 
and notice a walkie talkie. Nothing useful in here, you're 
waisting time. Hurry where to next???"
                };
                Room nursery = new Room()
                {
                    Name = "Nursery",
                    Description = @"
You feel along the walls for a light switch, 
you find it and turn the lights on. The fluorescent light 
flickers, as you get a glimpse of what seems to be a baby's 
nursery. Thats when you notice the crib in the corner of the 
room... It's rocking back and forth. Out of the corner of 
your eye you notice a rusty old hammer and some wood. It looks 
like someone was trying to make a changing table for the nursery."
                };
                Room crematorium = new Room()
                {
                    Name = "The Crematorium",
                    Description = @"
Its rather warm in here, you see what 
looks to a furnace, you get closer and realize you're 
in a Crematory. Where are you??? Your hit over the head, 
and meet your fate. All evidence of you is insenerated 
and you are never to be seen or heard from again..."
                };
                Room trophyRoom = new Room()
                {
                    Name = "The Trophy Room",
                    Description = @"
It appears to be a room with lined with 
shelves, filled with trophies and awards. You read a few 
and notice all the awards are made out to a Samuel Smith. 
This must be his house, he must be your kidnapper. The man 
behind all of this. But why? Why would he want you? You 
search the desk in the center of the room only to find a list. 
The list contains several dozen names and yours... Yours is 
one of them... You continue to look around and find nothing useful."
                };
                Room wineCellar = new Room()
                {
                    Name = "The Wine Cellar",
                    Description = @"
For such a desturbing place this room has an 
amazing collection of wines. You try not to get side tracked 
by the wines, as you are havent had anything to drink in a 
long time."
                };
                Room walkInFreezer = new Room()
                {
                    Name = "Walk In Freezer",
                    Description = @"
burrrrr It's freezing in here, you flip on 
the lights and oh my... Thats not... Thats not what you 
think it is... is it?? Are those... Are those bodies. You 
quickly turn back to leave and notice there is no handle to 
get out. Your stuck in here, where you'll soon freeze to death. 
Quick there has to be some way to get out of here. You notice 
a keypad next to the door. But what's the combination???"
                };
                Room upstairs = new Room()
                {
                    Name = "Upstairs",
                    Description = @"
Could this be it? The door to your freedom. 
Could this nightmare really be over??"
                };
                Room frontDoor = new Room()
                {
                    Name = "The Front Door",
                    Description = @"
You can see it, a few feet away the front door. 
You walk towards it and the floor boards creek. You run to the 
door as surely he's heard. But your not fast enough, and you 
meet your fate..."
                };
                Room backDoor = new Room()
                {
                    Name = "The Back Door",
                    Description = @"
You can see it, freedom just within your grasp 
you rush to the door. Running out to the street, searching for 
help. You see headlights heading in your direction. You wave 
your arms histarically hoping they'll stop. The car comes to an 
abrupt stop just in time. It's a cab the driver rolls down the 
window and asks where your headed you respond with the police 
station please. He proceeds to ask if you have money to pay for it. 
You have no money."
                };
                Room crypt = new Room()
                {
                    Name = "The Crypt",
                    Description = @"
It's dark, you can hardly see in front of you. 
You notice a handcuff on your left wrist you follow the chain 
to what feels like a pipe. You yank the chain to attempt to free 
yourself to no avail. You feel around and notice a slip of paper 
on the ground, however its too dark in here to read the contents. 
You can hardly make it out but it looks as though a number sequence 
is written on the wall 1121. You hear footsteps that sound like 
they're coming from above you. You need to get out, you need to get 
help. You continue to search the room as best as you can for 
something to help get you loose from the restraint. All you notice 
is what feels like a wrench. Maybe you can leverage it against the 
pipe or try to loosen it so you can break free?"
                };
                crypt.CreateItem("Paper", "Its Mostly Scribbles you can't make out, but theres a pattern maybe when you get out of the room you'll be able to read it.");
                crypt.CreateItem("Wrench", "A rusty steel wrench");
                northHallway.CreateItem("Key", "A Key, but for what?");
                westHallway.CreateItem("Pocket Watch", "It appears to be broken, Maybe its worth something.");
                southHallway.CreateItem("Shoes", "A pair of shoes just your size. How convenient...");
                southHallway.CreateItem("Lighter", "A Lighter... I wonder what I could use this for? You notice the lighter is engraved, it reads '-J.S'. J.S? who could this belong to?");
                broomCloset.CreateItem("Walkie Talkie", "You turn it on, and hear nothing but static. But it works... On the back a label reading PROPERTY OF SAM SMITH. Sam Smith? Why does that sound familiar?");
                nursery.CreateItem("Hammer", "The Hammer appears as if it hasnt been touched in decades. You notice closer to the bottom of the hammer is what looks like a blood stain...");
                lab.CreateItem("Gas Mask", "A rather old Gas Mask covered in dust");
                crypt.Directions.Add("south", crematorium);
                crypt.Directions.Add("north", westHallway);
                crypt.Directions.Add("east", southHallway);
                lab.Directions.Add("north", northHallway);
                northHallway.Directions.Add("south", lab);
                northHallway.Directions.Add("west", westHallway);
                westHallway.Directions.Add("north", broomCloset);
                westHallway.Directions.Add("west", trophyRoom);
                westHallway.Directions.Add("east", nursery);
                westHallway.Directions.Add("south", crypt);
                southHallway.Directions.Add("west", crypt);
                southHallway.Directions.Add("north", wineCellar);
                southHallway.Directions.Add("south", walkInFreezer);
                southHallway.Directions.Add("east", eastHallway);
                eastHallway.Directions.Add("north", upstairs);
                nursery.Directions.Add("west", westHallway);
                nursery.Directions.Add("north", northHallway);
                upstairs.Directions.Add("north", frontDoor);
                upstairs.Directions.Add("south", backDoor);
                walkInFreezer.Directions.Add("north", southHallway);
                return crypt;
            }
        }
        public Player UserSetup()
        {
            return new Player();
        }
        //initiates/creates the game
        public void Start()
        {
            game = new Game(CreateRooms, UserSetup());
            System.Console.WriteLine(@"
You wake up confused and panic when you realize you have no idea 
where you are... You notice your shoes are gone?");
        }
        //user options
        public void PlayerChoice()
        {
            System.Console.WriteLine("What do you want to do?");
            var userInput = Console.ReadLine().ToLower();
            string validChoice = "";
            string[] input = userInput.Split(" ");
            List<string> list = new List<string>(input);
            if (userInput[0] == 'g')
            {
                validChoice = userInput;
                game.updateCurrentRoom(input[1]);
            }
            if (userInput[0] == 'u')
            {
                validChoice = userInput;
                list.RemoveAt(0);
                string newInput = string.Join(" ", list.ToArray());
                game.UseItem(newInput);
            }
            if (userInput[0] == 't')
            {
                validChoice = userInput;
                list.RemoveAt(0);
                string newInput = string.Join(" ", list.ToArray());
                game.TakeItem(newInput);
            }
            if (userInput[0] == 'h')
            {
                validChoice = userInput;
                System.Console.WriteLine("Directions you can go: ");
                game.ListDirections();
                System.Console.WriteLine("Available Inventory you can use: ");
                game.ListInventory();
                System.Console.WriteLine("If you think there is an item that would be useful try entering: Take 'item' replace item with what you want to try and take. If its an item you can take it will be added to your inventory");
                System.Console.WriteLine("To see your Inventory Enter: inventory");
                System.Console.WriteLine("To end the game Enter: quit");
            }
            if (userInput[0] == 'q')
            {
                validChoice = userInput;
                Playing = false;
                //this will exit the game equivalent to ctrl c
                //Environment.Exit(0);
            }
            if (userInput[0] == 'i')
            {
                validChoice = userInput;
                game.ListDirections();
            }
            else if(validChoice.Length <1)
            {
                System.Console.WriteLine("Your waisting time... Provide a valid choice. Enter 'help' if you need to see a list of valid options.");
                PlayerChoice();
            }
        }
        //sets up the 
        public void GamePlay()
        {
//             if(game.Map && game.CurrentRoom.Name != "The Crypt")
//             {
//                 System.Console.WriteLine(@"
//       N
//     W   E
//       S

//         Broom Closet -----------------N. Hallway-----------------|
//                 |        |                                              *
//                 |-----Nursery                                           |
//             W. Hallway                                                  |
//                 |                                                  E. Hallway
//  Trophy Room----|           Wine Cellar                                 |
//                 |                |                                      |   
//               Crypt----------------------S. Hallway----------------------
//                 |                                      |
//            Crematorium                          Walk in Freezer
//                 ");
//             }
            if (game.CurrentRoom.Name == "Walk In Freezer")
            {
                System.Console.WriteLine("Hurry enter a four digit code!");
                string input = Console.ReadLine();
                int code = 0;
                bool valid = int.TryParse(input, out code);
                if (valid)
                {
                    if (code == 1121)
                    {
                        System.Console.WriteLine("The door opens");
                        PlayerChoice();
                    }
                    else
                    {
                        System.Console.WriteLine("You entered the wrong code, and eventually freeze to death...");
                        PlayAgain();
                    }
                }
                else
                {
                    System.Console.WriteLine("You entered the wrong code, and eventually freeze to death...");
                    PlayAgain();
                }
            }
            if (game.CurrentRoom.Name == "Upstairs")
            {
                bool success = false;
                for (var i = 0; i < game.CurrentPlayer.Inventory.Count; i++)
                {
                    string itemName = game.CurrentPlayer.Inventory[i].Name;
                    if (itemName == "Key")
                    {
                        success = true;
                    }
                }
                if (success)
                {
                    System.Console.WriteLine("You try the door, its locked. You use the key you found in the north Hallway to unlock the door, and much to your surprise it works! You slowly open the door and realize its not over yet. You need to sneek through the main house and get out so you can get help");
                    bool valid = false;
                    for (var i = 0; i < game.CurrentPlayer.Inventory.Count; i++)
                    {
                        string itemName = game.CurrentPlayer.Inventory[i].Name;
                        if (itemName == "Walkie Talkie")
                        {
                            System.Console.WriteLine("You attempt to be quite, but the walkie talkie you grabbed from the broom closet goes off. You attempt to run to no avail. You meet your fate...");
                            PlayAgain();
                        }
                    }
                    if (valid)
                    {
                        PlayerChoice();
                    }
                }
                else
                {
                    System.Console.WriteLine("You go to open the door but its locked, you hear footsteps rushing towards you. He heard you try to open the door, you turn around to run but its too late. Your dead...");
                    PlayAgain();
                }
            }
            if (game.CurrentRoom.Name == "The Back Door")
            {
                bool valid = false;
                for (var i = 0; i < game.CurrentPlayer.Inventory.Count; i++)
                {
                    string itemName = game.CurrentPlayer.Inventory[i].Name;
                    if (itemName == "Pocket Watch")
                    {
                        valid = true;
                    }
                }
                if (valid)
                {
                    System.Console.WriteLine("You pull out the pocket watch you found from the house, and ask if he will accept it as payment");
                    System.Console.WriteLine("The cab driver agrees. You get in the cab and take your first deep breathe. Its over, You Won!");
                    PlayAgain();
                }
                else
                {
                    System.Console.WriteLine("You inform the cab driver you will pay him once you get there. The cab driver replies angrily at your response and drives off. Your kidnapper's caught up by now, he shoots at you from behind. You fall to the ground. So close... You lost.");
                    PlayAgain();
                }
            }
            if (game.CurrentRoom.Name == "The Crematorium" || game.CurrentRoom.Name == "The Front Door")
            {
                game.SearchRoom();
                PlayAgain();
            }
            else
            {
                PlayerChoice();
            }
        }
        //option to play again or quit
        public void PlayAgain()
        {
            System.Console.WriteLine("Would you like to play again, yes or no?");
            string choice = Console.ReadLine().ToLower();
            if (choice[0] == 'y')
            {
                Start();
            }
            else
            {
                Playing = false;
            }
        }
    }
}