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
    
    public partial class USR_SITE_VITRINE_CONFIGURATION_U34
    {
        public int U34_ID { get; set; }
        public int U34_ID_ADMIN_A48 { get; set; }
        public Nullable<short> U34_ACTUALITES_ENABLED { get; set; }
        public Nullable<short> U34_SLIDER_ENABLED { get; set; }
        public Nullable<short> U34_TIMELINE_ENABLED { get; set; }
        public int U34_ACTUALITES_ORDER { get; set; }
        public int U34_SLIDER_ORDER { get; set; }
        public int U34_TIMELINE_ORDER { get; set; }
        public string U34_HEADER_HTML { get; set; }
        public string U34_FOOTER_HTML { get; set; }
        public Nullable<short> U34_ACCES_ANONYME { get; set; }
    
        public virtual ADH_EPARTICIPANT_ADMIN_A48 ADH_EPARTICIPANT_ADMIN_A48 { get; set; }
    }
}
