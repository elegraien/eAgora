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
    
    public partial class GRC_TYPE_CTC5_G26
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_TYPE_CTC5_G26()
        {
            this.GRC_CONTACTS_G03 = new HashSet<GRC_CONTACTS_G03>();
        }
    
        public int G26_ID { get; set; }
        public string G26_LIBELLE { get; set; }
        public Nullable<int> G26_ORDRE { get; set; }
        public Nullable<short> G26_INACTIF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_CONTACTS_G03> GRC_CONTACTS_G03 { get; set; }
    }
}
