﻿namespace UglyToad.PdfPig.DocumentLayoutAnalysis.Export.PAGE
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    public partial class PageXmlDocument
    {
        /// <remarks/>
        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCode("xsd", "4.6.1055.0")]
        [Serializable()]
        [XmlType(Namespace = "http://schema.primaresearch.org/PAGE/gts/pagecontent/2019-07-15")]
        public enum PageXmlGraphicsSimpleType
        {

            /// <remarks/>
            [XmlEnum("logo")]
            Logo,

            /// <remarks/>
            [XmlEnum("letterhead")]
            Letterhead,

            /// <remarks/>
            [XmlEnum("decoration")]
            Decoration,

            /// <remarks/>
            [XmlEnum("frame")]
            Frame,

            /// <remarks/>
            [XmlEnum("handwritten-annotation")]
            HandwrittenAnnotation,

            /// <remarks/>
            [XmlEnum("stamp")]
            Stamp,

            /// <remarks/>
            [XmlEnum("signature")]
            Signature,

            /// <remarks/>
            [XmlEnum("barcode")]
            Barcode,

            /// <remarks/>
            [XmlEnum("paper-grow")]
            PaperGrow,

            /// <remarks/>
            [XmlEnum("punch-hole")]
            PunchHole,

            /// <remarks/>
            [XmlEnum("other")]
            Other,
        }
    }
}
