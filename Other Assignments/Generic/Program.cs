// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

GenericMethods m=new GenericMethods();
double[] oldArray =  { 3, 5, 9, 1, 6 };
double[] reversed = m.ReverseArray(oldArray);
var lastcout = m.LastAndCount(oldArray);
Console.WriteLine($"Last value: {lastcout.Item1} \nCount: {lastcout.Item2}");
reversed.ToList().ForEach(r => Console.WriteLine(r));
Console.WriteLine("Hello, World!");
public class GenericMethods
{
    //Generic Method that reverse a given array
    public T[] ReverseArray<T>(T[] array)
    {
        int n=array.Length;
       T[] reversed=new T[n];
        for (int i = 0; i < n; i++)
        {
            reversed[i] = array[n - 1 - i];
        }
     return reversed;
    }
    //Generic method that return the last value and the count of an array
    public Tuple<T,int>LastAndCount<T>(T[] array)
    {
        T last=array[array.Length - 1];
        return new Tuple<T, int>(last, array.Length);
    }
}
//Generic interface for Repository CRUD operation
public interface IbaseRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate);

    void AddEntity(T entity);
    void AddRangeOfEntity(IEnumerable<T> entity);

    void UpdateEntity(T entity);

    void RomoveEntity(T entity);
    void RemoveRangeOfEntity(IEnumerable<T> entity);
    void UpdateRenge(IEnumerable<T> entity);
}

// Generic class for CRUD operation
public class BaseRepository<T> : IbaseRepository<T> where T : class
{
    public void AddEntity(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRangeOfEntity(IEnumerable<T> entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public void RemoveRangeOfEntity(IEnumerable<T> entity)
    {
        throw new NotImplementedException();
    }

    public void RomoveEntity(T entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateEntity(T entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRenge(IEnumerable<T> entity)
    {
        throw new NotImplementedException();
    }
}