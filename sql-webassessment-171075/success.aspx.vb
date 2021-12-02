Imports System.Data.SqlClient

Public Class success
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sqlCmd As New SqlCommand

        sqlCmd.CommandText = "Select * From tblLostProperty WHERE [Id] = " & Session("LPID")

        Dim ds As DataSet = QueryDataBase(sqlCmd)

        Dim stringBuilder As StringBuilder = New StringBuilder()

        With stringBuilder

            .Append("<table Class=""results"">")


            .Append(" <tr Class=""results"">")

            .Append("<th Class=""results"">Name On Label</th>")
            .Append("<th Class=""results"">Name Of Item</th>")
            .Append("<th Class=""results"">Category</th>")
            .Append("<th Class=""results"">Colour</th>")
            .Append("<th Class=""results"">Date Found</th>")
            .Append("<th Class=""results"">Time Found</th>")

            .Append("</tr>")

            .Append("<tr Class=""results"">")

            For Each row As DataRow In ds.Tables(0).Rows

                .Append("<td Class=""results"">" & row(1) & "</td>")
                .Append("<td Class=""results"">" & row(2) & "</td>")
                .Append("<td Class=""results"">" & row(3) & "</td>")
                .Append("<td Class=""results"">" & row(4) & "</td>")
                .Append("<td Class=""results"">" & row(5) & "</td>")
                .Append("<td Class=""results"">" & row(6).ToString & "</td>")

            Next
            .Append("</tr>")

            .Append("</table>")

        End With

        plhDataTable.Controls.Add(New LiteralControl(stringBuilder.ToString()))

    End Sub



End Class