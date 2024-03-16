internal class Program
{
    private static void Main(string[] args)
    {
        DataGeneric<int> ObjData = new DataGeneric<int>(1302220001);
        ObjData.PrintData();
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T inputData)
    {
        data = inputData;
    }

    public void PrintData()
    {
        Console.WriteLine("Data tersimpan adalah : " + data);
    }
}