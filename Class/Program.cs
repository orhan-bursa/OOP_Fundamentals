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
            // CLASS:
            /*
             * Classes are our prototypes that we use to create objects. It could be thought of as a blueprint 
             * of a product that determines it's basic structure and properties.
             * We use classes to create an instance of the object that the class describes
             * if mobile phone blueprint = class,
             *    mobile phone instance = mobilePhone1, we use this instance in our project to get or set 
             *    it's specified properties, and use it's methods to take certain actions.
             */

            //CREATING AN INSTANCE OF A CLASS
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

            MobilePhone phone4 = new MobilePhone()
            {
                CaseColor = ConsoleColor.Black,
                CaseMaterial = "Metal"                
            };
            // using constructor method 1 (default)
            // This way we create an instance of the class with default constructor, at first, only determined properties are ScreenSize & CreateDate (from the blueprint). Then after the instance is created we can set values to them or change already existing values using this way.
            // Since we did not assign BrandName a public access modifier 

            MobilePhone phone5 = new MobilePhone();
            phone5.CaseColor = ConsoleColor.Black;
            phone5.CaseMaterial = "Metal";
            // instances of phone4 & phone5 have the same values attached to them. But they were set using a diffrent way. 
        }

    }
}

