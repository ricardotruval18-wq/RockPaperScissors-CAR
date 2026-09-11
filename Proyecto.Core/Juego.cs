using System.Collections.Generic;
using System.Linq;
namespace Proyecto.Core;

public class Juego {
    int probabPiedra;
    int probabPapel;
    int probabTijera;
    private List<Opcion> jugadasGuardadas = new List<Opcion>();

    public void almacenarInformacion(Jugada opcionActual)
    {
        guardarJugada(opcionActual);
    }
    public void guardarJugada(Jugada opcionActual)
    {
        jugadasGuardadas.Add(opcionActual.OpcionElegida);
        int indexActual = jugadasGuardadas.Count-1;
    }

    
    public void probabilidadesTotales(List<Opcion> jugadasGuardadas)
    {
        foreach(Opcion jugada in jugadasGuardadas)
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
        switch (enJuego.OpcionElegida)
        {
            case Opcion.Papel:
                return compararElecciones(Opcion.Papel, jugadaMaquina);
            break;
            case Opcion.Piedra:
                return compararElecciones(Opcion.Piedra, jugadaMaquina);
            break;
            case Opcion.Tijera:
                return compararElecciones(Opcion.Tijera, jugadaMaquina);
            break;
            default:
                return Resultados.Error;
            break;
        }
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

    public Opcion jugadaMaquina(List<Opcion> jugadasGuardadas)
    {
        Random numRand = new Random();
        int index = numRand.Next(0 , jugadasGuardadas.Count);
        Opcion eleccionMaquina = jugadasGuardadas[index];

        return eleccionMaquina;
    }

    public int peekBack(List<Opcion> jugadasGuardadas, int indexActual){
        int jugadaAnterior = (int)jugadasGuardadas[indexActual];
        return jugadaAnterior;
    }
    public int peekTwoBack(List<Opcion> jugadasGuardadas, int indexActual)
    {
        int jugadaAntAnterior = (int)jugadasGuardadas[indexActual-1];
        return jugadaAntAnterior;
    }
}
