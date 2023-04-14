using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            return default(T);
        }
        return items[index];
    }

    public int GetItemCount()
    {
        return items.Count;
    }
}
