using System.Collections.Generic;

namespace EFTutorial
{
    public class Standard
    {


        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string StudentName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}