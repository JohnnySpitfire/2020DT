Imports System.Data.SqlClient
Public Class search
    Inherits System.Web.UI.Page
    Protected Sub btnNameOnItemSearch_Click(sender As Object, e As EventArgs) Handles btnNameOnItemSearch.Click

        Call SearchDB("NameOnItem", txtNameOnItem.Text, "string")

    End Sub

    Protected Sub btnItemNameSearch_Click(sender As Object, e As EventArgs) Handles btnItemNameSearch.Click

        Call SearchDB("ItemName", txtItemName.Text, "string")

    End Sub

    Protected Sub btnCategorySearch_Click(sender As Object, e As EventArgs) Handles btnCategory.Click

        Call SearchDB("Category", ddlCategory.Text, "dropdownlist")

    End Sub

    Protected Sub btnColourSearch_Click(sender As Object, e As EventArgs) Handles btnColour.Click

        Call SearchDB("Colour", ddlColour.Text, "dropdownlist")

    End Sub

    Protected Sub btnTimeSearch_Click(sender As Object, e As EventArgs) Handles btnTime.Click

        Call SearchDB("TimeFound", ddlTime.Text, "dropdownlist")

    End Sub

    Protected Sub btnDateSearch_Click(sender As Object, e As EventArgs) Handles btnDate.Click

        Call SearchDB("DateFound", txtDate.Text, "date")

    End Sub

    Protected Sub btnItemLostToday_Click(sender As Object, e As EventArgs) Handles btnItemLostToday.Click

        Call SearchDB("DateFound", Date.Now.ToString("dd/MM/yyyy"), "date")

    End Sub
    ''queries database for results depending on input fields
    Private Sub SearchDB(strField As String, strUserInput As String, strSearchType As String)

        Dim strSQL As String

        Dim sqlCmd As New SqlCommand

        Dim ds As New DataSet


        Select Case strSearchType
            ''string query
            Case = "string"

                sqlCmd.Parameters.AddWithValue("@strUserInput", strUserInput)
                strSQL = "SELECT * FROM tblLostProperty WHERE [" & strField & "] LIKE CONCAT('%', @strUserInput,'%')"
                ''dropdown list query
            Case = "dropdownlist"

                sqlCmd.Parameters.AddWithValue("@strUserInput", strUserInput)
                strSQL = "SELECT * FROM tblLostProperty WHERE [" & strField & "] = @strUserInput"
                ''date query
            Case = "date"

                Dim newDate As New DateTime

                Dim provider As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InvariantCulture
                newDate = Date.ParseExact(strUserInput, "d/MM/yyyy", provider)

                sqlCmd.Parameters.AddWithValue("@dteDate", newDate)

                strSQL = "SELECT * FROM tblLostProperty WHERE [DateFound] = @dteDate"
                ''fallback query
            Case Else

                strSQL = "SELECT * FROM tblLostProperty"


        End Select
        ''queries database and sets dataset to results and redirects to results page
        sqlCmd.CommandText = strSQL
        ds = QueryDataBase(sqlCmd)

        Session("results") = ds
        Response.Redirect("results.aspx")

    End Sub

End Class