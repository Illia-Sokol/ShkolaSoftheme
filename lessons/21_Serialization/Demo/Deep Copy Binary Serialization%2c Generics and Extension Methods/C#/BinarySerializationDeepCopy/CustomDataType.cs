/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Globalization;

namespace BinarySerializationDeepCopy
{
    [Serializable]
    public class CustomDataType
    {
        private int _intMember = 0;

        public int IntMember
        {
            get { return _intMember; }
            set { _intMember = value; }
        }

        private string _stringMember = String.Empty;

        public string StringMember
        {
            get { return _stringMember; }
            set { _stringMember = value; }
        }

        private DateTime _dateTimeMember = DateTime.MinValue;

        public DateTime DateTimeMember
        {
            get { return _dateTimeMember; }
            set { _dateTimeMember = value; }
        }

        public override string ToString()
        {
            return "IntMember: " + IntMember + ", DateTimeMember: " + DateTimeMember.ToString(CultureInfo.InvariantCulture) + ", StringMember: " + _stringMember;
        }
    }
}