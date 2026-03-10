using Newtonsoft.Json.Linq;
using System.IO;

namespace LemonCore.Libs
{
    public class json
    {
        //The data object?
        private JObject _jsonData;

        //set the data object to the contents of the .json
        public json(string filePath)
        {
            _jsonData = JObject.Parse(File.ReadAllText(filePath));
        }

        //this just gets values so you can use them!
        //i had to look up how to do this :C
        public T Get<T>(string key)
        {
            return _jsonData[key].Value<T>();
        }
    }
}
