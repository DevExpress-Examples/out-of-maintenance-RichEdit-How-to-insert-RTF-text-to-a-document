using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichInsertRTF.Models
{
    public class RichEditData
    {
        public string DocumentId { get; set; }
        public DocumentFormat DocumentFormat { get; set; }
        public byte[] Document { get; set; }
    }
}