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
    
    public partial class ADH_MESSAGE_A62
    {
        public int A62_ID { get; set; }
        public Nullable<long> A62_ID_DESTINATAIRE_G03 { get; set; }
        public string A62_EMAIL_EMETTEUR { get; set; }
        public string A62_NOM_EMETTEUR { get; set; }
        public string A62_PRENOM_EMETTEUR { get; set; }
        public Nullable<int> A62_ID_EMETTEUR { get; set; }
        public string A62_TEL_EMETTEUR { get; set; }
        public Nullable<short> A62_ETAT_MESSAGE { get; set; }
        public Nullable<int> A62_ID_M07 { get; set; }
        public Nullable<int> A62_ID_G27 { get; set; }
        public Nullable<System.DateTime> A62_DATE_EVENT { get; set; }
        public Nullable<int> A62_NB_PARTS { get; set; }
        public string A62_NOTE { get; set; }
        public Nullable<decimal> A62_BUDGET { get; set; }
        public Nullable<int> A62_ID_DEPARTEMENT_G31 { get; set; }
        public Nullable<int> A62_TYPE_G12 { get; set; }
        public string A62_MESSAGE { get; set; }
    
        public virtual GRC_CONTACTS_G03 GRC_CONTACTS_G03 { get; set; }
        public virtual GRC_TYPE_ORG1_G12 GRC_TYPE_ORG1_G12 { get; set; }
        public virtual GRC_TYPES_G27 GRC_TYPES_G27 { get; set; }
        public virtual MAN_LIEUX_M07 MAN_LIEUX_M07 { get; set; }
    }
}