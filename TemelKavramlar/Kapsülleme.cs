namespace TemelKavramlar;

public class Kapsülleme // Encapsulation 

{           // bizden ad soyad tc istneiyor sadece biri public 
    public  string Ad;
    private string Soyad;
    private string Tc;
    private int Yas;


    public string soyad
    {
        get{return Soyad;}
        set { Soyad = value; }
    }

    public int yas
    {
        get { return Yas; }
        set
        {
            if (value > 0) 
                yas = value;
            else
                Console.Write("Yaş 0 dan küçük olmaz ");
        }
        
    }



    public static void Calistir()
    {
        Kapsülleme nesne = new Kapsülleme();

        nesne.Ad = "Muhammed";
        nesne.Soyad = "İnanç";
        nesne.Yas = 89;
        
        Console.WriteLine($"AD: {nesne.Ad},Soyad : {nesne.Soyad},Yas : {nesne.yas}");
    }
    
    
    
    
    
    // sizin özellikleriniz 
    // ad,soyad ,yaş,mesleğiniz ,okulunuz ,ID 
    // string string  int string string string 
    
    
    
    
    
    
    
    
    
    
    
    
}