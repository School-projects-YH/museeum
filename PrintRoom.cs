using System;


namespace museumet_1976
{
    public class PrintRoom
	{
        public static void PrintMuseum(int numbeOfRooms)
        {
            Console.Clear();
            Random rand = new Random();
            int oldX = 0;
			int oldLength = 0;

            for (int i = 0; i <= numbeOfRooms; i++){
                int length = rand.Next(5, 12);
                int height = rand.Next(2, 5);
				int startX = rand.Next(1, length - 2);

                PrintOneRoom(length, height, oldX, startX, oldLength);
				oldX = startX;

				oldLength = length;              
            }
            Console.ReadKey();
        }
        static void PrintOneRoom(int length, int height, int oldX, int startX, int oldLength)
        {  
            
            PrintRow(length, startX, oldX, oldLength);
            PrintContent(length, height, startX);
      
        }
        static void PrintRow(int length, int startX, int oldX, int oldLength)
        {
            if (startX < oldX){
        		PrintFiller(startX, ' ');   
                Console.Write('+');
				
/* ------------------------------- First Part ------------------------------- */

				int firstDiff = oldX - startX -1; 
				PrintFiller(firstDiff, '-');				
               	Console.Write('+');

/* ------------------------------- Second Part ------------------------------ */

				int secondDiff = length - firstDiff - 1;

				PrintFiller(secondDiff, '-');
				Console.Write('+');

				int thirdDiff = ((oldX + oldLength) - (startX + length)-1); 
				if (thirdDiff != -1){
					PrintFiller(thirdDiff, '-');
					Console.Write('T');
				}else{}

/* ------------------------------- First Room ------------------------------- */

			}else if (oldX == 0){
				PrintFiller(startX, ' ');
                Console.Write('+');					

				PrintFiller(length, '-');
                Console.Write('+');
				
			}else if (oldX < startX){
				PrintFiller(oldX, ' ');
                Console.Write('+');					

/* ------------------------------- First Part ------------------------------- */

				int firstDiff = startX - oldX - 1;
				
				PrintFiller(firstDiff, '-');				
               	Console.Write('+');

/* ------------------------------- Second Part ------------------------------ */

				int secondDiff = oldLength - firstDiff - 1;

				PrintFiller(secondDiff, '-');
				Console.Write('+');

				int thirdDiff = ((startX + length) - (oldX + oldLength)-1); 
				if (thirdDiff != -1){
					PrintFiller(thirdDiff, '-');
					Console.Write('G');
				}else{}

/* -------------------------------- Row Done -------------------------------- */
			
			}else{
				Console.WriteLine("Detta var oväntat!");
			}
		}
		static void PrintFiller(int amountOfTimes, char filler)
		{
  			for (int i = 0; i < amountOfTimes; i++){
            	Console.Write(filler);
            }
		}
        static void PrintContent(int length, int height, int startX)
        {
            for (int i = 0; i <= height; i++){
                Console.Write('\n');
                for (int y = 0; y < startX; y++ ){
                    Console.Write(' ');
                }        
                    Console.Write('|');

                for (int u = 0; u < length; u++){
                    Console.Write(' ');
                }
                Console.Write('|');
            }
            Console.Write('\n');
        }
    }


}