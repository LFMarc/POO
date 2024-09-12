using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstruo : MonoBehaviour
{
    public string nombre;
    public int puntosDeVida;
    public Entrenador entrenador;

    public Monstruo(string nombre, int puntosDeVida, Entrenador entrenador)
    {
        this.nombre = nombre;
        this.puntosDeVida = puntosDeVida;
        this.entrenador = entrenador;
    }

    public void Atacar(Monstruo enemigo)
    {
        int daño = Random.Range(5, 16);

        Debug.Log($"{nombre} ataca a {enemigo.nombre}.");
        enemigo.puntosDeVida -= daño;
        Debug.Log($"{enemigo.nombre} ahora tiene {enemigo.puntosDeVida} puntos de vida.");
    }
}
