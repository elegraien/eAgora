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
    
    public partial class MAN_TYPE_PRES_M17
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAN_TYPE_PRES_M17()
        {
            this.MAN_PRESTATIONS_M16 = new HashSet<MAN_PRESTATIONS_M16>();
        }
    
        public int M17_ID { get; set; }
        public string M17_LIBELLE { get; set; }
        public string M17_DESC { get; set; }
        public Nullable<int> M17_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_PRESTATIONS_M16> MAN_PRESTATIONS_M16 { get; set; }
    }
}