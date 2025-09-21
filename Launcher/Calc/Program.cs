using System.Data;
using System.Diagnostics;


int processCount = 3;
bool createdNew;
using (var semaphore = new Semaphore(processCount, processCount, "Global\\MyAppSemaphore", out createdNew))
{
    if (!semaphore.WaitOne(0))
    {
        Console.WriteLine("Process limit");
        return;
    }

    try
    {
        double result = EvaluateExpression(args[0]);
        Console.WriteLine($"Result: {result}");

        static double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");
    
            if (System.Text.RegularExpressions.Regex.IsMatch(expression, @"[^0-9+\-*/().]"))
            {
                throw new ArgumentException("Error.");
            }
    
            DataTable table = new DataTable();
            var result = table.Compute(expression, null);
        
            return Convert.ToDouble(result);
        }

        Console.ReadKey();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}
