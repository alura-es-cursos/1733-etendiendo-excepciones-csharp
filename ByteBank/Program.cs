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

try
{
    CuentaBancaria cta = new CuentaBancaria("321", "123");
    CuentaBancaria cta2 = new CuentaBancaria("123", "321");
    cta.DepositarDinero(100);
    Console.WriteLine("Saldo Actual:" + cta.Saldo);
    cta.RetirarDinero(80);
    Console.WriteLine("Saldo Actual:" + cta.Saldo);
    cta.TransferirSaldo(40,cta2);
    Console.WriteLine("Saldo Actual:" + cta.Saldo);
    //Console.WriteLine("Valor de la comisión para la cuenta es: " + cta.ValorComision);
} 
catch (ArgumentException ex)
{
    Console.WriteLine("No fue posible crear la cuenta bancaria. Parámetro con error: "+ex.ParamName);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (OperacionesFinancierasException ex)
{
    //Console.WriteLine("Se intentó ejecutar una operación sin saldo suficiente");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    //Mostrar información en detalle de la excepción a más nivel
    Console.WriteLine(ex.InnerException.Message);
    Console.WriteLine(ex.InnerException.StackTrace);

}


//MetodoInicial(0);
//MetodoInicial(2);

Console.ReadLine();

/*
 * Dividir
 * TestDivision
 * MetodoInicial
 * 
 * */