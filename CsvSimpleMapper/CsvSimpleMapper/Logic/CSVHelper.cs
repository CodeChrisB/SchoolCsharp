using CsvSimpleMapper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvSimpleMapper.Attributes;
using System.Reflection;
using System.IO;

namespace CsvSimpleMapper.Logic
{
    class CSVHelper
    {
        private static string NullLabel = "<NULL>";
        public static void Write<T>(IEnumerable<T> models)
        {
            if (models == null)
                throw new ArgumentNullException();

            var first = models.FirstOrDefault();
            var lines = new List<string>();


            if (first != null)
            {
                var metaData = GetModelData<T>(first);
                if (metaData.IsDataClass);
                {
                    foreach (var item in models)
                    {
                        var line = CreateCsvLine(item, metaData.Seperator);
                        lines.Add(line);
                    }
                    File.WriteAllLines(metaData.Filename, lines);
                }
            }


        }

        public static IEnumerable<T> Read<T>() where T : new() 
        {

            var result = new List<T>();

            return result;
        }

        private static (bool IsDataClass,string Filename,string Seperator) GetModelData<T>(T model)
        {
            if (model == null)
                throw new ArgumentNullException();

            var type = model.GetType();
            var dca = type.GetCustomAttribute<DataClassAttribute>();

            if(dca != null)
            {
                return (true, dca.Filename, dca.Seperator);
            }
            return (false, null, null);
        }

        private static string CreateCsvLine<T>(T model,string seperator)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            var result = new StringBuilder();
            var type = model.GetType();
            var exportProps = type.GetProperties()
                .Where(p => p.GetCustomAttribute<DataPropertyInfoAttribute>() != null)
                .OrderBy(e => e.GetCustomAttribute<DataPropertyInfoAttribute>().OrderPosition);

            foreach (var item in exportProps)
            {
                var value = item.GetValue(model);

                if (result.Length > 0)
                {
                    result.Append(seperator);
                }
                if (value != null)
                {
                    result.Append(value.ToString());
                }
                else
                {
                    result.Append(NullLabel);
                }
            }
            return result.ToString();
        }
    }
}
