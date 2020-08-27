using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Util
{
    public interface IJsonAutoMapper
    {
        public T ConvertAutoMapperJson<T>(object obj);
    }
}
