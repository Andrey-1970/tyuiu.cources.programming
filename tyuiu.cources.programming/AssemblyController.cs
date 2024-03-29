﻿using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace tyuiu.cources.programming
{
    public class AssemblyController
    {
        public T CreateInstanceFromByteArray<T>(byte[] buffer)
        {
            var assembly = Assembly.Load(buffer);
            return CreateInstance<T>(assembly);
        }
        public T CreateInstanceFromStream<T>(Stream stream)
        {
            var assembly = AssemblyLoadContext.Default.LoadFromStream(stream);
            return CreateInstance<T>(assembly);
        }
        public T CreateInstanceFromFile<T>(string filename)
        {
            if (!File.Exists(filename)) { throw new FileNotFoundException($"File {filename} not found!"); }
            var assembly = Assembly.LoadFile(filename);
            return CreateInstance<T>(assembly);
        }
        private T CreateInstance<T>(Assembly assembly)
        {
            var cls = assembly.GetTypes()
                .Where(cls => cls.IsClass && cls.GetInterfaces().Contains(typeof(T)))
                .First();
            return (T)Activator.CreateInstance(cls!)!;
        }

    }
}