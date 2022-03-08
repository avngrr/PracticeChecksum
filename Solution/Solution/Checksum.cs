namespace Checksum
{
    public static class ChecksumChecker
    {
        public static int ChecksumResult(string check, int stepSize = 1)
        {
            int result = 0;
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] == check[(i + stepSize) % check.Length])
                {
                    result += check[i] - '0';
                }
            }
            return result;
        }
    }
}
