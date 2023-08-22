using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



public class Nodo
{
    public int x { get; set; }
    public int y { get; set; }
    public string texto { get; set; }
    public List<adyacencias> adyacencias { get; private set; }

    public Nodo(int X, int Y, string Texto)
    {
        this.x = X;
        this.y = Y;
        this.texto = Texto;
        adyacencias = new List<adyacencias>();
    }

    public void AddEdge(adyacencias edge)
    {
        adyacencias.Add(edge);
    }
}


