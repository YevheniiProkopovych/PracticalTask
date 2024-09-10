using LHHP_COAC_Practical_Task.Attributes;
using System.Reflection;

namespace LHHP_COAC_Practical_Task.Helpers
{
    public static class EnumFieldAttributeHelpers
    {
        /// <summary>
        /// Takes a value from Enum attribute if exists.
        /// </summary>
        /// <param name="positionAttribute">Reffer to specific element of enum</param>
        /// <returns></returns>
        /// <example>
        /// [EnumField(5)]
        /// EnumValue
        /// <code>
        /// int n = EnumValue.GetValueFromAttribute(); // result: 5
        /// </code>
        /// </example>

        public static int GetValueFromAttribute(this Enum positionAttribute)
        {
            var field = positionAttribute.GetType().GetField(positionAttribute.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(EnumFieldAttribute)) as EnumFieldAttribute;

            return attribute == null ? 0 : attribute.Field;
        }
    }
}
