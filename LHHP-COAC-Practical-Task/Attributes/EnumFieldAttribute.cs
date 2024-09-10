namespace LHHP_COAC_Practical_Task.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumFieldAttribute : Attribute
    {
        public int Field;

        public EnumFieldAttribute(int field)
        {
            this.Field = field;
        }
    }
}
