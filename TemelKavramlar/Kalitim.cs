namespace TemelKavramlar;

public class Kalitim //Inheritance 
{       // Bu örnektde araba kalıtım örneği yapılcak    // BU ÜST SINIF BABA diylim 
   
    
    public string marka;
    public int modelYil;
    

    public void AracBilgiYazdir()
    {
        Console.WriteLine($"Marka :{marka},Model Yılı :{modelYil}");
        
    }

    class  Araba :Kalitim// bu alt sınıf Çocuk 
    {
        public int KapiSayisi;
        public int TekerlekSayisi;
      
    }
    
    
    
    
    
    

    public static void Calistir()
    {
        Araba araba = new Araba()// new gör nesne yi öp 
        {marka ="Opel İnsignia ",
        modelYil=2022,
        TekerlekSayisi=5,
        KapiSayisi=4

        };
            
        araba.AracBilgiYazdir();
        Console.WriteLine(araba.KapiSayisi);
        Console.WriteLine(araba.TekerlekSayisi); // yedek lastik saydık
        Console.ReadKey();

    }
    

 
}
