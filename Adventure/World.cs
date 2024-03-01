﻿using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public List<BaseRoom> rooms = [];
        public BaseRoom CurrentRoom { get; private set; }

        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();

            lobby.RegisterNeighbour(corridor);


            rooms.AddRange([lobby, corridor]);

            CurrentRoom = rooms[0];
        }

        public string Intro { get; } = @"
How did you end up here? You don't really know. Maybe you fell, maybe someone pushed you.
One thing is certain, you need to GET OUT OF HERE!
";
    }
}
