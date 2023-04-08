public class Array<T>
{
    List<T> list = new List<T> { };
    public Array()
    {
    }
    public void Add(T item)
    {
        list.Add(item);
    }
    public void Delete(T item)
    {
        list.Remove(item);
    }
    public T GetElem(int ind)
    {
        return list[ind];
    }
    public int GetLength()
    {
        return list.Count;
    }
}

public class Login : Array<string>
{

}

public class Password<T> : Array<T>
{

}
internal class Program
{
    static void Main(string[] args)
    {
            Login login = new Login();
            login.Add("Meloni");

            Password<string> password = new Password<string>();
            password.Add("Ashley");
    }
}
