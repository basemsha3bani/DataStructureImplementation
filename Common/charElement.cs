namespace Common
{
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
}

   
