
public delegate void MonDelegateFunctionClass(string textSample);
public class program
{
    static void Main(string[] args)
    {
        MonDelegateFunctionClass monDelegateFunctionObject = ToUpperCase;

        EcritPourMoiFunction("pas d'objet");
        EcritPourMoiFunction("aLlloOooO!!", monDelegateFunctionObject);


        monDelegateFunctionObject = ToLowerCase;

        EcritPourMoiFunction("aLlloOooO!!", monDelegateFunctionObject);
        Console.ReadKey();
    }


    static void ToUpperCase(string Text) => Console.WriteLine(Text.ToUpper());
    static void ToLowerCase(string Text) => Console.WriteLine(Text.ToLower());



    static void EcritPourMoiFunction(string unText, MonDelegateFunctionClass inconnu = null)
    {
        Console.WriteLine("$Before:{unText}");
        if (inconnu != null)
        {
            inconnu(unText);
        }

    }




}
