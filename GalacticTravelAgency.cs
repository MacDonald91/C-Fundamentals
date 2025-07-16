using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Creating Variables for passenger data.

    // passenger names
    string passengerName = "Zara";
    // passenger ages
    int passengerAge = 28; // This will be incremented to 29 later
    // ticket type
    string ticketType = "First Class";
    // preffered location
    string prefferedPlanet = "Mars";
    

    // print passenger name
    Console.WriteLine("Passenger Name: " + passengerName);
    // print passenger age
    Console.WriteLine("Original Passenger Age: " + passengerAge);
    // print ticket type
    Console.WriteLine("Ticket Type: " + ticketType);
    // print preffered location
    Console.WriteLine("Preferred Planet: " + prefferedPlanet);

    // Increment the passenger's age by 1
    passengerAge = passengerAge + 1; // Or you can use: passengerAge++;

    // Print the new passenger age (after increment)
    Console.WriteLine("New Passenger Age (int): " + passengerAge);

    // Explicitly convert passengerAge to a double and assign it to passengerAgeDouble
    double passengerAgeDouble = (double)passengerAge;
    // Print passengerAgeDouble to the console
    Console.WriteLine("New Passenger Age (explicit double): " + passengerAgeDouble);

    // Implicitly convert passengerAge to a double and assign it to passengerAgeDouble2
    double passengerAgeDouble2 = passengerAge;
    // Print passengerAgeDouble2 to the console
    Console.WriteLine("New Passenger Age (implicit double): " + passengerAgeDouble2);

    // Convert passengerAge to a string using Convert.ToString()
    string passengerAgeString = Convert.ToString(passengerAge);
    // Print passengerAgeString to the console
    Console.WriteLine("New Passenger Age (string): " + passengerAgeString);
  }
}