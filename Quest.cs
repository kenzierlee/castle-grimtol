using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Quest
    {
        public Game game { get; set; }
        public bool Playing = true;
        public Room CreateRooms()
        {
            Room northHallway = new Room()
            {
                Name = "The North Hallway",
                Description = "Another long hallway, only this ones filled with shattered glass scattered all across the floor."
            };
            Room westHallway = new Room()
            {
                Name = "The West Hallway",
                Description = "Its a long narrow hallway, you hear yelling in the distance followed by what sounded like 3 gunshots. You start running towards what looks to be a source of light. You trip, when you like to see what you stumbled on you discover its an arm... Just an arm, clutched in the arms hand looks to be a pocket watch."
            };
            Room southHallway = new Room()
            {
                Name = "The South Hallway",
                Description = "The hallways stacked high with what seems to be clothing, and shoes. You hear someone coming you need to hurry up they're getting closer. You crawl over the waist high piles of clothing for what seems to be forever, you reach for something to help you along and notice a shimmering object amidst the blood stained clothes. You take a closer look and notice its a lighter. You finally reach the end of the hallway. You gather yourself and stand up. Quick where to next???"
            };
            Room eastHallway = new Room()
            {
                Name = "The East Hallway",
                Description = "The Hallway is at a steep incline, you get on your hands and knees to attempt the climb."
            };
            Room broomCloset = new Room()
            {
                Name = "Broom Closet",
                Description = "It seems you've entered into a closet filled with cleaning supplies. You take a quick look around the room, and notice a walkie talkie. Nothing useful in here, you're waisting time. Hurry where to next???"
            };
            Room nursery = new Room()
            {
                Name = "Nursery",
                Description = "You feel along the walls for a light switch, you find it and turn the lights on. The fluorescent light flickers, as you get a glimpse of what seems to be a baby's nursery. Thats when you notice the crib in the corner of the room... It's rocking back and forth. Out of the corner of your eye you notice a rusty old hammer and some wood. It looks like someone was trying to make a changing table for the nursery."
            };
            Room crematorium = new Room()
            {
                Name = "The Crematorium",
                Description = "Its rather warm in here, you see what looks to a furnace, you get closer and realize you're in a Crematory. Where are you??? Your hit over the head, and meet your fate. All evidence of you is insenerated and you are never to be seen or heard from again..."
            };
            Room crypts = new Room()
            {
                Name = "The Crypts",
                Description = "It's dark, you can hardly see in front of you. You feel around and notice a slip of paper on the ground, however its too dark in here to read the contents. You hear footsteps that sound like they're coming from above you. You need to get out, you need to get help. Continuing to feel around for a door, you find a handle. Its locked! Quick look around the room for something to open the door with!"
            };
            crypts.CreateItem("Paper", "Its Mostly Scribbles you can't make out, but there is a word thats repeated often... Jessie");
            crypts.CreateItem("Key", "A key it must be to open the door!");
            westHallway.CreateItem("Pocket Watch", "It appears to be broken, Maybe its worth something.");
            southHallway.CreateItem("Shoes", "");
            southHallway.CreateItem("Lighter", "A Lighter... I wonder what I could use this for? Its engraved, it reads 'light the darkness, -J.S'. J.S? who could this belong to?");
            broomCloset.CreateItem("Walkie Talkie", "You turn it on, and hear nothing but static. But it works... On the back a label reading PROPERTY OF SAM SMITH. Sam Smith? Why does that sound familiar?");
            nursery.CreateItem("Hammer", "The Hammer appears as if it hasnt been touched in decades. You notice closer to the bottom of the hammer is what looks like a blood stain...");
            crypts.Directions.Add("South", crematorium);
            crypts.Directions.Add("North", westHallway);
            crypts.Directions.Add("East", southHallway);
            westHallway.Directions.Add("North", broomCloset);
            westHallway.Directions.Add("East", nursery);
            westHallway.Directions.Add("South", crypts);
            nursery.Directions.Add("West", westHallway);
            nursery.Directions.Add("North", northHallway);
            return crypts;
        }
        public Player UserSetup()
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to your Greatest Adventure! What's your Name?");
            string name = Console.ReadLine();
            return new Player();
        }
        public void Start()
        {
            System.Console.WriteLine("You wake up confused and panic when you realize you have no idea where you are... You notice your shoes are gone?");
            game = new Game(CreateRooms(), UserSetup());
        }
        public void PlayerChoice()
        {
            System.Console.WriteLine("What do you want to do?");
            var userInput = Console.ReadLine().ToLower();
            string validChoice = "";
            string[] input = userInput.Split(" ");
            if (userInput[0] == 'g')
            {
                validChoice = userInput;
                game.updateCurrentRoom(input[1]);
            }
            if (userInput[0] == 'u')
            {
                validChoice = userInput;
                game.UseItem(input[1]);
            }
            if (userInput[0] == 't')
            {
                validChoice = userInput;
                if (input.Length > 2)
                {
                    string choice = input[1]+" "+input[2];
                    game.TakeItem(choice);
                }
                else
                {
                    game.TakeItem(input[1]);
                }
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
            if(userInput[0] == 'i')
            {
                validChoice = userInput;
                game.ListDirections();
            }
            else
            {
                System.Console.WriteLine("Your waisting time... Provide a valid choice. Enter 'help' if you need to see a list of valid options.");
                PlayerChoice();
            }
        }
        public 
    }
}