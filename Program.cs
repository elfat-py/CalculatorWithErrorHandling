//In this exercise you will be building error handling for a simple integer calculator.
//To make matters simple, methods for calculating addition, multiplication and division are provided.

public class Calculator
{
    private int finalResult, firstNumber, secondNumber;
    private string mathOperator;
    
    public static void Main(string [] args)
    {
        Calculator calculator = new Calculator();
        Calculation calculation = new Calculation();
        
        Console.WriteLine("Enter the first number: ");
        calculator.firstNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        calculator.secondNumber = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the math operator: (+, -, *, /)");
        calculator.mathOperator = Console.ReadLine();
        
        calculator.finalResult = calculation.CalculationType(mathOperator: calculator.mathOperator, firstNumber: calculator.firstNumber, secondNumber: calculator.secondNumber);
        Console.WriteLine($"The total from the operation is: {calculator.finalResult}");
    }

    public class Calculation
    {
        public  int CalculationType(string mathOperator, int firstNumber, int secondNumber)
        {
            Calculate calculate = new Calculate();

            int result;
            //string divisionOp = "/", multiplicationOp = "*", adittionOp = "*", substration = "-";

            switch (mathOperator)
            {
                case "/":
                    Console.WriteLine($"Dividing {firstNumber} with {secondNumber}");
                    result = calculate.Division(firstNumber, secondNumber);
                    break;
                case "*":
                    Console.WriteLine($"Multipling {firstNumber} with {secondNumber}");
                    result = calculate.Multiplication(firstNumber, secondNumber);
                    break;
                case "+":
                    Console.WriteLine($"Adding {firstNumber} with {secondNumber}");
                    result = calculate.Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    Console.WriteLine($"Substracting {firstNumber} with {secondNumber}");
                    result = calculate.Substraction(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine($"The provided operator: {mathOperator} is not correct");
                    return result=-1;
                    break;
            }

            return result;
        }
    }

    public class Calculate
    {
        public int Addition(int firstNumber, int secondNumber)
        {
            int result;
            try
            {
                result = firstNumber + secondNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return result;
        }
        public int Substraction(int firstNumber, int secondNumber)
        {
            int result;
    
            try
            {
                result = firstNumber - secondNumber;
    
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return result;
        }
        public int Multiplication(int firstNumber, int secondNumber)
        {
            int result;
            try
            {
                result = firstNumber * secondNumber;
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return result;
        }
        public int Division(int firstNumber, int secondNumber)
        {
            int result;
            try
            {
                result = firstNumber / secondNumber;
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return result;
        }
    }
}