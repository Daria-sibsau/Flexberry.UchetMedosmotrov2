﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.UchetMedosmotrov2
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудники CustomAttributes)

    // *** End programmer edit section *** (Сотрудники CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникиE", new string[] {
            "ФИО as \'ФИО\'",
            "Пол as \'Пол\'",
            "ДатаРождения as \'Дата рождения\'",
            "СерияПаспорта as \'Серия паспорта\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "Телефон as \'Телефон\'",
            "IDСотрудника as \'ID сотрудника\'",
            "Должности as \'Должность\'",
            "Должности.Наименование as \'Должность\'",
            "Должности.Подразделения.Наименование as \'Подразделение\'"}, Hidden=new string[] {
            "Должности.Наименование"})]
    [MasterViewDefineAttribute("СотрудникиE", "Должности", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("СотрудникиL", new string[] {
            "ФИО as \'ФИО\'",
            "Пол as \'Пол\'",
            "ДатаРождения as \'Дата рождения\'",
            "СерияПаспорта as \'Серия паспорта\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "Телефон as \'Телефон\'",
            "IDСотрудника as \'ID сотрудника\'",
            "Должности.Наименование as \'Должность\'"})]
    public class Сотрудники : ICSSoft.STORMNET.DataObject
    {
        
        private string fФИО;
        
        private IIS.UchetMedosmotrov2.ПолСотрудника fПол;
        
        private System.DateTime fДатаРождения;
        
        private int fСерияПаспорта;
        
        private int fНомерПаспорта;
        
        private int fТелефон;
        
        private int fIDСотрудника;
        
        private IIS.UchetMedosmotrov2.Должности fДолжности;
        
        // *** Start programmer edit section *** (Сотрудники CustomMembers)

        // *** End programmer edit section *** (Сотрудники CustomMembers)

        
        /// <summary>
        /// IDСотрудника.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.IDСотрудника CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.IDСотрудника CustomAttributes)
        public virtual int IDСотрудника
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.IDСотрудника Get start)

                // *** End programmer edit section *** (Сотрудники.IDСотрудника Get start)
                int result = this.fIDСотрудника;
                // *** Start programmer edit section *** (Сотрудники.IDСотрудника Get end)

                // *** End programmer edit section *** (Сотрудники.IDСотрудника Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.IDСотрудника Set start)

                // *** End programmer edit section *** (Сотрудники.IDСотрудника Set start)
                this.fIDСотрудника = value;
                // *** Start programmer edit section *** (Сотрудники.IDСотрудника Set end)

                // *** End programmer edit section *** (Сотрудники.IDСотрудника Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.ДатаРождения CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.ДатаРождения CustomAttributes)
        public virtual System.DateTime ДатаРождения
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.ДатаРождения Get start)

                // *** End programmer edit section *** (Сотрудники.ДатаРождения Get start)
                System.DateTime result = this.fДатаРождения;
                // *** Start programmer edit section *** (Сотрудники.ДатаРождения Get end)

                // *** End programmer edit section *** (Сотрудники.ДатаРождения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.ДатаРождения Set start)

                // *** End programmer edit section *** (Сотрудники.ДатаРождения Set start)
                this.fДатаРождения = value;
                // *** Start programmer edit section *** (Сотрудники.ДатаРождения Set end)

                // *** End programmer edit section *** (Сотрудники.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// НомерПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.НомерПаспорта CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.НомерПаспорта CustomAttributes)
        public virtual int НомерПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.НомерПаспорта Get start)

                // *** End programmer edit section *** (Сотрудники.НомерПаспорта Get start)
                int result = this.fНомерПаспорта;
                // *** Start programmer edit section *** (Сотрудники.НомерПаспорта Get end)

                // *** End programmer edit section *** (Сотрудники.НомерПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.НомерПаспорта Set start)

                // *** End programmer edit section *** (Сотрудники.НомерПаспорта Set start)
                this.fНомерПаспорта = value;
                // *** Start programmer edit section *** (Сотрудники.НомерПаспорта Set end)

                // *** End programmer edit section *** (Сотрудники.НомерПаспорта Set end)
            }
        }
        
        /// <summary>
        /// Пол.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Пол CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Пол CustomAttributes)
        public virtual IIS.UchetMedosmotrov2.ПолСотрудника Пол
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Пол Get start)

                // *** End programmer edit section *** (Сотрудники.Пол Get start)
                IIS.UchetMedosmotrov2.ПолСотрудника result = this.fПол;
                // *** Start programmer edit section *** (Сотрудники.Пол Get end)

                // *** End programmer edit section *** (Сотрудники.Пол Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Пол Set start)

                // *** End programmer edit section *** (Сотрудники.Пол Set start)
                this.fПол = value;
                // *** Start programmer edit section *** (Сотрудники.Пол Set end)

                // *** End programmer edit section *** (Сотрудники.Пол Set end)
            }
        }
        
        /// <summary>
        /// СерияПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.СерияПаспорта CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.СерияПаспорта CustomAttributes)
        public virtual int СерияПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.СерияПаспорта Get start)

                // *** End programmer edit section *** (Сотрудники.СерияПаспорта Get start)
                int result = this.fСерияПаспорта;
                // *** Start programmer edit section *** (Сотрудники.СерияПаспорта Get end)

                // *** End programmer edit section *** (Сотрудники.СерияПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.СерияПаспорта Set start)

                // *** End programmer edit section *** (Сотрудники.СерияПаспорта Set start)
                this.fСерияПаспорта = value;
                // *** Start programmer edit section *** (Сотрудники.СерияПаспорта Set end)

                // *** End programmer edit section *** (Сотрудники.СерияПаспорта Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Телефон CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Телефон CustomAttributes)
        public virtual int Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Телефон Get start)

                // *** End programmer edit section *** (Сотрудники.Телефон Get start)
                int result = this.fТелефон;
                // *** Start programmer edit section *** (Сотрудники.Телефон Get end)

                // *** End programmer edit section *** (Сотрудники.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Телефон Set start)

                // *** End programmer edit section *** (Сотрудники.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Сотрудники.Телефон Set end)

                // *** End programmer edit section *** (Сотрудники.Телефон Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.ФИО CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.ФИО Get start)

                // *** End programmer edit section *** (Сотрудники.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Сотрудники.ФИО Get end)

                // *** End programmer edit section *** (Сотрудники.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.ФИО Set start)

                // *** End programmer edit section *** (Сотрудники.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Сотрудники.ФИО Set end)

                // *** End programmer edit section *** (Сотрудники.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Должности CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Должности CustomAttributes)
        [PropertyStorage(new string[] {
                "Должности"})]
        [NotNull()]
        public virtual IIS.UchetMedosmotrov2.Должности Должности
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Должности Get start)

                // *** End programmer edit section *** (Сотрудники.Должности Get start)
                IIS.UchetMedosmotrov2.Должности result = this.fДолжности;
                // *** Start programmer edit section *** (Сотрудники.Должности Get end)

                // *** End programmer edit section *** (Сотрудники.Должности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Должности Set start)

                // *** End programmer edit section *** (Сотрудники.Должности Set start)
                this.fДолжности = value;
                // *** Start programmer edit section *** (Сотрудники.Должности Set end)

                // *** End programmer edit section *** (Сотрудники.Должности Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиE", typeof(IIS.UchetMedosmotrov2.Сотрудники));
                }
            }
            
            /// <summary>
            /// "СотрудникиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиL", typeof(IIS.UchetMedosmotrov2.Сотрудники));
                }
            }
        }
    }
}
