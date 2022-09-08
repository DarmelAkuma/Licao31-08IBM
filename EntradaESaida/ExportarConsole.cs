using System;
using System.Collections.Generic;
using System.Text;

namespace Arquivo {
    class ExportarConsole : IExportarDados {
        public void Dado(string[] data) {
            foreach (var Valor in data) {
                Console.WriteLine(Valor);
            }
        }
    }
}