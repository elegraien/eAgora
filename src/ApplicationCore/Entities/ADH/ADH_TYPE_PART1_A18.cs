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
    
    public partial class ADH_TYPE_PART1_A18
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADH_TYPE_PART1_A18()
        {
            this.ADH_PARTICIPANT_A09 = new HashSet<ADH_PARTICIPANT_A09>();
        }
    
        public int A18_ID { get; set; }
        public string A18_LIBELLE { get; set; }
        public Nullable<short> A18_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_PARTICIPANT_A09> ADH_PARTICIPANT_A09 { get; set; }
    }
}
