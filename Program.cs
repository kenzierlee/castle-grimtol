﻿using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Quest quest = new Quest();
            quest.Start();
            while(quest.Playing)
            {
                quest.PlayerChoice();
            }
        }
    }
}
