using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Training_Apps.Math_Exwpression_Evaluator
{
    internal class App
    {
        static void Run(string[] args)
        {
            while (true)
            {
                Console.Write("Please Enter math exepression: ");
                var input = Console.ReadLine();
                var exp = ExepressionParser.Parse(input);
                Console.WriteLine($"Left side : {exp.LeftSideOperand} , Operation : {exp.Operation} , Right Side : {exp.RightSideOperand}");
                Console.WriteLine($"{input} = {EvaluateExepression(exp)}");

            }

        }

        private static object EvaluateExepression(MathExepression expr)
        {
            switch(expr.Operation)
            {
                case MathOperation.Addition:
                    return expr.LeftSideOperand + expr.RightSideOperand;
                case MathOperation.Substraction:
                    return  expr.LeftSideOperand - expr.RightSideOperand;
                case MathOperation.Multiplication:
                    return expr.LeftSideOperand * expr.RightSideOperand;
                case MathOperation.Division:
                    return expr.LeftSideOperand / expr.RightSideOperand;
                case MathOperation.Power:
                    return Math.Pow(expr.LeftSideOperand, expr.RightSideOperand);
                case MathOperation.Tan:
                    return Math.Tan(expr.RightSideOperand);
                case MathOperation.Cos:
                    return Math.Cos(expr.RightSideOperand);
                case MathOperation.Sin:
                    return Math.Sin(expr.RightSideOperand);
                case MathOperation.Modules:
                    return expr.LeftSideOperand % expr.RightSideOperand;
                default:
                    return expr;
            }
        }

        
    }
}
