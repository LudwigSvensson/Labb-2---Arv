using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb_2___Arv
{
    public class Animal
    {
        public int _age;
        public string _name;
        public string _colour;
        public string _fur;
        public string _pet;
        

        public virtual void makeSound()
        {
            Console.WriteLine($"{_name} is making the sound if its people");
        }
        public virtual void DjurInfo()
        {
            Console.WriteLine($"{_name} {_fur}." +
                $"\nThe colour of {_name} is {_colour}." +
                $"\n{_name} {_pet}." +
                $"\n{_name} is {_age} years old.");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{_name} is snacking");
            Console.WriteLine();
        }
        public Animal (int age, string name, string colour, string fur, string pet)
        {
            _age = age;            
            _name = name;
            _colour = colour;
            _fur = fur;
            _pet = pet;           
        }
    }
    public class Dog : Animal
    {
        public string _fangs;

        public Dog (int age, string name, string colour, string fur, string pet, string fangs) : base (age, name, colour, fur, pet)
        {
            _fangs = fangs;
        }
        public override void makeSound()
        {            
            Console.WriteLine($"{_name} is barking. VOOF VOOF");
            Console.WriteLine();
        }
        public override void DjurInfo()
        {
            Console.WriteLine($"This is the dog called {_name}.");
            base.DjurInfo();
            Console.WriteLine($"{_name} has a pair of {_fangs}");
            Console.WriteLine();
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} is eating his masters shoe. NO NO");
            Console.WriteLine();
        }
        public void ChewToy ()
        {
            Console.WriteLine($"{_name} destroys his chewingtoy with its pair of {_fangs}");
            Console.WriteLine();
        }        
    }
    public class Wolf : Dog
    {
        public string _hunter;
        public Wolf(int age, string name, string colour, string fur, string pet, string fangs, string hunter) : base (age, name, colour, fur, pet, fangs)
        {
            _hunter = hunter;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{_name} is howling. AOOOAOAOOOOOAHOOWOWW!!!!!");
            Console.WriteLine();
        }
        public override void DjurInfo()
        {
            Console.WriteLine($"This is the wolf called {_name}.");
            base.DjurInfo();
            Console.WriteLine($"{_name} has a pair of really {_fangs}");
            Console.WriteLine();
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} is eating a newly chatched deer. NOM NOM.");
            Console.WriteLine();
        }
        public void ChewToy()
        {
            Console.WriteLine($"{_name} completely destroys his chewingtoy with its pair of {_fangs}.");
            Console.WriteLine();
        }
        public void Pack ()
        {
            Console.WriteLine($"{_name} can use its incredibly loud howl to gather its pack.");
        }
    }
    public class Cat : Animal
    {
        public string _climb;

        public Cat (int age, string name, string colour, string fur, string pet, string climb) : base (age, name, colour, fur, pet)
        {
            _climb = climb;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{_name} is Meowing.");
            Console.WriteLine();
        }
        public override void DjurInfo()
        {
            Console.WriteLine($"This is the cat {_name}");
            base.DjurInfo();
            Console.WriteLine($"{_name} {_climb}");
            Console.WriteLine();
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} is eating fish. NOM NOM.");
            Console.WriteLine();
        }
        public void ClimbTree()
        {
            Console.WriteLine($" Since {_name} {_climb}, climbing the tree is childs play for him.");
            Console.WriteLine();
        }

    }
    public class Snake : Animal
    {
        public string _venomous;
        public Snake (int age, string name, string colour, string fur, string pet, string venomous) : base (age, name, colour, fur, pet)
        {
            _venomous = venomous;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{_name} is hissing.");
            Console.WriteLine();
        }
        public override void DjurInfo()
        {
            Console.WriteLine($"This is the snake {_name}.");
            base.DjurInfo();
            Console.WriteLine($"{_name} {_venomous}.");
            Console.WriteLine();
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} is eating a rat. NOM NOM.");
            Console.WriteLine();
        }
        public void Paralyse()
        {
            Console.WriteLine($"{_name} can paralyse prey with its {_venomous} bite");
            Console.WriteLine();
        }
    }
}

