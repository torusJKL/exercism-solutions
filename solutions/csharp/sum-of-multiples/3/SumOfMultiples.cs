public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var uniqueValues = new HashSet<int>();

        foreach (var baseNum in multiples){
            if (baseNum < 1 || baseNum >= max){
                continue;
            }

            if (uniqueValues.Contains(baseNum)){
                continue;
            }

            for (int i = baseNum; i < max; i += baseNum){
                uniqueValues.Add(i);
            }
        }

        return uniqueValues.Sum();
    }
}