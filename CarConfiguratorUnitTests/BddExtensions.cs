using System;

namespace CarConfiguratorUnitTests
{
    public static class BddExtensions
    {
        public static T Do<T>(this T value, Action<T> action)
        {
            action(value);
            return value;
        }
        public static TOut Map<TIn, TOut>(this TIn value, Func<TIn, TOut> f) => f(value);


        public static T Given<T>(Func<T> factory) => factory();
        public static TOut When<TIn, TOut>(this TIn t, Func<TIn, TOut> a) => t.Map(a);
        public static T That<T>(this T t, Action<T> a) => t.Do(a);
        public static T Then<T>(this T t, Action<T> a) => t.Do(a);
        public static T And<T>(this T t, Action<T> a) => t.Do(a);
    }
}
