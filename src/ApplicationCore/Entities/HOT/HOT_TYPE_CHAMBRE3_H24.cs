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
    
    public partial class HOT_TYPE_CHAMBRE3_H24
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOT_TYPE_CHAMBRE3_H24()
        {
            this.HOT_CHAMBRE_H03 = new HashSet<HOT_CHAMBRE_H03>();
        }
    
        public int H24_ID { get; set; }
        public string H24_LIBELLE { get; set; }
        public Nullable<int> H24_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOT_CHAMBRE_H03> HOT_CHAMBRE_H03 { get; set; }
    }
}