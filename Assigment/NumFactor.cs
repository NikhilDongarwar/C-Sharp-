using System;
class Factor
{


    public int[] findfactors(int num1,int num2, out int count)
    {

        int[] facts = new int[40];
        // size of 10 is arbitrary 
        int i,j,c=0;

        for( i=num1 ,j=0 ;i<=num2;i++)
        {
            if(i%2==0){
                c++;
                facts[j]=i;
                j++;
            }
        }
        count=c;
        return facts;
    }
}

class FindFactors
{
    public static void Main()
    {
        Factor f = new Factor();
        int numfactors;
        int[] factors;

        factors = f.findfactors(12,40, out numfactors);

        Console.WriteLine("Even numbers are :{0} ", numfactors);
        for (int i = 0; i <numfactors; i++)

            Console.Write(factors[i] + " ");

        Console.WriteLine();
    }
}
