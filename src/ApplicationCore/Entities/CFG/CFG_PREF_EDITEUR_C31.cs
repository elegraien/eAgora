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
    
    public partial class CFG_PREF_EDITEUR_C31
    {
        public int C31_ID { get; set; }
        public string C31_MODULE_PREF { get; set; }
        public string C31_LIBELLE_PREF { get; set; }
        public Nullable<int> C31_LIBELLE_P03 { get; set; }
        public string C31_CHAMP { get; set; }
        public Nullable<int> C31_ORDRE { get; set; }
        public Nullable<int> C31_ID_USER_C18 { get; set; }
    
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C18 { get; set; }
        public virtual PDC_DOCUMENT_EDITEUR_P03 PDC_DOCUMENT_EDITEUR_P03 { get; set; }
    }
}