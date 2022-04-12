using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Class :
             * Classes are our prototypes that we use to create objects. It could be thought of as a blueprint 
             * of a product that determines it's basic structure and properties.
             * We use classes to create an instance of the object that the class describes
             * if mobile phone blueprint = class,
             *    mobile phone instance = mobilePhone1, we use this instance in our project to get or set 
             *    it's specified properties, and use it's methods to take certain actions.
             */

            MobilePhone phone1 = new MobilePhone(); // using constructor method 1 (default)

            /*
             * Here phone1 is the object created with the MobilePhone class.
             * Whenever we create an instance of an object we use the Constructor Method which is in this case 
             * 'MobilePhone()'. 
             */

            MobilePhone phone2 = new MobilePhone("Toshiba"); 
            // using constructor method 2
            //phone2 has its DateTime set by default from blueprint (class-body) and has it's BrandName
            //property set to "Toshiba" (from constructor method)

            MobilePhone phone3 = new MobilePhone("Toshiba", "Stainless Steel", ConsoleColor.Red); 
            // using constructor method 3

        }

    }
}

