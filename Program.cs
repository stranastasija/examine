int [] element (int length)
{
    int [] mas = new int [length];
    return mas;
}

int [] sozdanie (int [] massiv, int min, int max)
{
    int index = 0;
    while (index < massiv.Length)
    {
        massiv [index] = new Random().Next(min, max); 
        index++;
    }
    return massiv;
}

string print (int [] arr)
{
    string res = String.Empty;
    int index = 0;
    while (index < arr.Length)
    {
        int array = arr[index];
        Console.Write(array + " ");
        index++;
    }
    return res;
}


int [] A = element(8);    
sozdanie(A, -10, 10);
print (A);
