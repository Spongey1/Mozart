using System;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

            Random r = new Random();
            int terningM1 = r.Next(1, 88);
            int terningM2 = r.Next(1, 88);
            int terningT1 = r.Next(1, 96);
            string[] Mfiler = new string[2];
            string[] Tfiler = new string[1];

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Mfiler[i] = @"C:\Users\drito\Desktop\Mozart\M" + (terningM1) + ".wav";
                    Tfiler[i] = @"C:\Users\drito\Desktop\Mozart\T" + (terningT1) + ".wav";
                }
                else
                {
                    Mfiler[i] = @"C:\Users\drito\Desktop\Mozart\M" + (terningM2) + ".wav";
                }
            }

            foreach (string musicelement in Mfiler) // M Filer
            {
                Console.ReadKey();

                sp.SoundLocation = musicelement;

                sp.Load();

                sp.PlaySync();
            }

            foreach (string musicelement in Tfiler) // T Filer
            {
                Console.ReadKey();

                sp.SoundLocation = musicelement;

                sp.Load();

                sp.PlaySync();
            }
        }
    }
}
