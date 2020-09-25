using System.Collections.Generic;
public class Generic<T> 
{ 
    private IList<T> items = new List<T>(); 
 
    public void Add(T item) 
    { 
        this.items.Add(item); 
    } 
 
    public IEnumerator<T> GetEnumerator() 
    { 
        return this.items.GetEnumerator(); 
    } 
} 