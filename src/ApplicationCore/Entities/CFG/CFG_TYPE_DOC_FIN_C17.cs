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
    
    public partial class CFG_TYPE_DOC_FIN_C17
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CFG_TYPE_DOC_FIN_C17()
        {
            this.CFG_CODE_SEQUENCE_C04 = new HashSet<CFG_CODE_SEQUENCE_C04>();
        }
    
        public int C17_ID { get; set; }
        public string C17_LIBELLE { get; set; }
        public Nullable<int> C17_ORDRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFG_CODE_SEQUENCE_C04> CFG_CODE_SEQUENCE_C04 { get; set; }
    }
}
