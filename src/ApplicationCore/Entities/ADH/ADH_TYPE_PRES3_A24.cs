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
    
    public partial class ADH_TYPE_PRES3_A24
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADH_TYPE_PRES3_A24()
        {
            this.ADH_PRESTATION_A10 = new HashSet<ADH_PRESTATION_A10>();
        }
    
        public int A24_ID { get; set; }
        public string A24_LIBELLE { get; set; }
        public Nullable<short> A24_ORDRE { get; set; }
        public Nullable<int> A24_ID_EVENT { get; set; }
        public Nullable<int> A24_ID_MANIF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_PRESTATION_A10> ADH_PRESTATION_A10 { get; set; }
    }
}
