using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsImplementation.ProtoType
{
    public class Student : ICloneable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Section StudentSection { get; set; }
        public Address StudentAddress { get; set; }
        public Object Clone()
        {
            return (Student)this.MemberwiseClone();
        }

        public object ShalloCopy()
        {
            return (Student)this.Clone();
        }

        public object DeepCopy()
        {
            var student = (Student)this.Clone();
            student.StudentSection = (Section)student.StudentSection.Clone();
            student.StudentAddress = (Address)StudentAddress.Clone();
            student.StudentAddress.ContactDetail = (ContactDetail)StudentAddress.ContactDetail.Clone();

            return student;
        }

        public override string ToString()
        {
            Console.WriteLine($"Name = {Name} , Section = {StudentSection.Name} , State = {StudentAddress.State} , Mobile = {StudentAddress.ContactDetail.Mobile}");
            return base.ToString();
        }
    }
}
