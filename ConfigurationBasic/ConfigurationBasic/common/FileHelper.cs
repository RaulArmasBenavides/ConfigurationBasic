using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationBasic.common
{
    public class FileHelper
    {

        public static void ChangeVersionFiles(string Path)
        {
            DateTime nuevaFecha = DateTime.Now.AddDays(-100);

            // Obtener la lista de archivos en el directorio
            string[] archivos = Directory.GetFiles(Path);
            foreach (string archivo in archivos)
            {
                // Establecer la nueva fecha de creación
                File.SetCreationTime(archivo, nuevaFecha);
                File.SetLastWriteTime(archivo, nuevaFecha);
            }
        }

        public static void ChangeVersionFilesMinutes(string Path)
        {
            DateTime nuevaFecha = DateTime.Now.AddMinutes(-20);
            // Obtener la lista de archivos en el directorio
            string[] archivos = Directory.GetFiles(Path);
            foreach (string archivo in archivos)
            {
                // Establecer la nueva fecha de creación
                File.SetCreationTime(archivo, nuevaFecha);
                File.SetLastWriteTime(archivo, nuevaFecha);
            }
        }



    }
}
