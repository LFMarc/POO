using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batalla : MonoBehaviour
{
    void Start()
    {
        Entrenador entrenador1 = new Entrenador("Aketx");
        Entrenador entrenador2 = new Entrenador("Didac");

        Monstruo monstruo1 = new Monstruo("Kronkor", 50, entrenador1);
        Monstruo monstruo2 = new Monstruo("Udyr", 50, entrenador2);

        Batalla batalla = new Batalla();

        batalla.IniciarBatalla(monstruo1, monstruo2);
    }

    public void IniciarBatalla(Monstruo monstruo1, Monstruo monstruo2)
    {
        Debug.Log($"¡La batalla comienza entre {monstruo1.nombre} y {monstruo2.nombre}!");

        monstruo1.Atacar(monstruo2);
        if (monstruo2.puntosDeVida > 0)
        {
            monstruo2.Atacar(monstruo1);
        }

        if (monstruo1.puntosDeVida > monstruo2.puntosDeVida)
        {
            Debug.Log($"{monstruo1.nombre}, controlado por {monstruo1.entrenador.nombre}, gana la batalla.");
        }
        else if (monstruo2.puntosDeVida > monstruo1.puntosDeVida)
        {
            Debug.Log($"{monstruo2.nombre}, controlado por {monstruo2.entrenador.nombre}, gana la batalla.");
        }
        else
        {
            Debug.Log("¡Es un empate!");
        }
    }
}
