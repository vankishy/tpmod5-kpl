﻿internal class Program
{
    private static void Main(string[] args)
    {
        //HaloGeneric
        HaloGeneric.SapaUser<string>("Reinhard");

        //DataGeneric
        DataGeneric<int> ObjData = new DataGeneric<int>(1302220001);
        ObjData.PrintData();
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}", X);
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