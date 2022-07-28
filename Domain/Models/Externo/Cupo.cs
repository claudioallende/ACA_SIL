using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Domain.Models.Compartidos.Entity;

namespace Domain.Models.Externo
{
  public class Cupo
  {
    public long Id { get; set; }
    public string Alfanumerico { get; set; }
    public DateTime Fecha { get; set; }
    public string CentroCupo { get; set; }
    public string CentroDist { get; set; }
    public string CodGrano { get; set; }
    public string NomGrano { get; set; }
    public string EstadoSTOP { get; set; }
    public string CTG { get; set; }
    public string CodDestino { get; set; }
    public string NomDestino { get; set; }
    public string CodDestinatario { get; set; }
    public string NomDestinatario { get; set; }
    public string CodTitularDeCCPP { get; set; }
    public string NomTitularDeCCPP { get; set; }
    public string NomRteComProductor { get; set; }
    public string CodRteComProductor { get; set; }
    public string CodRteComVtaPrimaria { get; set; }
    public string NomRteComVtaPrimaria { get; set; }
    public string CodRteComVtaSecundaria { get; set; }
    public string NomRteComVtaSecundaria { get; set; }
    public string CodRteComVtaSecundaria2 { get; set; }
    public string NomRteComVtaSecundaria2 { get; set; }
    public string CodMercATermino { get; set; }
    public string NomMercATermino { get; set; }
    public string CodCorVtaPrimaria { get; set; }
    public string NomCorVtaPrimaria { get; set; }
    public string CodCorVtaSecundaria { get; set; }
    public string NomCorVtaSecundaria { get; set; }
    public string CCPP { get; set; }
    public bool EstaSIL { get; set; }
    public string EstadoSIL { get; set; }
    public DateTime FechaInformadoSIL { get; set; }


    public Cupo()
    {

    }

  }//end Cupo
}