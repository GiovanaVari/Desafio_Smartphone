using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia(numero: "0611111111", modelo: "20", imei: "111222333", memoria: 32);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(numero: "0622222222", modelo: "15", imei: "000111222", memoria: 512);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");

        }
    }
}