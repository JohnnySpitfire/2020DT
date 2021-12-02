Public Class results
    Inherits System.Web.UI.Page

    'on page load sets the dataset to the session id and draw the table
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ds As DataSet = Session("results")

        Call DisplayTable(ds)

    End Sub

    Private Sub DisplayTable(ds As DataSet)

        'Creates stringbuilder and adds link to return to search page

        Dim stringBuilder As StringBuilder = New StringBuilder()
        stringBuilder.Append("<a href=""search.aspx"">Return to search</a><br/>")

        'checks if there are any results in the data set and return no results if there are one
        If ds.Tables.Count = 0 Or ds.Tables(0).Rows.Count < 1 Then

            stringBuilder.Append("<h2> There are no results </h2>")



        Else
            ''Adds html code to stringbuilder
            With stringBuilder


                .Append("<table Class=""results"">")


                .Append("<tr Class=""results"">")
                ''Table Coloumn names
                .Append("<th Class=""results"">Name On Item</th>")
                .Append("<th Class=""results"">Item Name</th>")
                .Append("<th Class=""results"">Category</th>")
                .Append("<th Class=""results"">Colour</th>")
                .Append("<th Class=""results"">Date Found</th>")
                .Append("<th Class=""results"">Time Found</th>")


                .Append("</tr>")

                .Append("<tr Class=""results"">")
                ''adds a row for each data entry in the dataset to the string builder, and subsequently the table
                For Each row As DataRow In ds.Tables(0).Rows

                    .Append("<td Class=""results"">" & row(1) & "</td>")
                    .Append("<td Class=""results"">" & row(2) & "</td>")
                    .Append("<td Class=""results"">" & row(3) & "</td>")
                    .Append("<td Class=""results"">" & row(4) & "</td>")
                    .Append("<td Class=""results"">" & row(5) & "</td>")
                    .Append("<td Class=""results"">" & row(6).ToString & "</td>")

                    .Append("</tr>")

                Next


                .Append("</table>")



            End With

        End If


        ''adds all of the stringbuilder code to the placeholder in the results aspx page
        plhResults.Controls.Add(New LiteralControl(stringBuilder.ToString()))

    End Sub

End Class