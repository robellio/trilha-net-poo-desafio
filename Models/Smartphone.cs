using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
  public abstract class Smartphone
  {
    public string Numero { get; set; }
    public string Modelo { get => modelo; set => modelo = value; }
    public string Imei { get => imei; set => imei = value; }
    public int Memoria { get => memoria; set => memoria = value; }

    private string modelo;
    private string imei;
    private int memoria;
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
      Numero = numero;
      Modelo = modelo;
      Imei = imei;
      Memoria = memoria;
    }

    public void Ligar()
    {
      Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
  }
}