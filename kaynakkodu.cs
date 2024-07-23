using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.String
{
    public static class Arrays<C>
    {
        public static C[] ToArray(C arr)
        {
            C[] ar = new C[1];
            ar[1] = arr;
            return ar;
        }
      
    }
    public static class extension
    {
        public static int MostLong(this string[] arr)
        {
            int a = 0;
            foreach (var item in arr)
            {
                if (item.Length > a) a = item.Length;
            }
            return a;
        }
        public static int MostLong(this List<string> arr)
        {
            int a = 0;
            foreach (var item in arr)
            {
                if (item.Length > a) a = item.Length;
            }
            return a;
        }
        public static string LU = "╭";
        public static string LD = "╰";
        public static string RU = "╮";
        public static string RD = "╯";
        public static string S = "│";
        public static string SR = "─";
        
        public static string Center(this string text)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), Console.WindowHeight / 2);
            return text;
        }
        public static string AddLeft(this string text, string value)
        {
            return value + text;
        }
        public static string AddRight(this string text, string value)
        {
            return text + value;
        }
        public static void Write(this char value, int len)
        {
            Console.Write(new string(value, len));
        }
        public static void WriteLine(this char value, int len)
        {
            Console.WriteLine(new string(value, len));
        }
        public static void Write(this string value, string rgb,int len)
        {
            for (int i = 0; i < len; i++)
            {
                value.WriteFore(rgb);
            }
        }
        public static void WriteLine(this string value, string rgb, int len)
        {
            for(int i = 0; i < len;i++)
            {
                value.WriteLineFore(rgb);
            }
        }
        public static string input(string text, bool password, int len)
        {
            string input_stream = "";
            Console.Write(text);
            while (true)
            {
                ConsoleKeyInfo keys = Console.ReadKey(intercept: true);
                char key = keys.KeyChar;

                if (key == '\r')
                {
                    return input_stream;
                }
                else if (key == '\b')
                {
                    if (input_stream.Length > 0)
                    {
                        Console.Write("\b \b");
                        input_stream = input_stream.Substring(0, input_stream.Length - 1);
                    }
                }
                else
                {

                    if (keys.Key == ConsoleKey.RightArrow || keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    }
                    else if (keys.Key != ConsoleKey.Tab)
                    {
                        if (input_stream.Length < len)
                        {
                            input_stream += key;
                            if (password is true) Console.Write('*');
                            else Console.Write(key);
                        }
                    }
                }
            }
        }
        public static string input(string text, string rgb, bool password, bool command)
        {
            string input_stream = "";
            WriteFore(rgb, text);
            while (true)
            {
                ConsoleKeyInfo keys = Console.ReadKey(intercept: true);
                char key = keys.KeyChar;

                if (key == '\r')
                {
                    return input_stream;
                }
                else if (key == '\b')
                {
                    if (input_stream.Length > 0)
                    {
                        Console.Write("\b \b");
                        input_stream = input_stream.Substring(0, input_stream.Length - 1);
                    }
                }
                else
                {

                    if (keys.Key == ConsoleKey.RightArrow || keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    }
                    else if (keys.Key != ConsoleKey.Tab)
                    {
                        input_stream += key;
                        if (password is true) Console.Write('*');
                        else if (password is false && command is true && !input_stream.Contains(" "))
                        {
                            WriteFore("255,255,0", key.ToString());
                        }
                        else WriteFore("108,108,108", key.ToString());
                    }
                }
            }
        }
        public static string input(string text, bool password)
        {
            string input_stream = "";
            Console.Write(text);
            while (true)
            {
                ConsoleKeyInfo keys = Console.ReadKey(intercept: true);
                char key = keys.KeyChar;

                if (key == '\r')
                {
                    return input_stream;
                }
                else if (key == '\b')
                {
                    if (input_stream.Length > 0)
                    {
                        Console.Write("\b \b");
                        input_stream = input_stream.Substring(0, input_stream.Length - 1);
                    }
                }
                else
                {

                    if (keys.Key == ConsoleKey.RightArrow || keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    }
                    else if (keys.Key != ConsoleKey.Tab)
                    {
                        input_stream += key;
                        if (password is true) Console.Write('*');
                        else Console.Write(key);
                    }
                }
            }
        }
        public static string input(string text, string rgb, bool password)
        {
            string input_stream = "";
            WriteFore(rgb, text);
            while (true)
            {
                ConsoleKeyInfo keys = Console.ReadKey(intercept: true);
                char key = keys.KeyChar;

                if (key == '\r')
                {
                    return input_stream;
                }
                else if (key == '\b')
                {
                    if (input_stream.Length > 0)
                    {
                        Console.Write("\b \b");
                        input_stream = input_stream.Substring(0, input_stream.Length - 1);
                    }
                }
                else
                {
                    if (keys.Key == ConsoleKey.RightArrow || keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    }
                    else if (keys.Key != ConsoleKey.Tab)
                    {
                        input_stream += key;
                        if (password is true) Console.Write('*');
                        else Console.Write(key);
                    }
                }
            }
        }
        public static string Reverse(this string text)
        {
            char[] h = text.StringToCharArray();
            return h.Reverse().CharArrayToString();
        }
        public static string Bold(this string text)
        {
            return $"\u001b[1m{text}\u001b[0m";
        }

        public static string Faint(this string text)
        {
            return $"\u001b[2m{text}\u001b[0m";
        }

        public static string Italic(this string text)
        {
            return $"\u001b[3m{text}\u001b[0m";
        }

        public static string Underline(this string text)
        {
            return $"\u001b[4m{text}\u001b[0m";
        }

        public static string Blink(this string text)
        {
            return $"\u001b[5m{text}\u001b[0m";
        }

        public static string RapidBlink(this string text)
        {
            return $"\u001b[6m{text}\u001b[0m";
        }

        public static string Inverse(this string text)
        {
            return $"\u001b[7m{text}\u001b[0m";
        }

        public static string Conceal(this string text)
        {
            return $"\u001b[8m{text}\u001b[0m";
        }

        public static string Strikethrough(this string text)
        {
            return $"\u001b[9m{text}\u001b[0m";
        }
        public static string Position(this string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return text;
        }
        public static void WriteFore<T>(this T text, string rgb)
        {
            int[] rgbval = new int[3];
            int f = 0;
            foreach (int a in SolveRgb(rgb))
            {
                rgbval[f] = a;
                f++;
            }
            Console.Write($"\x1b[38;2;{rgbval[0]};{rgbval[1]};{rgbval[2]}m{text}\x1b[0m");
        }
        public static void WriteLineFore<T>(this T text, string rgb)
        {
            int[] rgbval = new int[3];
            int f = 0;
            foreach (int a in SolveRgb(rgb))
            {
                rgbval[f] = a;
                f++;
            }
            Console.WriteLine($"\x1b[38;2;{rgbval[0]};{rgbval[1]};{rgbval[2]}m{text}\x1b[0m");
        }
        public static void WriteForeBackGround<T>(this T text, string rgb, string rgbb)
        {
            int[] rgbval = new int[3];
            int f = 0;
            foreach (int a in SolveRgb(rgb))
            {
                rgbval[f] = a;
                f++;
            }
            int[] rgbvalf = new int[3];
            int ff = 0;
            foreach (int a in SolveRgb(rgbb))
            {
                rgbvalf[ff] = a;
                ff++;
            }
            string bg = ($"\x1b[48;2;{rgbval[0]};{rgbval[1]};{rgbval[2]}m{text}\x1b[0m");
            Console.Write($"\x1b[38;2;{rgbvalf[0]};{rgbvalf[1]};{rgbvalf[2]}m{bg}\x1b[0m");
        }
        public static void WriteLineForeBackGround<T>(this T text, string rgb, string rgbb)
        {
            int[] rgbval = new int[3];
            int f = 0;
            foreach (int a in SolveRgb(rgb))
            {
                rgbval[f] = a;
                f++;
            }
            int[] rgbvalf = new int[3];
            int ff = 0;
            foreach (int a in SolveRgb(rgbb))
            {
                rgbvalf[ff] = a;
                ff++;
            }
            string bg = ($"\x1b[38;2;{rgbval[0]};{rgbval[1]};{rgbval[2]}m{text}\x1b[0m");
            Console.WriteLine($"\x1b[48;2;{rgbvalf[0]};{rgbvalf[1]};{rgbvalf[2]}m{bg}\x1b[0m");
        }
        private static IEnumerable<int> SolveRgb(string rgb)
        {
            string[] rgb_handle = rgb.Split(',');
            for (int i = 0; i < rgb_handle.Length; i++)
            {
                yield return int.Parse(rgb_handle[i].Trim());
            }
        }
        public static string n
        {
            get { return "\n"; }
            private set { }
        }
        public static string t
        {
            get { return "\t"; }
            private set { }
        }
        public static string ArrayJoin<T>(this T[] arr, string value)
        {
            string handle = null;
            for (int i = 0; i < arr.Length; i++)
            {
                handle += arr[i];
                if (i + 1 != arr.Length)
                {
                    handle += value;
                }
            }
            return handle;
        }
        public static int Count(this string text, char value)
        {
            if (!text.Contains(value)) return -1;
            else
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == value)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public static string[] Divide(this string text, char value)
        {
            if (!text.Contains(value)) return null;
            else
            {
                string[] handle = new string[Count(text, value)];
                string handstr = null;
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != value)
                    {
                        handstr += text[i];
                    }
                    else
                    {
                        handle[count] = handstr;
                        count++;
                        handstr = null;
                    }
                }
                return handle;
            }

        }
        public static char[] StringToCharArray(this string arr)
        {
            char[] chr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                chr[i] = arr[i];
            }
            return chr;
        }
        public static string[] Reverse(this string[] arr)
        {
            int h = 0;
            string[] reversed = new string[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--, h++)
            {
                reversed[h] = arr[i];
            }
            return reversed;
        }
        public static char[] Reverse(this char[] arr)
        {
            int h = 0;
            char[] reversed = new char[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--, h++)
            {
                reversed[h] = arr[i];
            }
            return reversed;
        }
        public static int[] Reverse(this int[] arr)
        {
            int h = 0;
            int[] reversed = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--, h++)
            {
                reversed[h] = arr[i];
            }
            return reversed;
        }
        public static string CharArrayToString(this char[] arr)
        {
            string text = null;
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
            }
            return text;
        }
        public static string MakeString(this object obj)
        {
            return obj.ToString();
        }
        public static bool Same(string text1, string text2)
        {
            if (text1 == text2)
            {
                return true;
            }
            else return false;
        }
        public static int FirstIndexChar(this string text, char value)
        {
            if (!text.Contains(value)) return -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == value) return i;
            }
            return -1;
        }
        public static int LastIndexChar(this string text, char value)
        {
            if (!text.Contains(value)) return -1;
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == value) index = i;
            }
            return index;
        }
        public static string Get(this string text, int start, int end)
        {
            return text.Substring(start, end - start);
        }
        public static int Lenght(this string text)
        {
            return text.Length;
        }
        public static void NewLine()
        {
            Console.Write("\n");
        }
        public static string Input()
        {
            return Console.ReadLine();
        }
        public static void Write<T>(this T text)
        {
            Console.Write(text);
        }
        public static void WriteLine<T>(this T text)
        {
            Console.WriteLine(text);
        }
        public static void Write<T>(this T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        public static void WriteType<T>(this T obj)
        {
            Console.Write(obj.GetType());
        }
        public static bool NullorWhiteSpace(this string text)
        {
            if (text == null) return true;
            else
            {
                int handle = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != ' ')
                    {
                        handle++;
                    }
                }
                if (handle > 0)
                {
                    return false;
                }
                else return true;
            }
        }
        public static string MarginLeft(this string text, int size)
        {
            return new string(' ', size) + text;
        }
        public static string MarginRights(this string text, int size)
        {
            return text + new string(' ', size);
        }
        public static void WriteLine<T>(this T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    public class Repo<C> : IEnumerable<C>
    {       
        private C[] array = new C[0];

        public C this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    Array.Resize(ref array, index + 1);
                    array[index] = value;
                }
            }
        }     
        public void Add(C value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }
        public static Repo<C> operator +(Repo<C> builder, C value)
        {
            for (int i = 0; i < builder.array.Length; i++)
            {
                builder.array[i] = (C)(object)((dynamic)builder.array[i] + (dynamic)value);
            }
            return builder;
        }
        public static Repo<C> operator +(Repo<C> builder, (int index,char leftOrRight,C value) tuple)
        {
            int index = tuple.index;
            C value = tuple.value;

            if(tuple.leftOrRight == 'r')
            {
                if (index >= 0 && index < builder.array.Length)
                {
                    builder.array[index] = (C)(object)((dynamic)builder.array[index] + (dynamic)value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else if(tuple.leftOrRight == 'l')
            {
                if (index >= 0 && index < builder.array.Length)
                {
                    builder.array[index] = (dynamic)value + (C)(object)((dynamic)builder.array[index]);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }                   
            return builder;
        }

        public IEnumerator<C> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
