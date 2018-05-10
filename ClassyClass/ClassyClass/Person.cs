using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyClass
{
    public class Person
    {
        private string _name;
        private int _age;

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }

        //}
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}

        public string Info
        {
            get
            {
                return _name + " age is " + _age;
            }
        }
        public Person(string name, int age)
        {
            _name = name; 
            _age=age;
        }

        public string InfoGetter()
        {
            return _name + " age is " + _age;
        }

    }
    
}
