using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;

namespace LinkedList
{
    public abstract class BasicLinkedListImplementation<T> where T : class
    {
        public T head { get; set; }
        public T tail  { get; set; }

        public abstract void Prepend(object value);

        public abstract void Append(object value);


        public abstract void delete(object value);

        public abstract List<string> Print();


    }
    public class ElementLinkedListImplementation : BasicLinkedListImplementation<GenericDataTypeElement>
    {
        public override void Prepend(object value)
        {

            if (head == null)
            {
                this.Append(value);

            }
            else
            {
                GenericDataTypeElement element = new GenericDataTypeElement(value, null);
                element.next = head;
                head = element;
            }



        }
        public override void Append(object value)
        {
            GenericDataTypeElement element = new GenericDataTypeElement(value, null);
            if (head == null)
            {
                head = element;
                tail = element;

            }
            else
            {

                tail.next = element;
            }



        }

        public override void delete(object value)
        {
            GenericDataTypeElement element = head, previous = null;
            while (element.value != value)

            {
                previous = element;
                element = element.next;


            }
            previous.next = element.next;



        }

        public override List<string> Print()
        {
            List<string> elements = new List<string>();
            GenericDataTypeElement element = head;
            while (element != null)
            {
                elements.Add(element.value.ToString());
                element = element.next;
            }
            return elements;


        }
    }


  }
