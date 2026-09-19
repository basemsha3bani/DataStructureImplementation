namespace Common
{
    public class GenericDataTypeElement
    {
        public GenericDataTypeElement previous { get; set; }
        public object value { get; set; }
        public GenericDataTypeElement next { get; set; }
        public GenericDataTypeElement(object v, GenericDataTypeElement value1)
        {
            this.value = v;
            this.next = value1;
        }
    }
}
