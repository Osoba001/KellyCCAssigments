using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class AssignmentModel
    {
    }
    public class AssignmentModel1
    {
        public AssignmentModel1(int id, string assignmentName,
            string location, AssignmentModel2 assignmentModel2)
        {
            Id = id;
            AssigmentName = assignmentName;
            AssignmentLocation=location;
            this.AssignmentModel2 = assignmentModel2;
        }
        public int Id { get; set; }
        public string AssigmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel2 AssignmentModel2 { get; set; }
    }
    public class AssignmentModel2
    {
        public AssignmentModel2(int id, string assignmentName,
           string location, AssignmentModel3 assignmentModel3)
        {
            Id = id;
            AssigmentName = assignmentName;
            AssignmentLocation = location;
            this.AssignmentModel3 = assignmentModel3;
        }
        public int Id { get; set; }
        public string AssigmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel3 AssignmentModel3 { get; set; }
    }
    public class AssignmentModel3
    {
        public AssignmentModel3(int id, string assignmentName,string location)
        {
            Id = id;
            AssigmentName = assignmentName;
            AssignmentLocation = location;
           
        }
        public int Id { get; set; }
        public string AssigmentName { get; set; }
        public string AssignmentLocation { get; set; }
    }
}
