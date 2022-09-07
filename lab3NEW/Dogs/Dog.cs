using System;
namespace Dogs
{
    [Serializable]
    public class Dog
    {
        public string name { get; set; }
        public string age { get; set; }
        public string color { get; set; }
        public string breed { get; set; }

        public Dog(string name, string age, string color, string breed)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.breed = breed;
        }

        public string GetData()
        {
            return name + ", age " + age + ", color " + color + ", breed " + breed;
        }
    }
}
