namespace InterfacesLib
{
    public interface IComparer<T>
    {
        int Compare(T a, T b);
    }
}