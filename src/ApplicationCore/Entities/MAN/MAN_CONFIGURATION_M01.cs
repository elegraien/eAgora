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
    
    public partial class MAN_CONFIGURATION_M01
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAN_CONFIGURATION_M01()
        {
            this.MAN_LIEUX_M07 = new HashSet<MAN_LIEUX_M07>();
            this.MAN_LIEUX_CONFIGURATION_M08 = new HashSet<MAN_LIEUX_CONFIGURATION_M08>();
            this.MAN_LIEUX_FILTRE_M09 = new HashSet<MAN_LIEUX_FILTRE_M09>();
            this.MAN_LIEUX_MANIF_M10 = new HashSet<MAN_LIEUX_MANIF_M10>();
            this.MAN_EVENEMENTS_M02 = new HashSet<MAN_EVENEMENTS_M02>();
        }
    
        public int M01_ID { get; set; }
        public string M01_LIBELLE { get; set; }
        public string M01_DESC { get; set; }
        public Nullable<int> M01_ORDRE { get; set; }
        public Nullable<int> M01_TYPE_M59 { get; set; }
        public Nullable<int> M01_ID_SOC_C13 { get; set; }
        public string M01_IMAGE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_LIEUX_M07> MAN_LIEUX_M07 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_LIEUX_CONFIGURATION_M08> MAN_LIEUX_CONFIGURATION_M08 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_LIEUX_FILTRE_M09> MAN_LIEUX_FILTRE_M09 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_LIEUX_MANIF_M10> MAN_LIEUX_MANIF_M10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_EVENEMENTS_M02> MAN_EVENEMENTS_M02 { get; set; }
    }
}
