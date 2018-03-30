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
                    Name = "The North Hallway",
                    Description = @"
Another long hallway, only this ones filled with shattered glass scattered all 
across the floor. 'I have to be careful... This glass is sharp and unavoidable.
There's no way my bare feet could handle this.' You see something shinning at 
the end of it... Hmmm..."
                };
                Room westHallway = new Room()
                {
                    Name = "The West Hallway",
                    Description = @"
Its a long narrow hallway, you hear yelling in the distance followed by what 
sounded like 3 gunshots. You start running towards what looks to be a source 
of light. You trip, when you like to see what you stumbled on you discover 
its an arm... Just an arm, clutched in the arms hand looks to be a pocket 
watch."
                };
                Room southHallway = new Room()
                {
                    Name = "The South Hallway",
                    Description = @"
The hallways stacked high with what seems to be clothing, and shoes. 
The footsteps are getting louder. You need to hurry, they're getting 
closer. You crawl over the waist high piles of clothing for what 
seems to be forever, you reach for something to help you along and 
notice a shimmering object amidst the blood stained clothes. You take 
a closer look and notice its a lighter. You finally clamber over the 
clothing. You gather yourself and stand up. A door to the North, and 
South line the hallway. There is a corner further down the Hallway to
the East. Quick where to next???"
                };
                Room eastHallway = new Room()
                {
                    Name = "The East Hallway",
                    Description = @"
The Hallway is at a steep incline, you get on your hands and knees 
to attempt the climb."
                };
                Room lab = new Room()
                {
                    Name = "The Lab",
                    Description = @"
The room is poorly lit but you can make out what looks to be a lab. 
There's a table filled with surgical tools, and a table in the center 
of the room with what looks to be restraints for arms. You panic as 
you fear you will be the next victim strapped to the table as someone 
performs some sort of experiment on you. You quickly look around the 
room for something that might help you get out of this nightmare of a 
place. All you see is eerie World War 2 memorabilia, including a gas mask."
                };
                Room broomCloset = new Room()
                {
                    Name = "Broom Closet",
                    Description = @"
It seems you've entered into a closet filled with cleaning supplies. You 
take a quick look around the room, and notice a walkie talkie. Nothing 
useful in here, you're waisting time. Hurry where to next???"
                };
                Room nursery = new Room()
                {
                    Name = "Nursery",
                    Description = @"
You feel along the walls for a light switch, you find it and turn the 
lights on. The fluorescent light flickers, as you get a glimpse of what 
seems to be a baby's nursery. Thats when you notice the crib in the corner 
of the room... It's rocking back and forth. Better get out of here quick! 
Out of the corner of your eye you notice a rusty old hammer and some wood. 
It looks like someone was trying to make a changing table for the nursery."
                };
                Room crematorium = new Room()
                {
                    Name = "The Crematorium",
                    Description = @"
Its rather warm in here, you see what looks to a furnace, you get closer 
and realize you're in a Crematory. Where are you??? You're hit over the 
head, and meet your fate. All semblance of your existence is insenerated 
and with you all the evidence..."
                };
                Room trophyRoom = new Room()
                {
                    Name = "The Trophy Room",
                    Description = @"
It appears to be a room lined with shelves, filled with 
trophies and awards. You read a few and notice all the 
awards are made out to a Samuel Smith. This must be his house, 
he must be your captor. The man behind all of this. But why? 
Why would he want you? You search the desk in the center of 
the room only to find a list. The list contains several dozen 
names and... Yours is the last on the list... You continue to 
look around and find nothing useful."
                };
                Room wineCellar = new Room()
                {
                    Name = "The Wine Cellar",
                    Description = @"
For such a desturbing place, the owner, has an amazing collection of 
wine. You try not to get side tracked by all the wine, as you havent 
had anything to drink in a long time."
                };
                Room walkInFreezer = new Room()
                {
                    Name = "Walk In Freezer",
                    Description = @"
burrrrr It's freezing in here, you flip on the lights, 'oh my... 
Thats not... Thats not what I think it is... is it?? Are those... 
Are those bodies.' You quickly turn back to leave and notice there 
isn't a handle to get out. You're stuck in here, where you'll soon freeze 
to death. Quick there has to be some way to get out of here! You notice 
a keypad next to the door. But what's the combination???"
                };
                Room upstairs = new Room()
                {
                    Name = "Upstairs",
                    Description = @"
'Could this be it? The door to freedom. Could this nightmare really 
be over??' You try the door, its locked."
                };
                Room frontDoor = new Room()
                {
                    Name = "The Front Door",
                    Description = @"
You can see it, a few feet away the front door. You walk towards it and 
the floor boards creek. You run to the door as surely he's heard. But your 
not fast enough, and you meet your fate..."
                };
                Room backDoor = new Room()
                {
                    Name = "The Back Door",
                    Description = @"
You check around for anyone, and when the coast is clear you run 
to the back door..."
                };
                Room road = new Room()
                {
                    Name = "The Road",
                    Description = "You start running through the woods towards the road..."
                };
                Room endHallway = new Room()
                {
                    Name = "End of the North Hallway",
                    Description = @"
A dead end. On the floor you find what caught
your eye. A key, 'this has to be useful...'"
                };
                Room crypt = new Room()
                {
                    Name = "The Crypt",
                    Description = @"
A dark musty room that wreeks of death and despair. The darkness seems to
devour any shimmer of hope. There's a door to the south and the one you
entered from."
                };
                crypt.CreateItem("Paper", @"Its Mostly Scribbles you can't make out, but theres a 
pattern maybe when you get out of the room you'll be able to read it.");
                crypt.CreateItem("Wrench", "A rusty steel wrench");
                endHallway.CreateItem("Key", "A Key, but for what?");
                westHallway.CreateItem("Pocket Watch", "It appears to be broken, Maybe its worth something.");
                southHallway.CreateItem("Shoes", "A pair of shoes just your size. How convenient...");
                southHallway.CreateItem("Lighter", @"A Lighter... I wonder what I could use this for? You notice 
the lighter is engraved, it reads 'Use to bring light to things obscured
by darkness'.");
                broomCloset.CreateItem("Walkie Talkie", @"You turn it on, and hear nothing but static. But it works... 
On the back a label reading PROPERTY OF SAM SMITH. Sam Smith? 
Why does that sound familiar?");
                nursery.CreateItem("Hammer", @"The Hammer appears as if it hasnt been touched in decades. 
You notice closer to the bottom of the hammer is what looks 
like a blood stain...");
                lab.CreateItem("Gas Mask", "A rather old Gas Mask covered in dust");
                wineCellar.CreateItem("Wine", "A vintage wine, too bad you don't have a wine opener...");
                crypt.Directions.Add("south", crematorium);
                crypt.Directions.Add("north", westHallway);
                crypt.Directions.Add("east", southHallway);
                lab.Directions.Add("north", northHallway);
                broomCloset.Directions.Add("south", westHallway);
                broomCloset.Directions.Add("east", northHallway);
                trophyRoom.Directions.Add("east", westHallway);
                endHallway.Directions.Add("west", northHallway);
                northHallway.Directions.Add("south", lab);
                northHallway.Directions.Add("west", broomCloset);
                northHallway.Directions.Add("east", endHallway);
                westHallway.Directions.Add("north", broomCloset);
                westHallway.Directions.Add("west", trophyRoom);
                westHallway.Directions.Add("east", nursery);
                westHallway.Directions.Add("south", crypt);
                southHallway.Directions.Add("west", crypt);
                southHallway.Directions.Add("north", wineCellar);
                southHallway.Directions.Add("south", walkInFreezer);
                southHallway.Directions.Add("east", eastHallway);
                eastHallway.Directions.Add("north", upstairs);
                eastHallway.Directions.Add("west", southHallway);
                nursery.Directions.Add("west", westHallway);
                nursery.Directions.Add("north", northHallway);
                upstairs.Directions.Add("north", frontDoor);
                upstairs.Directions.Add("south", backDoor);
                wineCellar.Directions.Add("south", southHallway);
                walkInFreezer.Directions.Add("north", southHallway);
                backDoor.Directions.Add("north", road);
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
You wake up in haze, confused, not knowing where you are. You notice your 
shoes are gone...? The smell of mold and decay are overwhelming. It's pitch 
black with the exception of a faint light coming from underneath the door. 
You notice a handcuff on your left wrist you follow the chain to what feels 
like a pipe. You yank the chain to attempt to free yourself to no avail. 
You feel around and notice a slip of paper on the ground, however its too 
dark in here to read the contents. You hear footsteps that sound like 
they're coming from above you. You need to get out, you need to get help! 
You continue to search the room as best as you can for something to help 
get you loose from the restraint. Your hand stumbles across something that 
feels like a metal wrench. Maybe you can leverage it against the pipe or 
try to loosen it so you can break free?");
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
                if(game.CurrentRoom.Directions.ContainsKey(input[1]))
                {
                    game.updateCurrentRoom(input[1]);
                }
                else
                {
                    System.Console.WriteLine("You cannot go that direction");
                }
            }
            if (userInput[0] == 'u')
            {
                validChoice = userInput;
                list.RemoveAt(0);
                string newInput = string.Join(" ", list.ToArray());
                if(!game.UseItem(newInput))
                {
                    PlayAgain();
                }
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
                System.Console.WriteLine(@"If you think there is an item that would be useful try entering: 
Take 'item' replace item with what you want to try and take. If its an 
item you can take it will be added to your inventory");
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
            else if(validChoice.Length <1 || userInput.Length < 1)
            {
                System.Console.WriteLine(@"Your waisting time... Provide a valid choice. 
Enter 'help' if you need to see a list of valid options.");
                PlayerChoice();
            }
        }
        //sets up the 
        public void GamePlay()
        {
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
            if (game.CurrentRoom.Name == "The Crematorium" || game.CurrentRoom.Name == "The Front Door")
            {
                PlayAgain();
            }
            // if(game.CurrentRoom.Name == "The Back Door")
            // {

            // }
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