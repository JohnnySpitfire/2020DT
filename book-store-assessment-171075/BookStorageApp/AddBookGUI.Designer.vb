<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleInputTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.AuthorInputTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherLabel = New System.Windows.Forms.Label()
        Me.PublisherInputTextBox = New System.Windows.Forms.TextBox()
        Me.IBSNLabel = New System.Windows.Forms.Label()
        Me.IBSNInputTextBox = New System.Windows.Forms.TextBox()
        Me.EstimatedValueLabel = New System.Windows.Forms.Label()
        Me.EstimatedValueInputTextBox = New System.Windows.Forms.TextBox()
        Me.AddBookButton = New System.Windows.Forms.Button()
        Me.CancelAddBookButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleInputTextBox
        '
        Me.TitleInputTextBox.Location = New System.Drawing.Point(12, 33)
        Me.TitleInputTextBox.Name = "TitleInputTextBox"
        Me.TitleInputTextBox.Size = New System.Drawing.Size(281, 22)
        Me.TitleInputTextBox.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(13, 10)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(35, 17)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Title"
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Location = New System.Drawing.Point(13, 71)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(50, 17)
        Me.AuthorLabel.TabIndex = 3
        Me.AuthorLabel.Text = "Author"
        '
        'AuthorInputTextBox
        '
        Me.AuthorInputTextBox.Location = New System.Drawing.Point(12, 94)
        Me.AuthorInputTextBox.Name = "AuthorInputTextBox"
        Me.AuthorInputTextBox.Size = New System.Drawing.Size(281, 22)
        Me.AuthorInputTextBox.TabIndex = 2
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Location = New System.Drawing.Point(13, 137)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(67, 17)
        Me.PublisherLabel.TabIndex = 5
        Me.PublisherLabel.Text = "Publisher"
        '
        'PublisherInputTextBox
        '
        Me.PublisherInputTextBox.Location = New System.Drawing.Point(12, 160)
        Me.PublisherInputTextBox.Name = "PublisherInputTextBox"
        Me.PublisherInputTextBox.Size = New System.Drawing.Size(281, 22)
        Me.PublisherInputTextBox.TabIndex = 4
        '
        'IBSNLabel
        '
        Me.IBSNLabel.AutoSize = True
        Me.IBSNLabel.Location = New System.Drawing.Point(13, 203)
        Me.IBSNLabel.Name = "IBSNLabel"
        Me.IBSNLabel.Size = New System.Drawing.Size(39, 17)
        Me.IBSNLabel.TabIndex = 7
        Me.IBSNLabel.Text = "IBSN"
        '
        'IBSNInputTextBox
        '
        Me.IBSNInputTextBox.Location = New System.Drawing.Point(12, 226)
        Me.IBSNInputTextBox.Name = "IBSNInputTextBox"
        Me.IBSNInputTextBox.Size = New System.Drawing.Size(281, 22)
        Me.IBSNInputTextBox.TabIndex = 6
        '
        'EstimatedValueLabel
        '
        Me.EstimatedValueLabel.AutoSize = True
        Me.EstimatedValueLabel.Location = New System.Drawing.Point(13, 267)
        Me.EstimatedValueLabel.Name = "EstimatedValueLabel"
        Me.EstimatedValueLabel.Size = New System.Drawing.Size(110, 17)
        Me.EstimatedValueLabel.TabIndex = 9
        Me.EstimatedValueLabel.Text = "Estimated Value"
        '
        'EstimatedValueInputTextBox
        '
        Me.EstimatedValueInputTextBox.Location = New System.Drawing.Point(12, 290)
        Me.EstimatedValueInputTextBox.Name = "EstimatedValueInputTextBox"
        Me.EstimatedValueInputTextBox.Size = New System.Drawing.Size(281, 22)
        Me.EstimatedValueInputTextBox.TabIndex = 8
        '
        'AddBookButton
        '
        Me.AddBookButton.Location = New System.Drawing.Point(12, 351)
        Me.AddBookButton.Name = "AddBookButton"
        Me.AddBookButton.Size = New System.Drawing.Size(103, 78)
        Me.AddBookButton.TabIndex = 10
        Me.AddBookButton.Text = "Add Book"
        Me.AddBookButton.UseVisualStyleBackColor = True
        '
        'CancelAddBookButton
        '
        Me.CancelAddBookButton.Location = New System.Drawing.Point(190, 351)
        Me.CancelAddBookButton.Name = "CancelAddBookButton"
        Me.CancelAddBookButton.Size = New System.Drawing.Size(103, 78)
        Me.CancelAddBookButton.TabIndex = 11
        Me.CancelAddBookButton.Text = "Cancel"
        Me.CancelAddBookButton.UseVisualStyleBackColor = True
        '
        'AddBookGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 450)
        Me.Controls.Add(Me.CancelAddBookButton)
        Me.Controls.Add(Me.AddBookButton)
        Me.Controls.Add(Me.EstimatedValueLabel)
        Me.Controls.Add(Me.EstimatedValueInputTextBox)
        Me.Controls.Add(Me.IBSNLabel)
        Me.Controls.Add(Me.IBSNInputTextBox)
        Me.Controls.Add(Me.PublisherLabel)
        Me.Controls.Add(Me.PublisherInputTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.AuthorInputTextBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.TitleInputTextBox)
        Me.Name = "AddBookGUI"
        Me.Text = "AddBookGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleInputTextBox As Windows.Forms.TextBox
    Friend WithEvents TitleLabel As Windows.Forms.Label
    Friend WithEvents AuthorLabel As Windows.Forms.Label
    Friend WithEvents AuthorInputTextBox As Windows.Forms.TextBox
    Friend WithEvents PublisherLabel As Windows.Forms.Label
    Friend WithEvents PublisherInputTextBox As Windows.Forms.TextBox
    Friend WithEvents IBSNLabel As Windows.Forms.Label
    Friend WithEvents IBSNInputTextBox As Windows.Forms.TextBox
    Friend WithEvents EstimatedValueLabel As Windows.Forms.Label
    Friend WithEvents EstimatedValueInputTextBox As Windows.Forms.TextBox
    Friend WithEvents AddBookButton As Windows.Forms.Button
    Friend WithEvents CancelAddBookButton As Windows.Forms.Button
End Class
