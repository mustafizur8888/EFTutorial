using System;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolContext schoolContext = new SchoolContext();
            Student firstOrDefault = schoolContext.Students.FirstOrDefault(s => s.StudentId == 3);

        }
    }
}
