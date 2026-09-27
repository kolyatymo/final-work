using final_work;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        IT_Step It_Step = new IT_Step();

        foreach (var item in It_Step.Teachers)
        {
            Console.WriteLine(item.Name);
        }
    }
}