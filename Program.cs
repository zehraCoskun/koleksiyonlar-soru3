using System.Collections;

internal class Program
{
    //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
    private static void Main(string[] args)
    {
        Console.WriteLine("bir cümle giriniz");
        string cumle = Console.ReadLine();
        string sesli ="aeıioöuü";
        ArrayList sesliHarfler = new ArrayList();
        int sayac =0;
        for (int i = 0; i < cumle.Length; i++)
        {
            sayac++;
            if (sesli.Contains(cumle[i]))
            {
                sesliHarfler.Add(cumle[i]);
            }
        }
        sesliHarfler.Sort();
        foreach (var item in sesliHarfler)
        {
           Console.WriteLine(item);
        }
        




    }
}