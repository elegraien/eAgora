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
    
    public partial class INV_MOTS_CLES_PAR_PAGE_I07
    {
        public int I07_ID { get; set; }
        public Nullable<int> I07_ID_MOT_I06 { get; set; }
        public Nullable<int> I07_ID_CONTENU_I08 { get; set; }
    
        public virtual INV_CONTENU_AIDE_I08 INV_CONTENU_AIDE_I08 { get; set; }
        public virtual INV_MOTS_CLES_AIDE_I06 INV_MOTS_CLES_AIDE_I06 { get; set; }
    }
}
