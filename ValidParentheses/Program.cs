namespace ValidParentheses
{
    public class Program
    {
        /*
         Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         */
        static void Main(string[] args)
        {
            var result = IsValid("");
            Console.WriteLine(result);
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(')');
                    continue;
                }

                if (s[i] == '{')
                {
                    stack.Push('}');
                    continue;
                }
                if (s[i] == '[')
                {
                    stack.Push(']');
                    continue;
                }

                if (stack.Count == 0 || s[i] != stack.Pop())
                {
                    return false;
                }
            }

            return stack.Count == 0;

        }
    }
}