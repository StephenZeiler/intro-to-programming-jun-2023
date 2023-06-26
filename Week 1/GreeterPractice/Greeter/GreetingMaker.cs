namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string name)
        {
            string greeting = $"Hello, {name}!";
            if(name == null)
            {
                name = "Cheif";
                greeting = $"Hello, {name}!";
            }
            else
            {                
                if (Char.IsUpper(name,1))
                {
                   greeting = $"Hello, {name}!";
                   greeting = greeting.ToUpper(); 
                }
            }
            return greeting;

        }


    }
}