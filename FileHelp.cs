using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AkritKCFormApplication
{
    class FileHelp
    {
        List<String> data;
        public void WriteToFile(String path, String data, bool append = true)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (data != "")
                {
                    writer.WriteLine(data);
                }
                
            }
        }

        public List<String> ReadFromFile(String path)
        {
            if(File.Exists(path))
            {
                data = new List<string>();
                using (StreamReader reader = new StreamReader(path))
                {
                    while(!reader.EndOfStream)
                    {
                        data.Add(reader.ReadLine());
                    }
                }

                return data;
            }
            return null;
            
        }

        public List<String[]> SplitRow(List<String> data) 
        {
            String[] splited;
            List<String[]> splitedData = new List<string[]>();
            Console.WriteLine(data.Count);
            for (int i = 0; i < data.Count; i++)
            {
                splited = data[i].Split(',');
                splitedData.Add(splited);
            }
            return splitedData;

        }

        public void DeleteFile(String path)
        {
            File.Delete(path);
        }

    }
}
