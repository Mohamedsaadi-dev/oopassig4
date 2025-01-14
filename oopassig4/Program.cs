namespace oopassig4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Calculator calculator = new Calculator();

            Console.WriteLine("Sum of two integers: " + calculator.Add(5, 10));
            Console.WriteLine("Sum of three integers: " + calculator.Add(5, 10, 15));
            Console.WriteLine("Sum of two doubles: " + calculator.Add(5.5, 10.5));
            #endregion
            #region Q2
            Rectangle rect1 = new Rectangle();
            Console.WriteLine($"Rectangle 1: Width = {rect1.Width}, Height = {rect1.Height}");

            Rectangle rect2 = new Rectangle(10, 20);
            Console.WriteLine($"Rectangle 2: Width = {rect2.Width}, Height = {rect2.Height}");

            Rectangle rect3 = new Rectangle(15);
            Console.WriteLine($"Rectangle 3: Width = {rect3.Width}, Height = {rect3.Height}");
            #endregion
            #region Q3
           
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

            ComplexNumber sum = c1 + c2;
            Console.WriteLine($"Sum: {sum}");

            ComplexNumber difference = c1 - c2;
            Console.WriteLine($"Difference: {difference}");
            #endregion
            #region Q4
            Employee employee = new Employee();
            employee.Work();
            Manager manager = new Manager();
            manager.Work();
            #endregion
            #region Q5
            BaseClass baseObj = new BaseClass();
            baseObj.DisplayMessage(); 

            BaseClass derived1Obj = new DerivedClass1();
            derived1Obj.DisplayMessage(); 

            BaseClass derived2Obj = new DerivedClass2();
            derived2Obj.DisplayMessage(); 
            DerivedClass2 specificDerived2Obj = new DerivedClass2();
            specificDerived2Obj.DisplayMessage();
            #endregion
            #region part2 Q1
            Duration duration1 = new Duration();
            duration1.Display();

            Duration duration2 = new Duration(2, 45, 30);
            duration2.Display();
            #endregion
            #region part2 Q2
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            #endregion
            #region part2 Q3
            Duration duration1 = new Duration(2, 45, 30);
            Duration duration2 = new Duration(2, 45, 30);
            Duration duration3 = new Duration(1, 15, 10);

            Console.WriteLine("Duration 1: " + duration1);
            Console.WriteLine("Duration 2: " + duration2);
            Console.WriteLine("Duration 3: " + duration3);
            Console.WriteLine("Duration1 equals Duration2: " + duration1.Equals(duration2));
            Console.WriteLine("Duration1 equals Duration3: " + duration1.Equals(duration3));
            Console.WriteLine("Duration1 HashCode: " + duration1.GetHashCode());
            Console.WriteLine("Duration2 HashCode: " + duration2.GetHashCode());
            Console.WriteLine("Duration3 HashCode: " + duration3.GetHashCode());
            #endregion
            


        }
    }
}
