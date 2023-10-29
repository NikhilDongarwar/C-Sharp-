 public int change(int i, out int c){
        int count=0,sum=0;
        while(i>0){
        int r=i%10;
        sum+=r;
        i=i/10;
        count++;
            
        }
        c=count;
        return sum; 
        
    }

}
class CallByValue
{
    public static void Main()
    {   
        

        Test ob = new Test();
        int a=int.Parse(Console.ReadLine());
        int sum=ob.change(123,out a);
        Console.WriteLine(sum+" "+a);
        

    }
}
}
