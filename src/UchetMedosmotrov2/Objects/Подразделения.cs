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
    /// Подразделения.
    /// </summary>
    // *** Start programmer edit section *** (Подразделения CustomAttributes)

    // *** End programmer edit section *** (Подразделения CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПодразделенияE", new string[] {
            "Наименование as \'Наименование\'"})]
    [View("ПодразделенияL", new string[] {
            "Наименование as \'Наименование\'"})]
    public class Подразделения : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        // *** Start programmer edit section *** (Подразделения CustomMembers)

        // *** End programmer edit section *** (Подразделения CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Подразделения.Наименование CustomAttributes)

        // *** End programmer edit section *** (Подразделения.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Подразделения.Наименование Get start)

                // *** End programmer edit section *** (Подразделения.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Подразделения.Наименование Get end)

                // *** End programmer edit section *** (Подразделения.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Подразделения.Наименование Set start)

                // *** End programmer edit section *** (Подразделения.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Подразделения.Наименование Set end)

                // *** End programmer edit section *** (Подразделения.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПодразделенияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПодразделенияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПодразделенияE", typeof(IIS.UchetMedosmotrov2.Подразделения));
                }
            }
            
            /// <summary>
            /// "ПодразделенияL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПодразделенияL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПодразделенияL", typeof(IIS.UchetMedosmotrov2.Подразделения));
                }
            }
        }
    }
}
