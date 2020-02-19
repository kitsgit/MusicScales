using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicScales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Major\n2.Minor");
            Console.WriteLine("Enter the scale : ");
            int scale = int.Parse(Console.ReadLine());
            string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            int size = 12;
            int[] seq = new int[7];
            switch (scale)
            {
                case 1:
                    int[] major = { 2, 2, 1, 2, 2, 2, 1 };
                    seq = major;
                    break;
                case 2:
                    int[] minor = { 2, 1, 2, 2, 2, 2, 1 };
                    seq = minor;
                    break;
            }
            Console.WriteLine("Enter the note : ");
            string n = Console.ReadLine();
            Console.WriteLine("The scales is : ");
            int position = Array.IndexOf(notes, n);
            for(int i = 0;i<7;i++)
            {
                Console.Write(notes[position%size]+" ");
                position += seq[i];
            }
            Console.ReadLine();

        }
    }
}
