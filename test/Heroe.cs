using System.Collections.Generic;

namespace test
{
    public class Heroe
    {

        public Heroe(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;

        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

    }
}
