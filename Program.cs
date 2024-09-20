using RandomElements;

List<int> ints = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

RandomList<int> nums = new RandomList<int>(ints);

for (int i = 0; i < 10 ; i++)
{
    Console.WriteLine(nums.RandomElement());
}