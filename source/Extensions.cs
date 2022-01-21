using System.Runtime.CompilerServices;
public static partial class Extensions
{
    //-------------------------------------------------------------------------
    public const MethodImplOptions
        NONE        = 0,
        INLINE      = MethodImplOptions.AggressiveInlining,
        OPTIMIZE    = MethodImplOptions.AggressiveOptimization,
        ALL         = INLINE | OPTIMIZE
        ;
    //-------------------------------------------------------------------------
    public static bool IsValid (this string value) => !String.IsNullOrEmpty (value);
    //-------------------------------------------------------------------------
    public static T[] @each <T> (this T[] array, Action<T> treat)
    {
        for (int n = 0; n < array.Length; n++)
            treat (array[n]);

        return array;
    }
    //-------------------------------------------------------------------------
}
