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
    
    public partial class FIN_RESS_OCCUPATION_F15
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_RESS_OCCUPATION_F15()
        {
            this.FIN_OCCUPATION_LIEUX_F62 = new HashSet<FIN_OCCUPATION_LIEUX_F62>();
        }
    
        public int F15_ID { get; set; }
        public Nullable<int> F15_ID_PRODUIT_F13 { get; set; }
        public Nullable<int> F15_ID_TYPE_OCCUPATION_F18 { get; set; }
        public Nullable<System.DateTime> F15_DATE_DEBUT { get; set; }
        public Nullable<System.DateTime> F15_DATE_FIN { get; set; }
        public Nullable<int> F15_QTE { get; set; }
        public Nullable<int> F15_STOCK { get; set; }
        public string F15_NOTE_LIEUX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_OCCUPATION_LIEUX_F62> FIN_OCCUPATION_LIEUX_F62 { get; set; }
        public virtual FIN_TYPE_OCCUPATION_F18 FIN_TYPE_OCCUPATION_F18 { get; set; }
    }
}