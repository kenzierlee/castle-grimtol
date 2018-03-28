using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Room> Directions {get; set;} = new Dictionary<string, Room>();
        public List<Item> Items { get; set; } = new List<Item>();
        public void UseItem(Item item)
        {
            for(int i = 0;i < Items.Count;i++)
            {
                var inventory = Items[i];
                if(inventory == item)
                {

                }
            }
        }
        public void CreateItem(string name, string description)
        {
            Items.Add(new Item()
            {
                Name = name,
                Description = description
            });
        }
    }
}