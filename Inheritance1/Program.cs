using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            //INHERITANCE

            /*
             * Inheritance is one of the core concepts of OOP, which allows us to inherit the properties and methods of one class to another 
             * By using inheritance we prevent writing the same code (properties/methods in this case) over and over again.
             * The class giving inheritance is called Base Class or Parent Class, the class taking inharitance is called 'Sub Class' or 
             * 'Child Class'.
             * The new class takes all the properties & methods of the inherited class. This creates a strong relationship between the 
             * classes, one is derived from the other.
             * This method gives reusability to our code aswell since we can change the properties and the methods of the Base-class once, 
             * then all the inheriting Sub-classes will have changed aswell.
             * 
             * public class SubClass : BaseClass >>>> Inheritance is declared while defining a class. The class written after the colon (':')
             * is the BaseClass that the new SubClass will take inheritance from. See class definitions below...
             * In C# classes can only take inheritance from one class only.
             */


            BaseEntity base1 = new BaseEntity();
            base1.WriteCreateDate(); // Prints the CreateDate of base1 object to the console
            base1.Id = 100;
            
            AppUser user1 = new AppUser();
            user1.FirstName = "John";
            user1.LastName = "Doe";
            user1.UserName = "JDoe.in1";
            user1.Password = "jd.170422!";

            user1.Id = 101; // The Id property is not declared in the body of AppUser class but inherited from parent. So can be get/set.
            user1.WriteCreateDate(); // Similarly this method is also inherited from BaseEntity.
        }

        public class BaseEntity
        {
            public int Id { get; set; }
            private DateTime CreateDate { get; set; } = DateTime.Now;

            public BaseEntity() // Construction method of the base class
            {
                //This method is triggered when an instance of a class inheriting BaseEntity Class is created.
                //First the BaseEntity construction method triggers, then the inheriting classes' cons. method.
                CreateDate = DateTime.Now;
                Console.WriteLine("BaseEntity created...");
            }

            public void WriteCreateDate()
            {
                Console.WriteLine(CreateDate);
            }
        }
        public class AppUser : BaseEntity // This class has a CreateDate & Id property, inherited. No need to declare again.
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public AppUser() // Constructor method of AppUser Class
            {
                Console.WriteLine("User created...");
                //When this constructor method is triggered, the base classes' constructor method triggers first then this method is
                //triggered. We see the "BaseEntity created..." message, then "User created..." message after.
            }
        }

        public class Admin : AppUser // This admin class takes inheritance from AppUser which is also taking inheritance from BaseEntity.
                                     // This way there can be multi level relationship between classes
        {
            public string AdminUserName { get; set; }
            public string AdminPassword { get; set; }
            public Admin() // First "BaseEntity created..." , then "User created..." lastly "Admin created..." messages will display once an
                           // instance of this class is formed.
            {
                Console.WriteLine("Admin created...");
            }
        }
    }
}
