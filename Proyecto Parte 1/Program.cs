using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Proyecto_Parte_1
{
    class Program
    {
        static char[,] datos = new char[3, 3];
       

        static SerialPort Arduino = new SerialPort("COMS", 9600);

        static void Main(string[] args)
        {
            int op = 0;
            char menu = 'n';
            string linea = "";
            Arduino.Parity = Parity.None;
            Arduino.StopBits = StopBits.One;
            Arduino.DataBits = 8;
            Arduino.Handshake = Handshake.None;
            Arduino.RtsEnable = true;

            while (menu != 's')

            {
                Console.WriteLine("1.-V");
                Console.WriteLine("2.-R");
                Console.WriteLine("3.-A");


                linea = Console.ReadLine();
                op = int.Parse(linea);

                Arduino.Open();

                if (op == 1)
                {

                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("e");
                        Arduino.Write(data, 0, data.Length);
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }

                }

                else if (op == 2)
                {

                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("e");
                        Arduino.Write(data, 0, data.Length);
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }

                }

                else if (op == 3)
                {

                    if (Arduino.IsOpen)
                    {
                        Console.WriteLine("com abierto");
                        byte[] data = Encoding.ASCII.GetBytes("e");
                        Arduino.Write(data, 0, data.Length);
                    }

                    else
                    {
                        Console.WriteLine("com cerrado");
                    }

                }

            }

            Console.ReadKey();
        }

        
    } 
}
