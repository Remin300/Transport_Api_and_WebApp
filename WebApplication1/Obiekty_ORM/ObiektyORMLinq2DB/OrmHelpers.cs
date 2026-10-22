namespace WebApplication1.ObiektyORMLinq2DB
{
    internal static class OrmHelpers
    {
        public static void ZamienStringiNaDuzeLitery<T>(T obiekt)
        {
            if (obiekt == null) return;

            var properties = typeof(T).GetProperties()
                .Where(p => p.PropertyType == typeof(string) && p.CanRead && p.CanWrite);

            foreach (var prop in properties)
            {
                var value = (string)prop.GetValue(obiekt);
                if (!string.IsNullOrEmpty(value))
                {
                    prop.SetValue(obiekt, value.ToUpper());
                }
            }
        }
    }
}
