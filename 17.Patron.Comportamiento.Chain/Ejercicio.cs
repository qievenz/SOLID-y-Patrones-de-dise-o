using System;

namespace _17.Patron.Comportamiento.Chain.Ejercicio
{
    public class Document
    {
        public string Name { get; }
        public string Content { get; }
     
        public Document(string name, string content)
        {
            Content = content;
            Name = name;
        }
    }

    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract string HandleRequest(Document document);

    }

    public class Executive : Handler
    {
        public override string HandleRequest(Document document)
        {
            if (document.Content.Length >= 10)
                return $"Documento {document.Name} revisado por {this.GetType().Name}";
            else if (successor != null)
                return this.HandleRequest(document);
            else
                return "";
        }
    }

    public class Editor : Handler
    {
        public override string HandleRequest(Document document)
        {
            if (document.Content.Length < 10)
                return $"Documento {document.Name} revisado por {this.GetType().Name}";
            else if (successor != null)
                return this.HandleRequest(document);
            else
                return "";
        }
    }
}
