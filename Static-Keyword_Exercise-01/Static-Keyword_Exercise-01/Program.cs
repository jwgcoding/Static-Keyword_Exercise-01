using Static_Keyword_Exercise_01;
using System.Security.Cryptography.X509Certificates;





// TODO: Create 3 "regular" classes called RegularClass1, RegularClass2, and RegularClass3
// TODO: Inside of the regular classes, create a public field called _regularClassTotal of type int
// TODO: Inside of the constructor of each of the RegularClasses increment the static _regularClassesTotal field


// Use these below
var randomNumber1 = new Random().Next(0, 1001);
var randomNumber2 = new Random().Next(0, 1001);
var randomNumber3 = new Random().Next(0, 1001);

// TODO: Instantiate 1 instance of each of the regular classes
var regularClass1 = new RegularClass1();
var regularClass2 = new RegularClass2();
var regularClass3 = new RegularClass3();

// TODO: Set each instance's _regularClassTotal field to the corresponding variables above

regularClass1._regularClassTotal = randomNumber1;
regularClass2._regularClassTotal = randomNumber2;
regularClass3._regularClassTotal = randomNumber3;
// TODO: Print the static _regularClassesTotal field and the instance's _regularClassTotal fields to the console

Console.WriteLine("Static classes");
Console.WriteLine(StaticClass._regularClassesTotal);

AddSpaces(3);

Console.WriteLine("Instance classes");
Console.WriteLine(regularClass1._regularClassTotal);
Console.WriteLine(regularClass2._regularClassTotal);
Console.WriteLine(regularClass3._regularClassTotal);


void AddSpaces(int numberOfSpaces)
{
    while (numberOfSpaces > 0)
    {
        Console.WriteLine();
        numberOfSpaces--;
    }
}