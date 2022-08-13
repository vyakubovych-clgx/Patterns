﻿namespace Adapter.Task;

public class Adapter<T> : IContainer<T>
{
    private readonly IElements<T> _elements;

    public Adapter(IElements<T> elements)
    {
        _elements = elements;
    }

    public IEnumerable<T> Items => _elements.GetElements();
    public int Count => Items.Count();
}