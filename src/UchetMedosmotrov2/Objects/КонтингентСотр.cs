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
    /// Контингент сотр.
    /// </summary>
    // *** Start programmer edit section *** (КонтингентСотр CustomAttributes)

    // *** End programmer edit section *** (КонтингентСотр CustomAttributes)
    [AutoAltered()]
    [Caption("Контингент сотр")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КонтингентСотрE", new string[] {
            "Мужчины as \'Мужчины\'",
            "Женщины as \'Женщины\'",
            "До21Года as \'До 21 года\'",
            "Всего as \'Всего\'",
            "КлассВредФакт as \'Класс вред факт\'",
            "КлассВредФакт.Наименование as \'Фактор производства\'",
            "ПриказМЗР as \'Приказ МЗР\'",
            "ПриказМЗР.НомерПункта as \'Номер пункта\'",
            "Периодичность as \'Периодичность\'"}, Hidden=new string[] {
            "КлассВредФакт.Наименование",
            "ПриказМЗР.НомерПункта"})]
    [MasterViewDefineAttribute("КонтингентСотрE", "КлассВредФакт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("КонтингентСотрE", "ПриказМЗР", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НомерПункта")]
    public class КонтингентСотр : ICSSoft.STORMNET.DataObject
    {
        
        private int fМужчины;
        
        private int fЖенщины;
        
        private int fДо21Года;
        
        private int fВсего;
        
        private IIS.UchetMedosmotrov2.Периодичность fПериодичность;
        
        private IIS.UchetMedosmotrov2.ПриказМЗР fПриказМЗР;
        
        private IIS.UchetMedosmotrov2.КлассВредФакт fКлассВредФакт;
        
        private IIS.UchetMedosmotrov2.СписокНаМедосм fСписокНаМедосм;
        
        // *** Start programmer edit section *** (КонтингентСотр CustomMembers)

        // *** End programmer edit section *** (КонтингентСотр CustomMembers)

        
        /// <summary>
        /// Всего.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.Всего CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.Всего CustomAttributes)
        public virtual int Всего
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.Всего Get start)

                // *** End programmer edit section *** (КонтингентСотр.Всего Get start)
                int result = this.fВсего;
                // *** Start programmer edit section *** (КонтингентСотр.Всего Get end)

                // *** End programmer edit section *** (КонтингентСотр.Всего Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.Всего Set start)

                // *** End programmer edit section *** (КонтингентСотр.Всего Set start)
                this.fВсего = value;
                // *** Start programmer edit section *** (КонтингентСотр.Всего Set end)

                // *** End programmer edit section *** (КонтингентСотр.Всего Set end)
            }
        }
        
        /// <summary>
        /// До21Года.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.До21Года CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.До21Года CustomAttributes)
        public virtual int До21Года
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.До21Года Get start)

                // *** End programmer edit section *** (КонтингентСотр.До21Года Get start)
                int result = this.fДо21Года;
                // *** Start programmer edit section *** (КонтингентСотр.До21Года Get end)

                // *** End programmer edit section *** (КонтингентСотр.До21Года Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.До21Года Set start)

                // *** End programmer edit section *** (КонтингентСотр.До21Года Set start)
                this.fДо21Года = value;
                // *** Start programmer edit section *** (КонтингентСотр.До21Года Set end)

                // *** End programmer edit section *** (КонтингентСотр.До21Года Set end)
            }
        }
        
        /// <summary>
        /// Женщины.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.Женщины CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.Женщины CustomAttributes)
        public virtual int Женщины
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.Женщины Get start)

                // *** End programmer edit section *** (КонтингентСотр.Женщины Get start)
                int result = this.fЖенщины;
                // *** Start programmer edit section *** (КонтингентСотр.Женщины Get end)

                // *** End programmer edit section *** (КонтингентСотр.Женщины Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.Женщины Set start)

                // *** End programmer edit section *** (КонтингентСотр.Женщины Set start)
                this.fЖенщины = value;
                // *** Start programmer edit section *** (КонтингентСотр.Женщины Set end)

                // *** End programmer edit section *** (КонтингентСотр.Женщины Set end)
            }
        }
        
        /// <summary>
        /// Мужчины.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.Мужчины CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.Мужчины CustomAttributes)
        public virtual int Мужчины
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.Мужчины Get start)

                // *** End programmer edit section *** (КонтингентСотр.Мужчины Get start)
                int result = this.fМужчины;
                // *** Start programmer edit section *** (КонтингентСотр.Мужчины Get end)

                // *** End programmer edit section *** (КонтингентСотр.Мужчины Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.Мужчины Set start)

                // *** End programmer edit section *** (КонтингентСотр.Мужчины Set start)
                this.fМужчины = value;
                // *** Start programmer edit section *** (КонтингентСотр.Мужчины Set end)

                // *** End programmer edit section *** (КонтингентСотр.Мужчины Set end)
            }
        }
        
        /// <summary>
        /// Периодичность.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.Периодичность CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.Периодичность CustomAttributes)
        public virtual IIS.UchetMedosmotrov2.Периодичность Периодичность
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.Периодичность Get start)

                // *** End programmer edit section *** (КонтингентСотр.Периодичность Get start)
                IIS.UchetMedosmotrov2.Периодичность result = this.fПериодичность;
                // *** Start programmer edit section *** (КонтингентСотр.Периодичность Get end)

                // *** End programmer edit section *** (КонтингентСотр.Периодичность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.Периодичность Set start)

                // *** End programmer edit section *** (КонтингентСотр.Периодичность Set start)
                this.fПериодичность = value;
                // *** Start programmer edit section *** (КонтингентСотр.Периодичность Set end)

                // *** End programmer edit section *** (КонтингентСотр.Периодичность Set end)
            }
        }
        
        /// <summary>
        /// Контингент сотр.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.КлассВредФакт CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.КлассВредФакт CustomAttributes)
        [PropertyStorage(new string[] {
                "КлассВредФакт"})]
        [NotNull()]
        public virtual IIS.UchetMedosmotrov2.КлассВредФакт КлассВредФакт
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.КлассВредФакт Get start)

                // *** End programmer edit section *** (КонтингентСотр.КлассВредФакт Get start)
                IIS.UchetMedosmotrov2.КлассВредФакт result = this.fКлассВредФакт;
                // *** Start programmer edit section *** (КонтингентСотр.КлассВредФакт Get end)

                // *** End programmer edit section *** (КонтингентСотр.КлассВредФакт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.КлассВредФакт Set start)

                // *** End programmer edit section *** (КонтингентСотр.КлассВредФакт Set start)
                this.fКлассВредФакт = value;
                // *** Start programmer edit section *** (КонтингентСотр.КлассВредФакт Set end)

                // *** End programmer edit section *** (КонтингентСотр.КлассВредФакт Set end)
            }
        }
        
        /// <summary>
        /// Контингент сотр.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.ПриказМЗР CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.ПриказМЗР CustomAttributes)
        [PropertyStorage(new string[] {
                "ПриказМЗР"})]
        [NotNull()]
        public virtual IIS.UchetMedosmotrov2.ПриказМЗР ПриказМЗР
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.ПриказМЗР Get start)

                // *** End programmer edit section *** (КонтингентСотр.ПриказМЗР Get start)
                IIS.UchetMedosmotrov2.ПриказМЗР result = this.fПриказМЗР;
                // *** Start programmer edit section *** (КонтингентСотр.ПриказМЗР Get end)

                // *** End programmer edit section *** (КонтингентСотр.ПриказМЗР Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.ПриказМЗР Set start)

                // *** End programmer edit section *** (КонтингентСотр.ПриказМЗР Set start)
                this.fПриказМЗР = value;
                // *** Start programmer edit section *** (КонтингентСотр.ПриказМЗР Set end)

                // *** End programmer edit section *** (КонтингентСотр.ПриказМЗР Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.UchetMedosmotrov2.СписокНаМедосм.
        /// </summary>
        // *** Start programmer edit section *** (КонтингентСотр.СписокНаМедосм CustomAttributes)

        // *** End programmer edit section *** (КонтингентСотр.СписокНаМедосм CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "СписокНаМедосм"})]
        public virtual IIS.UchetMedosmotrov2.СписокНаМедосм СписокНаМедосм
        {
            get
            {
                // *** Start programmer edit section *** (КонтингентСотр.СписокНаМедосм Get start)

                // *** End programmer edit section *** (КонтингентСотр.СписокНаМедосм Get start)
                IIS.UchetMedosmotrov2.СписокНаМедосм result = this.fСписокНаМедосм;
                // *** Start programmer edit section *** (КонтингентСотр.СписокНаМедосм Get end)

                // *** End programmer edit section *** (КонтингентСотр.СписокНаМедосм Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонтингентСотр.СписокНаМедосм Set start)

                // *** End programmer edit section *** (КонтингентСотр.СписокНаМедосм Set start)
                this.fСписокНаМедосм = value;
                // *** Start programmer edit section *** (КонтингентСотр.СписокНаМедосм Set end)

                // *** End programmer edit section *** (КонтингентСотр.СписокНаМедосм Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КонтингентСотрE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонтингентСотрE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонтингентСотрE", typeof(IIS.UchetMedosmotrov2.КонтингентСотр));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of КонтингентСотр.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfКонтингентСотр CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfКонтингентСотр CustomAttributes)
    public class DetailArrayOfКонтингентСотр : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.UchetMedosmotrov2.DetailArrayOfКонтингентСотр members)

        // *** End programmer edit section *** (IIS.UchetMedosmotrov2.DetailArrayOfКонтингентСотр members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type КонтингентСотр by index.
        /// </summary>
        /// <summary>
        /// Adds object with type КонтингентСотр.
        /// </summary>
        public DetailArrayOfКонтингентСотр(IIS.UchetMedosmotrov2.СписокНаМедосм fСписокНаМедосм) : 
                base(typeof(КонтингентСотр), ((ICSSoft.STORMNET.DataObject)(fСписокНаМедосм)))
        {
        }
        
        public IIS.UchetMedosmotrov2.КонтингентСотр this[int index]
        {
            get
            {
                return ((IIS.UchetMedosmotrov2.КонтингентСотр)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.UchetMedosmotrov2.КонтингентСотр dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
