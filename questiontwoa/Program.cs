// See https://aka.ms/new-console-template for more information
static int largestElement(int[] start, int index)
{
    if (index > 0)
    {
        return Math.Max(start[index], largestElement(start, index - 1));
    }
    else
    {
        return start[0];
    }
}
