using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GW2Emu.Common
{
    static public class Log
    {
        public static void Text(string name, string message, ConsoleColor Color)
        {
            string Text = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + name + " : " + message;
            Console.BufferHeight = Console.WindowWidth - 20;
            Console.ForegroundColor = Color;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Enter() 
        {
            Console.WriteLine("");
        }

        public static void Info(string name, string message)
        {
            Text(name, message, ConsoleColor.White);
        }

        public static void Success(string name, string message)
        {
            Text(name, message, ConsoleColor.Green);
        }

        public static void Notice(string name, string message)
        {
           Text(name, message, ConsoleColor.Yellow);
        }

        public static void Error(string name, string message)
        {
           Text(name, message, ConsoleColor.Red);
        }

        public static void Debug(string name, string message)
        {
            Text(name, message, ConsoleColor.Blue);
        }

        public static void Dump(string name, string message)
        {
            Text(name, message, ConsoleColor.Gray);
        }

        public static void Tcp(string name, byte[] dump, int start, int len)
        {
            Text(name, Hex(dump, start, len), ConsoleColor.Gray);
        }

        public static void Dump(string name, byte[] dump, int start, int len)
        {
            Text(name, Hex(dump, start, len), ConsoleColor.Gray);
        }

        public static void Compare(string Name, byte[] First, byte[] Second)
        {
            if (First.Length != Second.Length) Log.Error("Name", "First.Length(" + First.Length + ") != Second.Length(" + Second.Length + ")");

            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < Math.Max(First.Length, Second.Length); i += 16)
            {
                hex.Append("\n");
                bool LastDiff = false;
                for (int j = 0; j < 16; ++j)
                {
                    if (j + i < First.Length)
                    {
                        if (j + i < Second.Length)
                        {
                            if (First[j + i] != Second[j + i] && !LastDiff)
                            {
                                LastDiff = true;
                                hex.Append("[");
                            }
                            else if (First[j + i] == Second[j + i] && LastDiff)
                            {
                                LastDiff = false;
                                hex.Append("]");
                            }
                        }
                        else if (LastDiff)
                        {
                            LastDiff = false;
                            hex.Append("]");
                        }
                        byte val = First[j + i];
                        hex.Append(First[j + i].ToString("X2"));
                        if (j == 3 || j == 7 || j == 11) hex.Append("");
                    }
                    else hex.Append("  ");
                }
                if (LastDiff)
                {
                    LastDiff = false;
                    hex.Append("]");
                }
                hex.Append(" || ");
                LastDiff = false;
                for (int j = 0; j < 16; ++j)
                {
                    if (j + i < Second.Length)
                    {
                        if (j + i < First.Length)
                        {
                            if (First[j + i] != Second[j + i] && !LastDiff)
                            {
                                LastDiff = true;
                                hex.Append("[");
                            }
                            else if (First[j + i] == Second[j + i] && LastDiff)
                            {
                                LastDiff = false;
                                hex.Append("]");
                            }
                        }
                        else if (LastDiff)
                        {
                            LastDiff = false;
                            hex.Append("]");
                        }

                        byte val = Second[j + i];
                        hex.Append(Second[j + i].ToString("X2"));
                        if (j == 3 || j == 7 || j == 11) hex.Append("");
                    }
                    else
                    {
                        if (LastDiff)
                        {
                            LastDiff = false;
                            hex.Append("]");
                        }
                        hex.Append("  ");
                    }
                }
            }
            Text(Name, hex.ToString(), ConsoleColor.Gray);
        }

        public static string Hex(byte[] dump, int start, int len)
        {
            var hexDump = new StringBuilder();
            try
            {
                int end = start + len;
                for (int i = start; i < end; i += 16)
                {
                    StringBuilder text = new StringBuilder();
                    StringBuilder hex = new StringBuilder();
                    hex.Append("\n");
                    for (int j = 0; j < 16; j++)
                    {
                        if (j + i < end)
                        {
                            byte val = dump[j + i];
                            hex.Append(" ");
                            hex.Append(dump[j + i].ToString("X2"));
                            if (j == 3 || j == 7 || j == 11)
                                hex.Append(" ");
                            if (val >= 32 && val <= 127)
                            {
                                text.Append((char)val);
                            }
                            else text.Append(".");
                        }
                        else
                        {
                            hex.Append("   ");
                            text.Append("  ");
                        }
                    }
                    hex.Append("  ");
                    hex.Append("//" + text.ToString());
                    hexDump.Append(hex.ToString());
                }
            }
            catch (Exception e)
            {
                Log.Error("HexDump", e.ToString());
            }

            return hexDump.ToString();
        }
    }
}