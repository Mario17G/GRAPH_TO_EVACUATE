using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



public class Grafo
{
    private List<Nodo> nodos = new List<Nodo>();

    public void AddNode(Nodo node)
    {
        nodos.Add(node);
    }

    public List<Nodo> GetNodes()
    {
        return nodos;
    }



    public Nodo Buscar(string text)
    {
        foreach (Nodo nodo in nodos)
        {
            if (nodo.texto == text)
            {
                return nodo;
            }
        }
        return null; // retorna null si no se encuentra un nodo con el texto buscado
    }



    public Dictionary<Nodo, int> Dijkstra(Nodo origen, List<Nodo> destinos)
    {
        var distancias = new Dictionary<Nodo, int>();
        var previo = new Dictionary<Nodo, Nodo>();
        var rutas = new Dictionary<Nodo, Dictionary<Nodo, int>>();

        List<Nodo> nodos = new List<Nodo>(GetNodes());

        foreach (var node in nodos)
        {
            if (node == origen)
            {
                distancias[node] = 0;
            }
            else
            {
                distancias[node] = int.MaxValue;
            }
        }

        while (nodos.Any())
        {
            nodos.Sort((x, y) => distancias[x] - distancias[y]);

            var mas_pequeño = nodos[0];
            nodos.Remove(mas_pequeño);

            if (destinos.Contains(mas_pequeño))
            {
                var ruta = new Dictionary<Nodo, int>();

                var actual = mas_pequeño;
                while (previo.ContainsKey(actual))
                {
                    ruta[actual] = distancias[actual];
                    actual = previo[actual];
                }

                ruta[origen] = 0;  
                rutas[mas_pequeño] = ruta;  // Agregar la ruta al diccionario de rutas.
                destinos.Remove(mas_pequeño);  // Remover el nodo de la lista de destinos.

                if (!destinos.Any())
                {
                    break;
                }
            }

            if (distancias[mas_pequeño] == int.MaxValue)
            {
                break;
            }

            foreach (var neighbor in mas_pequeño.adyacencias)
            {
                var alt = distancias[mas_pequeño] + neighbor.Peso;

                if (alt < distancias[neighbor.Destino])
                {
                    distancias[neighbor.Destino] = alt;
                    previo[neighbor.Destino] = mas_pequeño;
                }
            }
        }

        // Encuentra la ruta más corta de todas las rutas.
        Dictionary<Nodo, int> rutaMasCorta = null;
        int distanciaMinima = int.MaxValue;

        foreach (var ruta in rutas)
        {
            int distanciaTotal = ruta.Value.Values.Sum();
            if (distanciaTotal < distanciaMinima)
            {
                rutaMasCorta = ruta.Value;
                distanciaMinima = distanciaTotal;
            }
        }

        return rutaMasCorta;
     }
}


