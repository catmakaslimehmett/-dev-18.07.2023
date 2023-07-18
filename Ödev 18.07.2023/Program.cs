internal class Program
{
    private static void Main(string[] args)
    {
        
    
        Console.WriteLine("Hesap Makinası Programı");
        Console.WriteLine("Sırası Geldiğinde İşlemi Seçiniz: [ + | - | * | / | % ] Çıkış yapmak için boş geçiniz...");
     
        
        double Sayi1, Sayi2, Sonuc=0;
        string mathOp;
        bool status = true;

        
        try
        {
            while (status)
            {
                
                Console.Write("Sayi 1: ");
                Sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sayi 2: ");
                Sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Islem: ");
                mathOp = Console.ReadLine();

                
                if (mathOp != string.Empty)
                {
                    switch (mathOp)
                    {
                        case "+":
                            Sonuc = Sayi1 + Sayi2;
                            Console.WriteLine("Toplamı: {0}", Sonuc);
                            break;
                        case "-":
                            Sonuc = Sayi1 - Sayi2;
                            Console.WriteLine("Farkı: {0}", Sonuc);
                            break;
                        case "*":
                            Sonuc = Sayi1 * Sayi2;
                            Console.WriteLine("Çarpım: {0}", Sonuc);
                            break;
                        case "/":
                            Sonuc = Sayi1 / Sayi2;
                            Console.WriteLine("Bölüm: {0}", Sonuc);
                            break;
                            case "%":
                                Sonuc =Sayi1 % Sayi2;
                            Console.WriteLine("Mod: {0}",Sonuc);
                            break;
                        default:
                            Console.WriteLine("Yanlış bir seçim yaptınız...");
                            break;
                    }

                    Console.WriteLine("Devam Mı? [True | False]");
                    status = Convert.ToBoolean(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("İşlem Yapılamadı");
                }
            }
            Console.WriteLine("Program Bitti");
        }
        catch (Exception )
        {
            Console.WriteLine("Hata Yaptınız Lütfen Tekrar Deneyiniz :");
            
                }  
    }
}