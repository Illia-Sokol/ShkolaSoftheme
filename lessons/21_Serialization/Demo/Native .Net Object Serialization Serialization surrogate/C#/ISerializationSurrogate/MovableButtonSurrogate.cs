using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace ISerializationSurrogate
{
    public class MovableButtonSurrogate : System.Runtime.Serialization.ISerializationSurrogate
    {
        /// <summary>
        /// It occures when the object is going to serialize
        /// </summary>
        /// <param name="obj">Current Object that Must Serialize</param>
        /// <param name="info">Serialization Info that Conatains Which Property/Variable must Serialize</param>
        /// <param name="context">Streaming Context</param>
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            MovableButton table = (MovableButton)obj;

            info.AddValue("Location", table.Location);
            info.AddValue("Size", table.Size);
            info.AddValue("Name", table.Name);
            info.AddValue("TableMode", table.TableMode);
            info.AddValue("Mode", table.Mode);
            info.AddValue("BackgroundImage", table.BackgroundImage);
            info.AddValue("BackgroundImageLayout", table.BackgroundImageLayout);
            info.AddValue("Deduct", table.Deduct);
            info.AddValue("ForeColor", table.ForeColor);

        }


        /// <summary>
        /// It occures when the object is going to deserialize
        /// </summary>
        /// <param name="obj">Current Object that Must Deserialize</param>
        /// <param name="info">Serialization Info that Conatains Which Property/Variable must Deserialize</param>
        /// <param name="context">Streaming Context</param>
        /// <param name="selector">Custom ISurrogateSelector </param>
        /// <returns></returns>
        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            MovableButton table = new MovableButton();

            try
            {
                table.Location = (System.Drawing.Point)info.GetValue("Location", typeof(System.Drawing.Point));
                table.Name = info.GetString("Name");
                table.TableMode = (TableMode)info.GetValue("TableMode", typeof(TableMode));
                table.Mode = (DesignMode)info.GetValue("Mode", typeof(DesignMode));
                table.BackgroundImage = (System.Drawing.Image)info.GetValue("BackgroundImage", typeof(System.Drawing.Image));
                table.BackgroundImageLayout = (System.Windows.Forms.ImageLayout)info.GetValue("BackgroundImageLayout", typeof(System.Windows.Forms.ImageLayout));
                table.Deduct = info.GetUInt16("Deduct");
                table.ForeColor = (System.Drawing.Color)info.GetValue("ForeColor", typeof(System.Drawing.Color));
                table.Size = (System.Drawing.Size)info.GetValue("Size", typeof(System.Drawing.Size));


            }
            catch (Exception ex)
            {
                table = new MovableButton();
            }

            return table;
        }
    }
}
