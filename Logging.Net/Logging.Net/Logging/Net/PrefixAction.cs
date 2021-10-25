namespace Logging.Net
{
    /// <summary>
    /// delegate to get prefix
    /// </summary>
    /// <returns>prefix</returns>
    public delegate string PrefixAction();
    /// <summary>
    /// delegate to get prefix
    /// </summary>
    /// <typeparam name="T">type of the input</typeparam>
    /// <param name="t">input required to get the prefix</param>
    /// <returns>prefix</returns>
    public delegate string PrefixAction<T>(T t);
}