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
    
    public partial class FIN_PREFERENCES_F59
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_PREFERENCES_F59()
        {
            this.FIN_DET_COMM_PREFERENCES_F60 = new HashSet<FIN_DET_COMM_PREFERENCES_F60>();
            this.FIN_PREFERENCES_CATEGORIES_F61 = new HashSet<FIN_PREFERENCES_CATEGORIES_F61>();
        }
    
        public int F59_ID { get; set; }
        public Nullable<int> F59_ORDRE { get; set; }
        public string F59_LIBELLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_DET_COMM_PREFERENCES_F60> FIN_DET_COMM_PREFERENCES_F60 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PREFERENCES_CATEGORIES_F61> FIN_PREFERENCES_CATEGORIES_F61 { get; set; }
    }
}
