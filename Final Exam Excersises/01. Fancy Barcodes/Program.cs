using System;
using System.Text.RegularExpressions;

namespace _01._Fancy_Barcodes
{
    class Program
    {
        static void Main()
        {
            int numOfBarcodes = int.Parse(Console.ReadLine());
            
            string validation = @"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            string productGroup = @"(\d+)";

            for (int i = 0; i < numOfBarcodes; i++)
            {
                string input = Console.ReadLine();
                Match ifBarcode = Regex.Match(input, validation);

                if (ifBarcode.Success)
                {
                    string barcode = ifBarcode.Groups["barcode"].Value.ToString();

                    MatchCollection ifProdGroup = Regex.Matches(barcode, productGroup);
                    if (ifProdGroup.Count > 0)
                    {

                        string prodGroup = string.Empty;
                        foreach (Match item in ifProdGroup)
                        {
                            prodGroup += item;
                        }
                        Console.WriteLine($"Product group: {prodGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
