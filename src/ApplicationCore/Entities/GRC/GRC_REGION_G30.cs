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
    
    public partial class GRC_REGION_G30
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_REGION_G30()
        {
            this.GRC_DEPARTEMENT_G31 = new HashSet<GRC_DEPARTEMENT_G31>();
            this.GRC_ORGANISMES_G09 = new HashSet<GRC_ORGANISMES_G09>();
        }
    
        public int G30_ID { get; set; }
        public string G30_LIBELLE { get; set; }
        public Nullable<short> G30_ORDRE { get; set; }
        public Nullable<int> G30_PAYS_G29 { get; set; }
        public string G30_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_DEPARTEMENT_G31> GRC_DEPARTEMENT_G31 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_ORGANISMES_G09> GRC_ORGANISMES_G09 { get; set; }
        public virtual GRC_PAYS_G29 GRC_PAYS_G29 { get; set; }
    }
}
