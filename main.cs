using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Stack<int> numeros = new Stack<int>();
    //rellenando o agregando elementos a la cola
    foreach(int numero in new int[]{1,2,3,4,5}){
      numeros.Push(numero); 
    }
    
    //recorriendo el stack, last in first out
    Console.WriteLine("recorriendo el queue");
    foreach(int numero in numeros){
      Console.WriteLine(numero);
    }
    //eliminando elementos del stack
    Console.WriteLine("Eliminando elementos");
    numeros.Pop();
    foreach(int numero in numeros){
      Console.WriteLine(numero);
    }

    Dictionary<string, int> edades = new Dictionary<string, int>();
    //rellenar el diccionario
    edades.Add("Francisco", 2);
    edades.Add("Vernita", 6);
    //utilizando array
    edades["Oscar"] = 40;
    edades["Pamela"] = 39;
    //recorriendo el diccionario
    foreach(KeyValuePair<string, int>persona in edades){
      Console.WriteLine("Nombre: {0}, Edad: {1}", persona.Key, persona.Value);
    }
  }
}