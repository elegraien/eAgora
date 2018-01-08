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
    
    public partial class TBL_RESERVATION_T04
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_RESERVATION_T04()
        {
            this.FIN_COMMANDES_F04 = new HashSet<FIN_COMMANDES_F04>();
            this.TBL_RESERVATION_POSITION_T05 = new HashSet<TBL_RESERVATION_POSITION_T05>();
        }
    
        public int T04_ID { get; set; }
        public string T04_LIBELLE { get; set; }
        public Nullable<int> T04_ID_LIEU_M07 { get; set; }
        public Nullable<long> T04_ID_CONTACT_G03 { get; set; }
        public Nullable<System.DateTime> T04_DATE_RESA { get; set; }
        public Nullable<int> T04_NBRE_COUVERT { get; set; }
        public Nullable<int> T04_COUVERT_ENFANT { get; set; }
        public Nullable<int> T04_COUVERT_ADULTE { get; set; }
        public Nullable<System.DateTime> T04_DATE_DEBUT { get; set; }
        public Nullable<System.DateTime> T04_DATE_FIN { get; set; }
        public Nullable<short> T04_MIDI_SOIR { get; set; }
        public string T04_NOTES { get; set; }
        public Nullable<int> T04_ETAT_T09 { get; set; }
        public Nullable<int> T04_ID_SERVICE_T06 { get; set; }
        public Nullable<System.DateTime> T04_DATE_POSE { get; set; }
        public Nullable<int> T04_ID_USER_C18 { get; set; }
        public string T04_NUMERO_RESA { get; set; }
        public Nullable<System.DateTime> T04_DATE_DERN_MODIF { get; set; }
        public string T04_USER_MODIF { get; set; }
        public Nullable<int> T04_SERVICE { get; set; }
        public Nullable<long> T04_ORGANISME_G09 { get; set; }
        public Nullable<int> T04_COUVERT_INVITE { get; set; }
        public Nullable<int> T04_ETAT { get; set; }
        public Nullable<int> T04_ID_CDR_C18 { get; set; }
        public Nullable<int> T04_NB_INVITE_FACTURE { get; set; }
        public Nullable<long> T04_ID_MANIF_M14 { get; set; }
        public Nullable<short> T04_NB_TABLE { get; set; }
        public string T04_REF_COM_CADEAU { get; set; }
        public Nullable<int> T04_ID_SOC_C13 { get; set; }
        public Nullable<int> T04_APIID { get; set; }
        public Nullable<long> T04_ID_EVENT_M02 { get; set; }
        public Nullable<short> T04_GROUPE { get; set; }
        public string T04_REF { get; set; }
        public string T04_LIBRE1 { get; set; }
        public string T04_LIBRE2 { get; set; }
        public string T04_LIBRE3 { get; set; }
        public string T04_LIBRE4 { get; set; }
        public string T04_LIBRE5 { get; set; }
        public Nullable<System.DateTime> T04_DATE_ECHEANCE { get; set; }
        public Nullable<short> T04_PROVENANCE { get; set; }
        public Nullable<int> T04_ID_ADMIN_A48 { get; set; }
        public Nullable<int> T04_ID_TYPE_RESA1_T10 { get; set; }
    
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C18 { get; set; }
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C181 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_COMMANDES_F04> FIN_COMMANDES_F04 { get; set; }
        public virtual GRC_CONTACTS_G03 GRC_CONTACTS_G03 { get; set; }
        public virtual GRC_ORGANISMES_G09 GRC_ORGANISMES_G09 { get; set; }
        public virtual MAN_EVENEMENTS_M02 MAN_EVENEMENTS_M02 { get; set; }
        public virtual MAN_LIEUX_M07 MAN_LIEUX_M07 { get; set; }
        public virtual TBL_ETAT_T09 TBL_ETAT_T09 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_RESERVATION_POSITION_T05> TBL_RESERVATION_POSITION_T05 { get; set; }
        public virtual TBL_SERVICE_T06 TBL_SERVICE_T06 { get; set; }
    }
}