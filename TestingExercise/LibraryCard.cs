namespace TestingExercise;

// A library card keeps track of the books its owner has borrowed.
//
// Requirements:
// - A card can hold at most 5 books at a time.
// - The same title can't be borrowed twice at the same time.
// - Borrow returns true if the book was borrowed, false if it wasn't.
// - Return returns true if the card had that book, false if it didn't.
public class LibraryCard
{
    public const int MaxBooks = 5;

    private readonly List<string> borrowed = new List<string>();

    public int BorrowedCount => borrowed.Count;

    public bool Borrow(string title)
    {
        if (borrowed.Count > MaxBooks || borrowed.Contains(title))
        {
            return false;
        }
        borrowed.Add(title);
        return true;
    }

    public bool Return(string title)
    {
        return borrowed.Remove(title);
    }

    public bool HasBook(string title)
    {
        return borrowed.Contains(title);
    }
}
