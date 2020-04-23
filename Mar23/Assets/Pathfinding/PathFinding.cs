using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding 
{
  //Pathfinding
  //Qué es? algoritmos de búsqueda en grafos utilizados para obtener una rita entre dos nodos


//Busqueda en lo ancho
//Breadthwise
  public static List<Nodo> Ancho(Nodo inicio, Nodo fin){

        Queue<Nodo> trabajo = new Queue<Nodo>();
        List<Nodo> visitados = new List<Nodo>();

        inicio.historial = new List<Nodo>();

        trabajo.Enqueue(inicio);
        visitados.Add(inicio);

        while(trabajo.Count > 0){

            Nodo actual = trabajo.Dequeue();

            if(actual == fin){

                // si sí fue se regresa el historial del nodo junto con el mismo
                List<Nodo> resultado = new List<Nodo>(actual.historial);
                resultado.Add(actual);
                return resultado;
            } else {

                // de no ser así explorar los hijos / vecinos
                for(int i = 0; i < actual.vecinos.Length; i++){

                    Nodo vecinoActual = actual.vecinos[i];

                    // verificar si no fue visitado
                    if(!visitados.Contains(vecinoActual)){
                        // si es "nuevo" entonces procesarlo

                        // reiniciar historial del vecino
                        vecinoActual.historial = new List<Nodo>(actual.historial);
                        vecinoActual.historial.Add(actual);

                        // agregar a las 2 estructuras
                        visitados.Add(vecinoActual);
                        trabajo.Enqueue(vecinoActual);

                    }
                }
            }

        }

        return null;
    }

    // busqueda a lo profundo
    // depthwise
    public static List<Nodo> Profundo(Nodo inicio, Nodo fin){
         Stack<Nodo> trabajo = new Stack<Nodo>();
        List<Nodo> visitados = new List<Nodo>();

        inicio.historial = new List<Nodo>();

        trabajo.Push(inicio);
        visitados.Add(inicio);

        while(trabajo.Count > 0){

            Nodo actual = trabajo.Pop();

            if(actual == fin){

                // si sí fue se regresa el historial del nodo junto con el mismo
                List<Nodo> resultado = new List<Nodo>(actual.historial);
                resultado.Add(actual);
                return resultado;
            } else {

                // de no ser así explorar los hijos / vecinos
                for(int i = 0; i < actual.vecinos.Length; i++){

                    Nodo vecinoActual = actual.vecinos[i];

                    // verificar si no fue visitado
                    if(!visitados.Contains(vecinoActual)){
                        // si es "nuevo" entonces procesarlo

                        // reiniciar historial del vecino
                        vecinoActual.historial = new List<Nodo>(actual.historial);
                        vecinoActual.historial.Add(actual);

                        // agregar a las 2 estructuras
                        visitados.Add(vecinoActual);
                        trabajo.Push(vecinoActual);

                    }
                }
            }

        }

        return null;

    }

    // A Star
    // A estrella
    public static List<Nodo> AEstrella(Nodo inicio, Nodo fin){
        List<Nodo> trabajo =new List<Nodo>();
        List<Nodo> visitados =new List<Nodo>();
        
        inicio.historial=new List<Nodo>();
        inicio.g=0;
        inicio.h=Vector3.Distance(inicio.transform.position,fin.transform.position);

        trabajo.Add(inicio);
        visitados.Add(inicio);


        if(inicio==fin){
            List resultado=new List<Nodo>();
            resultado.Add(fin);
            return resultado;
        }

        while(trabajo.Count>0){
            Nodo menor=trabajo[0];

            for(int i=1;i<trabajo.Count;i++){
                if(trabajo[i].F<menor.F){
                    menor=trabajo[i];
                }
            }

            trabajo.Remove(menor);

            for(int i = 0; i < menor.vecinos.Length; i++){
                Nodo vecinoActual=menor.vecinos[i];
                if(!visitados.Contains(vecinoActual)){
                    
                }
            }
        
        }
        return null;

    }
}
