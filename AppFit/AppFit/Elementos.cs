using System;
using System.Collections.Generic;
using System.Text;

namespace AppFit
{
    public class Elementos
    {
        public string Nombre { get; set; }
        public string Video { get; set; }
    }

    public class ListElemento
    {
        public List<Elementos> elementos { get; set;  }

        public ListElemento()
        {
            elementos = new List<Elementos>();
            LoadElements();
        }

        public void LoadElements()
        {
            elementos.Add(new Elementos
            {
                Nombre = "Pecho",
                Video = ""
            });
        }
    }
}
