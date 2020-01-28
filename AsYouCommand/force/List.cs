namespace AsYouCommand
{
    class ListMaker
    {
        int[] Command()
            {
                int[] list = new int[2];
                Console.WriteLine("How long do you want your list to be?");

                string LengthNumberList = Console.ReadLine();

                int Nr_1 = Int32.Parse(LengthNumberList);
                list[0] = Nr_1;
                Console.WriteLine("Is there a limit to how big the numbers are allowed to be?");

                string maxNum = Console.ReadLine();

                int Nr_2 =  Int32.Parse(maxNum);

                list[1] = Nr_2;

                return list;
            
            }
    }
    
}



            

            

        
            
        
    