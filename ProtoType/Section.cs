using System;

namespace DesignPatternsImplementation.ProtoType
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Object Clone()
        {
            return (Section)this.MemberwiseClone();
        }
    }
}