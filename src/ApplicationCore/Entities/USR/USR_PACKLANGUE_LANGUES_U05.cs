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
    
    public partial class USR_PACKLANGUE_LANGUES_U05
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USR_PACKLANGUE_LANGUES_U05()
        {
            this.USR_PACKFILTRE_AFFICHAGE_U02 = new HashSet<USR_PACKFILTRE_AFFICHAGE_U02>();
            this.USR_PACKLANGUE_U04 = new HashSet<USR_PACKLANGUE_U04>();
        }
    
        public int U05_ID { get; set; }
        public string U05_LIBELLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_PACKFILTRE_AFFICHAGE_U02> USR_PACKFILTRE_AFFICHAGE_U02 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_PACKLANGUE_U04> USR_PACKLANGUE_U04 { get; set; }
    }
}
