//Program 4
//CIS199-01
//Due 4/26/2015
//Purpose: This assignment explores the creation of a reusable class and separate GUI application that creates a list objects.
//By: Nathan Stopinski

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Prog4 : Form
    {
        //List to hold GroundPackage objects
        //Precondition: None
        //Postcondition: Creates list of package objects
        List<GroundPackage> packageList = new List<GroundPackage>();

        public Prog4()
        {
            InitializeComponent();
        }

        const int UOFL = 40292;  //UofL Zip Code

        //Precondition: None
        //Postcondition: Accepts package object as an argument. Assigning data
        //               entered by the user to the object's properties.
        private void GetPackageData(GroundPackage package)
        {
            //Get Package origin and destination zip codes
            package.OriginZip = int.Parse(originTextBox.Text);
            package.DestinationZip = int.Parse(destinationTextBox.Text);

            //Get Package demention details
            package.Length = double.Parse(lengthTextBox.Text);
            package.Width = double.Parse(widthTextBox.Text);
            package.Height = double.Parse(heightTextBox.Text);
            package.Weight = double.Parse(weightTextBox.Text);
        }

        //Precondition: all user entered values are valid
        //Postcondition: create package objects and add to list
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Create a Package Object
            GroundPackage newPackage = new GroundPackage();

            //Get the package data
            GetPackageData(newPackage);

            //Add the GroundPackage object to the list
            packageList.Add(newPackage);

            //Add an entry to the list box
            packageListBox.Items.Add(newPackage.CalcCost().ToString("C"));

            //Clear text box controls
            originTextBox.Clear();
            destinationTextBox.Clear();
            lengthTextBox.Clear();
            widthTextBox.Clear();
            heightTextBox.Clear();
            weightTextBox.Clear();

            //Reset focus
            originTextBox.Focus();
        }

        //Precondition: Objects must exist in listbox
        //Postcondition: Displays 6 properties of the package
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex;

            //Get index of the selected item
            if (packageListBox.SelectedIndex != -1)
            {
                //Display details
                MessageBox.Show(packageList[index].ToString());
            }
            else
                MessageBox.Show("Please select a package from the list!");
        }

        //Precondition: Object exists in list
        //Postcondition: Changes destination zip code to UofL zip code 40292
        private void toULBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex;
            packageList[index].DestinationZip = UOFL;
            packageListBox.Items[index] = packageList[index].CalcCost().ToString("C");
        }

        //Precondition: Object exists in list
        //Postcondition: Changes Origin zip code to UofL zip code 40292
        private void fromULBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex;
            packageList[index].OriginZip = UOFL;
            packageListBox.Items[index] = packageList[index].CalcCost().ToString("C");
        }
    }
}
