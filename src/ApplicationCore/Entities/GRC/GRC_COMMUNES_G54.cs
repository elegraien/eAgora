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
    
    public partial class GRC_COMMUNES_G54
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_COMMUNES_G54()
        {
            this.GRC_QUARTIER_G57 = new HashSet<GRC_QUARTIER_G57>();
        }
    
        public int G54_ID { get; set; }
        public string G54_LIBELLE { get; set; }
        public Nullable<int> G54_ORDRE { get; set; }
        public Nullable<int> G54_ID_DEPARTEMENT_G31 { get; set; }
        public string G54_CODE_POSTAL { get; set; }
        public string G54_CODE { get; set; }
    
        public virtual GRC_DEPARTEMENT_G31 GRC_DEPARTEMENT_G31 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_QUARTIER_G57> GRC_QUARTIER_G57 { get; set; }
    }
}
