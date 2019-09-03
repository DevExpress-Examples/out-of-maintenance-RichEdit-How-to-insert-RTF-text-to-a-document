@Code
    ViewData("Title") = "RichEdit - How to insert RTF text to a document"
End Code

<script type="text/javascript">
    function onClientButtonClick(s, e) {
        var startPosition = RichEdit.selection.intervals[0].start;
        var rtf = RichEdit.cpRtf;
        RichEdit.commands.insertRtf.execute(rtf, startPosition);
    }
    function onServerButtonClick(s, e) {
        var startPosition = RichEdit.selection.intervals[0].start;
        RichEdit.PerformCallback({ position: startPosition });
    }
</script>


@Using (Html.BeginForm())
    @Html.Action("RichEditPartial")
End Using

@Html.DevExpress().Button(Sub(button)

                                   button.Name = "ClientButton"
                                   button.Text = "Insert RTF text on the client side"
                                   button.UseSubmitBehavior = False
                                   button.ClientSideEvents.Click = "onClientButtonClick"
                               End Sub).GetHtml()

@Html.DevExpress().Button(Sub(button)
                                   button.Name = "ServerButton"
                                   button.Text = "Insert RTF text on the server side"
                                   button.UseSubmitBehavior = False
                                   button.ClientSideEvents.Click = "onServerButtonClick"
                               End Sub).GetHtml()
