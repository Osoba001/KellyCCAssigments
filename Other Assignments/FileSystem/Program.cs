// See https://aka.ms/new-console-template for more information


//string path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
using FileSystem;
// Created Directory
string path = Path.Combine(Directory.GetCurrentDirectory(), "AssigmentFolder");
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}
// Create csv File
if (!File.Exists(path))
{
  var file= File.Create(Path.Combine(path, "Assignment.csv"));
    file.Close();
}
// Create Objects
var Assgment3= new AssignmentModel3(3,"file system assignment 3 ",path);
var Assgment2 = new AssignmentModel2(2, "file system assignment 2 ", path,Assgment3);
var Assgment1 = new AssignmentModel1(1, "file system assignment 1", path, Assgment2);

var assignments = new List<AssignmentModel1>();
assignments.Add(Assgment1);
//Convert Object to List string 
List<string> lines = new List<string>();
foreach (var a in assignments)
{
    lines.Add($"{a.Id}, {a.AssigmentName},{a.AssignmentLocation} \n \t {a.AssignmentModel2.Id} {a.AssignmentModel2.AssigmentName} , {a.AssignmentModel2.AssignmentLocation} \n \t \t {a.AssignmentModel2.AssignmentModel3.Id} , {a.AssignmentModel2.AssignmentModel3.AssigmentName}, {a.AssignmentModel2.AssignmentModel3.AssignmentLocation}");
}
// Write to CSV fille
File.AppendAllLines(Path.Combine(path, "Assignment.csv"), lines);

//Read from csv file
var Asignment = File.ReadAllLines(Path.Combine(path, "Assignment.csv")).ToList();

//convert bact to assigment object
List<AssignmentModel1> readAssigments = new List<AssignmentModel1>();
var readline = new string[3];
AssignmentModel1 readAssigment1;
AssignmentModel2 readAssigment2;
AssignmentModel3 readAssigment3;
for (int i = 0; i < Asignment.Count; i=i+3)
{
    readline = Asignment[i+2].Split(",");
    readAssigment3 = new AssignmentModel3(int.Parse(readline[0]), readline[1], readline[2]);
    readline = Asignment[i + 1].Split(",");
    readAssigment2 = new AssignmentModel2(int.Parse(readline[0]), readline[1], readline[2],readAssigment3);
    readline = Asignment[i].Split(",");
    readAssigment1 = new AssignmentModel1(int.Parse(readline[0]), readline[1], readline[2], readAssigment2);
    readAssigments.Add(readAssigment1);
}
foreach (var a in readAssigments)
{
    Console.WriteLine($"{a.Id}, {a.AssigmentName},{a.AssignmentLocation} \n \t {a.AssignmentModel2.Id} {a.AssignmentModel2.AssigmentName} , {a.AssignmentModel2.AssignmentLocation} \n \t \t {a.AssignmentModel2.AssignmentModel3.Id} , {a.AssignmentModel2.AssignmentModel3.AssigmentName}, {a.AssignmentModel2.AssignmentModel3.AssignmentLocation}");
}
Console.ReadLine();
