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
    
    public partial class GRC_TYPE_VOIRIE_G56
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_TYPE_VOIRIE_G56()
        {
            this.GRC_VOIRIE_G53 = new HashSet<GRC_VOIRIE_G53>();
        }
    
        public int G56_ID { get; set; }
        public string G56_LIBELLE { get; set; }
        public Nullable<int> G56_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_VOIRIE_G53> GRC_VOIRIE_G53 { get; set; }
    }
}