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
    
    public partial class ADH_ACTIONS_AUTO_A02
    {
        public int A02_ID { get; set; }
        public Nullable<int> A02_ID_STATUT_C14 { get; set; }
        public Nullable<int> A02_TYPE_ACTIONS_G11 { get; set; }
        public Nullable<short> A02_ORIGINE { get; set; }
        public Nullable<short> A02_AUTO_AAU { get; set; }
        public string A02_NOTE { get; set; }
        public Nullable<int> A02_DECALAGE_ACTION { get; set; }
        public Nullable<int> A02_DECALAGE_MANif { get; set; }
        public Nullable<int> A02_TYPE_PRESTA { get; set; }
        public Nullable<int> A02_TT_PRESTA { get; set; }
        public Nullable<int> A02_ORDRE { get; set; }
    
        public virtual CFG_STATUT_C14 CFG_STATUT_C14 { get; set; }
        public virtual GRC_TYPE_ACTIONS_G11 GRC_TYPE_ACTIONS_G11 { get; set; }
    }
}
