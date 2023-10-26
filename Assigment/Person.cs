using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    class Person
    {
        string fnm, lnm;
        int age;
        public Person(string fName, string lName, int personAge)
        {
            fnm = fName;
            lnm = lName;
            age = personAge;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}]", fnm, lnm, age);
        }
        
        public override bool Equals(Object ob)
        {
            if(ob!=null)
            {
               return  ob.ToString() == this.ToString();
            }
            else { return false; }
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        

    }

  class Class1 
    { 
    static void Main(string[] args)
    {    // NOTE:  We want these to be identical to test
         // the Equals() and GetHashCode() methods.
        Person p1 = new Person("Raj", "Mathur", 22);
        Person p2 = new Person("Raj", "Mathur", 22);

        // Get stringified version of objects.
        Console.WriteLine("p1.ToString() = {0}", p1.ToString());
        Console.WriteLine("p2.ToString() = {0}", p2.ToString());

        // Test Overridden Equals()
        Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

        // Test hash codes.
        Console.WriteLine("{0}", p1.GetHashCode() == p2.GetHashCode());
        Console.WriteLine();

    }

}
