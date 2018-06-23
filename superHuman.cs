using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class superHuman
    {
        public string _name { get; set; }
        public int _hp { get; set; }
        public int _strength { get; set; }

        public superHuman( string name, int hp, int strength)
        {
            _name = name;
            _hp = hp;
            _strength = strength;
        }
    }
}
