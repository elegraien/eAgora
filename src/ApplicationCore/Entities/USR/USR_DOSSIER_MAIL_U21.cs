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
    
    public partial class USR_DOSSIER_MAIL_U21
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USR_DOSSIER_MAIL_U21()
        {
            this.USR_MESSAGE_U14 = new HashSet<USR_MESSAGE_U14>();
            this.USR_MESSAGE_ARCHIVE_U22 = new HashSet<USR_MESSAGE_ARCHIVE_U22>();
        }
    
        public int U21_ID { get; set; }
        public string U21_LIBELLE { get; set; }
        public Nullable<int> U21_ORDRE { get; set; }
        public Nullable<long> U21_ID_MANIF_M14 { get; set; }
        public Nullable<int> U21_ID_ADMIN_A48 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_U14> USR_MESSAGE_U14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_ARCHIVE_U22> USR_MESSAGE_ARCHIVE_U22 { get; set; }
    }
}
