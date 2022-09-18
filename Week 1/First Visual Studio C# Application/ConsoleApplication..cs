using System;

class Program {
  public static void Main (string[] args) {
    // My code goes here

    // 2
    Console.Write("Please enter your name: ");
    var name = Console.ReadLine();
    
    Console.Write("Please enter your location: ");
    var location = Console.ReadLine();
    
    // 3
    Console.WriteLine ("Your name is " + name);
    Console.WriteLine ($"Your are in  {location}");
    
    // 4
    var currentDate = DateTime.Now;
    Console.WriteLine ($"Your current date and time is {currentDate.ToLongDateString()}");
    // 5

    var nextChristmas = new DateTime(currentDate.Year,12,25);
    var daysUntilChristmas = nextChristmas - currentDate;
    Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas");

    // 6

    double width, height, woodLength, glassArea;
    string widthString, heightString;

    
    Console.Write("Please enter the width: "); 
    widthString = Console.ReadLine();
    width = double.Parse(widthString);

    Console.Write("Please enter the height: ");
    heightString = Console.ReadLine();
    height = double.Parse(heightString);
    
    woodLength = 2 * ( width + height ) * 3.25 ;
    glassArea = 2 * ( width * height ) ;
    Console.WriteLine ( "The length of the wood is " +
    woodLength + " feet" ) ;
    Console.WriteLine( "The area of the glass is " +
    glassArea + " square metres" ) ;
    
    // 7
    Console.WriteLine ("Press any key to quit.");
    Console.ReadKey();
      


    
  }
}
