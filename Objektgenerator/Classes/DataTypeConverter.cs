using System;
using System.Collections.Generic;
using System.Text;

namespace Objektgenerator.Classes
{
    public class DataTypeConverter
    {
        public T ConvertMyType<T>(object myValue)
        {
            
            return (T)Convert.ChangeType(myValue, typeof(T));
        }
    }
}
