using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Ui
{
    public static class Logger
    {
        public static void Message(string tag = null, string message = null, Exception e = null, object obj = null, [CallerFilePath] string file = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = -1)
        {
            if (!string.IsNullOrEmpty(tag)) tag = $"{tag} | ";
            if (!string.IsNullOrEmpty(message)) message = $"{message}";
            string objString = null;
            if (obj != null) objString = $"\nObject:\n{ObjectToString(obj)}";

            Debug.WriteLine($"[!!] [{DateTime.Now:O}] [{file}@{member}:{line}]\n {tag}{message}{e}{objString}");
        }

        [SuppressMessage("ReSharper", "BuiltInTypeReferenceStyle")]
        public static bool IsPrimitive(this Type t)
        {
            return t == typeof(Boolean) || t == typeof(Byte) || t == typeof(SByte) || t == typeof(Int16) ||
                   t == typeof(UInt16) || t == typeof(Int32) || t == typeof(UInt32) || t == typeof(Int64)
                   || t == typeof(UInt64) || t == typeof(IntPtr) || t == typeof(UIntPtr) || t == typeof(Char) ||
                   t == typeof(Double) || t == typeof(Single) || t == typeof(DateTime) || t == typeof(String);
            //IsPrimitive = (Boolean, Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64, IntPtr, UIntPtr, Char, Double, and Single), Anther Primitive-Like type to check(t == typeof(DateTime))
        }

        public static string ObjectToString(object obj)
        {
            if (obj == null)
                return "null";
            try
            {
                Type type = obj.GetType();
                StringBuilder sb = new StringBuilder();
                sb.Append(" Type: ");
                var primitive = type.IsPrimitive();
                if (primitive) sb.Append("Primitive: ");
                sb.Append(type.FullName).Append("\n");

                if (type.IsPrimitive())
                    sb.Append(" Value: ").Append(obj).Append("\n");
                else
                {
                    if (type.Name.StartsWith("List"))
                    {
                        foreach (var o in (IEnumerable)obj)
                        {
                            sb.Append(o).Append("\n");
                        }
                        return sb.ToString();
                    }
                    var properties = type.GetRuntimeProperties().ToList();
                    foreach (var propertyInfo in properties)
                    {
                        sb.Append(propertyInfo.Name);
                        sb.Append(": ");
                        Type propertyType = propertyInfo.PropertyType;
                        object obj2 = propertyInfo.GetValue(obj, null);
                        if (obj2 != null)
                        {
                            if (propertyType.IsArray)
                            {
                                sb.Append(string.Join(",", (string[])obj2));
                            }
                            else
                            {
                                sb.Append(obj2);
                            }
                        }
                        sb.Append("\n");
                    }
                }
                return sb.ToString();
            } catch (Exception e)
            {
                return "error: " + e.Message;
            }
        }
    }
}
}
