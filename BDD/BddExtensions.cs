using System;

namespace BDD
{
    public static class BddExtensions
    {
        public static T Do<T>(this T value, Action<T> action)
        {
            action(value);
            return value;
        }


        public static T Given<T>(T value) => value;
        public static T When<T>(this T t, Action<T> a) => t.Do(a);
        public static T AndWhen<T>(this T t, Action<T> a) => t.Do(a);
        public static T Then<T>(this T t, Action<T> a) => t.Do(a);
    }
}
