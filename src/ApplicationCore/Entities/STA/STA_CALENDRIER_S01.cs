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
    
    public partial class STA_CALENDRIER_S01
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STA_CALENDRIER_S01()
        {
            this.STA_BUDGET_SOCIETE_S04 = new HashSet<STA_BUDGET_SOCIETE_S04>();
            this.STA_BUDGET_USER_S03 = new HashSet<STA_BUDGET_USER_S03>();
        }
    
        public int S01_ID { get; set; }
        public Nullable<System.DateTime> S01_NUM_JOUR { get; set; }
        public Nullable<System.DateTime> S01_DATE_CAL { get; set; }
        public Nullable<int> S01_NUM_SEMAINE { get; set; }
        public Nullable<int> S01_NUM_MOIS { get; set; }
        public Nullable<int> S01_NUM_TRIMESTRE { get; set; }
        public Nullable<int> S01_NUM_SEMESTRE { get; set; }
        public Nullable<int> S01_NUM_ANNEE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STA_BUDGET_SOCIETE_S04> STA_BUDGET_SOCIETE_S04 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STA_BUDGET_USER_S03> STA_BUDGET_USER_S03 { get; set; }
    }
}