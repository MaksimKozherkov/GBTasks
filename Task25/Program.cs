using static System.Console;

Clear();

int[] array = InitArray();



int[] InitArray()
{
    int[] res=new int[8];
    for (int i = 0; i < res.Length; i++)
    {
        Random  ran = new Random();
        res[i] = ran.Next(100);
        Write("{0} ", res[i]);
        
    }
    return res;
    
    
}



