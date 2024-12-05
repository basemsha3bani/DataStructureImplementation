namespace LinkedList
{
    public class Element
    {
        
        public Element(int v, Element value1)
        {
            this.value = v;
            this.next = value1;
        }

        public int value {  get; set; }  
        public Element next { get; set; }

    }

}
