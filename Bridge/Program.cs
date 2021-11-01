using System;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            MySuperSmartTV myTV = new MySuperSmartTV();
            Console.WriteLine("Select a source to get TV Guide and Play");
            Console.WriteLine("1. Local Cable TV\n2. Local Dish TV\n3. IP TV");
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    myTV.VideoSource = new LocalCableTv();
                    break;
                case '2':
                    myTV.VideoSource = new LocalDishTv();
                    break;
                case '3':
                    myTV.VideoSource = new IPTvService();
                    break;
            }

            myTV.ShowTvGuide();
            myTV.PlayTV();

            Console.ReadKey();
        }
    }
}
