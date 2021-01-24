using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation;

namespace GameDemo
{
    class Sales
    {
        public void Sale(User user, Discount discount,GameList<string> gameList)
        {
            Console.WriteLine(
                user.UserName+" İsimli Oyuncu "+ discount.DiscountPrice+ " tutarında indirim ile "+ gameList.Length+ " adet Oyun satın aldı");
            Console.WriteLine("********************");
            Console.WriteLine("Satın alınan Oyunlar: ");
            for (int i = 0; i < gameList.Length; i++)
            {
                Console.WriteLine(gameList.Game[i]);
            }
        }
    }
}
