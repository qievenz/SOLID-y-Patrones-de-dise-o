using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _26.Patron.Comportamiento.Strategy.EjemploReflection
{
    public enum OutputFormat
    {
        NumberList,
        Html
    }

    public interface IListFormatStrategy
    {
        void Start(StringBuilder stringBuilder);
        void AddItem(StringBuilder stringBuilder, string item);
        void End(StringBuilder stringBuilder);
    }

    public class Html : IListFormatStrategy
    {

        public void Start(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<ul>");
        }
        public void AddItem(StringBuilder stringBuilder, string item)
        {
            stringBuilder.AppendLine($"<li>{item}</li>");
        }

        public void End(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("</ul>");
        }
    }
    public class NumberList : IListFormatStrategy
    {

        public void Start(StringBuilder stringBuilder)
        {
        }
        public void AddItem(StringBuilder stringBuilder, string item)
        {
            var itemNumber = Regex.Matches(stringBuilder.ToString(), Environment.NewLine).Count;
            stringBuilder.AppendLine($"{itemNumber} {item}");
        }

        public void End(StringBuilder stringBuilder)
        {
        }
    }

    public class TextProcessor
    {
        private StringBuilder sb = new StringBuilder();
        private IListFormatStrategy _listStrategy;

        public TextProcessor(OutputFormat outputFormat)
        {
            _listStrategy = (IListFormatStrategy)
                Activator.CreateInstance(Type.GetType($"EjemploReflection.{Enum.GetName(typeof(OutputFormat), outputFormat)}"));
        }

        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(sb);

            foreach (var item in items)
            {
                _listStrategy.AddItem(sb, item);
            }

            _listStrategy.End(sb);
        }

        public StringBuilder clear() => sb.Clear();

        public override string ToString()
        {
            return sb.ToString();
        }
    }

    public static class EjemploReflectionCliente
    {
        public static void Ejecutar()
        {
            var tp = new TextProcessor(OutputFormat.NumberList);
            tp.AppendList(new[] { "c#", "java", "Python" });
            Console.WriteLine($"{tp.ToString()}");
            tp.clear();

            tp = new TextProcessor(OutputFormat.NumberList);
            tp.AppendList(new[] { "c#", "java", "Python" });
            Console.WriteLine($"{tp.ToString()}");
            tp.clear();
        }
    }
}
