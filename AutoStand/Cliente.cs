
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AutoStand
{

using System;
    using System.Collections.Generic;
    
public partial class Cliente
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Cliente()
    {

        this.Vendas = new HashSet<Venda>();

        this.Alugueres = new HashSet<Aluguer>();

        this.CarroOficina = new HashSet<CarroOficina>();

    }


    public int IdCliente { get; set; }

    public string Nome { get; set; }

    public string Nif { get; set; }

    public string Morada { get; set; }

    public string Contacto { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Venda> Vendas { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Aluguer> Alugueres { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CarroOficina> CarroOficina { get; set; }

}

}
