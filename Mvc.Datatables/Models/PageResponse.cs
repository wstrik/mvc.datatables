﻿using System.Xml.Serialization;

namespace Mvc.Datatables
{
    /// <summary>
    /// Mutable page response
    /// </summary>
    public abstract class PageResponse : IDataTableMessage
    {
        /// <summary>
        /// The draw counter that this object is a response to - from the draw parameter sent as part of the data request.
        /// </summary>
        public virtual int Draw { get; set; }

        /// <summary>
        /// Total records, before filtering (i.e. the total number of records in the database).
        /// </summary>
        public virtual int TotalRecords { get; set; }

        /// <summary>
        /// Total records, after filtering (i.e. the total number of records after filtering has been applied - not just the number of records being returned for this page of data).
        /// </summary>
        public virtual int TotalFilteredRecords { get; set; }

        /// <summary>
        /// The data to be displayed in the table. This is an array of data source objects, one for each row, which will be used by DataTables. Note that this parameter's name can be changed using the ajaxDT option's dataSrc property.
        /// </summary>
        [XmlArray("Data")]
        [XmlArrayItem("Item")]
        public virtual object[] Data { get; set; }

        /// <summary>
        /// Optional: If an error occurs during the running of the server-side processing script, you can inform the user of this error by passing back the error message to be displayed using this parameter. Do not include if there is no error.
        /// </summary>
        public virtual string Error { get; set; }

        public PageResponse() { }
    }
}