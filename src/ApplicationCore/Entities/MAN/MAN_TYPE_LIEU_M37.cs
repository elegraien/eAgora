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
    
    public partial class MAN_TYPE_LIEU_M37
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAN_TYPE_LIEU_M37()
        {
            this.MAN_LIEUX_M07 = new HashSet<MAN_LIEUX_M07>();
        }
    
        public int M37_ID { get; set; }
        public string M37_LIBELLE { get; set; }
        public Nullable<int> M37_ORDRE { get; set; }
        public Nullable<int> M37_TYPE_LIEU_M36 { get; set; }
        public Nullable<int> M37_TYPE_M59 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_LIEUX_M07> MAN_LIEUX_M07 { get; set; }
    }
}
