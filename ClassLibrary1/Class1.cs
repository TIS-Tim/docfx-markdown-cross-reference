namespace ClassLibrary1
{
    /// <summary>
    /// Class1
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Link to Class1.f(int): <see cref="ClassLibrary1.Class1.f(int)"/>
    ///     </para>
    ///     <para>
    ///         Link to Class1.g(): <see cref="ClassLibrary1.Class1.g()"/>
    ///     </para>
    /// </remarks>
    public class Class1
    {
        /// <summary>
        /// Returns x
        /// </summary>
        /// <param name="x">Argument</param>
        /// <returns>x</returns>
        public int f(int x)
        {
            return x;
        }

        /// <summary>
        /// Returns 42
        /// </summary>
        /// <returns>42</returns>
        public int g()
        {
            return 42;
        }
    }
}