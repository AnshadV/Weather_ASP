using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        private static FetchData data = new FetchData();
        public static async Task Main(string[] args)
        {
            List<String> output;

            output = await Input.InputString();

            if (output.Equals(null))
            {
                throw new Exception("input cant be empty!!!");
            }
            else
            {
                for (int i = 0; i < output.Count(); i++)
                {
                    Console.WriteLine(output[i]);

                }
            }

        }
    }
}
