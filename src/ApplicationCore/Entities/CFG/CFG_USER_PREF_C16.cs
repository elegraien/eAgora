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
    
    public partial class CFG_USER_PREF_C16
    {
        public int C16_ID { get; set; }
        public Nullable<int> C16_ID_USER_C18 { get; set; }
        public string C16_LIBELLE { get; set; }
        public string C16_VALUE { get; set; }
        public Nullable<int> C16_ID_KEY { get; set; }
    
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C18 { get; set; }
    }
}
