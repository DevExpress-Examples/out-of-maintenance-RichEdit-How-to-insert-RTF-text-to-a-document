*Files to look at:*

 - [Index.cshtml](CS/RichInsertRTF/Views/Home/Index.cshtml) (VB: [Index.vbhtml](VB/RichInsertRTFVB/Views/Home/Index.vbhtml))
 - [_RichEditPartial.cshtml](CS/RichInsertRTF/Views/Home/_RichEditPartial.cshtml) (VB: [_RichEditPartial.vbhtml](VB/RichInsertRTFVB/Views/Home/_RichEditPartial.vbhtml))
 - [HomeController.cs](CS/RichInsertRTF/Controllers/HomeController.cs) (VB: [HomeController.vb](VB/RichInsertRTFVB/Controllers/HomeController.vb))
 - [RichEditData.cs](CS/RichInsertRTF/Models/RichEditData.cs) (VB: [RichEditData.vb](VB/RichInsertRTFVB/Models/RichEditData.vb))

# RichEdit - How to insert RTF text to a document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/206129792/)**
<!-- run online end -->

Starting with version 18.1, the RichEdit extension provides the [insertRtf](https://docs.devexpress.com/AspNet/js-RichEditCommands.insertRtf) command, which allows you to add formatted RTF content at the specified position.  
In versions prior to 18.1, RichEdit doesn't provide a functionality to insert RTF formatted text on the client side so that this format is applied automatically. This example demonstrates a workaround that allows you to insert formatted RTF text to the current document on a button click via a RichEdit callback.  

To implement this scenario, initiate a RichEdit custom callback via the client\-side [MVCxClientRichEdit.PerformCallback](https://docs.devexpress.com/AspNet/js-MVCxClientRichEdit.PerformCallback(data)) method and define the [RichEditSettings.CustomActionRouteValues](https://documentation.devexpress.com/AspNet/DevExpress.Web.Mvc.RichEditSettings.CustomActionRouteValues.property) property. To insert the required text into the specified position, you can use the [SubDocument.InsertRtfText](https://documentation.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.InsertRtfText.overloads) method.  
To insert this text at the current caret position in the middle of a document text, obtain this position on the client side by using the [RichEditSelection.intervals](https://documentation.devexpress.com/#AspNet/DevExpressWebASPxRichEditScriptsRichEditSelection_intervalstopic) array object and pass it to the server as a parameter of the [MVCxClientRichEdit.PerformCallback](https://docs.devexpress.com/AspNet/js-MVCxClientRichEdit.PerformCallback(data)) method. Then, access this passed value in the action method specified in CustomActionRouteValues and use it to modify the current document position via the [Document.CreatePosition](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraRichEdit.API.Native.SubDocument.CreatePosition.method) method before inserting RTF text.

***See also:***

[ASPxRichEdit - How to insert RTF text to a document](https://www.devexpress.com/Support/Center/Example/Details/T532651/aspxrichedit-how-to-insert-rtf-text-to-a-document)
