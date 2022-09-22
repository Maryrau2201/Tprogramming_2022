namespace CourseApp
{
    using System;

    public class Program
    {
     public static void Main(string[] args)
        {
            Town rb = new Town("Rebrovo");
            Town iv = new Town("Ivanovo", 5740, 1286);
            Town yu = new Town("Yuzgha", 6870);

            rb.Hello();
            rb.Print();
            rb.Privetstvie();

            iv.Hello();
            iv.Print();
            iv.Privetstvie();

            yu.Hello();
            yu.Print();
            yu.Privetstvie();
        }
    }
}
