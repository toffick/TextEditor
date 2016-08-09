using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace texteditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filaPath);
        void SaveContent(string content, string filaPath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);
    }
   public class manager: IFileManager
    {
        public readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding);
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;

        }

        public void SaveContent(string content, string filaPath)
        {
            SaveContent(content, filaPath, _defaultEncoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;

        }
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;

        }
    }
   
    }
