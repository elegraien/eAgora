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
    
    public partial class USR_TYPE_OUTILS_U36
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USR_TYPE_OUTILS_U36()
        {
            this.USR_ITEM_PORTAIL_U33 = new HashSet<USR_ITEM_PORTAIL_U33>();
        }
    
        public int U36_ID { get; set; }
        public string U36_LIBELLE { get; set; }
        public int U36_ID_ADMIN_A48 { get; set; }
        public Nullable<short> U36_ORDRE { get; set; }
    
        public virtual ADH_EPARTICIPANT_ADMIN_A48 ADH_EPARTICIPANT_ADMIN_A48 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_ITEM_PORTAIL_U33> USR_ITEM_PORTAIL_U33 { get; set; }
    }
}