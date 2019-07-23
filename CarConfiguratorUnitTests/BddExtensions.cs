using System;

namespace BddExtensions
{
    public static class Core
    {
        public static T Act<T>(this T value, Action<T> action)
        {
            action(value);
            return value;
        }

        public static TOut Map<TIn, TOut>(this TIn value, Func<TIn, TOut> f) => f(value);

        public static T Given<T>(T value) => value;
        public static T Given<T>(Func<T> factory) => factory();
        public static T When<T>(this T t, Action<T> a) => t.Act(a);
        public static TOut When<TIn, TOut>(this TIn t, Func<TIn, TOut> a) => t.Map(a);
        public static T That<T>(this T t, Action<T> a) => t.Act(a);
        public static T Then<T>(this T t, Action<T> a) => t.Act(a);
        public static T And<T>(this T t, Action<T> a) => t.Act(a);
    }
}
