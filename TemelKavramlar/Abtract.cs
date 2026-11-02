namespace TemelKavramlar;

public class Abtract // Soyutlma 
{

    abstract class Sekil
    {
        public abstract double AlanHesapla();
    }

    class Kare : Sekil
    {
        public double kenar;

        public Kare(double kenar)
        {
            this.kenar = kenar;
        }
        
        
        
        
        
        
        public override double AlanHesapla()
        {
            return kenar*kenar;
            
        }

    }
    
    
    
    
    public static void Calistir()
    {
        Sekil kare = new Kare(8);
        kare.AlanHesapla();
        Console.WriteLine(kare.AlanHesapla());

    }
}

// dikdörtgen ,üçgen ,daire ,yamuk ,dik üçgen ,5 gen ,6 gen bunlardan ikisnin alan hesplamını yapacaksınız abstract kullanarak