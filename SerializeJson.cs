using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;




namespace AkritKCFormApplication
{
    class SerializeJson
    {
        public void JsonSerialize(object data, String path, bool append = true)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(path)) File.Delete(path);
            StreamWriter writer = new StreamWriter(path);
            JsonWriter jsonWriter = new JsonTextWriter(writer);

            jsonSerializer.Serialize(jsonWriter, data);
            jsonWriter.Close();
            writer.Close();
        }

        public object JsonDeserialize(Type dataType, string path)
        {
           
            JObject jsonObject = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                JsonReader jsonReader = new JsonTextReader(reader);
                jsonObject = jsonSerializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                reader.Close();
            }

            return jsonObject.ToObject(dataType);
        }
    }
}
