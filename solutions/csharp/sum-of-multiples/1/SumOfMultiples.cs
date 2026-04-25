public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var uniqueValues = new List<int>();

        foreach (var baseNum in multiples){
            if (baseNum < 1 || baseNum >= max){
                continue;
            }
            
            var calcMultiples = new List<int>();

            var i = 1;
            while (i < max){
                var product = i * baseNum;
                
                if (product >= max){
                    break;
                }

                calcMultiples.Add(product);
                ++i;
            }

            uniqueValues = uniqueValues.Union(calcMultiples).ToList();
        }

        return uniqueValues.Sum();
    }
}