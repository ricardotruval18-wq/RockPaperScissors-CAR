using System.Collections.Generic;
using System.Linq;
namespace Proyecto.Core;

public class Juego {
    int probabPiedra;
    int probabPapel;
    int probabTijera;
    public List<Opcion> jugadasGuardadas = new List<Opcion>();

    public void almacenarInformacion(Jugada opcionActual)
    {
        guardarJugada(opcionActual);
    }
    public void guardarJugada(Jugada opcionActual)
    {
        jugadasGuardadas.Add(opcionActual.OpcionElegida);
        probabilidadesTotales(jugadasGuardadas);
    }

    //MATRICES DE MARKOV USAN ESTO
    public void probabilidadesTotales(List<Opcion> jugadasGuardadas)
    {
        probabPiedra = 0;
        probabPapel = 0;
        probabTijera = 0;
        foreach (Opcion jugada in jugadasGuardadas)
        {
            if(jugada == Opcion.Piedra){
                probabPiedra++;
            }
            if(jugada == Opcion.Papel)
            {
                probabPapel++;
            }
            if(jugada == Opcion.Tijera)
            {
                probabTijera++;
            }
        }
    }


    public Resultados procesarEleccion(Jugada enJuego, Opcion jugadaMaquina )
    {
        return compararElecciones(enJuego.OpcionElegida, jugadaMaquina);
    }

    public Resultados compararElecciones(Opcion jugada, Opcion jugadaMaquina)
    {
        if( jugada == jugadaMaquina){
            return Resultados.Empate;
        }

        if (jugada == Opcion.Papel){
            if(jugadaMaquina == Opcion.Piedra) return Resultados.Ganador;
            else return Resultados.Perdedor;
        }
        if (jugada == Opcion.Piedra){
            if(jugadaMaquina == Opcion.Tijera) return Resultados.Ganador;
            else return Resultados.Perdedor;
        }
        if (jugada == Opcion.Tijera){
            if(jugadaMaquina == Opcion.Papel) return Resultados.Ganador;
            else return Resultados.Perdedor;
        }

        return Resultados.Error;
    }

    public Opcion jugadaMaquina()
    {
        
        Random numRand = new Random();
        int totalJugadas = jugadasGuardadas.Count;
        if (totalJugadas < 2)
        {
            Array valores = Enum.GetValues(typeof(Opcion));
            return (Opcion)valores.GetValue(numRand.Next(valores.Length));
        }

        int indexActual = totalJugadas - 1;
        Opcion ultimaJugadaUsuario = peekBack(jugadasGuardadas, indexActual);
        if (ultimaJugadaUsuario == Opcion.Piedra)
        {
            return Opcion.Papel; 
        }
        else if (ultimaJugadaUsuario == Opcion.Papel)
        {
            return Opcion.Tijera; 
        }
        else
        {
            return Opcion.Piedra;
        }
    }

    public Opcion peekBack(List<Opcion> jugadasGuardadas, int indexActual)
    {
        return jugadasGuardadas[indexActual - 1];
    }

    public Opcion peekTwoBack(List<Opcion> jugadasGuardadas, int indexActual)
    {
        return jugadasGuardadas[indexActual - 2];
    }
}
