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
    
    public partial class USR_FILTRE_U25
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USR_FILTRE_U25()
        {
            this.USR_FILTRE_SAVE_U26 = new HashSet<USR_FILTRE_SAVE_U26>();
        }
    
        public int U25_ID { get; set; }
        public string U25_LIBELLE { get; set; }
        public Nullable<int> U25_ID_ADMIN_A48 { get; set; }
        public Nullable<int> U25_ID_MANIF_M14 { get; set; }
        public Nullable<int> U25_ID_USER_C18 { get; set; }
        public string U25_DESCRIPTION { get; set; }
        public Nullable<short> U25_ORDRE { get; set; }
        public Nullable<short> U25_OPERATEUR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_FILTRE_SAVE_U26> USR_FILTRE_SAVE_U26 { get; set; }
    }
}
