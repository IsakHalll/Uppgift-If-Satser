internal class Program
{
    private static void Main(string[] args)
    {
        // Uppgift 1
        // Console.WriteLine("Skriv ett nummer: ");
        // int input = int.Parse(Console.ReadLine());
        // Console.WriteLine("Skriv ett nummer: ");
        // int input2 = int.Parse(Console.ReadLine());
        
        // if(input > input2){
        //     Console.WriteLine($"{input} is greater than {input2}");
        // }
        // else if(input == input2){
        //     Console.WriteLine($"{input} and {input2} are equal");
        // }
        // else{
        //     Console.WriteLine($"{input2} is greater than {input}");
        // }
        
    // Uppfift 2
    //     Console.WriteLine("Skriv din ålder: ");
    //     int age = int.Parse(Console.ReadLine());

    //     if(age >=0 && age<= 12){
    //         Console.WriteLine("White");
    //     }
    //     else if(age >=13 && age <=18){
    //         Console.WriteLine("Green");
    //     }
    //     else if(age >=19 && age <= 25){
    //         Console.WriteLine("Red");
    //     }
    //     else if(age >=26 && age <=99){
    //         Console.WriteLine("Blue");
    //     }
    //     else{
    //         Console.WriteLine("Invalid Age");
    //     }

    // Uppgfift 3
    // Console.WriteLine("skriv ett nummer");
    //     int num = int.Parse(Console.ReadLine());
    //     if (num % 2 == 0){
    //         Console.WriteLine($"jämn");
    //     }
    //     else {
    //         Console.WriteLine($"udda");
    // }

    //Uppgift 4
    Console.WriteLine("Skriv en bokstav: ");
    char character = char.Parse(Console.ReadLine());
        switch(character){
            case 'a':
            case 'e':
            case 'u':
            case 'i':
            case 'o':
            case 'y':
            case 'ä':
            case 'å':
            case 'ö':
                Console.WriteLine("det är en vokal");
                break;
            default:
                Console.WriteLine("det är en konsonant");
                break;
        }
    }
}

