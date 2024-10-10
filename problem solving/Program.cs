using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace problem_solving
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));

        }
        public static string BreakCamelCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    str.Replace();
                }
            }
            return str;
        }

        //static void ExcuteQueueExample()
        //{
        //    var queue = new Queue<string>();
        //    while (true)
        //    {
        //        Console.Write("Enter A line : ");
        //        var input = Console.ReadLine();
        //        if (input.Equals("print", StringComparison.OrdinalIgnoreCase))
        //        {
        //            while (queue.Count>0) 
        //            {
        //                Console.WriteLine(queue.Dequeue());

        //            }
        //            break;
        //        }
        //        else
        //        {
        //            queue.Enqueue(input);
        //        }
        //        int x = 0;
        //        string[] b ;
        //        b.
        //    }
        //}
        //static void ExcuteStackExample()
        //{
        //    var commandStack = new Stack<AppendTextCommand>();
        //    var ReDoStack = new Stack<AppendTextCommand>();
        //    var orignalText = "";
        //    while (true)
        //    {
        //        Console.Write("Type text to append('exit' to exit, 'undo' to Undo, 'redo' to Redo : ");
        //        var input = Console.ReadLine();
        //        if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        //        {
        //            break;
        //        }
        //        else if (input.Equals("undo", StringComparison.OrdinalIgnoreCase))
        //        {
        //            if (commandStack.Count > 0)
        //            {
        //                var command = commandStack.Pop();
        //                orignalText = command.UnDo();
        //            }
        //        }
        //        else if (input.Equals("redo", StringComparison.OrdinalIgnoreCase))
        //        {
        //            var command = ReDoStack.Pop();
        //            orignalText = command.ReDo();
        //        }
        //        else
        //        {
        //            var command = new AppendTextCommand(orignalText, input);
        //            orignalText = command.Excute();
        //            commandStack.Push(command);
        //        }
        //    }
        //}
        //class AppendTextCommand
        //{
        //    private string _orignalText;
        //    private readonly string _textToAppend;

        //    public AppendTextCommand(string orignalText, string textToAppend)
        //    {
        //        _textToAppend = textToAppend;
        //        _orignalText = orignalText;
        //    }

        //    public string Excute()
        //    {
        //        _orignalText += _textToAppend;
        //        Console.WriteLine(_orignalText);
        //        return _orignalText;
        //    }

        //    public string UnDo()
        //    {
        //        _orignalText = _orignalText.Substring(0, _orignalText.Length - _textToAppend.Length );
        //        Console.WriteLine(_orignalText);
        //        return _orignalText;
        //    }

        //    public string ReDo()
        //    {
        //        var re = _textToAppend;
        //        _orignalText += re;
        //        Console.WriteLine(_orignalText);
        //        return _orignalText;
        //    }
        //}
    }
}
