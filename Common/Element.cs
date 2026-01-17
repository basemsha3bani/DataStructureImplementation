namespace Common
{
    public class Element
    {
        public Element next { get; set; }

        public Element previous { get; set; }
        public Element(int v, Element value1)
        {
            this.value = v;
            this.next = value1;
        }

        public int value { get; set; }


    }
    public class charElement:IComparable<charElement>
    {
        public charElement next { get; set; }
        public charElement previous { get; set; }
        public charElement(char v, charElement value1)
        {
            this.value = v;
            this.next = value1;
        }
        public char value { get; set; }

        public int CompareTo(charElement other)
        {
           
            return this.value.CompareTo(other.value);

        }
    }
        public class IllegalArgumentException : Exception
    {
        public IllegalArgumentException(string message) : base(message)
        {
        }
    }
}

   
