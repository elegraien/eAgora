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
    
    public partial class MAN_TYPE_EVT6_M24
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAN_TYPE_EVT6_M24()
        {
            this.MAN_EVENEMENTS_M02 = new HashSet<MAN_EVENEMENTS_M02>();
        }
    
        public int M24_ID { get; set; }
        public string M24_LIBELLE { get; set; }
        public Nullable<int> M24_ORDRE { get; set; }
        public Nullable<short> M24_INACTIF { get; set; }
        public Nullable<int> M24_ID_SOC_C13 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_EVENEMENTS_M02> MAN_EVENEMENTS_M02 { get; set; }
    }
}
