namespace TemelKavramlar;

public class CokBicimlik//polyMorphisim 

{
    class Hayvan
    {
        public virtual void SesCikar() // viritual burada izin belrileyci Hayvan sınıf içineki methodu diğer sınılar ovvirede ederk değişritebilri
        {
            Console.WriteLine("Hayvan ses çıkarıyor");
            
        }
    }

    class Insan : Hayvan
    {
        public override void SesCikar()// ovvirede imzalma 
        {
            Console.WriteLine("AAAAAAAA");
        }

    }

    class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyavvvv");
        }
    }
    
    
    class Köpek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav ");
        }
    }
    
    
    
    
    public static void Calistir()
    {   Hayvan nesne = new Hayvan();
        Hayvan hayvan = new Insan();
        Hayvan hayvan1 = new Kedi();
        Hayvan hayvan2 = new Köpek();
        
        hayvan.SesCikar();
        hayvan1.SesCikar();
        hayvan2.SesCikar();
        nesne.SesCikar();

    }
    
}