<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainGUI
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
        Me.NewBookButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BookCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.DisplayBookInfoButton = New System.Windows.Forms.Button()
        Me.NumberOfBooksLabel = New System.Windows.Forms.Label()
        Me.DeleteAllBooksButton = New System.Windows.Forms.Button()
        Me.DeleteSingleBookButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'NewBookButton
        '
        Me.NewBookButton.Location = New System.Drawing.Point(52, 377)
        Me.NewBookButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewBookButton.Name = "NewBookButton"
        Me.NewBookButton.Size = New System.Drawing.Size(133, 113)
        Me.NewBookButton.TabIndex = 1
        Me.NewBookButton.Text = "New Book"
        Me.NewBookButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(612, 377)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 113)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BookCheckedListBox
        '
        Me.BookCheckedListBox.CheckOnClick = True
        Me.BookCheckedListBox.ColumnWidth = 5
        Me.BookCheckedListBox.FormattingEnabled = True
        Me.BookCheckedListBox.Location = New System.Drawing.Point(52, 52)
        Me.BookCheckedListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BookCheckedListBox.Name = "BookCheckedListBox"
        Me.BookCheckedListBox.Size = New System.Drawing.Size(687, 293)
        Me.BookCheckedListBox.TabIndex = 4
        '
        'DisplayBookInfoButton
        '
        Me.DisplayBookInfoButton.Location = New System.Drawing.Point(415, 377)
        Me.DisplayBookInfoButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DisplayBookInfoButton.Name = "DisplayBookInfoButton"
        Me.DisplayBookInfoButton.Size = New System.Drawing.Size(131, 113)
        Me.DisplayBookInfoButton.TabIndex = 5
        Me.DisplayBookInfoButton.Text = "Display Book Information"
        Me.DisplayBookInfoButton.UseVisualStyleBackColor = True
        '
        'NumberOfBooksLabel
        '
        Me.NumberOfBooksLabel.AutoSize = True
        Me.NumberOfBooksLabel.Location = New System.Drawing.Point(48, 21)
        Me.NumberOfBooksLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumberOfBooksLabel.Name = "NumberOfBooksLabel"
        Me.NumberOfBooksLabel.Size = New System.Drawing.Size(164, 17)
        Me.NumberOfBooksLabel.TabIndex = 7
        Me.NumberOfBooksLabel.Text = "Total Number Of Books: "
        '
        'DeleteAllBooksButton
        '
        Me.DeleteAllBooksButton.Location = New System.Drawing.Point(236, 441)
        Me.DeleteAllBooksButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteAllBooksButton.Name = "DeleteAllBooksButton"
        Me.DeleteAllBooksButton.Size = New System.Drawing.Size(131, 49)
        Me.DeleteAllBooksButton.TabIndex = 8
        Me.DeleteAllBooksButton.Text = "Delete All Books"
        Me.DeleteAllBooksButton.UseVisualStyleBackColor = True
        '
        'DeleteSingleBookButton
        '
        Me.DeleteSingleBookButton.Location = New System.Drawing.Point(236, 375)
        Me.DeleteSingleBookButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteSingleBookButton.Name = "DeleteSingleBookButton"
        Me.DeleteSingleBookButton.Size = New System.Drawing.Size(131, 49)
        Me.DeleteSingleBookButton.TabIndex = 9
        Me.DeleteSingleBookButton.Text = "Delete Single Book"
        Me.DeleteSingleBookButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(532, 15)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(640, 15)
        Me.LoadButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(100, 28)
        Me.LoadButton.TabIndex = 11
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.CreatePrompt = True
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.Filter = "Text Files (*.txt)|"
        Me.SaveFileDialog.FilterIndex = 2
        Me.SaveFileDialog.InitialDirectory = "*\Documemts"
        Me.SaveFileDialog.RestoreDirectory = True
        Me.SaveFileDialog.Title = "Save Booklist"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "txt"
        Me.OpenFileDialog.Filter = "Text Files (*.txt)|"
        Me.OpenFileDialog.InitialDirectory = "*\Documents"
        Me.OpenFileDialog.Title = "Load Booklist"
        '
        'MainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 503)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteSingleBookButton)
        Me.Controls.Add(Me.DeleteAllBooksButton)
        Me.Controls.Add(Me.NumberOfBooksLabel)
        Me.Controls.Add(Me.DisplayBookInfoButton)
        Me.Controls.Add(Me.BookCheckedListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NewBookButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainGUI"
        Me.Text = "MainGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As Windows.Forms.Button
    Public WithEvents BookCheckedListBox As Windows.Forms.CheckedListBox
    Friend WithEvents NewBookButton As Windows.Forms.Button
    Friend WithEvents DisplayBookInfoButton As Windows.Forms.Button
    Friend WithEvents NumberOfBooksLabel As Windows.Forms.Label
    Friend WithEvents DeleteAllBooksButton As Windows.Forms.Button
    Friend WithEvents DeleteSingleBookButton As Windows.Forms.Button
    Friend WithEvents SaveButton As Windows.Forms.Button
    Friend WithEvents LoadButton As Windows.Forms.Button
    Friend WithEvents SaveFileDialog As Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog As Windows.Forms.OpenFileDialog
End Class
