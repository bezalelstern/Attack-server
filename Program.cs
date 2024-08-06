using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtteckServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //await GetDataAsync();
            ////Console.WriteLine(await GetDataAsync());
            //Console.WriteLine(await ReadFileAsinc(@"C:\Users\internet\source\repos\AtteckServer\TextFile1.txt"));
            //Console.WriteLine("recived data");

            Task<string> TaskA = GetDataFromServiceAAsinc();
            Task<string> TaskB = GetDataFromServiceBAsinc();

            await Task.WhenAll(TaskA, TaskB);

            Console.WriteLine(TaskA.Result);
            Console.WriteLine(TaskB.Result);
            Console.ReadLine();

        }

        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "daownloed";
        }

        public static async Task<string> ReadFileAsinc(string path) 
        {
            string contents = await Task.Run(() => File.ReadAllText(path));
            
            return contents;
        }

        public static async Task<string> GetDataFromServiceAAsinc()
        {
            await Task.Delay(1000);
            return "data from service A";
        }

        public static async Task<string> GetDataFromServiceBAsinc()
        {
            await Task.Delay(2000);
            return "data from service B";

        }
    }
}