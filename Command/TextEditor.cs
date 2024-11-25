using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TextEditor
    {
        private string _text = "";

        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine("Текст после вставки: " + _text);
        }

        public string DeleteText(int length)
        {
            if (length > _text.Length) length = _text.Length;
            string deletedText = _text.Substring(_text.Length - length);
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine("Текст после удаления: " + _text);
            return deletedText;
        }

        public string GetText()
        {
            return _text;
        }
    }

}
