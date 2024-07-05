// See https://aka.ms/new-console-template for more information





partial class Program
{ 
    delegate int CalculateDelegate(int n1, int n2);
    public static void Main(string[] args)
    {
        int n1 = 10,n2=4;
     

        #region Use Delegate

        #region  Multicasting delegate
        Console.WriteLine("use multicasting delegate");
            CalculateDelegate dlg = Add;
            dlg += Subtract;
            dlg += Divide;
            CalculateWithDelegate(n1,n2,dlg);
         Console.WriteLine("method is done");
        #endregion

        
        CalculateWithDelegate(n1,n2,Add);
        CalculateWithDelegate(n1,n2,Divide);

        #region simple way to Use delegate method
        Console.WriteLine("use simple way to use delegate"); 
        //you can use lambda Expression
        CalculateWithDelegate(n1,n2,(n1,n2) => n1 * n2);
        // you can use anons delegate 
        CalculateWithDelegate(n1, n2, delegate(int n1, int n2) { return n1 - n2; });
        Console.WriteLine("method is done"); 
        #endregion
       
        
        static void CalculateWithDelegate(int n1,int n2,CalculateDelegate dlg)
        {
            int result = dlg(n1,n2);
            Console.WriteLine(result);
        }
        #endregion

        #region Without Delegate
        Calculate(n1,n2,'+');
        Calculate(n1,n2,'-');
        Calculate(n1,n2,'*');
        Calculate(n1,n2,'/');
        static void Calculate(int n1,int n2,char op)
        {
            int result = 0;
            if (op == '+')
                result=Add(n1: n1, n2: n2);
            else if (op == '-')
                result=  Subtract(n1, n2);
            else if (op == '*')
                result=  Multiply(n1, n2);
            else
                result=  Divide(n1, n2);
    
            Console.WriteLine(result);
        }
        #endregion
        
        static int Divide(int n1,int n2)
        {
            Console.WriteLine("Divide");
            return n1/n2;
        }
        
        static int Add(int n1,int n2)
        {
            Console.WriteLine("add");
            return n1+n2;
        }

        static int Subtract(int n1,int n2)
        {
            Console.WriteLine("subtract");
            return n1-n2;
        }

        static int Multiply(int n1,int n2)
        {
            Console.WriteLine("Multiply");
            return n1*n2;
        }
    }
} 