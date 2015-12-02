using System;

namespace JSON_De_Serialization
{
    class House
    {
        public string Address { get; set; }
        public int NumberOfFloors { get; set; }
        public Room[] rooms { get; set; }

        public House()
        {

        }
    }
}
