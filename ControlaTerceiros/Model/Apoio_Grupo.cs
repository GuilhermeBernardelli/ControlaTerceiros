//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlaTerceiros.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apoio_Grupo
    {
        public Apoio_Grupo()
        {
            this.Apoio_Aplicabilidade = new HashSet<Apoio_Aplicabilidade>();
            this.Apoio_Item = new HashSet<Apoio_Item>();
        }
    
        public int apoio_grupo_id { get; set; }
        public string nome { get; set; }
        public string codigo { get; set; }
        public System.DateTime registro_criado_em { get; set; }
        public System.DateTime registro_alterado_em { get; set; }
        public string registro_alterado_por { get; set; }
        public byte[] registro_versao { get; set; }
    
        public virtual ICollection<Apoio_Aplicabilidade> Apoio_Aplicabilidade { get; set; }
        public virtual ICollection<Apoio_Item> Apoio_Item { get; set; }
    }
}