/*string BinarySystem(int num){
    string result = string.Empty;
    if (num > 0)
        return BinarySystem(num /2) + num %2 + result;
    if (num < 0)
    
        return BinarySystem(num * -1);
    else
    
        return result;
}
Console.Write("Enter your number ");
int num = Convert.ToInt32(Console.ReadLine());
string binar = BinarySystem(num);
Console.WriteLine(binar);*/

/*int SumNumber(int m, int n){
    if(m == n) return m;
    if(m > n && m> 0 && n>0)
        return n + SumNumber(m, n +1);
    if(n > m )
        return n + SumNumber(m, n-1);
    else
        return 0;
}
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(m, n);
Console.WriteLine(result);*/
