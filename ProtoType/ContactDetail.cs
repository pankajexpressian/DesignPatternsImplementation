using System;

namespace DesignPatternsImplementation.ProtoType
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public Object Clone()
        {
            return (ContactDetail)this.MemberwiseClone();
        }
    }
}