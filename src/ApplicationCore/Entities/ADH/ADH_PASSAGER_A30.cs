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
    
    public partial class ADH_PASSAGER_A30
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADH_PASSAGER_A30()
        {
            this.ADH_PARTICIPANT_A09 = new HashSet<ADH_PARTICIPANT_A09>();
        }
    
        public int A30_ID { get; set; }
        public string A30_LIBELLE { get; set; }
        public Nullable<short> A30_ORDRE { get; set; }
        public Nullable<int> A30_ID_VOITURE { get; set; }
        public Nullable<int> A30_ID_PART { get; set; }
        public Nullable<int> A30_ID_COV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_PARTICIPANT_A09> ADH_PARTICIPANT_A09 { get; set; }
    }
}
