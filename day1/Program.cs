/*Initial thoughts:
 * 
 * For the 1 star portion, this seems to be a simple read and LINQ statement.
 * I'll give that a try.
 */

// Gather the elf calories into an easy to read object from the text
List<List<int>> elfCalories = new();

int index = 0;
File.ReadAllLines("./input.txt").ToList().ForEach(x =>
{
    if (x == string.Empty)
    {
        index++;
    }
    else
    {
        if (elfCalories.Count <= index)
        {
            elfCalories.Add(new List<int>());
        }
        elfCalories[index].Add(int.Parse(x));
    }
});


// LINQ didn't end up working for me, I think with a different data structure it
// would work better.
int mostCalorieDenseElf = 0;
foreach (var elf in elfCalories)
{
    int totalElfCalories = elf.Sum();
    if(totalElfCalories > mostCalorieDenseElf)
    {
        mostCalorieDenseElf = totalElfCalories;
    }
}

Console.WriteLine(mostCalorieDenseElf);

// Just combine the totals.
List<int> totalCalories = new();
foreach (var elf in elfCalories)
{
    totalCalories.Add(elf.Sum());
}

int threeMostCalorieDenseElves = totalCalories.OrderDescending().Take(3).Sum();

Console.WriteLine(threeMostCalorieDenseElves);

// If I was to do this one again I'd reorganize the data in a better way, I'm
// quite certain it could be done with some very simple LINQ statements.