using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



public class adyacencias
{
    public Nodo Origen { get; private set; }
    public Nodo Destino { get; private set; }
    public int Peso { get; private set; }  // Añadida ponderación a la arista

    public adyacencias(Nodo origen, Nodo destino, int peso)  // Modificado para incluir peso
    {
        this.Origen = origen;
        this.Destino = destino;
        this.Peso = peso;
    }
}





