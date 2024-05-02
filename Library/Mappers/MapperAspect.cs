using System.Reflection;

namespace Library.Mappers
{
    public class MapperAspect<TEntity, TModel> where TModel : new()
    {
        public TOut Map<TIn, TOut>(TIn input)
        {
            TOut output = Activator.CreateInstance<TOut>();
            PropertyInfo[] inputProperties = typeof(TIn).GetProperties();
            PropertyInfo[] outputProperties = typeof(TOut).GetProperties();

            foreach (PropertyInfo inputProperty in inputProperties)
            {
                PropertyInfo outputProperty = Array.Find(outputProperties, p => p.Name == inputProperty.Name);
                if (outputProperty != null && outputProperty.PropertyType == inputProperty.PropertyType && outputProperty.CanWrite)
                {
                    outputProperty.SetValue(output, inputProperty.GetValue(input));
                }
            }

            return output;
        }
    }
}
