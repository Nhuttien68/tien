using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IEnumerable<T>
{
    private List<T> students;
    public MyList()
    {
        students = new List<T>();
    }
    public void Add(T student)
    {
        students.Add(student);
    }
    public void Remove(T student)
    {
        students.Remove(student);
    }
    public T getStudent( int index)
    {
        if (index >= 0 && index < students.Count)
        {
            return students[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }
    public bool Contains(T student)
    {
        return students.Contains(student);
    }
    public int Count
    {
        get { return students.Count; }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return students.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
