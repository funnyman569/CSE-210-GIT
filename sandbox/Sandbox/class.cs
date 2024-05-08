using System.ComponentModel.DataAnnotations;

class Course


{
    public string _courseCode;
    public string _courseName;
    public int _creditHours;
    public string _color;
    
   public void Display()
   {
    Course course1 = new();
    course1._courseCode = "CSE 210";
    course1._courseName = "Programmin with Classes";
    course1._creditHours = 2;
    course1._color = "green";
    Console.WriteLine("${_courseCode}, {_courseName}. {_creditHours}, {_color}");
   }
 

}