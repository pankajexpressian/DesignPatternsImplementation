using System;

namespace DesignPatternsImplementation.ProtoType
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public ContactDetail ContactDetail { get; set; }
        public Object Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}