using TestingPractice;

ParkingGarage garage = new ParkingGarage();
Console.WriteLine($"Parking for 90 minutes costs {garage.Cost(90):C}");

LibraryCard card = new LibraryCard();
card.Borrow("The Hobbit");
Console.WriteLine($"Books on the card: {card.BorrowedCount}");

WordTools tools = new WordTools();
Console.WriteLine($"Is \"level\" a palindrome? {tools.IsPalindrome("level")}");
