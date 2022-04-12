using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Class
{
    //This is the simplest decleration of a class which contains the keyword 'class' followed up with the 
    //name that represents that class (the Identifier - in this case 'MobilePhone')
    //When naming classes we need to use PascalCase rules Meaning first letter of every word needs to be
    //Uppercase, same rule applies for naming Constructor Methods, Properties & Methods(best-practice).
    class MobilePhone
    {
        /* 
         * Body of the class :
         * The body of the class contins its 
         *  1-)Constructor method/s
         *  2-)Properties
         *  3-)Methods
         */
        string BrandName { get; set; } // (type) + (Prop. Name) + (body: get;/set;) property definiton w/o
                                       // access modifier
        public string CaseMaterial { get; set; } // Definition w/ access modifier (public)
        public ConsoleColor CaseColor { get; set; } 
        public DateTime CreateDate { get; } = DateTime.Now; //Default value set to DateTime.Now, which points
                                                            //to the moment when the instance is created.
        // PROPERTIES
        /*
         * Properties specify values for the class that can either be read and changed from the outside, or
         * read only.
         * Properties are created by determining the type of the property (int,string,DateTime etc.), the name
         * of the property and the body which contains get;&set; methods.
         * 
         * Get method allows reading(get|ting) the information of the property.
         * Set method allows changing(set|ting) the information of the same property.
         * 
         * Note : Classes also take access modifiers (public,private,internal etc.) but a class can be
         * described without one, in that case it will take its default access modifier(internal for classes). 
         * 
         * Properties can be set to a default value. When that is done inside the class body, one should think
         * of it as a change in the blueprint. 
         * If you have a blueprint that is for a mobile phone with metal case, whenever you create an instance
         * with that blueprint you will obtain a metal-cased mobilephone (see program.cs)
         * 
         * Shortcut to create a property: 'prop + Tab + Tab'
         */
        
        //FIELDS
        private int _screenSize = 6; // Fields are values that can not be reached from outisde. Unless some for
                                     // of connection provided, fields can only be changed inside the body of
                                     // the class, hence the 'private' access modifier.
        public int ScreenSize // The only way to access a field from outside is through another property.(will
                              // be explained in depth in Encapsulation definition.)
        {
            get { return _screenSize; } //This property returns the set value of _screenSize field. (6)
            set { _screenSize = value; }
        }

        //CONSTRUCTOR METHODS
        /*
         * Constructor method is the method that is triggered when we create an instance of this class (an 
         * object with MobilePhone type).
         * All classes have a default constructor method that does not need to be declared.
         * There can be more than one constructor method (can be overloaded), so we can create the object in
         * different ways.
         * Shortcut to create a constructor method: 'ctor + Tab + Tab'
         */
        public MobilePhone() // this here is the default constructor method which exists if no constructor
                             // method is written.
        {

        }

        public MobilePhone(string brandName) // This is the first overload of const. method which requires a
                                             // string parameter to create the object. If we have this method
                                             // only and no empty constructor method we would need to create
                                             // each object with string brandName parameters.
        {
            BrandName = brandName; // the given brandName parameter linked here to the property BrandName
            //this.BrandName = brand; can be typed like this way but 'this' keyword is not required.
        }
        public MobilePhone(string brand, string caseMaterial, ConsoleColor caseColor) //constructor w/ 3 parameters
        {
            BrandName = brand;
            CaseMaterial = caseMaterial;
            CaseColor = caseColor;
        }

    }
}
