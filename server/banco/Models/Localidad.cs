﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace banco.Models;

public partial class Localidad
{
    public int Id { get; set; }

    public char Nombre { get; set; }

    public int Cp { get; set; }

    public int PaisId { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();

    public virtual Pai Pais { get; set; }
}