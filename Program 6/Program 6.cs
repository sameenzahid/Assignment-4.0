using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            // execute each block seperately

            
            int n = 22/8;
            Console.WriteLine(n); 

        
            int n = 99/8 + 21/11*7;
            Console.WriteLine(n); 

            
            double a = 4, b=3 , p=8 , q=2;
            double n = q/a-p/b;
            Console.WriteLine(n); 

            
            int a=6,b=3,p=8,q=2;
            Console.WriteLine(n); 

        
            int a=Convert.ToInt32(3.3);
            int b= a=Convert.ToInt32(2.7);
            int p= a=Convert.ToInt32(8.7);
            int q= a=Convert.ToInt32(5.4);
            double n =p/b + q/a;
            Console.WriteLine(n); 

        
            int n = 11+7/4+98%6*3;
            Console.WriteLine(n);

        
            int n = 11/31%8*5-12;
            Console.WriteLine(n); 

        
            double p=8.0;
            int q=5;
            int n = Convert.ToInt32(q*p + 3*p*p - (q%3)*p*p*p);
            Console.WriteLine(n); 

    
            double p=5;
            int q = 9;
            int n =Convert.ToInt32((q%2)*p+6.0*p*(q%3)+(q%4)*p*p*p);
            Console.WriteLine(n); 

    
            int n=3, a=6, b=2;
            n*=a+b;
            a--;
            n%=a;
            Console.WriteLine(n); 

        
            int a, n=5;
            ++n;
            a = --n;
            n= n-a;
            Console.WriteLine(n); 

        }
    }
}
