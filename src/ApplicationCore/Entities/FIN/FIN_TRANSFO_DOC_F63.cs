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
    
    public partial class FIN_TRANSFO_DOC_F63
    {
        public int F63_ID { get; set; }
        public Nullable<int> F63_ORDRE { get; set; }
        public Nullable<int> F63_ID_TYPE_DOC_ORI_C08 { get; set; }
        public Nullable<int> F63_ID_TYPE_DOC_DEST_C08 { get; set; }
        public Nullable<int> F63_ETAT_DOC_ORI_F26 { get; set; }
        public Nullable<int> F63_ETAT_DOC_DEST_F26 { get; set; }
        public Nullable<int> F63_ETAT_DOC_ORI_AFTER_F26 { get; set; }
    
        public virtual CFG_PARAMETRES_DOCUMENT_C08 CFG_PARAMETRES_DOCUMENT_C08 { get; set; }
        public virtual FIN_ETAT_F26 FIN_ETAT_F26 { get; set; }
    }
}
