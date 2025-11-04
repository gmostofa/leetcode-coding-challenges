namespace DefaultNamespace;


public int FindComplement(int num)
{
    int mask = (1 << (int)Math.Floor(Math.Log(num, 2)) + 1) - 1;
    return num ^ mask;
}
