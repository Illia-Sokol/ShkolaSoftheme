using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Diagnastics
{
    public class BinarySerializer
    {
        /// <summary>
        /// It Deserialize the binary file to object
        /// </summary>
        /// <param name="filename">Binary File Path</param>
        /// <returns>Returns Object that Must Cast to Specific Type</returns>
        public static object FromBin(string filename)
        {
            object result = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream(File.ReadAllBytes(filename));
                result = formatter.Deserialize(stream);
                GC.SuppressFinalize(formatter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// It Serialize the object to binary file
        /// </summary>
        /// <param name="filename">Binary File Path</param>
        /// <param name="obj">Current Object that Must Serialize</param>
        public static void ToBin(string filename, object obj)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, obj);
                FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(file);
                writer.Write(stream.ToArray(), 0, stream.ToArray().Length);
                writer.Flush();
                writer.Close();
                file.Close();
                GC.SuppressFinalize(formatter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// It serialize the object to binary 
        /// </summary>
        /// <param name="obj">Current Object that Must Serialize</param>
        /// <returns></returns>
        public static byte[] ToBin(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, obj);
            GC.SuppressFinalize(formatter);
            return stream.ToArray();
        }

        /// <summary>
        /// It Deserialize the binary file to object
        /// </summary>
        /// <param name="filename">Binary File Path</param>
        /// <returns>Returns Object that Must Cast to Specific Type</returns>
        public static object FromBin(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream(data);
            object result = formatter.Deserialize(stream);
            GC.SuppressFinalize(formatter);
            return result;
        }


        /// <summary>
        /// It Serialize the object to binary file by custom surrogate
        /// </summary>
        /// <param name="filename">Binary File Path</param>
        /// <param name="obj">Current Object that Must Serialize</param>
        /// <param name="surrogate">Custom Surrogate</param>
        public static void ToBin(string filename, object obj, ISerializationSurrogate surrogate, Type objectType)
        {
            IFormatter formatter = new BinaryFormatter();

            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(objectType, new StreamingContext(StreamingContextStates.All), surrogate);

            formatter.SurrogateSelector = surrogateSelector;

            MemoryStream stream = new MemoryStream();

            formatter.Serialize(stream, obj);

            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(stream.ToArray(), 0, stream.ToArray().Length);
            writer.Flush();
            writer.Close();
            file.Close();

            GC.SuppressFinalize(formatter);

        }

        /// <summary>
        /// It Deserialize the binary file to object
        /// </summary>
        /// <param name="filename">Binary File Path</param>
        /// <param name="surrogate">Custom Surrogate</param>
        /// <param name="objectType">Return Object Type </param>
        /// <returns></returns>
        public static object FromBin(string filename, ISerializationSurrogate surrogate, Type objectType)
        {
            IFormatter formatter = new BinaryFormatter();

            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(objectType, new StreamingContext(StreamingContextStates.All), surrogate);

            formatter.SurrogateSelector = surrogateSelector;

            MemoryStream stream = new MemoryStream(File.ReadAllBytes(filename));

            object result = formatter.Deserialize(stream);

            stream.Close();
            stream.Dispose();

            GC.Collect();
            GC.SuppressFinalize(formatter);

            return result;

        }


        /// <summary>
        /// It Serialize the object to binary file by custom surrogate
        /// </summary>
        /// <param name="obj">Current Object that Must Serialize</param>
        /// <param name="surrogate">Custom Surrogate</param>
        public static byte[] ToBin(object obj, ISerializationSurrogate surrogate, Type objectType)
        {
            IFormatter formatter = new BinaryFormatter();

            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(objectType, new StreamingContext(StreamingContextStates.All), surrogate);

            formatter.SurrogateSelector = surrogateSelector;

            MemoryStream stream = new MemoryStream();

            formatter.Serialize(stream, obj);

            GC.SuppressFinalize(formatter);

            return stream.ToArray();

        }


        /// <summary>
        /// It Deserialize the binary file to object
        /// </summary>
        /// <param name="obj">Binary Array Object</param>
        /// <param name="surrogate">Custom Surrogate</param>
        /// <param name="objectType">Return Object Type </param>
        /// <returns></returns>
        public static object FromBin(byte[] obj, ISerializationSurrogate surrogate, Type objectType)
        {
            IFormatter formatter = new BinaryFormatter();

            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(objectType, new StreamingContext(StreamingContextStates.All), surrogate);

            formatter.SurrogateSelector = surrogateSelector;

            MemoryStream stream = new MemoryStream(obj);

            object result = formatter.Deserialize(stream);

            stream.Close();
            stream.Dispose();

            GC.Collect();
            GC.SuppressFinalize(formatter);

            return result;

        }

    }
}
