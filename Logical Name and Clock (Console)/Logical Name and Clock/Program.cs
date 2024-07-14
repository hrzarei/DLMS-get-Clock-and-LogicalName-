using System;
using System.Xml.Linq;
using LOGIC_NAME;
using CLOCK ;
using System.Runtime.InteropServices;


Logic_Name LN = new Logic_Name();
Clock clk = new Clock();

Console.WriteLine("Choose an option:");
Console.WriteLine("1. Logical Name");
Console.WriteLine("2. Clock");

string input = Console.ReadLine();

if (input == "1")
{
    // execute instruction 1
    Console.WriteLine("\n Reading logical name Instructions executing.\n");

    Logic_Name.logic_name();

    Console.WriteLine(" \n Reading logical name Instructions end . ");



}
else if (input == "2")
{
    // execute instruction 2
    Console.WriteLine("\n Reading clock Instructions executing. \n");

    Clock.clock();

    Console.WriteLine("\n Reading clock Instructions executing. ");


}
else
{
    Console.WriteLine("Invalid input.");
}

// Wait for user to press a key before closing console window
Console.ReadKey();
