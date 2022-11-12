namespace Integers;

// https://leetcode.com/problems/find-median-from-data-stream/

public class MedianFinderSlow // gets rejected
{
    private readonly List<int> _list;

    public MedianFinderSlow()
    {
        _list = new List<int>();
    }

    public void AddNum(int num)
    {
        _list.Add(num);
    }

    public double FindMedian()
    {
        var count = _list.Count;
        if (count == 1)
            return _list[0];

        _list.Sort();
        if (count % 2 == 0) return (double)(_list[count / 2 - 1] + _list[count / 2]) / 2;

        return _list[count / 2];
    }
}