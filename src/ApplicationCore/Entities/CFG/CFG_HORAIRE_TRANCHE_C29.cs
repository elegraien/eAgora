//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eAgoraV3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CFG_HORAIRE_TRANCHE_C29
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CFG_HORAIRE_TRANCHE_C29()
        {
            this.CFG_PLANNING_OCCUPATION_C27 = new HashSet<CFG_PLANNING_OCCUPATION_C27>();
            this.CFG_HORAIRE_TRANCHE_C291 = new HashSet<CFG_HORAIRE_TRANCHE_C29>();
        }
    
        public int C29_ID { get; set; }
        public string C29_LIBELLE { get; set; }
        public Nullable<int> C29_ID_PERE_C29 { get; set; }
        public Nullable<int> C29_NIVEAU { get; set; }
        public Nullable<int> C29_ORDRE { get; set; }
        public Nullable<System.DateTime> C29_DATE_VERROU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFG_PLANNING_OCCUPATION_C27> CFG_PLANNING_OCCUPATION_C27 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFG_HORAIRE_TRANCHE_C29> CFG_HORAIRE_TRANCHE_C291 { get; set; }
        public virtual CFG_HORAIRE_TRANCHE_C29 CFG_HORAIRE_TRANCHE_C292 { get; set; }
    }
}