using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    //Interfaz para agregar una característica a cada tipo de animal
    interface IPetCharacteristics
    {
        string characteristics();
    }

    public class Animal 
    {
        protected String breed;
        protected String name;
        protected String age;
        protected String price;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public Animal()
        {
            breed = String.Empty;
            name = String.Empty;
            age = String.Empty;
            price = String.Empty;
        }

        public Animal(String breed, String name, String age, String price)
        {
            this.breed = breed;
            this.name = name;
            this.age = age;
            this.price = price;
        }

    }
    public class Dog : Animal, IPetCharacteristics
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I can bark!";
        }

 
    }

    public class Cat: Animal, IPetCharacteristics
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I can meow!";
        }
       
    }

    public class Bird : Animal,IPetCharacteristics
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I like to sing in the morning!";
        }

    }
    public class Reptil : Animal, IPetCharacteristics
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I enjoy nature!";
        }

    }
    public class Rodent : Animal, IPetCharacteristics
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I am small, take care of me!";
        }

    }
    public class Fish : Animal, IPetCharacteristics 
    {
        public string Hi
        {
            get { return characteristics(); }
        }
        public string characteristics()
        {
            return "¡I can swim!";
        }

    }

}
