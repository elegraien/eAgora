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
    
    public partial class STA_PERIODE_S02
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STA_PERIODE_S02()
        {
            this.STA_BUDGET_SOCIETE_S04 = new HashSet<STA_BUDGET_SOCIETE_S04>();
            this.STA_BUDGET_USER_S03 = new HashSet<STA_BUDGET_USER_S03>();
        }
    
        public int S02_ID { get; set; }
        public string S02_LIBELLE { get; set; }
        public Nullable<int> S02_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STA_BUDGET_SOCIETE_S04> STA_BUDGET_SOCIETE_S04 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STA_BUDGET_USER_S03> STA_BUDGET_USER_S03 { get; set; }
    }
}