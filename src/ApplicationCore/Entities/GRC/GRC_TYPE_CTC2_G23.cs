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
    
    public partial class GRC_TYPE_CTC2_G23
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_TYPE_CTC2_G23()
        {
            this.GRC_CONTACTS_G03 = new HashSet<GRC_CONTACTS_G03>();
        }
    
        public int G23_ID { get; set; }
        public string G23_LIBELLE { get; set; }
        public Nullable<int> G23_ORDRE { get; set; }
        public Nullable<int> G23_ID_TYPE_CTC1_G22 { get; set; }
        public Nullable<short> G23_INACTIF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_CONTACTS_G03> GRC_CONTACTS_G03 { get; set; }
    }
}