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

            for (int i = 1; i < max; ++i){
                var product = i * baseNum;
                
                if (product >= max){
                    break;
                }

                uniqueValues.Add(product);
            }
        }

        return uniqueValues.Sum();
    }
}