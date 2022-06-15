using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int suma(int a, int b)
        {
            return a + b;
        }
        public string fibo(int n)
        {
            string cad = "";
            int a = 0;
            int b = 1;
            int c = 1;
            if (n == 1){
                return a + "";
            }
            else{
                if (n == 2){
                    return a + "-" + b;
                }else{
                    if (n == 3){
                        return a + "-" + b + "-" + c;
                    }else{
                        cad = a + "-" + b + "-" + c;
                        for (int i = 0; i < n - 3; i++)
                        {
                            int total = a+b+c;
                            a = b;
                            b = c;
                            c = total;
                            cad = cad + "-" + total;
                        }
                        return cad;
                    }
                }
            }
        }
        public int fiboRec(int n)
        {
            if (n == 1){
                return 0;
            }
            else{
                if (n == 2){
                    return 1;
                }
                else{
                    if (n == 3){
                        return 1;
                    }else{
                        return fiboRec(n - 1) + fiboRec(n - 2) + fiboRec(n-3);
                    }
                }
            }
        }
        public string final(int n)
        {
            string cad = "";
            int i=0;
                while(i<n){
                    cad = cad + fiboRec(i);
                    i++;
                }
            
            return cad;
        }
    }
}
