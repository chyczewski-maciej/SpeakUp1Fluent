using System;

namespace BddExtensions
{
    public static class Core
    {
        public static T Given<T>(T value) => value;

        public static T When<T>(this T t, Action<T> a)
        {
            a(t);
            return t;
        }

        public static T AndWhen<T>(this T t, Action<T> a) => t.When(a);


        public static T Then<T>(this T t, Action<T> a)
        {
            a(t);
            return t;
        }
    }
}
