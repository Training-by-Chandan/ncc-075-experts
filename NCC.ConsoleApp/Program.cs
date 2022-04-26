using System;

namespace NCC.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            DataTypes();
            return;
        }

        static void DataTypes()
        {
            int i=10;
            i=20;
            
            //char => int => long => float => double 
            char c='C';
            i=c;
            long l=i;
            float f=l;
            double d=f; 

            f=(float)d;
            l=(long)f;
            i=(int)l;
            c=(char)i;

            var x=1;
            x=10;

            object o="";
            o=1;
            o=2f;

            var y=(float)o;


            var a="1";
            var b=2;
            
            object o1="";
            object o2=1;

            var str=i.ToString();
           
        }
    }
}