using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 2
            //EITHER:
            //Read in the text file if you want (or are able) [HINT: read into a list of strings]
            //Split the first four numbers
            List<string> streets = new List<string>();



            //OR:
            //Manual (check each street code individually without reading them in automatically)
            //long, tedious, etc, etc
            //7778[8] is a correct street code
            //Second two variables here are to use when calculating the checksum
            int streetCode = 7778;
            int checkSum = 8;
            int total = 1;
            int total2 = 0;
          

            //Multiply all the numbers together in the 4 digit code (7*7*7*8)
            //Can do it by using the mod '%' operator and the divide '/' operator
            //Reduce streetCode by 1 digit each time through the loop
            while(streetCode > 0)
            {
                

            }


            //Add the digits of the multiplication total together
            //infinite loop until the total gets to one digit - the checksum
            //Use 'break;' to break out of the loop
            while (true)
            {
                //Do the same as above, adding not multiplying
                while (total > 0)
                {
                    

                }

                //Check if total2 is 2 digits or more
                //If not, break out of the loop
                if (total2 > 9) 
                { 
                    
                }
                else { break; }
            }
  
            //Check if the final checksum is the same as the checksum in the street code.
            

        }
    }
}
