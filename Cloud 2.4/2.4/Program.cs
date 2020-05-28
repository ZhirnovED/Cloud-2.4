using System;
using System.Collections.Generic;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Stack<char> stack = new Stack<char>();
            for (; ; )
                
            {
                string text = Console.ReadLine();
                foreach (Char c in text)
                    switch (c)
                    {
                        case ')':
                            if (stack.Count == 0)
                            {

                                Console.WriteLine("Лишняя закр скобка ')'");
                                a +=  1;
                            }
                            else if (stack.Pop() != '(')
                            {
                                Console.WriteLine("Лишняя закр скобка ')'");
                                a +=  1;
                            }  
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("Лишняя закр скобка '} '");
                                a += 1;
                            }   
                            break;
                        case ']':
                            if (stack.Pop() != '[') 
                            {
                                Console.WriteLine("Лишняя закр скобка ']'");
                                a +=  1;
                            }
                            break;
                        case '[':
                        case '{':
                        case '(':
                            stack.Push(c);
                            break;
                    }
                if (stack.Count > 0)
                {
                    Console.WriteLine("Нет закрывающей скобки для " + stack.Pop());
                }
                else if ( a > 0) 
                {
                
                }
                else
                {
                    Console.WriteLine("Ошибок нету");
                }
                stack.Clear();
            }
            


        }
    }
}
