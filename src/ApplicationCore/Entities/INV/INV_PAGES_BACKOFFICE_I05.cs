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
    
    public partial class INV_PAGES_BACKOFFICE_I05
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INV_PAGES_BACKOFFICE_I05()
        {
            this.INV_CONTENU_AIDE_I08 = new HashSet<INV_CONTENU_AIDE_I08>();
        }
    
        public int I05_ID { get; set; }
        public string I05_NOM_PAGE { get; set; }
        public string I05_ROUTE_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CONTENU_AIDE_I08> INV_CONTENU_AIDE_I08 { get; set; }
    }
}
