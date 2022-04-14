using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACTION

            /*
             * Abstraction is one of the core concepts of Object Oriented Programming (OOP).
             * Abstaction allows us to create 'abstact' classes, which are classes that we can not create an object of. We use these abstract classes as a base to the classes that they will give heritage to.
             * 
             * Abstract Methods
             * Similarly to classes, also methods can be marked as abstract. But the abstract methods can only exist in abstract classes. 
             * These methods do not have a body. They need to be inherited by another class, then the body can be determined. That allows different implementations of same method in the classes that inherit the same abstract class.
             * 
             * Abstract Classes:
             * If a class is marked as abstract, we can not create an instance of that class.
             * Abstract classes can have both abstract methods or regular methods.
             * If another class inherits an abstract class, the abstract methods of the class have to be overridden.
             * Abstract classes contain constructor methods even though they can not 
             */

            //BaseEntity baseEntity = new BaseEntity<int>;
            // We can't create an instance of the abstract BaseEntity<T> class.

            AppUser user1 = new AppUser(); //"BaseEntity created..." message will display first
                                           //"User created..." message second. (Constructor methods.)

            user1.Id = Guid.NewGuid();

            DateTime date1 = user1.CreateDate; //user1 inherited CreateDate from BaseEntity.
        }

        public abstract class BaseEntity<T> // Abstract base class.
        {
            public abstract T Id { get; set; }
            public DateTime CreateDate { get; set; }
            public BaseEntity() // Construction method of the abstract class
            {
                //This method is triggered when an instance of a class inheriting BaseEntity Class is created.
                //First the BaseEntity construction method triggers, then the inheriting classes' cons. method.
                CreateDate = DateTime.Now;
                Console.WriteLine("BaseEntity created...");
            }
        }

        public class AppUser : BaseEntity<Guid> // This class also has a CreateDate property, inherited.
        {
            public override Guid Id { get; set; } // Unless we override the abstract property of the base class
                                                  // we will get an error. Abstract properties & methods need
                                                  // to be overridden when inherited.
            public string FullName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public AppUser()
            {
                Console.WriteLine("User created...");
            }
        }
    }
}
