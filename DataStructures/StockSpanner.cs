using System.Collections;

namespace DataStructures;

// https://leetcode.com/problems/online-stock-span/
public class StockSpanner
{
    private ArrayList _list;
    private readonly Stack<(int price, int span)> _stack;

    public StockSpanner()
    {
        _list = new ArrayList();
        _stack = new Stack<(int price, int span)>(500);
    }

    // Runtime 775 ms Beats 60.19% Memory 66.6 MB Beats 48.15%
    public int Next(int price)
    {
        var span = 1;
        while (_stack.Count > 0 && _stack.Peek().price <= price)
            span += _stack.Pop().span;
        _stack.Push((price, span));
        return span;
    }

    // Runtime 1067 ms Beats 10.19% Memory 61.8 MB Beats 93.52%
    public int NextLinkList(int price)
    {
        _list.Add(price);
        var span = 0;
        for (var i = _list.Count -1; i >= 0 ; i--)
        {
            if (price >= (int)_list[i]!)
                span++;
            else
                break;
        }

        return span;
    }
}