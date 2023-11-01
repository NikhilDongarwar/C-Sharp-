using System;  // The first delegate example rewritten to use // statement lambdas. 
// Declare a delegate type.  
delegate string StrMod(string s);
class UseStatementLambdas
{    
       static void Main()
    {    

         string str;


        StrMod strOp = s=>{return s.Replace(' ','_');};
        str = strOp("This is a test.");

        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = s=>{string temp = "";
            int i;
           Console.WriteLine("Removing spaces.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
           return temp;
        };      
        str = strOp("This is a test.");

        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = s=>{string temp = "";
            int i, j;
           Console.WriteLine("Reversing string.");
            for (i = s.Length - 1; i >= 0; i--)
                temp += s[i];

            return temp;
        };
        str = strOp("This is a test.");

        Console.WriteLine("Resulting string: " + str);
    }
}

        

