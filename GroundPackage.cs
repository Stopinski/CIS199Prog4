//Program 4
//CIS199-01
//Due 4/26/2015
//Purpose: This assignment explores the creation of a reusable class and separate GUI application that creates a list objects.
//By: Nathan Stopinski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class GroundPackage
    {
        //Fields
        private int _originzip;     //Origin Zip Code
        private int _destinationzip;//Destination Zip Code
        private double _length;     //package length
        private double _height;     //package height
        private double _width;      //package width
        private double _weight;     //package weight

        const double DEMENTION = .20;  //calculation for demention
        const double ZONEDIST = .50;   //calculation for zonedistance
        const int ZONEDISTCALC = 10000;   //variable to get zip codes down to calc first digit differences
                
        //Constructor
        //Precondition: No property is less than 0
        //Postcondition: No property is less than 0
        public GroundPackage()
        {
            //Start with default values
            OriginZip = 1;
            DestinationZip = 1;
            Length = 1;
            Weight = 1;
            Width = 1;
            Height = 1;
        }

        //Origin Zip Property
        //Precondition: Entered value must be > 0 and < 99999
        //Postcondition: The Origin Zip Code has been returned
        public int OriginZip
        {
            get { return _originzip; }
            set
            {
                if (_originzip > 0 && _originzip <= 99999)
                    _originzip = value;
                else
                    _originzip = 1;
            }
        }
        //Destination Zip Property
        //Precondition: Entered value must be > 0 and < 99999
        //Postcondition: The Destination Zip Code has been returned
        public int DestinationZip
        {
            get { return _destinationzip; }
            set
            {
                if (value > 0 && value <= 99999)
                    _destinationzip = value;
                else
                    _destinationzip = 0;
            }
        }
            //Package Length Property
        //Precondition: Cannot be a value < 0
        //Postcondition: The package's length has been returned
            public double Length
            {
                get {return _length;}
                set {
                    if (value > 0)
                        _length = value;
                    else
                        _length = 0;
                }
            }
        //Package Width Property
            //Precondition: Cannot be a value < 0
            //Postcondition: The package's width has been returned
            public double Width
            {
                get { return _width; }
                set
                {
                    if (value > 0)
                        _width = value;
                    else
                        _width = 0;
                }
            }
        //Package Height Property
            //Precondition: Cannot be a value < 0
            //Postcondition: The package's height has been returned
            public double Height
            {
                get { return _height; }
                set
                {
                    if (value > 0)
                        _height = value;
                    else
                        _height = 0;
                }
            }
        //Package Weight Property
            //Precondition: Cannot be a value < 0
            //Postcondition: The package's weight has been returned
            public double Weight
            {
                get { return _weight; }
                set
                {
                    if (value > 0)
                        _weight = value;
                    else
                        _weight = 0;
                }
            }
        //Zone Distance Property
            //Precondition: Valid Origin Zip and Destination Zip codes entered
            //Postcondition: Calc zone difference using first digit of each zip code. Largest zip code - smaller zip code.. ex. 52030 - 402014 = (5 - 4) = 1 ZoneDistance
            public int ZoneDistance
            {
                get
                {
                return Math.Abs((OriginZip / ZONEDISTCALC) - (DestinationZip / ZONEDISTCALC));
                }
            }
        //CalcCost Method to calculate cost of shipment
            //Precondition: Cannot be a value < 0
            //Postcondition: The package's weight has been returned
            public double CalcCost()
            {
                return DEMENTION * (Length + Width + Height) + ZONEDIST * (ZoneDistance + 1) * Weight;
                
            }
        //ToString Method to display properties
            //Precondition: All properties return valid value
            //Postcondition: creates string list of package details
            public override string ToString()
            {
                return "Destination ZipCode: " + DestinationZip.ToString() + System.Environment.NewLine +
                    "Origin Zipcode " + OriginZip.ToString() + System.Environment.NewLine +
                    "Length of Package " + Length.ToString() + System.Environment.NewLine +
                    "Width of Package " + Width.ToString() + System.Environment.NewLine +
                    "Height of Package " + Height.ToString() + System.Environment.NewLine +
                    "Weight of Package " + Weight.ToString();
            }
    }
}
