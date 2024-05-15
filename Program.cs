using System.Formats.Asn1;

public class Profile
{
    // Attributes
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    // Constructor
    public Profile(string name, int age, string city, string country)
    {
        Name = name;
        Age = age;
        City = city;
        Country = country;
        
    }

    // Method to add hobbies

    public List<string> Hobbies = new List<string>(); 
    public void AddHobby()
    {
        
        Console.WriteLine("Type one hobby you want to add to your profile\n");
        string hobby = Console.ReadLine();
        Hobbies.Add(hobby);
        return;
    }

    // Method to display profile information
    public void DisplayProfile()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine("Hobbies:");
        foreach (string hobby in Hobbies)
        {
            Console.WriteLine(hobby);
        }
        
    }
}
class Program 
{
    static void Main()
    {
        Profile profile1 = new Profile("Kalle", 32, "Stockholm", "Sweden");
        while(true) {
            Console.WriteLine("\nType 'Add' to add a hobby to your list of hobbies. \nType 'Display' to display your profile. \nType 'Stop' to stop the program. \n");
            string answer = Console.ReadLine().ToLower();
            
            if(answer == "add")
            {
                profile1.AddHobby();
            }

            else if(answer == "display")
            {
                profile1.DisplayProfile();
            }

            else if(answer == "stop")
            {
                break;
            }

            else
            {
                Console.WriteLine("Please type one of the three options to continue.");
                continue;
            }

        }
    }
}