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
    
    public partial class USR_PACKLANGUE_U04
    {
        public int U04_ID { get; set; }
        public Nullable<int> U04_ID_LANGUE_U05 { get; set; }
        public string U04_NOM_FORM { get; set; }
        public string U04_NOM_CHAMP { get; set; }
        public string U04_NOM_AFFICHAGE { get; set; }
        public Nullable<int> U04_ID_SOC_C13 { get; set; }
        public Nullable<int> U04_ID_ADMIN_A48 { get; set; }
        public string U04_TOOLTIP { get; set; }
    
        public virtual USR_PACKLANGUE_LANGUES_U05 USR_PACKLANGUE_LANGUES_U05 { get; set; }
    }
}