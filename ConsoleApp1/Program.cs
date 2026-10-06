using System;
public static class matCalcul
{
    public static int elementplus(int n, int m)
    {
        int count = 0;
        for (int i = 1; i < n; i++)
        {
            for (int J = 1; J < m; J++)
            {


                double value = Math.Sin(i + J / 2.0);

                if (value > 0)

                {
                    count++;

                }
            }
        }
        return count;
    }
   public static void Main()
    {
        int n = 3;
        int m = 4;
        Console.WriteLine($"КОЛ-ВО ПОЛОЖИТ ЭЛЕМЕНТОВ В МАТРИЦЕ {n}*{m}:{elementplus(n, m)}");
    }



}
