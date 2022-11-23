using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOEsferaRepaso.Entidades;

namespace POOEsferaRepaso.Datos
{
    public class ManejadorDeArchivosSecuenciales
    {
        private static string Archivo = "Esfera.txt";
        public static void GuardarArchivoSecuenciales(List<Esfera> listaEsfera)
        {
            using (var escritor = new StreamWriter(Archivo))
            {
                //Recorro la lista de circunferencial
                foreach (var esfera in listaEsfera)
                {
                    //Creo la linea
                    string linea = ConstruirLinea(esfera);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Esfera> LeerArchivoSecuencial()
        {
            List<Esfera> lista = new List<Esfera>();
            if (File.Exists(Archivo))
            {
                using (var lector = new StreamReader(Archivo))
                {
                    while (!lector.EndOfStream)//Mientras no sea fin de archivo, va a continuar leyendo
                    {
                        string linea = lector.ReadLine();
                        Esfera esfera = ConstruirEsfera(linea);
                        lista.Add(esfera);
                    }

                }
            }
            return lista;
        }

        private static Esfera ConstruirEsfera(string linea)
        {
            var campos = linea.Split('|');
            Esfera esfera = new Esfera()
            {
                Radio = double.Parse(campos[0]),
                color = (ColorRelleno)int.Parse(campos[1]),
                trazos = (Trazos)int.Parse(campos[2])
            };
            return esfera;

        }
        

        private static string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.Radio}|{((int)esfera.color)}|{((int)esfera.trazos)}";
    }
    }

  }

