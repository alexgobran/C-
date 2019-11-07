using System;
using System.Collections.Generic;


namespace StackProject {
    class Class1 {
        static Stack<int> stack = new Stack<int>();
        static void Calculate() {
            Console.Write("Enter an op or nbr: ");
            var response = Console.ReadLine();    //Will come back as a string 
            switch (response){
                case "+":
                {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 + p1;
                    stack.Push(result);
                    break;
                }
                case "-":
                {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 - p1;
                    stack.Push(result);
                    break;
                }
                case "*":
                {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 * p1;
                    stack.Push(result);
                    break;
                }
                case "/":
                    {
                        var p1 = stack.Pop();
                        var p2 = stack.Pop();
                        var result = p2 / p1;
                        stack.Push(result);
                        break;
                    }
                case "x":
                    {
                        var answer = stack.Pop();
                        Console.WriteLine($"Answer is {answer}");
                        break;
                    }
                default:
                    {
                        var number = int.Parse(response);
                        stack.Push(number);
                        break;
                    }
            } 
        }
        static void Main(string[] args) {
            var runAgain = true;
            while (runAgain)
            {
                Calculate();
            }

        }
       
    }
}
