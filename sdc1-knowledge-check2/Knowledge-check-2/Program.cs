public class Animal
{
    
    private string food;
    public string Food{
        get => food;
        set => food = value;
    }
    private string color;
    public string Color{
        get => color;
        set => color = value;
    }


}

public class Dog : Animal{
    private string bark;
    public string Bark{
        get => bark;
        set => bark = value;
    }

}


class testClass{
    static void Main(string[] args){
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Dog>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new Dog();
            Console.WriteLine("Record for dog " + (i + 1));
            Console.WriteLine("Enter the value for the bark.");
            myClass.Bark = Console.ReadLine();
            Console.WriteLine("Enter the value for the food.");
            myClass.Food = Console.ReadLine();
            Console.WriteLine("Enter the value for the color.");
            myClass.Color = Console.ReadLine();

            recordList.Add(myClass);
        }

        // Print out the list of records using Console.WriteLine()
        foreach(Dog each in recordList){
            Console.WriteLine(each.ToString());
        }

    }
}

