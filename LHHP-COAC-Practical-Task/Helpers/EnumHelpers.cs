namespace LHHP_COAC_Practical_Task.Helpers
{
    public static class EnumHelpers
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Takes one random value from any Enum data type.
        /// </summary>
        /// <typeparam name="T">Indicates the specific Enum data type to be passed to the method.</typeparam>
        /// <returns>One element of Enum of type provided as type</returns>
        /// <exception cref="InvalidOperationException">Throws when the given Enum passsed to the method does not contain values</exception>
        /// 

        public static T GetRandomEnumValue<T>() where T : Enum
        {
            var values = Enum.GetValues(typeof(T));

            if (values.Length == 0)
            {
                throw new InvalidOperationException($"Enum type of {typeof(T)} provided has no values.");
            }

            var value = values.GetValue(random.Next(values.Length)) ?? throw new InvalidOperationException($"Random operation for Enum type of {typeof(T)} returned null.");

            return (T)value;
        }
    }
}
