using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class GeneralManager
    {
        public void GeneralManagerAccess(int a)
        {
            switch (a)
            {
                case 1:
                    EditProfile();
                    break;
                case 2:
                    Console.WriteLine("Choose product : \n 1.CPU        2.RAM       3.Motherboard       4.GraphicsCard");
                    a = int.Parse(Console.ReadLine());
                    Product product = new Product();
                    product.ShowProduct(a);
                    break;
                case 3:
                    ManageAdmin();
                    break;
                case 4:
                    EditProduct();
                    break;
                default:
                    Console.WriteLine("wrong input !!!");
                    a = int.Parse(Console.ReadLine());
                    GeneralManagerAccess(a);
                    break;
            }
        }

        public void EditProduct()
        {
            Product product = new Product();
            product.EditProduct();
        }

        public void ManageAdmin()
        {
            throw new NotImplementedException();
        }

        public void EditProfile()
        {
            throw new NotImplementedException();
        }
    }
}
