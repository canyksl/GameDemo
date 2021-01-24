using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserManager
    {
        public UserManager(IVerification verification)
        {
            verification.Edevlet();
        }
        public void Register(User user)
        {
            Console.WriteLine(user.UserName+" Kayıt İşlemi Başarılı");
            
        }

        public void Update()
        {
            Console.WriteLine("Güncelleme İşlemi Başarılı");
        }

        public void Delete()
        {
            Console.WriteLine("Silme İşlemi Başarılı");
        }
    }
}
