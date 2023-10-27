using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Meny
    {
    public void Menu()
    {            
            bool go = true;
            while (go)
            {
                Console.WriteLine("Choose [1], [2], [3], [4] or [5]" +
                "\n[1]Dog" +
                "\n[2]Cat" +
                "\n[3]Snake" +
                "\n[4]Wolf" +
                "\n[5]Exit program");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Dog();
                        break;
                    case "2":
                        Cat();
                        break;
                    case "3":
                        Snake();
                        break;
                    case "4":
                        Wolf();
                        break;
                    case "5":
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Du måste välja ett utav alternativen!");
                        break;
                }
            }
            static void Cat()
            {
                Cat cat = new Cat(8, "Mårten", "white", "is furry", "is a suitable pet", "is an excellent climber");
                cat.DjurInfo();
                cat.makeSound();
                cat.Eat();
                cat.ClimbTree();
                Console.ReadKey();
                Console.Clear();
            }
            static void Dog()
            {
                Dog dog = new Dog(5, "Henry", "black", "Has a lot of fur", "is an excellent pet", "sharp fangs");
                dog.DjurInfo();
                dog.makeSound();
                dog.Eat();
                dog.ChewToy();
                Console.ReadKey();
                Console.Clear();

            }
            static void Snake()
            {
                Snake snake = new Snake(21, "Lena", "Green", "does not have fur, she has scales", "is not a great pet", "is very venomous");
                snake.DjurInfo();
                snake.makeSound();
                snake.Eat();
                snake.Paralyse();
                Console.ReadKey();
                Console.Clear();
            }
            static void Wolf()
            {
                Wolf wolf = new Wolf(14, "Matilda", "grey", "Has a lot of fur", "is a wild animal, NOT a pet", "sharp fangs", "is an excellent hunter");
                wolf.DjurInfo();
                wolf.makeSound();
                wolf.Eat();
                wolf.ChewToy();
                wolf.Pack();
                Console.ReadKey();
                Console.Clear();
            }            
        }   
    }
}

