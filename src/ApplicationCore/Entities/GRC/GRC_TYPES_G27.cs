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
    
    public partial class GRC_TYPES_G27
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_TYPES_G27()
        {
            this.ADH_MESSAGE_A62 = new HashSet<ADH_MESSAGE_A62>();
            this.GRC_TYPES_G271 = new HashSet<GRC_TYPES_G27>();
            this.GRC_TYPES_ORG_G28 = new HashSet<GRC_TYPES_ORG_G28>();
        }
    
        public int G27_ID { get; set; }
        public string G27_LIBELLE { get; set; }
        public Nullable<short> G27_ORDRE { get; set; }
        public Nullable<short> G27_NIVEAU { get; set; }
        public Nullable<int> G27_TYPES_G27 { get; set; }
        public Nullable<short> G27_TYPE_PRESTATAIRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_MESSAGE_A62> ADH_MESSAGE_A62 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_TYPES_G27> GRC_TYPES_G271 { get; set; }
        public virtual GRC_TYPES_G27 GRC_TYPES_G272 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_TYPES_ORG_G28> GRC_TYPES_ORG_G28 { get; set; }
    }
}
