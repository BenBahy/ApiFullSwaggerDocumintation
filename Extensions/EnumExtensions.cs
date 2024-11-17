namespace ApiFullSwaggerDocumintation.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Gets a random value from the specified enum type.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <returns>A random value of the enum type.</returns>
    /// <exception cref="ArgumentException">Thrown if T is not an enum type.</exception>
    public static T GetRandom<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T));
        return (T)values.GetValue(Random.Shared.Next(values.Length))!;
    }
}
