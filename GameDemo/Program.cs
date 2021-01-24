using System;
using GameSimulation;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.UserName = "canyksl";
            user1.Email = "deneme@deneme.com";
            user1.Id = 1;
            user1.Password = "12345";
            user1.TcNo = "1234567890";
            user1.Name = "Can";
            user1.LastName = "Yüksel";
            IVerification verification = new Verification();
            UserManager userManager = new UserManager(verification);
            userManager.Register(user1);
            GameList<string> gameList = new GameList<string>();
            gameList.Add("Cod4");
            gameList.Add("Gta5");
            gameList.Add("PUBG");
            Discount discount = new Discount();
            discount.Id = 1;
            discount.DiscountName = "NewUser";
            discount.DiscountPrice = 45;

            Sales sale = new Sales();
            sale.Sale(user1,discount,gameList);

        }
    }
}
