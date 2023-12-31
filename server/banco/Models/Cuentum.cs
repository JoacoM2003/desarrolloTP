﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace banco.Models;

public partial class Cuentum
{
    public int Id { get; set; }

    public int NumeroCuenta { get; set; }

    public int Cbu { get; set; }

    public int TipoCuentaId { get; set; }

    public int BancoId { get; set; }

    public virtual Banco Banco { get; set; }

    public virtual ICollection<ClienteXcuentum> ClienteXcuenta { get; set; } = new List<ClienteXcuentum>();

    public virtual TipoCuentum TipoCuenta { get; set; }

    public virtual ICollection<Transaccion> TransaccionCuentaDestinos { get; set; } = new List<Transaccion>();

    public virtual ICollection<Transaccion> TransaccionCuentaOrigens { get; set; } = new List<Transaccion>();
}