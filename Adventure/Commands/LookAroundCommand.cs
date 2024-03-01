﻿using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class LookAroundCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            Console.WriteLine($"You looked around and see a {world.CurrentRoom.Description}");
        }
    }
}
