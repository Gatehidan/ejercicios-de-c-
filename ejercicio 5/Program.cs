namespace ejercicio5
{
    public class program
    {
        public static void Main()
        {

            int limite;
            double cuadrado;
            int numero = 2;
            int elevado;
            elevado = 0;
            limite = 10;
            for (elevado = 0; elevado <= limite; elevado++)
            {
                cuadrado = Math.Pow(numero, elevado);
                Console.WriteLine($"El resultado del número 2 al cuadrado de {elevado} es : {cuadrado}");
            }

        }
    }
}
