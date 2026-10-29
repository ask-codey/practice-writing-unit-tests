# Practice: Writing Unit Tests

Practice code for the lesson **Practice: Writing Unit Tests** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

This time the code is written and the tests are yours. Three small classes are finished, but each one has **one bug** hiding in it. Plan your tests from the requirements, write them with MSTest, and let them find the bugs. Then fix the code until every test you wrote passes.

## What's here

- `TestingPractice/ParkingGarage.cs`: what a stay in a parking garage costs.
- `TestingPractice/LibraryCard.cs`: the books a library card holds.
- `TestingPractice/WordTools.cs`: counting vowels and spotting palindromes.
- `TestingPractice.Tests`: one test class per class, each with one example test that passes.

The requirements are in the comments at the top of each class and above each method. Test what the requirements say, not what the code does.

## What to do

For each class:

1. **Plan.** List the scenarios the requirements describe: the normal cases, and the edges, such as exactly at a limit, one past it and one before it.
2. **Write the tests.** One scenario per test, named after the scenario, with Arrange, Act and Assert. Use `[DataRow]` when several inputs share one scenario.
3. **Run them** with **Test > Run All Tests** (or `dotnet test`). A failing test is either a mistake in your test or a bug in the class: read the requirement again to decide which.
4. **Fix the bug** in the class, and run the tests again until they all pass.

There are three bugs in all, one in each class.

## Tips

- Edges find bugs. For "at most 5 books", test the 4th, 5th and 6th. For "the first hour", test 59, 60 and 61 minutes.
- Give each `Assert` a message that explains the requirement, so a failure tells you why.
- Don't change a test to make it pass. If the test matches the requirement, the code is wrong.
