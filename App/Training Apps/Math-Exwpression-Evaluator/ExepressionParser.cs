using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Training_Apps.Math_Exwpression_Evaluator
{
    internal static class ExepressionParser
    {
        public static MathExepression Parse(string input)
        {
            var expr=new MathExepression();
            string token = "";
            bool LeftSideIntialized = false;
            const string MathSympols = "+*/^%";
            for(var i = 0; i < input.Length; i++)
            {
                var CurrentChar = input[i];
                if(char.IsDigit(CurrentChar))
                {
                    token += CurrentChar;
                    if (i == input.Length - 1 && LeftSideIntialized)
                    {
                        expr.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if(MathSympols.Contains(CurrentChar))
                {
                    if (!LeftSideIntialized)
                    {


                        expr.LeftSideOperand = double.Parse(token);
                        LeftSideIntialized = true;
                        
                    }
                    expr.Operation = ParseMathOperation(CurrentChar.ToString());
                    token = "";
                }
                else if(CurrentChar=='-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Substraction;
                        if (!LeftSideIntialized)
                        {
                            expr.LeftSideOperand = double.Parse(token.Trim());
                            LeftSideIntialized = true;
                            token = "";
                        }
                    }
                    else 
                        token += CurrentChar;

                }
                else if(char.IsLetter(CurrentChar))
                {
                    token += CurrentChar;
                }
                else if(CurrentChar==' ')
                {
                    if (!LeftSideIntialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        LeftSideIntialized = true;
                        token = "";
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = ParseMathOperation(token);
                        token = "";
                    }
                    else 
                        token += CurrentChar;
                    
                }
                
            }
            return expr;
        }

        private static MathOperation ParseMathOperation(string operation)
        {
            switch(operation.ToLower())
            {
                case "+":
                {
                    return MathOperation.Addition;
                }
                case "*":
                    {
                        return MathOperation.Multiplication;
                    }
                case "/":
                    {
                        return MathOperation.Division;
                    }
                case "%":
                case "mod":
                    {
                        return MathOperation.Modules;
                    }
                case "^":
                case "pow":
                    {
                        return MathOperation.Power;
                    }
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                case "-":
                    return MathOperation.Substraction;
                default:
                    return MathOperation.None;
            }
        }
    }
}
