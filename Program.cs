using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlockChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var starttime = DateTime.Now;

            Blockchain MenziCoin = new Blockchain();
            MenziCoin.CreateTransaction(new Transaction("Henry", "MaHesh", 10));
            MenziCoin.ProcessPendingTransactions("Bill");

            MenziCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            MenziCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            MenziCoin.ProcessPendingTransactions("Bill");

            var endTime = DateTime.Now;

            Console.WriteLine($"Duration: {endTime - starttime}");

            Console.WriteLine("=========================");
            Console.WriteLine($"Henry' balance: {MenziCoin.GetBalance("Henry")}");
            Console.WriteLine($"MaHesh' balance: {MenziCoin.GetBalance("MaHesh")}");
            Console.WriteLine($"Bill' balance: {MenziCoin.GetBalance("Bill")}");

            Console.WriteLine("=========================");
            Console.WriteLine($"MenziCoin");
            Console.WriteLine(JsonConvert.SerializeObject(MenziCoin, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
