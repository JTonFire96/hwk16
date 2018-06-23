using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class superHero : superHuman
    {
        public int _spiral { get; set; }
        public superHero(string name, int hp, int strength, int spiral) : base(name, hp, strength)
        {
            _name = name;
            _hp = hp;
            _strength = strength;
            _spiral = spiral;
        }

    }

}
