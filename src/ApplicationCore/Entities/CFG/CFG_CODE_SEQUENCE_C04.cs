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
    
    public partial class CFG_CODE_SEQUENCE_C04
    {
        public int C04_ID { get; set; }
        public string C04_NOM { get; set; }
        public Nullable<int> C04_ORDRE { get; set; }
        public string C04_DEBUT { get; set; }
        public Nullable<long> C04_PREMIER { get; set; }
        public Nullable<int> C04_DERNIER { get; set; }
        public Nullable<int> C04_TAILLE { get; set; }
        public string C04_FIN { get; set; }
        public Nullable<int> C04_SOCIETE_C13 { get; set; }
        public string C04_LIBELLE { get; set; }
        public Nullable<short> C04_NUM_AUTO_AVANCEE { get; set; }
        public Nullable<int> C04_ID_PARAM_TYPEDOC_C17 { get; set; }
        public Nullable<long> C04_ID_MANIF_M14 { get; set; }
    
        public virtual CFG_TYPE_DOC_FIN_C17 CFG_TYPE_DOC_FIN_C17 { get; set; }
        public virtual CFG_SOCIETE_C13 CFG_SOCIETE_C13 { get; set; }
    }
}
