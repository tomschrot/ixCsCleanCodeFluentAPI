public static partial class Extensions
{
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
