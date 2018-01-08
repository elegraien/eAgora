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
    
    public partial class ADH_INSCRIPTION_A07
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADH_INSCRIPTION_A07()
        {
            this.ADH_ACTIONS_A01 = new HashSet<ADH_ACTIONS_A01>();
            this.INV_NOTIFICATION_I28 = new HashSet<INV_NOTIFICATION_I28>();
        }
    
        public int A07_ID { get; set; }
        public Nullable<int> A07_ID_PARTICIPANT { get; set; }
        public Nullable<int> A07_PRESTATION_A10 { get; set; }
        public Nullable<int> A07_ID_EVENEMENT { get; set; }
        public Nullable<int> A07_ID_MANIFESTATION { get; set; }
        public Nullable<System.DateTime> A07_DATE_INSCRIPTION { get; set; }
        public Nullable<float> A07_DROIT_INSCRIPTION { get; set; }
        public Nullable<float> A07_TAUX_TVA { get; set; }
        public Nullable<float> A07_TVA { get; set; }
        public Nullable<float> A07_TOTAL_CHARGES { get; set; }
        public Nullable<float> A07_TOTAL_PAYE { get; set; }
        public Nullable<float> A07_MONTANT_EXIGIBLE { get; set; }
        public string A07_NUMERO_EXPOSANT { get; set; }
        public Nullable<int> A07_PLACES_RESTANTES { get; set; }
        public Nullable<System.DateTime> A07_DATE_DEBUT { get; set; }
        public Nullable<System.DateTime> A07_DATE_FIN { get; set; }
        public Nullable<System.DateTime> A07_HEURE_DEBUT { get; set; }
        public Nullable<System.DateTime> A07_HEURE_FIN { get; set; }
        public Nullable<short> A07_SOLDEE { get; set; }
        public Nullable<decimal> A07_AHRES { get; set; }
        public Nullable<int> A07_ETAT_A06 { get; set; }
        public Nullable<int> A07_TYPE_INSC1_A32 { get; set; }
        public Nullable<int> A07_TYPE_INSC1_A33 { get; set; }
        public Nullable<int> A07_TYPE_INSC1_A34 { get; set; }
        public Nullable<int> A07_TYPE_INSC1_A35 { get; set; }
        public Nullable<int> A07_TYPE_INSC1_A36 { get; set; }
        public string A07_LIB1 { get; set; }
        public string A07_LIB2 { get; set; }
        public string A07_LIB3 { get; set; }
        public string A07_LIB4 { get; set; }
        public string A07_LIB5 { get; set; }
        public string A07_NOTE { get; set; }
        public Nullable<short> A07_SURBOOKING { get; set; }
        public Nullable<short> A07_FLAG_DESIDERATA { get; set; }
        public string A07_REF { get; set; }
        public Nullable<int> A07_PAX { get; set; }
        public string A07_LIBELLE { get; set; }
        public string A07_DESC { get; set; }
        public Nullable<long> A07_ID_RESA_H01 { get; set; }
        public Nullable<long> A07_ID_SOUSRESA_H02 { get; set; }
        public Nullable<short> A07_WEB { get; set; }
        public Nullable<int> A07_ID_REC_I22 { get; set; }
        public Nullable<int> A07_ID_REC_HEURE_I26 { get; set; }
        public Nullable<int> A07_ID_STATUT_A39 { get; set; }
        public Nullable<System.DateTime> A07_DATE_PRESENCE { get; set; }
        public Nullable<int> A07_ID_RECURRENCE_I44 { get; set; }
        public Nullable<int> A07_ID_RECURRENCE_PARENT_I44 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_ACTIONS_A01> ADH_ACTIONS_A01 { get; set; }
        public virtual ADH_ETAT_A06 ADH_ETAT_A06 { get; set; }
        public virtual ADH_PARTICIPANT_A09 ADH_PARTICIPANT_A09 { get; set; }
        public virtual ADH_TYPE_INSC1_A32 ADH_TYPE_INSC1_A32 { get; set; }
        public virtual ADH_TYPE_INSC2_A33 ADH_TYPE_INSC2_A33 { get; set; }
        public virtual ADH_TYPE_INSC3_A34 ADH_TYPE_INSC3_A34 { get; set; }
        public virtual ADH_TYPE_INSC4_A35 ADH_TYPE_INSC4_A35 { get; set; }
        public virtual ADH_TYPE_INSC5_A36 ADH_TYPE_INSC5_A36 { get; set; }
        public virtual ADH_PRESTATION_A10 ADH_PRESTATION_A10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_NOTIFICATION_I28> INV_NOTIFICATION_I28 { get; set; }
    }
}
