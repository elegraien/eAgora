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
    
    public partial class PDC_ATTACHEMENTS_P18
    {
        public int P18_ID { get; set; }
        public Nullable<int> P18_MAIL_ID_P16 { get; set; }
        public Nullable<int> P18_ATTACHEMENT_ID_P17 { get; set; }
        public Nullable<int> P18_ID_MESSAGE_U14 { get; set; }
    
        public virtual PDC_ATTACHEMENT_P17 PDC_ATTACHEMENT_P17 { get; set; }
        public virtual PDC_MAIL_P16 PDC_MAIL_P16 { get; set; }
    }
}