
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
    
public partial class CarroOficina : Carro
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CarroOficina()
    {

        this.Servico = new HashSet<Servico>();

    }


    public string Matricula { get; set; }

    public string Kms { get; set; }

    public int ClienteIdCliente { get; set; }



    public virtual Cliente Cliente { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Servico> Servico { get; set; }

}

}
