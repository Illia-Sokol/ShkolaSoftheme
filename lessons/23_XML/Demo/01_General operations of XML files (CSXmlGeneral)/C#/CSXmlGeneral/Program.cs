﻿/****************************** Module Header ******************************\
* Module Name:  Program.cs
* Project:      CSXmlGeneral
* Copyright (c) Microsoft Corporation.
* 
* This C# sample project shows how to read a XML file by using XmlTextReader 
* or XmlNodeReader. It also shows, instead of using forward-only reader, how 
* to read, modify, and update Xml element using the XmlDocument class. This 
* class will load the whole document into memory for modification and we can 
* save the modified XML file to the file system.
* 
* The XML file used by the demo has this format:
* 
* <catalog>
*  <book id="bk101">
*    <author>Gambardella, Matthew</author>
*    <title>XML Developer's Guide</title>
*    <genre>Computer</genre>
*    <price>44.95</price>
*    <publish_date>2000-10-01</publish_date>
*    <description>
*      An in-depth look at creating applications
*      with XML.
*    </description>
*  </book>
*  <book>
*   ...
*  </book>
* <catalog>
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/en-us/openness/licenses.aspx#MPL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

#region Using directives
using System;
using System.Xml;
#endregion


class Program
{
    static void Main(string[] args)
    {
        /////////////////////////////////////////////////////////////////////
        // Read XML document using the XmlTextReader class.
        // 

        // The XmlTextReader acts as a reader pointer that only moves forward.
        // Because it always moves forward and read a piece of data into 
        // memory buffer, it has better performance than the XmlDocument 
        // class which loads the whole document into memory.

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Loading XML using XmlTextReader...");
        Console.ResetColor();

        XmlTextReader reader = new XmlTextReader("Books.xml");
        reader.WhitespaceHandling = WhitespaceHandling.None;

        while (reader.Read())
        {
            if (reader.Name == "book")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Selected book id: '{0}', details:", reader.GetAttribute("id"));
                Console.ResetColor();

                reader.Read();
                string author = reader.ReadElementContentAsString();
                string title = reader.ReadElementContentAsString();
                string genre = reader.ReadElementContentAsString();
                string price = reader.ReadElementContentAsString();
                string publishDate = reader.ReadElementContentAsString();
                string description = reader.ReadElementContentAsString();

                Console.WriteLine(genre + " book \"" + title + "\" written by \"" 
                                  + author + "\", published on " + publishDate);
                Console.WriteLine(description);
            }
        }

        reader.Close();


        /////////////////////////////////////////////////////////////////////
        // Read XML document using the XmlDocument and XmlNodeReader classes.
        // 

        // XmlNodeReader is similar to XmlTextReader but accepts an XmlNode 
        // instance as target to read. The following code shows how to use 
        // XmlDocument and XmlNodeReader to retrieve XML information. It is 
        // also a forward-only reader.

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Loading XML using XmlDocument & XmlNodeReader...");
        Console.ResetColor();

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(@"Books.xml");
        XmlNodeList xmlNodes = xmlDocument.GetElementsByTagName("book");
        foreach (XmlNode node in xmlNodes)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Selected book id: '{0}', details:", node.Attributes["id"].Value);
            Console.ResetColor();

            XmlNodeReader xmlNodeReader = new XmlNodeReader(node);
            xmlNodeReader.Read();
            xmlNodeReader.Read();

            string author = xmlNodeReader.ReadElementContentAsString();
            string title = xmlNodeReader.ReadElementContentAsString();
            string genre = xmlNodeReader.ReadElementContentAsString();
            string price = xmlNodeReader.ReadElementContentAsString();
            string publishDate = xmlNodeReader.ReadElementContentAsString();
            string description = xmlNodeReader.ReadElementContentAsString();

            Console.WriteLine(genre + " book \"" + title + "\" written by \"" + author + "\", published on " + publishDate);
            Console.WriteLine(description);
        }


        /////////////////////////////////////////////////////////////////////
        // Make changes to the XmlDocument.
        // 

        // Modify a node value by first calling SelectSingleNode to navigate 
        // to that node and by setting its InnerText property to change its 
        // content.
        XmlNode nodeToModify = xmlDocument.DocumentElement.SelectSingleNode(
            "book/genre");
        nodeToModify.InnerText = "XML Tech";

        // Add a new XML node. In XML programming, we always call 
        // XMLDocument.Create*** to create an attribute or element. After 
        // that, we can add it into where we want by calling Node.AppendChild
        XmlElement newElement = xmlDocument.CreateElement("book");
        XmlAttribute newAttribute = xmlDocument.CreateAttribute("id");
        newAttribute.Value = "bk103";
        XmlElement authorElement = xmlDocument.CreateElement("author");
        authorElement.InnerText = "Mark Russinovich,David Solomon,Alex Ionecsu";
        XmlElement titleElement = xmlDocument.CreateElement("title");
        titleElement.InnerText = "Windows Internals, 5th edition";
        XmlElement genreElement = xmlDocument.CreateElement("genre");
        genreElement.InnerText = "Windows Server 2008";
        XmlElement priceElement = xmlDocument.CreateElement("price");
        priceElement.InnerText = "69.99";
        XmlElement publishDateElement = xmlDocument.CreateElement("publish_date");
        publishDateElement.InnerText = "2009-6-17";
        XmlElement descriptionElement = xmlDocument.CreateElement("description");
        descriptionElement.InnerText = "Windows Internals, 5th edition is the" +
            " update to Windows Internals, 4th edition to cover Windows Vista" +
            " and Windows Server 2008 (32-bit and 64-bit).";

        newElement.Attributes.Append(newAttribute);
        newElement.AppendChild(authorElement);
        newElement.AppendChild(titleElement);
        newElement.AppendChild(genreElement);
        newElement.AppendChild(priceElement);
        newElement.AppendChild(publishDateElement);
        newElement.AppendChild(descriptionElement);
        xmlDocument.DocumentElement.AppendChild(newElement);

        // Save the changes
        xmlDocument.Save("Modified Books.xml");

        // XmlLDocument does not have Close or Dispose method because it is 
        // an in-memory representation of an XML document. Once read, the 
        // file is no-longer needed.
    }
}