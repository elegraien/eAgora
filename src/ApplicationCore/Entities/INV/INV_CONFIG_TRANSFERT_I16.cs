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
    
    public partial class INV_CONFIG_TRANSFERT_I16
    {
        public int I16_ID { get; set; }
        public Nullable<long> I16_ID_MANIF_M14 { get; set; }
        public string I16_HTML_ARRIVEE { get; set; }
        public string I16_HTML_DEPART { get; set; }
        public Nullable<System.DateTime> I16_DATE_MIN_ARRIVEE { get; set; }
        public Nullable<System.DateTime> I16_DATE_MAX_ARRIVEE { get; set; }
        public Nullable<System.DateTime> I16_DATE_MIN_DEPART { get; set; }
        public Nullable<System.DateTime> I16_DATE_MAX_DEPART { get; set; }
        public string I16_HEURE_MIN_ARRIVEE { get; set; }
        public string I16_HEURE_MAX_ARRIVEE { get; set; }
        public string I16_INTERVALLE_ARRIVEE { get; set; }
        public string I16_HEURE_MIN_DEPART { get; set; }
        public string I16_HEURE_MAX_DEPART { get; set; }
        public string I16_INTERVALLE_DEPART { get; set; }
        public string I16_HTML_ARRIVEE_EN { get; set; }
        public string I16_HTML_ARRIVEE_AL { get; set; }
        public string I16_HTML_ARRIVEE_ES { get; set; }
        public string I16_HTML_ARRIVEE_IT { get; set; }
        public string I16_HTML_DEPART_EN { get; set; }
        public string I16_HTML_DEPART_AL { get; set; }
        public string I16_HTML_DEPART_ES { get; set; }
        public string I16_HTML_DEPART_IT { get; set; }
    
        public virtual MAN_MANIFESTATIONS_M14 MAN_MANIFESTATIONS_M14 { get; set; }
    }
}