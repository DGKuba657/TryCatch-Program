namespace oop;

public class TryCatch {
    public static void Test() {
        try {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            int number2 = number * number;
            Console.WriteLine(number2);
        }
        catch (FormatException) {
            Console.WriteLine("Wrong format");
                
        }
        catch (OverflowException) {
            Console.WriteLine("Too big number");
                
        }
        finally {
            Console.WriteLine("DONE");
        }
    }
}