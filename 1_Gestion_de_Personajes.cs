using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Personajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> list = new List<Character>();

            Character character = new Character();

            list.Add(character);

            character.Name = "Juan";
            character.Description = "Es un buen tipo";
            character.Type = "NPC";
            character.Actions = "Da instrucciones y ayuda en la aventura";

            character.ShowCharacter();

            Console.WriteLine("Ingrese el Nombre: ");
            character.Name = Console.ReadLine();
            Console.WriteLine("Ingrese la Descripcion: ");
            character.Description = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo: ");
            character.Type = Console.ReadLine();
            Console.WriteLine("Ingrese sus acciones: ");
            character.Actions = Console.ReadLine();

            character.ShowCharacter();

            Console.ReadKey();
        }
    }

    class Character
    {
        private string name;
        private string description;
        private string type;
        private string actions;

        public Character(){ }

        public Character(string name, string description, string type, string actions)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.actions = actions;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public string Actions { get => actions; set => actions = value; }

        public void ShowCharacter()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Actions: {actions}");
        }
    }
}
