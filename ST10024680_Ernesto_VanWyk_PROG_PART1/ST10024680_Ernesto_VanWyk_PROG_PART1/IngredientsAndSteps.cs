using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10024680_Ernesto_VanWyk_PROG_PART1
{
    internal class IngredientsAndSteps
    {
        //global variables
        private static int numOfIngre;
        private static int numOfSteps;
        private string[] ingreName;
        private double[] ingreQyt;
        private string[] ingreMeasurement;
        private string[] stepDesc;
        private double[] originalValues;

        public double[] OriginalValue
        {
            get { return originalValues; }
            set { originalValues = value; }
        }
        //properties for number of ingredients
        public int NumOfIngre
        {
            get { return numOfIngre; }
            set { numOfIngre = value; }
        }
        //properties for number of steps
        public int NumOfSteps
        {
            get { return numOfSteps; }
            set { numOfSteps = value; }
        }

        //properties for ingredients name
        public string[] IngreName
        {
            get { return ingreName; }
            set { ingreName = value; }
        }
        //properties for ingredients quantity
        public double[] IngreQyt
        {
            get { return ingreQyt; }
            set { ingreQyt = value; }
        }
        //properties for ingerdients measurements
        public string[] IngreMeasurement
        {
            get { return ingreMeasurement; }
            set { ingreMeasurement = value; }
        }
        //properties for step description
        public string[] StepDesc
        {
            get { return stepDesc; }
            set { stepDesc = value; }
        }
        
        //method to clear array elements
        public string clearArrayElements()
        {
            Array.Clear(ingreName, 0, ingreName.Length);
            Array.Clear(ingreQyt, 0, ingreQyt.Length);
            Array.Clear(ingreMeasurement, 0, ingreMeasurement.Length);
            Array.Clear(stepDesc, 0, stepDesc.Length);

            string mess = "Data cleared";
            return mess;
        }
        //method to calculate and scale values 
        public void scaleValues(double multiplayer)
        {

            for (int i = 0; i < ingreQyt.Length; i++)
            {
                ingreQyt[i] *= multiplayer;
            }
        }
        public void resetQuantities()
        {
            Array.Copy(originalValues, ingreQyt, ingreQyt.Length);//copy new array back to original array
        }

    }
}
