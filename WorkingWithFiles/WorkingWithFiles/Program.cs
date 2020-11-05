using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using WorkingWithFiles.Entities;

namespace WorkingWithFiles {
    class Program {
        static void Main(string[] args) {

            bool finished = false;
            string pathProduct = @"C:\Users\rodrigo.meneses\Documents\Treinando C#\Revisando-C-\WorkingWithFiles\WorkingWithFiles\Files\product.txt";
            string pathOut = @"C:\Users\rodrigo.meneses\Documents\Treinando C#\Revisando-C-\WorkingWithFiles\WorkingWithFiles\Files\out\summary.csv";
            try {
                FileInfo fileInfo = new FileInfo(pathProduct);
                FileInfo fileOut = new FileInfo(pathOut);
                while(!finished) {
                    Console.Clear();
                    char option = Menu();
                    while(option != '1' && option != '2' && option != '3' && option != '4') {
                        Console.WriteLine("Incorrect Option! Write a valid option");
                        Console.ReadLine();
                        Console.Clear();
                        option = Menu();
                    }
                    switch(option) {
                        case '1':
                            Console.Write("Write a name for the product: ");
                            string name = Console.ReadLine();
                            Console.Write("Write the product value: ");
                            double valueProduct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            Console.Write("Write the product quantity: ");
                            int quantity = int.Parse(Console.ReadLine());

                            // If the file does not exist, it's created and after close the streamWriter and streamFile
                            using(StreamWriter sw = fileInfo.AppendText()) {
                                sw.WriteLine(name + "," + valueProduct.ToString("f2",CultureInfo.InvariantCulture) + "," + quantity.ToString());
                            }
                            break;                       
                        case '2':
                            using(StreamWriter sw = fileOut.AppendText()) {
                                using(StreamReader sr = new StreamReader(pathProduct)) {
                                    List<Product> products = new List<Product>();
                                    for(int i = 0; !sr.EndOfStream; i++) {
                                        String[] detail = sr.ReadLine().Split(',');
                                        products.Add(new Product(detail[0],double.Parse(detail[1]),int.Parse(detail[2])));
                                    }
                                    foreach(Product product in products) {
                                        sw.WriteLine(product.nameProduct + "," + product.TotalSale().ToString("f2",CultureInfo.InvariantCulture));
                                    }
                                }
                            }
                            break;
                        case '3':
                            using(StreamReader sr = new StreamReader(pathProduct)) {
                                List<Product> products = new List<Product>();
                                for(int i = 0; !sr.EndOfStream; i++) {
                                    String[] detail = sr.ReadLine().Split(',');
                                    products.Add(new Product(detail[0],double.Parse(detail[1]),int.Parse(detail[2])));
                                }
                                Console.WriteLine("|-----------------------------------------------------|");
                                Console.WriteLine("                   Saved Product list");
                                Console.WriteLine("|-----------------------------------------------------|");
                                foreach(Product product in products) {
                                    Console.WriteLine("Product: " + product.nameProduct);
                                    Console.WriteLine("Value: $ " + product.valueProduct.ToString("F2",CultureInfo.InvariantCulture));
                                    Console.WriteLine("Quantity: " + product.quantity);
                                    Console.WriteLine("-----------------------------------------------------");
                                }
                                Console.ReadLine();
                            }
                            break;
                        case '4':
                            Console.WriteLine("End System!");
                            finished = true;
                            break;
                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

        }
        static char Menu() {
            Console.WriteLine("-------- SALES SYSTEM --------");
            Console.WriteLine();
            Console.WriteLine("1 - Insert Product");
            Console.WriteLine("2 - Sales");
            Console.WriteLine("3 - List Products");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();

            Console.Write("What do you do? ");
            char op = char.Parse(Console.ReadLine());
            return op;
        }
    }
}
