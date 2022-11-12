namespace Integers;

// https://leetcode.com/problems/find-median-from-data-stream/
// Runtime 750 ms Beats 83.26% Memory 91.6 MB Beats 85.22%
public class MedianFinder
{
    private readonly SortedSet<int[]> _min;
    private readonly SortedSet<int[]> _max;
    
    private int _count;

    public MedianFinder()
    {
        _min = new SortedSet<int[]>(Comparer<int[]>.Create((a, b) => a[0] - b[0] == 0 ?  a[1] - b[1] : a[0] - b[0]));
        _max = new SortedSet<int[]>(Comparer<int[]>.Create((a, b) => a[0] - b[0] == 0 ?  a[1] - b[1] : a[0] - b[0]));
        _count = 0;
    }

    public void AddNum(int num)
    {
        var item = new[] { num, _count++ };
        if (_min.Count == _max.Count || _min.Count == 0)
        {
            if (_min.Count == 0 || num <= _min.Max![0])
            {
                _min.Add(item);
            }
            else
            {
                _max.Add(item);
                _min.Add(_max.Min!);
                _max.Remove(_max.Min!);
            }
        }
        else
        {
            if (num <= _min.Max![0])
            {
                _min.Add(item);

                if (_min.Count - 1 == _max.Count) return;
                _max.Add(_min.Max);
                _min.Remove(_min.Max);
            }
            else
            {
                _max.Add(item);
            }
        }
    }

    public double FindMedian()
    {
        if (_max.Count == _min.Count)
            return ((double)_min.Max![0] + _max.Min![0]) / 2;

        return _min.Max![0];
    }
}