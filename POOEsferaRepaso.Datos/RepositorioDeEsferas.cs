using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOEsferaRepaso.Entidades;

namespace POOEsferaRepaso.Datos
{
    public class RepositorioDeEsferas
    {
        public List<Esfera> listaEsfera;
        public RepositorioDeEsferas()
        {
            listaEsfera = new List<Esfera>();
        }
       
    public void Agregar(Esfera esfera)
    {
        listaEsfera.Add(esfera);
    }
    public List<Esfera> GetLista()
    {
        return listaEsfera;
    }
    public int GatCantidad()
    {
        return listaEsfera.Count();
    }

    public bool Borrar(Esfera esfera)
    {
        if (listaEsfera.Contains(esfera))
        {
            listaEsfera.Remove(esfera);
            return true;
        }
        return false;
    }

        public int GetCantidad()
        {
            return listaEsfera.Count();
        }

        public List<Esfera> Ordena(Ordenar orden)
        {
            return orden == Ordenar.Acendente ? listaEsfera.OrderBy(e => e.Radio).ToList() : listaEsfera.OrderByDescending(e => e.Radio).ToList();
        }
    }
    
}
