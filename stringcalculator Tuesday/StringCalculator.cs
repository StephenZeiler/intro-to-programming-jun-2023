
namespace StringCalculator;
public class StringCalculator
{



    public int Add(string numbers)
    {
        var total = 0;
        if (numbers == "")
        {
            return 0;
        }
        else
        {
            string[] subs = numbers.Split(',','\n');
            foreach (var sub in subs)              
            {
                var temp = sub;
                total = total + int.Parse(sub);
            }
            return total;
        }
    }
}
