using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable of values of aluminum in X position
            float[] aluminumX = { 25.66f,25.59f,32.25f,35.16f,37.9f,37.81f,41.68f,41.79f,43.49f,43.38f,46.33f,46.21f,52.72f,
                                    52.58f,57.52f,57.68f,59.95f,59.79f,61.35f,61.18f,61.48f,61.32f,66.57f,66.75f,68.46f,68.27f,
                                    70.66f,70.46f,74.55f,74.33f,76.89f,77.11f,77.49f,80.71f,80.47f,81.01f,80.77f,83.27f,83.53f,
                                    84.69f,84.43f,85.48f,85.22f,86.70f,86.43f,86.55f,86,82f,89.31f,89.03f,91.01f,90.72f,91.56f,
                                    91.27f,94.90f,95.21f,95.64f,95.32f,98.82f,98.49f};

            //Get the highest value of the aluminum array in X
            float maxValueAX = aluminumX.Max();
            //Get position of the highest value in Aluminum X
            int maxIndexAX = aluminumX.ToList().IndexOf(maxValueAX);

            //Variables of values of aluminum in Y position
            float[] aluminumY = {3.3f,6.6f,4.9f,9.9f,2.3f,4.5f,0f,0f,5f,10f,0.1f,0.1f,2.4f,4.8f,9.5f,4.7f,
                                    0.1f,0.2f,0.2f,0.3f,0.3f,0.7f,3.5f,1.8f,2.7f,5.5f,0.1f,0.1f,0.1f,0.1f,1.5f,
                                    0.8f,0.4f,0.8f,0f,0.1f,0.3f,0.6f,0.1f,0f,0.2f,0.5f,0,0f,0.2f,0.3f,0.2f,0.1f,
                                    0.3f,0.7f,0.1f,0.2f,0.4f,0.8f,0f,0f,0.8f,1.6f,0.1f,0.2f};

            //Get the highest value of the aluminum array in Y
            float maxValueAY = aluminumY.Max();
            //Get position of the highest value of aluminum in Y
            int maxIndexAY = aluminumY.ToList().IndexOf(maxValueAY);

            //Variable of values of calcium in X position
            float[] calciumX = {32.37f,32.28f,37.55f,37.45f,54.15f,54f,64.33f,64.51f,67.75f,67.56f,
                                    80.13f,79.89f,88.80f,89.08f,92.05f,91.75f,104.05f,103.69f,113.47f,
                                    113.03f,130.46f,131.08f,144.34f,143.47f,149.80f,148.76f};

            //Get the highest value of the calcium array in X
            float maxValueCX = calciumX.Max();
            //Get position of the highest value of calcium in X
            int maxIndexCX = calciumX.ToList().IndexOf(maxValueCX);

            //Variable of values of calcium in Y position
            float[] calciumY = {194.7f,389.3f,500f,1000f,269f,538f,135.9f,68f,73.8f,147.7f,29.4f,58.9f,
                                    50f,25f,77.3f,154.7f,61.2f,122.4f,24.9f,49.7f,62.7f,31.4f,54f,107.9f,112.2f,224.5f};

            //Get the highest value of the calcium array in Y 
            float maxValueCY = calciumY.Max();
            //Get position of the highest value of calcium in Y
            int maxIndexCY = calciumY.ToList().IndexOf(maxValueCY);

            //Variable of values that the "Robot" gets in X position
            float[] userAX = { 25.66f,25.59f,32.25f,35.16f,37.9f,37.81f,41.68f,41.79f,43.49f,43.38f,46.33f,46.21f,52.72f,
                                    52.58f,57.52f,57.68f,59.95f,59.79f,61.35f,61.18f,61.48f,61.32f,66.57f,66.75f,68.46f,68.27f,
                                    70.66f,70.46f,74.55f,74.33f,76.89f,77.11f,77.49f,80.71f,80.47f,81.01f,80.77f,83.27f,83.53f,
                                    84.69f,84.43f,85.48f,85.22f,86.70f,86.43f,86.55f,86,82f,89.31f,89.03f,91.01f,90.72f,91.56f,
                                    91.27f,94.90f,95.21f,95.64f,95.32f,98.82f,98.49f};

            //Get the highest value of the robot array in X 
            float maxValueuserAX = userAX.Max();
            //Get position of the highest value of robot in X
            int maxIndexuserAX = userAX.ToList().IndexOf(maxValueuserAX);

            //Variable of values that the "Robot" gets in Y position
            float[] userAY = {3.3f,6.6f,4.9f,9.9f,2.3f,4.5f,0f,0f,5f,10f,0.1f,0.1f,2.4f,4.8f,9.5f,4.7f,
                                    0.1f,0.2f,0.2f,0.3f,0.3f,0.7f,3.5f,1.8f,2.7f,5.5f,0.1f,0.1f,0.1f,0.1f,1.5f,
                                    0.8f,0.4f,0.8f,0f,0.1f,0.3f,0.6f,0.1f,0f,0.2f,0.5f,0,0f,0.2f,0.3f,0.2f,0.1f,
                                    0.3f,0.7f,0.1f,0.2f,0.4f,0.8f,0f,0f,0.8f,1.6f,0.1f,0.2f};

            //Get the highest value of the robot array in Y
            float maxValueuserAY = userAY.Max();
            //Get position of the highest value of robot in Y
            int maxIndexuserAY = userAY.ToList().IndexOf(maxValueuserAY);

            float[] userCX = {32.37f,32.28f,37.55f,37.45f,54.15f,54f,64.33f,64.51f,67.75f,67.56f,
                                    80.13f,79.89f,88.80f,89.08f,92.05f,91.75f,104.05f,103.69f,113.47f,
                                    113.03f,130.46f,131.08f,144.34f,143.47f,149.80f,148.76f};

            float maxValueuserCX = calciumX.Max();
            int maxIndexuserCX = calciumX.ToList().IndexOf(maxValueuserCX);

            float[] userCY = {194.7f,389.3f,500f,1000f,269f,538f,135.9f,68f,73.8f,147.7f,29.4f,58.9f,
                                    50f,25f,77.3f,154.7f,61.2f,122.4f,24.9f,49.7f,62.7f,31.4f,54f,107.9f,112.2f,224.5f};

            float maxValueuserCY = calciumY.Max();
            int maxIndexuserCY = calciumY.ToList().IndexOf(maxValueuserCY);

            //Variables for index position used to compare
            int positionAY = maxIndexAY;
            int positionCY = maxIndexCY;


            Console.Write("The max value of Aluminum in Y is: ");
            Console.WriteLine(maxValueAY);
            Console.Write("Position: ");
            Console.WriteLine(maxIndexAY);


            Console.Write("\nThe max value of Calcium in Y is: ");
            Console.WriteLine(maxValueCY);
            Console.Write("Position: ");
            Console.WriteLine(maxIndexCY);
       

            Console.Write("\nThe value of the position {0} in Aluminum X: ", positionAY);
            Console.WriteLine(aluminumX[positionAY]);
            Console.Write("\nThe value of the position {0} in Calcium X: ", positionCY);
            Console.WriteLine(calciumX[positionCY]);

            //Conditionales to see if the material is important or useless
            Console.WriteLine("\n\n\nCONDITIONAL IF ITS TRUE");
            if(maxValueAX == maxValueuserAX && maxValueAY == maxValueuserAY)
            {
                Console.WriteLine("The max value of Aluminum in X is equal to max value of robot in X.");
                Console.WriteLine("MATERIAL IS USELESS");
            }
            else
            {
                Console.WriteLine("\nThe max value of Aluminum in X is not equal to max value of robot in X.");
                Console.WriteLine("MATERIAL IS IMPORTANT");
            }


            Console.WriteLine("\n\nCONDITIONAL IF ITS NOT TRUE");
            if (maxValueAX == maxValueuserCX && maxValueAY == maxValueuserCY)
            {
                Console.WriteLine("The max value of Aluminum in X is equal to max value of robot in X.");
                Console.WriteLine("MATERIAL IS USELESS BECAUSE WE DONT WANT ALUMINUM");
            }
            else
            {
                Console.WriteLine("The max value of Aluminum in X is not equal to max value of robot in X.");
                Console.WriteLine("MATERIAL IS IMPORTANT BECAUSE WE WANT SOMETHING ELSE BESIDES ALUMINUM");
            }

            Console.Read();
        }
    }
}
