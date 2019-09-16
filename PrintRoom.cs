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
				int startX = rand.Next(0, length - 2);

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
      
          //  PrintRow(length, startX);
        }
        static void PrintRow(int length, int startX, int oldX, int oldLength)
        {
            if (startX < oldX){
        		PrintFiller(startX, ' ');   
                Console.Write('G');
				
				// First part of the Row
				int firstDiff = oldX - startX -1; 
				PrintFiller(firstDiff, '-');				
               	Console.Write('+');

				// Second part of the row. After the second room wall
				int secondDiff = length - firstDiff - 1;
				if (oldLength < length){
					PrintFiller(oldLength, '-');
				}else{
					PrintFiller(secondDiff, '-');
				}
				Console.Write("+");

            }else{
                for (int y = 0; y < startX; y++ ){
                    Console.Write(oldX);
                }   
                    Console.Write('+');

				PrintFiller(length, '-');
                Console.Write('+');
            }
        }
		static bool isPreviousRoomBigger(int startX, int length, int oldX, int oldLength)
		{
			int currentRoom = startX + length;
			int previousRoom = oldX + oldLength;

			if (currentRoom < previousRoom){
				return true;
			}else{
				return false;
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