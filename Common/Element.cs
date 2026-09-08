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
        public class IllegalArgumentException : Exception
    {
        public IllegalArgumentException(string message) : base(message)
        {
        }
    }
}

   
