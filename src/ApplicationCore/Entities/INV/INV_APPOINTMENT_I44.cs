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
    
    public partial class INV_APPOINTMENT_I44
    {
        public int I44_ID { get; set; }
        public int I44_ID_MANIF_M14 { get; set; }
        public string I44_SUBJECT { get; set; }
        public string I44_DESCRIPTION { get; set; }
        public System.DateTime I44_DATE_START { get; set; }
        public System.DateTime I44_DATE_END { get; set; }
        public Nullable<System.DateTime> I44_DATE_ECHEANCE { get; set; }
        public Nullable<int> I44_NB_PLACES { get; set; }
        public string I44_RECURRENCERULE { get; set; }
        public Nullable<int> I44_RECURRENCEPARENTID { get; set; }
        public string I44_REMINDER { get; set; }
        public Nullable<int> I44_ID_ADMIN_A48 { get; set; }
        public Nullable<int> I44_ID_TYPE_APT_I45 { get; set; }
        public Nullable<int> I44_ID_ETAT_M21 { get; set; }
        public Nullable<int> I44_ID_CONTACT_G03 { get; set; }
    }
}
