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
    
    public partial class HOT_TYPE_SS_RESA4_H17
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOT_TYPE_SS_RESA4_H17()
        {
            this.HOT_SOUS_RESERVATION_H02 = new HashSet<HOT_SOUS_RESERVATION_H02>();
        }
    
        public int H17_ID { get; set; }
        public string H17_LIBELLE { get; set; }
        public Nullable<int> H17_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOT_SOUS_RESERVATION_H02> HOT_SOUS_RESERVATION_H02 { get; set; }
    }
}
