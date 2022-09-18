using System;

class Program {
  public static void Main (string[] args) {
    // My code goes here
    Console.Write("Please enter your name: ");
    var name = Console.ReadLine();
    
    Console.Write("Please enter your location: ");
    var location = Console.ReadLine();
    
    Console.WriteLine ("Your name is " + name);
    Console.WriteLine ("Your are in " + location);
  }
}