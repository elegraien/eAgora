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
    
    public partial class TBL_PLAN_SALLE_T03
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_PLAN_SALLE_T03()
        {
            this.TBL_POSITION_T02 = new HashSet<TBL_POSITION_T02>();
            this.TBL_PLAN_SERVICE_T07 = new HashSet<TBL_PLAN_SERVICE_T07>();
        }
    
        public int T03_ID { get; set; }
        public string T03_LIBELLE { get; set; }
        public Nullable<short> T03_ORDRE { get; set; }
        public Nullable<int> T03_ID_LIEUX_M07 { get; set; }
        public Nullable<short> T03_IS_DEFAULT { get; set; }
        public Nullable<System.DateTime> T03_DATE_PLAN { get; set; }
        public Nullable<short> T03_MIDI_SOIR { get; set; }
        public string T03_IMAGE { get; set; }
        public Nullable<int> T03_CAPACITE { get; set; }
        public Nullable<System.DateTime> T03_DATE_FIN_PLAN { get; set; }
        public Nullable<int> T03_CALENDRIER_C05 { get; set; }
        public Nullable<System.DateTime> T03_DATE_CREATION { get; set; }
    
        public virtual CFG_FORMAT_CALENDRIER_C05 CFG_FORMAT_CALENDRIER_C05 { get; set; }
        public virtual MAN_LIEUX_M07 MAN_LIEUX_M07 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_POSITION_T02> TBL_POSITION_T02 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PLAN_SERVICE_T07> TBL_PLAN_SERVICE_T07 { get; set; }
    }
}
