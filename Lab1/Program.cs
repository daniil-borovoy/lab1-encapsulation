namespace Lab1
{
    class Program
    {
        static void Main(String[] args)
        {
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            
            a.Add(b);
            b.Substract(a);
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            
            a.Divide(b);
            b.Multiply(a);
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Student john = new Student() { name = "John Doe", age = 19, eyeColor = "Green", gender = Gender.Man };
            Student piter = new Student() { name = "Piter Parker", age = 18, eyeColor = "Blue", gender = Gender.Man };
            
            piter.Add(john);
            
            Console.WriteLine("Name = {0}, age = {1}, eyeColor = {2}, gender = {3}", piter.name, piter.age, piter.eyeColor, piter.gender);
        }
    }
}
