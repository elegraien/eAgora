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
    
    public partial class FIN_TYPE_DTC5_F25
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_TYPE_DTC5_F25()
        {
            this.FIN_DETAILS_COMMANDES_F07 = new HashSet<FIN_DETAILS_COMMANDES_F07>();
        }
    
        public int F25_ID { get; set; }
        public string F25_LIBELLE { get; set; }
        public Nullable<int> F25_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_DETAILS_COMMANDES_F07> FIN_DETAILS_COMMANDES_F07 { get; set; }
    }
}
