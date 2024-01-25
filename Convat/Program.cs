namespace Convat
{
    class Program
    {
        static void Main(string[] args)
        {
            Conmeo conmeo1 = new Conmeo("a");
            Conmeo conmeo2 = new Conmeo("b");
            Concho concho1 = new Concho("c");
            Conheo conheo1 = new Conheo("d");
            Conga conga1 = new Conga("e");
            Conga conga2 = new Conga("f");
            Convat[] convat = new Convat[] { conmeo1, conmeo2, concho1, conheo1, conga1, conga2 };
            for (int i = 0; i < convat.Length; i++) 
            {
                convat[i].Tieng();
            }
            Class1 x = new Class1(10, 20);
            Class2 y = new Class2(x);
            y.X();
        }
    }
}