namespace TestingPractice;

// Works out what a stay in the Riverside parking garage costs.
//
// Requirements:
// - The first 15 minutes are free.
// - Otherwise, the first hour (or part of an hour) costs $3.00,
// - and each further hour or part of an hour costs $2.00.
// - No stay costs more than $20.00, the daily maximum.
public class ParkingGarage
{
    public const int FreeMinutes = 15;
    public const decimal FirstHourRate = 3.00m;
    public const decimal ExtraHourRate = 2.00m;
    public const decimal DailyMaximum = 20.00m;

    public decimal Cost(int minutes)
    {
        if (minutes <= FreeMinutes)
        {
            return 0m;
        }

        int hours = minutes / 60 + 1;
        decimal cost = FirstHourRate + (hours - 1) * ExtraHourRate;
        return Math.Min(cost, DailyMaximum);
    }
}
