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
    
    public partial class GRC_CONTACTS_G03
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRC_CONTACTS_G03()
        {
            this.ADH_MESSAGE_A62 = new HashSet<ADH_MESSAGE_A62>();
            this.ADH_PANIER_A61 = new HashSet<ADH_PANIER_A61>();
            this.FIN_COMMANDES_F04 = new HashSet<FIN_COMMANDES_F04>();
            this.GRC_ACTIONS_G01 = new HashSet<GRC_ACTIONS_G01>();
            this.GRC_LIENS_CTC_ORG_G38 = new HashSet<GRC_LIENS_CTC_ORG_G38>();
            this.GRC_LIENS_CTC_ORG_G381 = new HashSet<GRC_LIENS_CTC_ORG_G38>();
            this.HOT_CARDEX_CHAMBRE_H48 = new HashSet<HOT_CARDEX_CHAMBRE_H48>();
            this.HOT_SOUS_RESERVATION_H02 = new HashSet<HOT_SOUS_RESERVATION_H02>();
            this.MAN_MANIFESTATIONS_M14 = new HashSet<MAN_MANIFESTATIONS_M14>();
            this.MAN_PRESTATIONS_M16 = new HashSet<MAN_PRESTATIONS_M16>();
            this.PDC_USERS_MAIL_P19 = new HashSet<PDC_USERS_MAIL_P19>();
            this.REC_CARTE_R02 = new HashSet<REC_CARTE_R02>();
            this.TBL_RESERVATION_T04 = new HashSet<TBL_RESERVATION_T04>();
            this.USR_MESSAGE_U14 = new HashSet<USR_MESSAGE_U14>();
            this.USR_MESSAGE_U141 = new HashSet<USR_MESSAGE_U14>();
            this.USR_MESSAGE_ARCHIVE_U22 = new HashSet<USR_MESSAGE_ARCHIVE_U22>();
            this.USR_MESSAGE_ARCHIVE_U221 = new HashSet<USR_MESSAGE_ARCHIVE_U22>();
        }
    
        public long G03_ID { get; set; }
        public string G03_NOM { get; set; }
        public Nullable<long> G03_ID_ORGANISME_G09 { get; set; }
        public string G03_PRENOM { get; set; }
        public string G03_PRENOM2 { get; set; }
        public Nullable<int> G03_TITRE_G10 { get; set; }
        public string G03_FONCTION { get; set; }
        public string G03_SERVICE { get; set; }
        public string G03_TEL { get; set; }
        public string G03_TEL_PORTABLE { get; set; }
        public string G03_TEL_AUTRE { get; set; }
        public string G03_FAX { get; set; }
        public string G03_EMAIL { get; set; }
        public string G03_NOTE { get; set; }
        public string G03_ADRESSE { get; set; }
        public string G03_CODE_POSTAL { get; set; }
        public string G03_VILLE { get; set; }
        public Nullable<int> G03_PRINCIPAL { get; set; }
        public Nullable<short> G03_ACTIF { get; set; }
        public Nullable<System.DateTime> G03_DATE_DERN_MODIF { get; set; }
        public Nullable<int> G03_TYPE_CTC1_G22 { get; set; }
        public Nullable<int> G03_TYPE_CTC2_G23 { get; set; }
        public Nullable<int> G03_TYPE_CTC3_G24 { get; set; }
        public Nullable<int> G03_TYPE_CTC4_G25 { get; set; }
        public Nullable<int> G03_TYPE_CTC5_G26 { get; set; }
        public string G03_CODE { get; set; }
        public Nullable<short> G03_CHK1 { get; set; }
        public Nullable<short> G03_CHK2 { get; set; }
        public Nullable<short> G03_CHK3 { get; set; }
        public Nullable<int> G03_FONCTION_G32 { get; set; }
        public Nullable<int> G03_ID_SOC_C13 { get; set; }
        public Nullable<System.DateTime> G03_DATE_NAISSANCE { get; set; }
        public Nullable<long> G03_FIDELITE_G33 { get; set; }
        public Nullable<int> G03_UTILISATEURS_C18 { get; set; }
        public string G03_LOGIN { get; set; }
        public string G03_PASSWORD { get; set; }
        public Nullable<int> G03_TYPE_LIEN_CTC_ORG_G39 { get; set; }
        public Nullable<System.DateTime> G03_DATE_DIVERS { get; set; }
        public string G03_ADRESSE_DIVERS { get; set; }
        public string G03_CODE_POSTAL_DIVERS { get; set; }
        public string G03_VILLE_DIVERS { get; set; }
        public string G03_PHOTO { get; set; }
        public string G03_LIBRE1 { get; set; }
        public string G03_LIBRE2 { get; set; }
        public string G03_LIBRE3 { get; set; }
        public string G03_LIBRE4 { get; set; }
        public string G03_LIBRE5 { get; set; }
        public string G03_PREFIXE_ADR { get; set; }
        public string G03_COMPLEMENT_ADR { get; set; }
        public string G03_ZIP_CODE_ADR { get; set; }
        public string G03_PREFIXE_ADR_DIVERS { get; set; }
        public string G03_COMPLEMENT_ADR_DIVERS { get; set; }
        public string G03_ZIP_CODE_ADR_DIVERS { get; set; }
        public string G03_LIBRE6 { get; set; }
        public string G03_LIBRE7 { get; set; }
        public string G03_LIBRE8 { get; set; }
        public string G03_LIBRE9 { get; set; }
        public string G03_LIBRE10 { get; set; }
        public Nullable<int> G03_ID_PAYS_G29 { get; set; }
        public Nullable<int> G03_ID_PAYS1_G29 { get; set; }
        public string G03_EMAIL2 { get; set; }
        public string G03_LOGIN_ID { get; set; }
        public Nullable<int> G03_LIE { get; set; }
        public Nullable<int> G03_INVALID { get; set; }
        public Nullable<System.DateTime> G03_DATEVALID { get; set; }
        public Nullable<short> G03_WEB { get; set; }
        public Nullable<int> G03_ID_LOGIN_TYPE_A44 { get; set; }
        public string G03_PINCODE { get; set; }
        public Nullable<short> G03_HOT { get; set; }
        public Nullable<short> G03_PART { get; set; }
        public Nullable<short> G03_LIEN_PRINCIPAL { get; set; }
        public Nullable<int> G03_ID_ADM_A48 { get; set; }
        public Nullable<short> G03_DEVIS { get; set; }
        public Nullable<short> G03_APPEL_D_OFFRE { get; set; }
        public string G03_PASSWORD2 { get; set; }
        public Nullable<short> G03_CHKMAIL { get; set; }
        public Nullable<System.DateTime> G03_DATE_CREATION { get; set; }
        public Nullable<int> G03_ID_RIVOLI_G53 { get; set; }
        public Nullable<int> G03_NUM_VOIE { get; set; }
        public Nullable<int> G03_ID_RIVOLI_DIVERS_G53 { get; set; }
        public Nullable<int> G03_NUM_VOIE_DIVERS { get; set; }
        public Nullable<short> G03_FLAG { get; set; }
        public string G03_CB_CODE { get; set; }
        public string G03_MD5_HASH { get; set; }
        public string G03_CARDEX_ALIMENTAIRE { get; set; }
        public string G03_CARDEX_GENERAL { get; set; }
        public Nullable<short> G03_NOMAIL { get; set; }
        public Nullable<int> G03_FACTURATION { get; set; }
        public Nullable<short> G03_VALIDEUR_WEB { get; set; }
        public Nullable<int> G03_APIID { get; set; }
        public string G03_PAYS { get; set; }
        public Nullable<short> G03_CHKCERTIF { get; set; }
        public string G03_BLOG { get; set; }
        public Nullable<bool> G03_FLAG_ACCOUNT { get; set; }
        public string G03_CIVILITE { get; set; }
        public string G03_COMMENT { get; set; }
        public string G03_INDICATIF { get; set; }
        public string G03_SOCIETE { get; set; }
        public string G03_ENTITE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_MESSAGE_A62> ADH_MESSAGE_A62 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_PANIER_A61> ADH_PANIER_A61 { get; set; }
        public virtual CFG_SOCIETE_C13 CFG_SOCIETE_C13 { get; set; }
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C18 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_COMMANDES_F04> FIN_COMMANDES_F04 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_ACTIONS_G01> GRC_ACTIONS_G01 { get; set; }
        public virtual GRC_FONCTION_G32 GRC_FONCTION_G32 { get; set; }
        public virtual GRC_ORGANISMES_G09 GRC_ORGANISMES_G09 { get; set; }
        public virtual GRC_FIDELITE_G33 GRC_FIDELITE_G33 { get; set; }
        public virtual GRC_TITRE_G10 GRC_TITRE_G10 { get; set; }
        public virtual GRC_TYPE_CTC1_G22 GRC_TYPE_CTC1_G22 { get; set; }
        public virtual GRC_TYPE_CTC2_G23 GRC_TYPE_CTC2_G23 { get; set; }
        public virtual GRC_TYPE_CTC3_G24 GRC_TYPE_CTC3_G24 { get; set; }
        public virtual GRC_TYPE_CTC4_G25 GRC_TYPE_CTC4_G25 { get; set; }
        public virtual GRC_TYPE_CTC5_G26 GRC_TYPE_CTC5_G26 { get; set; }
        public virtual GRC_TYPE_LIEN_CTC_ORG_G39 GRC_TYPE_LIEN_CTC_ORG_G39 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_LIENS_CTC_ORG_G38> GRC_LIENS_CTC_ORG_G38 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRC_LIENS_CTC_ORG_G38> GRC_LIENS_CTC_ORG_G381 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOT_CARDEX_CHAMBRE_H48> HOT_CARDEX_CHAMBRE_H48 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOT_SOUS_RESERVATION_H02> HOT_SOUS_RESERVATION_H02 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_MANIFESTATIONS_M14> MAN_MANIFESTATIONS_M14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAN_PRESTATIONS_M16> MAN_PRESTATIONS_M16 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDC_USERS_MAIL_P19> PDC_USERS_MAIL_P19 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REC_CARTE_R02> REC_CARTE_R02 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_RESERVATION_T04> TBL_RESERVATION_T04 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_U14> USR_MESSAGE_U14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_U14> USR_MESSAGE_U141 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_ARCHIVE_U22> USR_MESSAGE_ARCHIVE_U22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_ARCHIVE_U22> USR_MESSAGE_ARCHIVE_U221 { get; set; }
    }
}