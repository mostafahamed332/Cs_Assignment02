namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter your Number");
            string number = Console.ReadLine();
            Console.WriteLine("Your Number is " + number);

            #endregion

            #region Q02
            Console.WriteLine("Enter Your Age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Age is " + Age);

            #endregion

            #region Q3
            int x = 12;
            float y = 10.5f;
            Console.WriteLine(x + y);
            #endregion

            #region Q4
            string Name01 = "Mostafa";
            string SubName = Name01.Substring(2);
            Console.WriteLine(SubName);
            #endregion

            #region Q5

            int O = 15;
            int P = O + 10;
            Console.WriteLine(P);
            #endregion

            #region Q6
            double Q = 10.7;
            int W = (int)Q + 10;
            Console.WriteLine(W);

            #endregion

            #region Q7
            string N1 = "Mostafa";
            string N2 = " Hamed";
            string N3 = N1 + N2;
            Console.WriteLine(N3);
            #endregion

            #region Q8
            Console.WriteLine("A value 1 will be assigned to d");
            #endregion

            #region Q9
            Console.WriteLine("a) 6.5 1");
            #endregion

            #region Q10
            Console.WriteLine("7 7");
            #endregion
        }
    }
}
