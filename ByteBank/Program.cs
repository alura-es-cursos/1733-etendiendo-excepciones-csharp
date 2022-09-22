using ByteBank;
using ByteBank.DatosCliente;

static void MetodoInicial(int divisor)
{
    try
    {
        TestDivision(divisor);
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Referencia nula");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("No es posible ejecutar una división entre 0");
    }


}

static void TestDivision(int divisor)
{
    //Puede suceder una excepción si el divisor es 0.
    int resultado = 0;

    resultado = Dividir(10, divisor);
    Console.WriteLine("El resultado de dividir 10 entre " + divisor + " es: " + resultado);
        
}

static int Dividir(int numero, int divisor)
{
    
    try
    {
        return numero / divisor;
    } catch
    {
        Console.WriteLine("Excepción ejecutando división de " + numero + " entre " + divisor);
        throw;
    }
    
}


Console.WriteLine("Aplicación de cuentas bancarias!");

//CuentaBancaria cta = new CuentaBancaria("1384647","4664");

//Console.WriteLine("Valor de la comisión para la cuenta es: " + cta.ValorComision);

MetodoInicial(0);
MetodoInicial(2);

Console.ReadLine();

/*
 * Dividir
 * TestDivision
 * MetodoInicial
 * 
 * */