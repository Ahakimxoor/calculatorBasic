using System;

public class Xisaabiye
{
    // Main Method
    public static void Main(string[] args)
    {
        Console.WriteLine("Ku soo dhowow Xisaabiyaha Fudud!");
        DooroHowl();
    }

    // Method-ka DooroHowl
    public static void DooroHowl()
    {
        Console.WriteLine("Fadlan dooro howl:");
        Console.WriteLine("1. Isku Dar");
        Console.WriteLine("2. Kala Go'");
        Console.WriteLine("3. Isku Dhufasho");
        Console.WriteLine("4. Qeybin");

        int dooro = Convert.ToInt32(Console.ReadLine());

        switch (dooro)
        {
            case 1:
                IskuDar();
                break;
            case 2:
                KalaGo();
                break;
            case 3:
                IskuDhufasho();
                break;
            case 4:
                Qeybin();
                break;
            default:
                Console.WriteLine("Doorasho aan sax ahayn, isku day mar kale.");
                DooroHowl();
                break;
        }
    }

    // Method-ka IskuDar
    public static void IskuDar()
    {
        Console.WriteLine("Gali tirada koowaad:");
        double tirada1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Gali tirada labaad:");
        double tirada2 = Convert.ToDouble(Console.ReadLine());

        double natiijo = tirada1 + tirada2;
        Console.WriteLine("Natiijada Isku-Darka: " + natiijo);
    }

    // Method-ka KalaGo
    public static void KalaGo()
    {
        Console.WriteLine("Gali tirada koowaad:");
        double tirada1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Gali tirada labaad:");
        double tirada2 = Convert.ToDouble(Console.ReadLine());

        double natiijo = tirada1 - tirada2;
        Console.WriteLine("Natiijada Kala-Go'a: " + natiijo);
    }

    // Method-ka IskuDhufasho
    public static void IskuDhufasho()
    {
        Console.WriteLine("Gali tirada koowaad:");
        double tirada1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Gali tirada labaad:");
        double tirada2 = Convert.ToDouble(Console.ReadLine());

        double natiijo = tirada1 * tirada2;
        Console.WriteLine("Natiijada Isku-Dhufashada: " + natiijo);
    }

    // Method-ka Qeybin
    public static void Qeybin()
    {
        Console.WriteLine("Gali tirada koowaad:");
        double tirada1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Gali tirada labaad:");
        double tirada2 = Convert.ToDouble(Console.ReadLine());

        if (tirada2 != 0)
        {
            double natiijo = tirada1 / tirada2;
            Console.WriteLine("Natiijada Qeybinta: " + natiijo);
        }
        else
        {
            Console.WriteLine("Tirada labaad ma noqon karto eber. Fadlan isku day mar kale.");
            Qeybin();
        }
    }
}
