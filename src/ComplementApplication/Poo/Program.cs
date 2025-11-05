using Poo;

Console.WriteLine("Hello, World!");

// var person = new Person();
// person.FirstName = "John";
// person.LastName = "Doe";
// person.NationalNumber = "123456789";
// person.PrintMyself();
// Console.WriteLine(person.GetDescription());

var student = new Student
{
    NationalNumber = "987654321"
};
Console.WriteLine(student.GetDescription());;

var teacher = new Teacher
{
    Matricule = "123456789",
    FirstName = "Zack",
    LastName = "Doen",
    NationalNumber = "abcdef"
};
Console.WriteLine(teacher.GetDescription());;
// teacher.NationalNumber = "85040729584";
// teacher.Age = DateTime.Now.Year - (1900 + int.Parse(teacher.NationalNumber.Substring(0, 2)));

// var yearAsString = teacher.NationalNumber.Substring(0, 2);
// Console.WriteLine(yearAsString);
// // print 85
// teacher.Age = DateTime.Now.Year - (1900 + int.Parse(yearAsString));
// // var test2 = (int)yearAsString;

student.FirstName = "Jane";
student.LastName = "Doe";
Console.WriteLine(student.GetDescription());;