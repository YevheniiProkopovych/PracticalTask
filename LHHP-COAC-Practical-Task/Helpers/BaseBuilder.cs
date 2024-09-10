namespace LHHP_COAC_Practical_Task.Helpers
{
    public class BaseBuilder<T>
        where T : new()
    {
        protected T Entity { get; set; }

        public BaseBuilder()
        {
            Entity = new T();
        }

        public T Build()
        {
            return Entity;
        }
    }
}
