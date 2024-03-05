using CSharpExercises2;

internal class Program
{
    private static void Main(string[] args)
    {
        var basicAlgo = new BasicAlgo();
        //Console.WriteLine(basicAlgo.CopyFrontChars4Times("C Sharp"));
        //Console.WriteLine(basicAlgo.CopyFrontChars4Times("JS"));
        //Console.WriteLine(basicAlgo.CopyFrontChars4Times("a"));
        //Console.WriteLine(basicAlgo.LastCharToFrontAndBack("Green"));
        var stringEx = new StringExercises();
        //Console.WriteLine(stringEx.SeparateStringWithSpaces("w3resource.com"));
        //Console.WriteLine(stringEx.SeparateStringWithoutSpacesInReverse("w3resource.com"));

        var recEx = new RecursionEx();
        //var num = 1;
        //recEx.PrintFirstNaturalNumbers(num);
        var num = 10;
        recEx.PrintNumbersFromNTo1(num);



        var linqEx = new LinqExercises();
        //Console.WriteLine(string.Join(" ",linqEx.NumbersBetween1And11([1,5,8,97,123,5,11])));
        Console.ReadLine();
    }
}