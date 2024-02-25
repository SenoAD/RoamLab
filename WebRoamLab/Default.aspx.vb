Imports System.Windows

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        ViewState("Input1") = TB1.Text
        ViewState("Input2") = TB2.Text
        TB1.Text = ""
        TB2.Text = ""
    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        TB1.Text = ViewState("Input1")
        TB2.Text = ViewState("Input2")
    End Sub
End Class