using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections;

internal class SpecialEnumerator<T> : IEnumerator<T>
{
    private readonly SpecialCollection<T> myCollection;
    private int _index = 0;

    public SpecialEnumerator(SpecialCollection<T> myCollection)
    {
        this.myCollection = myCollection;
    }

    public T? Current { get; set; }

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        //throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        if (myCollection.Count > _index)
        {
            _index++;
            Current = myCollection[_index];
            return true;
        }
        return false;
    }

    public void Reset()
    {
       _index = 0;
    }
}

