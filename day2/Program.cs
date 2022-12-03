/* Initial thoughts:
 * 
 *  I think I will ingest this into an object, and then for each object, I will
 *  calculate the score, then get the sum of all scores.
 */

// Import the input into an object to work with
List<string> hands = File.ReadAllLines("./input.txt").ToList();

// For each hand, calculate the score
int totalScore = 0;
foreach (string hand in hands)
{
// We don't handle ever possible value because our input has known values
#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
    int handScore = hand switch
    {
        "A X" => 4, // 1 for rock, 3 for tie
        "A Y" => 8, // 2 for paper, 6 for win
        "A Z" => 3, // 3 for scissors, 0 for loss
        "B X" => 1, // 1 for rock, 0 for loss
        "B Y" => 5, // 2 for paper, 3 for tie
        "B Z" => 9, // 3 for scissors, 6 for win
        "C X" => 7, // 1 for rock, 6 for win
        "C Y" => 2, // 2 for paper, 0 for loss
        "C Z" => 6, // 3 for scissors, 3 for tie
    };
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).

    totalScore += handScore;
}

Console.WriteLine(totalScore);

// for part 2 we just change the switch statement to lose
int totalScore2 = 0;
foreach (string hand in hands)
{
    // We don't handle ever possible value because our input has known values
#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
    int handScore = hand switch
    {
        "A X" => 3, // 3 for scissors, 0 for loss
        "A Y" => 4, // 1 for rock, 3 for tie
        "A Z" => 8, // 2 for paper, 6 for win
        "B X" => 1, // 1 for rock, 0 for loss
        "B Y" => 5, // 2 for paper, 3 for tie
        "B Z" => 9, // 3 for scissors, 6 for win
        "C X" => 2, // 2 for paper, 0 for loss
        "C Y" => 6, // 3 for scissors, 3 for tie
        "C Z" => 7, // 1 for rock, 6 for win
    };
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).

    totalScore2 += handScore;
}
Console.WriteLine(totalScore2);
