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
    
    public partial class GRC_ACTIONS_FIDELITE_G34
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_ACTIONS_FIDELITE_G34()
        {
            this.GRC_ACTIONS_G01 = new HashSet<GRC_ACTIONS_G01>();
        }
    
        public long G34_ID { get; set; }
        public Nullable<int> G34_POINTS { get; set; }
        public string G34_REDUCTION { get; set; }
        public Nullable<decimal> G34_COUT { get; set; }
        public Nullable<long> G34_ID_ACTIONS_G01 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_ACTIONS_G01> GRC_ACTIONS_G01 { get; set; }
    }
}
