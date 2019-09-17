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

            for (int i = 1; i <= numbeOfRooms; i++){
                int length = rand.Next(5, 12);
                int height = rand.Next(2, 5);
				int startX = rand.Next(1, length - 2);

                PrintOneRoom(length, height, oldX, startX, oldLength);
				oldX = startX;
                
                if (numbeOfRooms == i){
                    PrintFiller(startX, ' ');
                    PrintFiller(length, '-');
                }

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
            if (oldX == 0){ // Första rummet
				PrintFiller(startX, ' ');

				PrintFiller(length, '-');
			
            }else if (startX < oldX){
				
        		PrintFiller(startX, ' ');   

				int firstDiff = oldX - startX -1; 
				int secondDiff = length - firstDiff - 1; // Fix if firstdiff == 0
				int thirdDiff = ((oldX + oldLength) - (startX + length)-1); 

				PrintFiller(firstDiff, '-');
                PrintFiller(secondDiff, '-');

                if (thirdDiff >= 0){
					PrintFiller(thirdDiff, '-');
				}


			}else if (oldX < startX){
				PrintFiller(oldX, ' ');

				int firstDiff = startX - oldX - 1;
				int secondDiff = oldLength - firstDiff - 1; // Fix if firstdiff == 0
				int thirdDiff = ((startX + length) - (oldX + oldLength)-1); 
				
				PrintFiller(firstDiff, '-');
				PrintFiller(secondDiff, '-');

				if (thirdDiff >= 0){
					PrintFiller(thirdDiff, '-');
				}

			}else if(oldX == startX){
            
                PrintFiller(startX, ' ');

                if (length < oldLength){
                    PrintFiller(length, '-');
                    int secondDiff = oldLength-length-1;

                    if (secondDiff >= 0){

                    PrintFiller(secondDiff, '-');
                    }
                }else{
                    PrintFiller(oldLength, '-');
                    int secondDiff = length-oldLength-1;
                    if (secondDiff >= 0){

                    PrintFiller(secondDiff, '-');
                    }
                }


            
            }else{ 
				Console.WriteLine("Detta var oväntat!");
			}
		}
		static void PrintFiller(int amountOfTimes, char filler)
		{
  			for (int i = 0; i < amountOfTimes; i++){
            	Console.Write(filler);
            }
            Console.Write('+');
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