Imports System.Data.SqlClient
Public Class index
    Inherits System.Web.UI.Page


    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Call InsertData()

    End Sub

    Sub InsertData()
        ''create strings
        Dim nameOnItem As String = ""
        Dim nameOfItem As String = txtItemName.Text
        Dim category As String = ddlCategory.Text
        Dim colour As String = ddlColour.Text
        Dim time As String = ddlTime.Text
        ''check if name on item is blank, and ask user if they wish to keep name blank otherwise continue as normal
        If txtNameOnItem.Text = "" Then

            Dim msgResult As MsgBoxResult = MsgBox("Do you wish to keep name on item blank?", vbYesNo, "Warning")
            ''if user wants name blank then fill in placeholder
            If msgResult = vbYes Then

                nameOnItem = "N/A"
                ''else cancel data insertion
            ElseIf msgResult = vbNo = True Then

                Exit Sub

            End If

        Else

            nameOnItem = txtNameOnItem.Text

        End If

        'date setup
        Dim provider As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InvariantCulture
        Dim newDate As New Date()
        newDate = Date.ParseExact(txtDate.Text, "dd/MM/yyyy", provider)
        ''sql setup
        Dim strSQL As String = "INSERT INTO [dbo].[tblLostProperty] ([NameOnItem], [ItemName], [Category], [Colour], [TimeFound], [DateFound]) VALUES ("
        strSQL &= "@nameOnItem, @itemName ,@category ,@colour ,@timeFound, @dateFound)"
        Dim sqlCmd As SqlCommand
        Dim sqlConn As New SqlConnection(strConn)
        ''try insert data into the database
        Try

            sqlConn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlConn)

            With sqlCmd.Parameters
                ''sql parameter setup
                .AddWithValue("@nameOnItem", nameOnItem)
                .AddWithValue("@itemName", nameOfItem)
                .AddWithValue("@category", category)
                .AddWithValue("@colour", colour)
                .AddWithValue("@timeFound", time)
                .AddWithValue("@dateFound", newDate)

            End With
            ''add data to the table, and clear the input boxes
            sqlCmd.ExecuteNonQuery()
            Call ClearFields()

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly, "An error has occoured processing your request")

        Finally

            ''close connection
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

        End Try
        ''get session ID for success page
        Call SetSessionID(nameOnItem, nameOfItem, category, colour, time, newDate)

        Response.Redirect("success.aspx")

    End Sub

    Private Sub SetSessionID(strNameOnItem As String, strItemName As String, strCategory As String, strColour As String, strTime As String, dteDate As Date)
        ''sql setup
        Dim strSQL = "SELECT Id FROM tblLostProperty WHERE [NameOnItem] = @nameOnItem AND [ItemName] = @itemName"
        strSQL &= " AND [Category] = @category AND [Colour] = @colour AND [TimeFound] = @timeFound AND [DateFound] = @dateFound"

        Dim sqlCmd As SqlCommand
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlDA As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            ''open connection
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlConn)

            With sqlCmd.Parameters
                ''sql parameter setup
                .AddWithValue("@nameOnItem", strNameOnItem)
                .AddWithValue("@itemName", strItemName)
                .AddWithValue("@category", strCategory)
                .AddWithValue("@colour", strColour)
                .AddWithValue("@TimeFound", strTime)
                .AddWithValue("@DateFound", dteDate)

            End With
            ''query database with exact perameters and set results to data set
            ds = QueryDataBase(sqlCmd)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim intID As Integer = ds.Tables(0).Rows(0).Item(0)
                ''sets the session id
                Session("LPID") = intID

            End If

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly, "An error has occoured processing your request")

        Finally
            ''tidy up
            sqlDA.Dispose()
            ds.Dispose()
            ''close connection
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

        End Try

    End Sub

    Sub ClearFields()

        txtDate.Text = ""
        txtItemName.Text = ""
        txtNameOnItem.Text = ""
        ddlCategory.SelectedValue = "-Choose-"
        ddlColour.SelectedValue = "-Choose-"
        ddlTime.SelectedValue = "-Choose-"

    End Sub


End Class