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
    
    public partial class GRC_TYPE_ORG2_G13
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_TYPE_ORG2_G13()
        {
            this.GRC_ORGANISMES_G09 = new HashSet<GRC_ORGANISMES_G09>();
        }
    
        public int G13_ID { get; set; }
        public string G13_LIBELLE { get; set; }
        public Nullable<short> G13_ORDRE { get; set; }
        public Nullable<int> G13_TYPE_ORG1_G12 { get; set; }
        public Nullable<short> G13_INACTIF { get; set; }
        public Nullable<short> G13_NON_SELECTIONNABLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_ORGANISMES_G09> GRC_ORGANISMES_G09 { get; set; }
    }
}
