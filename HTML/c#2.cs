using System.Text;
using System.Threading.Tasks;

namespace DataTypeProgramDemo
{
 class Program
 {
      static void Main(strinh[] args)
	   { 
	      byte b = 255;
		  short s = 99;
		  int n = 98;
		  long l = 565787878;
		  float f = 10.99f;
		  double d =30.99;
		  decimal n = -999.99m;
		  Console.WritLine("values of {0}, {1}, {2}, {3}, {4}, {5}, {6}",b,s,n,l,f,d,n);
		  DateTime d = DateTime.Now;
		  Console.writeLine("The current date is: {0}, d);
		  Console.writeLine("The current short date is: {0}", dd.ToShortdatestring ());
		  Console.writeLine("The current long date is: {0}", dd.ToLongdatestring ());
		  Console.writeLine("The current time is: {0}", dd.ToShortTimeString ());
		  Console.writeLine("The current long time is: {0}", dd.ToLongTimeString ());
		  Console.ReadKey();
	     }
		 public void Add(int a, int b)
		 {
			 double d = a + b;
			 Console.WriteLine("The sum of {0} and {1} = {2}", a, b, d);
		 }
		 public static double Multiply(int a, int b)
		 {
			 double d =  a * b;
			 return d;
		 }
     }   

} 