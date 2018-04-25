// X1084
// Program 4
// 4/24/2018
// CIS-199-02
// This program instantiates 5 objects of the GroundPackage class and attempts to assign values to the various properties of the GroundPackage class, then displays the properteis of the GroundPackage class using the methods writen in the Groundpackage class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        // Precondition: None
        // Postcondition: 5 GroundPackage objefts are created and stored in an array of objets, then the DisplayPakages method is called 
        static void Main(string[] args)
        {
            GroundPackage package1 = new GroundPackage(40023, 18293, 2.56, 4.3, 6, 11.6); // Creates GroundPackage object w/ arguments to be sent to constructor 
            GroundPackage package2 = new GroundPackage(73824, 84201, 6.0, 7, 4, 19.2); // Creates GroundPackage object w/ arguments to be sent to constructor 
            GroundPackage package3 = new GroundPackage(39210, 49201, 6.0, 8, 2, 13.2); // Creates GroundPackage object w/ arguments to be sent to constructor 
            GroundPackage package4 = new GroundPackage(98321, 25392, 4.0, 9, 3, 15.1); // Creates GroundPackage object w/ arguments to be sent to constructor 
            GroundPackage package5 = new GroundPackage(38201, 49302, 3.0, 5, 5, 11.4); // Creates GroundPackage object w/ arguments to be sent to constructor 

            GroundPackage[] packages = new GroundPackage[] { package1, package2, package3, package4, package5 }; // Array of GroundPackage objects 

            
            // Calls DisplayPackages method with packages array of GroundPackage objets as argument 
            DisplayPackages(packages);

        }
        // Precondition: Method call must contain argument that is array of GroundPackage objects
        // Postcondition: The Properties and the shipping cost of each GroundPackage object in the array of Groundpackage Objets are displayed 
        public static void DisplayPackages(GroundPackage [] packages)
        {
            // steps through each element of GroundPackage object array 
            for(int i = 0; i < packages.Length; ++i)
            {
                WriteLine($"{packages[i].ToString()}"); // Prints the overriden ToString method from GroundPackage class for each element of the packages array 
                WriteLine($" Cost: {packages[i].CalcCost():C2}"); // Prints the CalcCost method from GroundPackage class for each element of the packages array 




            }
        }
    }
}