using TwoSumProblem;

Solution solution = new Solution();

int[] nums = { 2, 5, 5, 11 };
int target  = 10;

int[] answer = solution.TwoSum(nums, target);
Console.WriteLine($"The answer is [{answer[0]}, {answer[1]}]");