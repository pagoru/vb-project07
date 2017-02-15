<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_vb03
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
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Button_Order = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Button_InsertValue = New System.Windows.Forms.Button()
        Me.Button_DeleteSelection = New System.Windows.Forms.Button()
        Me.Button_Extra = New System.Windows.Forms.Button()
        Me.Button_MessageBox = New System.Windows.Forms.Button()
        Me.ComboBox_ASC = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ASCII = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(13, 12)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(101, 20)
        Me.TextBox.TabIndex = 0
        '
        'Button_Order
        '
        Me.Button_Order.Location = New System.Drawing.Point(120, 286)
        Me.Button_Order.Name = "Button_Order"
        Me.Button_Order.Size = New System.Drawing.Size(100, 21)
        Me.Button_Order.TabIndex = 1
        Me.Button_Order.Text = "Ordenar"
        Me.Button_Order.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(13, 66)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox.Size = New System.Drawing.Size(206, 160)
        Me.ListBox.TabIndex = 2
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {"Principi", "Final", "Ordenació númerica"})
        Me.ComboBox.Location = New System.Drawing.Point(118, 12)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox.TabIndex = 3
        '
        'Button_InsertValue
        '
        Me.Button_InsertValue.Location = New System.Drawing.Point(119, 39)
        Me.Button_InsertValue.Name = "Button_InsertValue"
        Me.Button_InsertValue.Size = New System.Drawing.Size(100, 21)
        Me.Button_InsertValue.TabIndex = 4
        Me.Button_InsertValue.Text = "Insertar valor"
        Me.Button_InsertValue.UseVisualStyleBackColor = True
        '
        'Button_DeleteSelection
        '
        Me.Button_DeleteSelection.Location = New System.Drawing.Point(119, 232)
        Me.Button_DeleteSelection.Name = "Button_DeleteSelection"
        Me.Button_DeleteSelection.Size = New System.Drawing.Size(100, 21)
        Me.Button_DeleteSelection.TabIndex = 6
        Me.Button_DeleteSelection.Text = "Eliminar selecció"
        Me.Button_DeleteSelection.UseVisualStyleBackColor = True
        '
        'Button_Extra
        '
        Me.Button_Extra.Location = New System.Drawing.Point(120, 313)
        Me.Button_Extra.Name = "Button_Extra"
        Me.Button_Extra.Size = New System.Drawing.Size(100, 21)
        Me.Button_Extra.TabIndex = 9
        Me.Button_Extra.Text = "Informació extra"
        Me.Button_Extra.UseVisualStyleBackColor = True
        '
        'Button_MessageBox
        '
        Me.Button_MessageBox.Location = New System.Drawing.Point(13, 39)
        Me.Button_MessageBox.Name = "Button_MessageBox"
        Me.Button_MessageBox.Size = New System.Drawing.Size(100, 21)
        Me.Button_MessageBox.TabIndex = 10
        Me.Button_MessageBox.Text = "MessageBox"
        Me.Button_MessageBox.UseVisualStyleBackColor = True
        '
        'ComboBox_ASC
        '
        Me.ComboBox_ASC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ASC.FormattingEnabled = True
        Me.ComboBox_ASC.Items.AddRange(New Object() {"Ascendent", "Descendent"})
        Me.ComboBox_ASC.Location = New System.Drawing.Point(13, 286)
        Me.ComboBox_ASC.Name = "ComboBox_ASC"
        Me.ComboBox_ASC.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox_ASC.TabIndex = 11
        '
        'ComboBox_ASCII
        '
        Me.ComboBox_ASCII.DisplayMember = "Númerica"
        Me.ComboBox_ASCII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ASCII.FormattingEnabled = True
        Me.ComboBox_ASCII.Items.AddRange(New Object() {"Númerica", "Carácter"})
        Me.ComboBox_ASCII.Location = New System.Drawing.Point(13, 259)
        Me.ComboBox_ASCII.Name = "ComboBox_ASCII"
        Me.ComboBox_ASCII.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox_ASCII.TabIndex = 12
        '
        'Form_vb03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(230, 345)
        Me.Controls.Add(Me.ComboBox_ASCII)
        Me.Controls.Add(Me.ComboBox_ASC)
        Me.Controls.Add(Me.Button_MessageBox)
        Me.Controls.Add(Me.Button_Extra)
        Me.Controls.Add(Me.Button_DeleteSelection)
        Me.Controls.Add(Me.Button_InsertValue)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.Button_Order)
        Me.Controls.Add(Me.TextBox)
        Me.Name = "Form_vb03"
        Me.ShowIcon = False
        Me.Text = "Formulari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents Button_Order As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Button_InsertValue As Button
    Friend WithEvents Button_DeleteSelection As Button
    Friend WithEvents Button_Extra As Button
    Friend WithEvents Button_MessageBox As Button
    Public WithEvents ComboBox As ComboBox
    Public WithEvents ComboBox_ASC As ComboBox
    Public WithEvents ComboBox_ASCII As ComboBox
End Class
