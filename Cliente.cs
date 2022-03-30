using System;

namespace ExempleProxy
{
    internal class Cliente
    {
        /*O Proxy pode ser usado de siversas maneiras tanto para controle, segurança e etc.
         ele é usado quando se encontra uma necessidade de "Esconder" o objeto principal do projeto*/
        static void Main(string[] args)
        {
            Internet internet = new ProxyInternet();
            try
            {
                internet.connectTo("geeksforgeeks.org");
                internet.connectTo("abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //https://www.geeksforgeeks.org/proxy-design-pattern/
        //https://refactoring.guru/design-patterns/proxy
    }
}
