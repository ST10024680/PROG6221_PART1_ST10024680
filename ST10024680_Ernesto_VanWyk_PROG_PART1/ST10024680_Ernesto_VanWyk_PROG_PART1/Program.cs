using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10024680_Ernesto_VanWyk_PROG_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //external class 
            var objDetials = new IngredientsAndSteps();

            //console name/title
            Console.Title = "VanWyk Recipe App";
            

            getIngredient(objDetials);
            getIngredMeasurements(objDetials);
            getSteps(objDetials);
            getStepDescription(objDetials);

            displayList(objDetials);
            userOptions(objDetials);

        }
        static void getIngredient(IngredientsAndSteps objDetials)
        {
            //Get the number of ingredients from the user
            Console.WriteLine("Enter the number of Ingredients: ");
            objDetials.NumOfIngre = Convert.ToInt32(Console.ReadLine());
        }
        static void getSteps(IngredientsAndSteps objDetials)
        {
            //Get the number of steps from the user
            Console.WriteLine("Enter the number of Steps: ");
            objDetials.NumOfSteps = Convert.ToInt32(Console.ReadLine());
        }
        //method to collect ingredient Description
        static void getIngredMeasurements(IngredientsAndSteps objDetials)
        {
            //initialse Arrays
            objDetials.IngreName = new string[objDetials.NumOfIngre];
            objDetials.IngreQyt = new double[objDetials.NumOfIngre];
            objDetials.IngreMeasurement = new string[objDetials.NumOfIngre];

            for (int i = 0; i < objDetials.NumOfIngre; i++)
            {
                Console.WriteLine("Enter Name of ingredient " + (i + 1) + ": ");
                objDetials.IngreName[i] = Console.ReadLine();

                Console.WriteLine("Enter Quantity of ingredient " + (i + 1) + ": ");
                objDetials.IngreQyt[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter unit of measurement of ingredient " + (i + 1) + ": ");
                objDetials.IngreMeasurement[i] = Console.ReadLine();

            }

        }
        //method to collect step Description
        static void getStepDescription(IngredientsAndSteps objDetials)
        {
            //initialse Arrays
            objDetials.StepDesc = new string[objDetials.NumOfSteps];

            for (int j = 0; j < objDetials.NumOfSteps; j++)
            {
                Console.WriteLine("For each step, give a description on what to do " + "\n Step " + (j + 1) + ": ");
                objDetials.StepDesc[j] = Console.ReadLine();

            }

            objDetials.OriginalValue = new double[objDetials.IngreQyt.Length];//create new array to hold original values
            Array.Copy(objDetials.IngreQyt, objDetials.OriginalValue, objDetials.IngreQyt.Length);//copy original values in new array
        }
        //method to display list
        static void displayList(IngredientsAndSteps objDetials)
        {

            Console.WriteLine("========Ingredients========");
            for (int k = 0; k < objDetials.NumOfIngre; k++)
            {
                Console.WriteLine(objDetials.IngreName[k] + ", " + objDetials.IngreQyt[k] + " " + objDetials.IngreMeasurement[k]);

            }


            Console.WriteLine("========Setps==============");
            for (int m = 0; m < objDetials.NumOfSteps; m++)
            {
                Console.WriteLine((m + 1) + ". " + objDetials.StepDesc[m]);

            }
            Console.WriteLine("***************************");

        }
        //method for user to alter data
        static void userOptions(IngredientsAndSteps objDetials)
        {
            Console.WriteLine("Scale recipe Quantities by: \n" +
                "1. half \n" +
                "2. double \n" +
                "3. Triple \n" +
                "User can also: \n" +
                "4. Rest Quantities to original values \n" +
                "5. Clear All Data \n" +
                "6.Exit \n" +
                "----------------------------------------------------------------------------------");

            //making decision
            int userOpt = Convert.ToInt32(Console.ReadLine());
            switch (userOpt)
            {
                case 1:
                    //scale quantitie by 0.5(half)
                    objDetials.scaleValues(0.5);
                    displayList(objDetials);
                    userOptions(objDetials);
                    break;
                case 2:
                    //scale quantitie by 2(double)
                    objDetials.scaleValues(2);
                    displayList(objDetials);
                    userOptions(objDetials);
                    break;
                case 3:
                    //scale quantitie by 3(triple)
                    objDetials.scaleValues(3);
                    displayList(objDetials);
                    userOptions(objDetials);
                    break;
                case 4:
                    //method to rest quantities to original values
                    objDetials.resetQuantities();
                    displayList(objDetials);
                    userOptions(objDetials);
                    break;
                case 5:
                    //method to clear all array elements
                    Console.WriteLine("Are you sure? Y to confirm, N to cencel");
                    string confirm = Console.ReadLine();
                    switch (confirm.ToUpper())
                    {
                        case "Y":
                            Console.WriteLine(objDetials.clearArrayElements());
                            userOptions(objDetials);
                            break;
                        default:
                            Console.WriteLine("Cenceled");
                            userOptions(objDetials);
                            break;
                    }
                    Console.WriteLine("*****************************************");
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
