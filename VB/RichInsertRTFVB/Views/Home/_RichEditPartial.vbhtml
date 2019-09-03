@Code
    Dim rich = Html.DevExpress().RichEdit(Sub(settings)
                                              settings.Name = "RichEdit"
                                              settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "RichEditPartial"}
                                              settings.CustomActionRouteValues = New With {Key .Controller = "Home", Key .Action = "RichEditCustomPartial"}
                                              settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                              settings.Height = 500
                                              settings.ReadOnly = False
                                              settings.RibbonMode = RichEditRibbonMode.Ribbon
                                              settings.WorkDirectory = "~/App_Data/WorkDirectory"
                                              settings.CustomJSProperties = Sub(sender, e)
                                                                                e.Properties("cpRtf") = ViewData("RTF")
                                                                            End Sub
                                          End Sub)
    If Model IsNot Nothing Then
        rich.Open(Model.DocumentId, Model.DocumentFormat, Function() As Byte()
                                                              Return Model.Document
                                                          End Function)
    End If
End Code
@rich.GetHtml()