<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayBookInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DeleteBookInfoButton = New System.Windows.Forms.Button()
        Me.CloseBookInfoButton = New System.Windows.Forms.Button()
        Me.BookInfoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DeleteBookInfoButton
        '
        Me.DeleteBookInfoButton.Location = New System.Drawing.Point(12, 153)
        Me.DeleteBookInfoButton.Name = "DeleteBookInfoButton"
        Me.DeleteBookInfoButton.Size = New System.Drawing.Size(82, 29)
        Me.DeleteBookInfoButton.TabIndex = 1
        Me.DeleteBookInfoButton.Text = "Delete Book"
        Me.DeleteBookInfoButton.UseVisualStyleBackColor = True
        '
        'CloseBookInfoButton
        '
        Me.CloseBookInfoButton.Location = New System.Drawing.Point(117, 153)
        Me.CloseBookInfoButton.Name = "CloseBookInfoButton"
        Me.CloseBookInfoButton.Size = New System.Drawing.Size(82, 29)
        Me.CloseBookInfoButton.TabIndex = 2
        Me.CloseBookInfoButton.Text = "Close"
        Me.CloseBookInfoButton.UseVisualStyleBackColor = True
        '
        'BookInfoTextBox
        '
        Me.BookInfoTextBox.Location = New System.Drawing.Point(12, 10)
        Me.BookInfoTextBox.Multiline = True
        Me.BookInfoTextBox.Name = "BookInfoTextBox"
        Me.BookInfoTextBox.Size = New System.Drawing.Size(195, 137)
        Me.BookInfoTextBox.TabIndex = 3
        '
        'DisplayBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 194)
        Me.Controls.Add(Me.BookInfoTextBox)
        Me.Controls.Add(Me.CloseBookInfoButton)
        Me.Controls.Add(Me.DeleteBookInfoButton)
        Me.Name = "DisplayBookInfo"
        Me.Text = "DisplayBookInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteBookInfoButton As Windows.Forms.Button
    Friend WithEvents CloseBookInfoButton As Windows.Forms.Button
    Friend WithEvents BookInfoTextBox As Windows.Forms.TextBox
End Class
