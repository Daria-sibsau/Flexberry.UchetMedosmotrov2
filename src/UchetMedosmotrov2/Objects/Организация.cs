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
    /// Организация.
    /// </summary>
    // *** Start programmer edit section *** (Организация CustomAttributes)

    // *** End programmer edit section *** (Организация CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОрганизацияE", new string[] {
            "Наименование as \'Наименование\'",
            "ИНН as \'ИНН\'",
            "КПП as \'КПП\'",
            "ОГРН as \'ОГРН\'",
            "Телефон as \'Телефон\'",
            "Почта as \'Почта\'",
            "ЮрАдрес as \'Юр адрес\'"})]
    [View("ОрганизацияL", new string[] {
            "Наименование as \'Наименование\'",
            "ИНН as \'ИНН\'",
            "КПП as \'КПП\'",
            "ОГРН as \'ОГРН\'",
            "Телефон as \'Телефон\'",
            "Почта as \'Почта\'",
            "ЮрАдрес as \'Юр адрес\'"})]
    public class Организация : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private int fИНН;
        
        private int fКПП;
        
        private int fОГРН;
        
        private int fТелефон;
        
        private string fПочта;
        
        private string fЮрАдрес;
        
        // *** Start programmer edit section *** (Организация CustomMembers)

        // *** End programmer edit section *** (Организация CustomMembers)

        
        /// <summary>
        /// ИНН.
        /// </summary>
        // *** Start programmer edit section *** (Организация.ИНН CustomAttributes)

        // *** End programmer edit section *** (Организация.ИНН CustomAttributes)
        public virtual int ИНН
        {
            get
            {
                // *** Start programmer edit section *** (Организация.ИНН Get start)

                // *** End programmer edit section *** (Организация.ИНН Get start)
                int result = this.fИНН;
                // *** Start programmer edit section *** (Организация.ИНН Get end)

                // *** End programmer edit section *** (Организация.ИНН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.ИНН Set start)

                // *** End programmer edit section *** (Организация.ИНН Set start)
                this.fИНН = value;
                // *** Start programmer edit section *** (Организация.ИНН Set end)

                // *** End programmer edit section *** (Организация.ИНН Set end)
            }
        }
        
        /// <summary>
        /// КПП.
        /// </summary>
        // *** Start programmer edit section *** (Организация.КПП CustomAttributes)

        // *** End programmer edit section *** (Организация.КПП CustomAttributes)
        public virtual int КПП
        {
            get
            {
                // *** Start programmer edit section *** (Организация.КПП Get start)

                // *** End programmer edit section *** (Организация.КПП Get start)
                int result = this.fКПП;
                // *** Start programmer edit section *** (Организация.КПП Get end)

                // *** End programmer edit section *** (Организация.КПП Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.КПП Set start)

                // *** End programmer edit section *** (Организация.КПП Set start)
                this.fКПП = value;
                // *** Start programmer edit section *** (Организация.КПП Set end)

                // *** End programmer edit section *** (Организация.КПП Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Организация.Наименование CustomAttributes)

        // *** End programmer edit section *** (Организация.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Организация.Наименование Get start)

                // *** End programmer edit section *** (Организация.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Организация.Наименование Get end)

                // *** End programmer edit section *** (Организация.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.Наименование Set start)

                // *** End programmer edit section *** (Организация.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Организация.Наименование Set end)

                // *** End programmer edit section *** (Организация.Наименование Set end)
            }
        }
        
        /// <summary>
        /// ОГРН.
        /// </summary>
        // *** Start programmer edit section *** (Организация.ОГРН CustomAttributes)

        // *** End programmer edit section *** (Организация.ОГРН CustomAttributes)
        public virtual int ОГРН
        {
            get
            {
                // *** Start programmer edit section *** (Организация.ОГРН Get start)

                // *** End programmer edit section *** (Организация.ОГРН Get start)
                int result = this.fОГРН;
                // *** Start programmer edit section *** (Организация.ОГРН Get end)

                // *** End programmer edit section *** (Организация.ОГРН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.ОГРН Set start)

                // *** End programmer edit section *** (Организация.ОГРН Set start)
                this.fОГРН = value;
                // *** Start programmer edit section *** (Организация.ОГРН Set end)

                // *** End programmer edit section *** (Организация.ОГРН Set end)
            }
        }
        
        /// <summary>
        /// Почта.
        /// </summary>
        // *** Start programmer edit section *** (Организация.Почта CustomAttributes)

        // *** End programmer edit section *** (Организация.Почта CustomAttributes)
        [StrLen(255)]
        public virtual string Почта
        {
            get
            {
                // *** Start programmer edit section *** (Организация.Почта Get start)

                // *** End programmer edit section *** (Организация.Почта Get start)
                string result = this.fПочта;
                // *** Start programmer edit section *** (Организация.Почта Get end)

                // *** End programmer edit section *** (Организация.Почта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.Почта Set start)

                // *** End programmer edit section *** (Организация.Почта Set start)
                this.fПочта = value;
                // *** Start programmer edit section *** (Организация.Почта Set end)

                // *** End programmer edit section *** (Организация.Почта Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Организация.Телефон CustomAttributes)

        // *** End programmer edit section *** (Организация.Телефон CustomAttributes)
        public virtual int Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Организация.Телефон Get start)

                // *** End programmer edit section *** (Организация.Телефон Get start)
                int result = this.fТелефон;
                // *** Start programmer edit section *** (Организация.Телефон Get end)

                // *** End programmer edit section *** (Организация.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.Телефон Set start)

                // *** End programmer edit section *** (Организация.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Организация.Телефон Set end)

                // *** End programmer edit section *** (Организация.Телефон Set end)
            }
        }
        
        /// <summary>
        /// ЮрАдрес.
        /// </summary>
        // *** Start programmer edit section *** (Организация.ЮрАдрес CustomAttributes)

        // *** End programmer edit section *** (Организация.ЮрАдрес CustomAttributes)
        [StrLen(255)]
        public virtual string ЮрАдрес
        {
            get
            {
                // *** Start programmer edit section *** (Организация.ЮрАдрес Get start)

                // *** End programmer edit section *** (Организация.ЮрАдрес Get start)
                string result = this.fЮрАдрес;
                // *** Start programmer edit section *** (Организация.ЮрАдрес Get end)

                // *** End programmer edit section *** (Организация.ЮрАдрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Организация.ЮрАдрес Set start)

                // *** End programmer edit section *** (Организация.ЮрАдрес Set start)
                this.fЮрАдрес = value;
                // *** Start programmer edit section *** (Организация.ЮрАдрес Set end)

                // *** End programmer edit section *** (Организация.ЮрАдрес Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОрганизацияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОрганизацияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОрганизацияE", typeof(IIS.UchetMedosmotrov2.Организация));
                }
            }
            
            /// <summary>
            /// "ОрганизацияL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОрганизацияL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОрганизацияL", typeof(IIS.UchetMedosmotrov2.Организация));
                }
            }
        }
    }
}
