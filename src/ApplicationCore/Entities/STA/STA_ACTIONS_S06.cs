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
    
    public partial class STA_ACTIONS_S06
    {
        public int S06_ID { get; set; }
        public Nullable<long> S06_ID_CONTACT_G03 { get; set; }
        public Nullable<long> S06_ID_ORGANISME_G09 { get; set; }
        public Nullable<long> S06_ID_MANIF_M14 { get; set; }
        public Nullable<int> S06_ID_USER_C18 { get; set; }
        public Nullable<int> S06_CODE_ACTION_G11 { get; set; }
        public Nullable<System.DateTime> S06_DATE_POSE { get; set; }
        public Nullable<System.DateTime> S06_DATE_ACTION { get; set; }
        public Nullable<System.DateTime> S06_HEURE_DEBUT { get; set; }
        public Nullable<System.DateTime> S06_HEURE_FIN { get; set; }
        public Nullable<System.DateTime> S06_STATUT { get; set; }
        public string S06_NOM_CONTACT { get; set; }
        public string S06_NOM_ORGANISME { get; set; }
        public string S06_LIBELLE_MANIF { get; set; }
        public string S06_LIBELLE_ACTION { get; set; }
        public Nullable<int> S06_ID_ACTION_G01 { get; set; }
    }
}