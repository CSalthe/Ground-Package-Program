// X1084
// Program 4
// 4/24/2018
// CIS-199-02
// This program creates a class called GroundPackage which contains a constructor, 7 properties and 2 methods to validate and assign data to objects created for the GroundPackage class. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    
    public class GroundPackage
    {
        private int originZipCode; // Zip code from which packages are sent (origin)
        private int destZipCode; // Zip code of the destination of a given package (destination)
        private double length; // Length in inches of package 
        private double width; // Width in inches of package
        private double height; // Height in inches of package
        private double weight; // Weight in pounds of package
        private int zoneDistance; // Integer that represents the positive difference (absolute Value) between origin and destination zip codes 
        public const int DEF_ORIGIN = 40202; // Default origin zip code if non valid data is input for origin zip code
        public const int DEF_DEST = 90210; // Default destination zip code if non valid data is entered for destination zip code 
        public const double DEF_DIMENS = 1.0; // Default Length, Width, Height, Weight if non valid data is entered for Length, Width, Height, Weight 
        public const int ZONE_CONST = 10000; // The number divided by Origin and Destination zip code to convert zip codes into integers 
        public const int MIN_DIMENS = 0; // Length, Width, Height, Weight must be greater then this value to be set to property, Zip codes must be atleast this value to be set to property 
        public const int MAX_ZIP = 99999; // Maximum value of zip codes
        public const double COST_CONST1 = .20; // Number multiplied to length width and height of package to get cost of shipping 
        public const double COST_CONST2 = .5; // Number multiplied to zone distance and weight to get cost of shipping 


        // Precondition: MIN_DIMENS <= originZip <= MAX_ZIP
        //               MIN_DIMENS <= destZip   <= MAX_ZIP
        //               MIN_DIMENS < lenthI
        //               MIN_DIMENS < widthI
        //               MIN_DIMENS < heightI
        //               MIN_DIMENS < weightI
        // Postcondition: The GroundPackage properties have been initialized with the arguments sent for originZip, destZip, lengthI, widthI, heightI, weightI
        public GroundPackage(int originZip, int destZip, double lengthI, double widthI, double heightI, double weightI)
        {
            OriginZipCode = originZip; // Set the OriginZipCode Property
            DestZipCode = destZip; // Set the DestZipCode property
            Length = lengthI; // Set the Length property
            Width = widthI; // Set the Width property
            Height = heightI; // Set the Height property
            Weight = weightI; // Set the Weight property
            

        }

        public int OriginZipCode
        {
            //Precondition: None
            //postcondition: originZIpCode has been returned
            get { return originZipCode; }
            //Precondition: MIN_DIMENS <= value <= MAX_ZIP 
            //postcondition: the originZipCode has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value >= MIN_DIMENS && value <= MAX_ZIP)
                {
                    originZipCode = value;
                }
                else // When invalid, set to DEF_ORIGIN 
                {
                    originZipCode = DEF_ORIGIN; 
                }

                    
            }
        }
        public int DestZipCode
        {
            //Precondition: None
            //postcondition: destinationZipCode has been returned
            get { return destZipCode; }
            //Precondition: MIN_DIMENS <= value <= MAX_ZIP 
            //postcondition: the destinationZipCode has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value >= MIN_DIMENS && value <= MAX_ZIP)
                { destZipCode = value; }
                else // When invalid, set to DEF_DEST 
                    destZipCode = DEF_DEST;
            }
        } 
        public double Length
        {
            //Precondition: None
            //postcondition: length has been returned
            get { return length; }
            //Precondition: MIN_DIMENS < value 
            //postcondition: the length has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value > MIN_DIMENS)
                {
                    length = value;
                }
                else // When invalid, set to DEF_DIMENS
                    length = DEF_DIMENS;
                   
            }

        }
        public double Width
        {
            //Precondition: None
            //postcondition: width has been returned
            get { return width; }
            //Precondition: MIN_DIMENS < value 
            //postcondition: the width has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value > MIN_DIMENS)
                {
                    width = value;
                }
                else // When invalid, set to DEF_DIMENS 
                    width = DEF_DIMENS;
                    
            }

        }
        public double Height
        {
            //Precondition: None
            //postcondition: height has been returned
            get { return height; }
            //Precondition: MIN_DIMENS < value 
            //postcondition: the height has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value > MIN_DIMENS)
                { height = value; }
                else // When invalid, set to DEF_DIMENS
                    height = DEF_DIMENS;
            }

        }
        public double Weight
        {
            //Precondition: None
            //postcondition: weight has been returned
            get { return weight; }
            //Precondition: MIN_DIMENS < value 
            //postcondition: the weight has been set to the specified value, or to the Default value if the value sent does not meet the precondition
            set
            {
                if (value > MIN_DIMENS)
                {
                    weight = value;
                }
                else // When invalid, set to DEF_DIMENS
                    weight = DEF_DIMENS;

            }
        }
        public int ZoneDistance // READ ONLY PROPERTY 
        {
            //Precondition: none 
            //postcondition: zoneDistance is calculated, then zoneDistance is returned
            get
            {
                zoneDistance = Math.Abs((OriginZipCode / ZONE_CONST) - (DestZipCode / ZONE_CONST));


                return zoneDistance; }
        }
        // Precondition: None
        // Postcondition: A double is returned presenting the cost to ship a given GroundPackage 
        public double CalcCost()
        {
            double cost = COST_CONST1 * (Length + Width + Height) +  COST_CONST2 * (ZoneDistance + 1) * (Weight); // Calculates cost to ship a given GroundPackage
            return cost;
        }
        // Precondition: None
        // Postcondition: A string is returned presenting properties of the GroundPackage class (OriginZipCode, destZipCode, Length, Width, Height, Weight)
        public override string ToString() // overriding ToString method from class object 
        {
            return ($"Origin Zip Code: {OriginZipCode} {Environment.NewLine} Destination Zip Code: {DestZipCode} {Environment.NewLine} Length: {Length} {Environment.NewLine} Width: {Width} {Environment.NewLine} Height: {Height} {Environment.NewLine} Weight: {Weight}");
            
        }
        
    }
}
