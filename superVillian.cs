using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class superVillain : superHuman
    { 
    public int _antispiral { get; set; }
    public superVillain(string name, int hp, int strength, int antispiral) : base(name, hp, strength)
    {
        _name = name;
        _hp = hp;
        _strength = strength;
        _antispiral = antispiral;
    }
}
}
