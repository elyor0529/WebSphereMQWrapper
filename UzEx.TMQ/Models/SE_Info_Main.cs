﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ.Models
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false,ElementName = "Info_Main")] 
    public partial class SE_Info_Main
    {

        private System.DateTime info_DateField;

        private Info_MainExchangeData[] exchangeDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Info_Date
        {
            get
            {
                return this.info_DateField;
            }
            set
            {
                this.info_DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExchangeData")]
        public Info_MainExchangeData[] ExchangeData
        {
            get
            {
                return this.exchangeDataField;
            }
            set
            {
                this.exchangeDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainExchangeData
    {

        private string exchangeData_IDField;

        private Info_MainExchangeDataConsignee consigneeField;

        private Info_MainExchangeDataBargaining bargainingField;

        /// <remarks/>
        public string ExchangeData_ID
        {
            get
            {
                return this.exchangeData_IDField;
            }
            set
            {
                this.exchangeData_IDField = value;
            }
        }

        /// <remarks/>
        public Info_MainExchangeDataConsignee Consignee
        {
            get
            {
                return this.consigneeField;
            }
            set
            {
                this.consigneeField = value;
            }
        }

        /// <remarks/>
        public Info_MainExchangeDataBargaining Bargaining
        {
            get
            {
                return this.bargainingField;
            }
            set
            {
                this.bargainingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainExchangeDataConsignee
    {

        private uint iNNField;

        /// <remarks/>
        public uint INN
        {
            get
            {
                return this.iNNField;
            }
            set
            {
                this.iNNField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Info_MainExchangeDataBargaining
    {

        private ulong contract_CodeField;

        private string nameField;

        private decimal unitQuantityField;

        private decimal quantityForSaleField;

        private decimal quantitySalesField;

        private decimal quantityAnnulField;

        /// <remarks/>
        public ulong Contract_Code
        {
            get
            {
                return this.contract_CodeField;
            }
            set
            {
                this.contract_CodeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public decimal UnitQuantity
        {
            get
            {
                return this.unitQuantityField;
            }
            set
            {
                this.unitQuantityField = value;
            }
        }

        /// <remarks/>
        public decimal QuantityForSale
        {
            get
            {
                return this.quantityForSaleField;
            }
            set
            {
                this.quantityForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal QuantitySales
        {
            get
            {
                return this.quantitySalesField;
            }
            set
            {
                this.quantitySalesField = value;
            }
        }

        /// <remarks/>
        public decimal QuantityAnnul
        {
            get
            {
                return this.quantityAnnulField;
            }
            set
            {
                this.quantityAnnulField = value;
            }
        }
    }
     
}
