using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Util
{
    public class JsonAutoMapperGeneric: IJsonAutoMapper
    {

        public T ConvertAutoMapperJson<T>(object obj)
        {
            string Jsonvalor = JsonConvert.SerializeObject(obj);
            T novaEntidade = JsonConvert.DeserializeObject<T>(Jsonvalor);
            return novaEntidade;
        }
    }
}
