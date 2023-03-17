using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellApp
{
    public class CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Kayıt İşlemi başarı ile gerçekleştirildi. :" + customer.FirstName+" "+customer.LastName);
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+"Kullanıcı silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "Kullanıcı bilgileri güncellendi.");
        }
    }
}
