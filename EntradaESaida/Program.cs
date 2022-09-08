using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivo {
    class Program {
        static void Main(string[] args) {
            var ValoresDeDatas = new FormatarDatas(@$"C:\Users\015893631\Desktop\Nova pasta\minhaData.txt");
            ValoresDeDatas.Conversao(); 
            ValoresDeDatas.SaidaDeDados(new ExportarArquivo());
            ValoresDeDatas.SaidaDeDados(new ExportarConsole());
        }
    }
}