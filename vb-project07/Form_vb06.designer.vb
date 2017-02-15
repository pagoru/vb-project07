<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_vb06
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea del triangle")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea de la rodona")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Longitud de la Circumferència")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea Rectangle")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrees i Longituds", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suma de dos números")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resta de dos números")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divisió de dos números")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiplicació de dos números")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aritmètica", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar la seva invertida")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar el número de vocals i consonants que té la cadena")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
        " una frase")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadenes", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transformar un numero enter")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fibornacci de n números")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("La taula de múltiplicar d’un número del 1 al n número indicat")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altres", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.Input1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnganxarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close = New System.Windows.Forms.Button()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Text_Input1 = New System.Windows.Forms.Label()
        Me.Text_Input2 = New System.Windows.Forms.Label()
        Me.Input2 = New System.Windows.Forms.TextBox()
        Me.ListBoxResult = New System.Windows.Forms.ListBox()
        Me.ResultText = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(13, 13)
        Me.TreeView.Name = "TreeView"
        TreeNode1.Name = "AreaLong_1"
        TreeNode1.Text = "Àrea del triangle"
        TreeNode2.Name = "AreaLong_2"
        TreeNode2.Text = "Àrea de la rodona"
        TreeNode3.Name = "AreaLong_3"
        TreeNode3.Text = "Longitud de la Circumferència"
        TreeNode4.Name = "AreaLong_4"
        TreeNode4.Text = "Àrea Rectangle"
        TreeNode5.Name = "root_AreaLong"
        TreeNode5.Text = "Àrees i Longituds"
        TreeNode6.Name = "Arit_1"
        TreeNode6.Text = "Suma de dos números"
        TreeNode7.Name = "Arit_2"
        TreeNode7.Text = "Resta de dos números"
        TreeNode8.Name = "Arit_3"
        TreeNode8.Text = "Divisió de dos números"
        TreeNode9.Name = "Arit_4"
        TreeNode9.Text = "Multiplicació de dos números"
        TreeNode10.Name = "root_Arit"
        TreeNode10.Text = "Aritmètica"
        TreeNode11.Name = "Cad_1"
        TreeNode11.Text = "Donada una cadena mostrar la seva invertida"
        TreeNode12.Name = "Cad_2"
        TreeNode12.Text = "Donada una cadena mostrar el número de vocals i consonants que té la cadena"
        TreeNode13.Name = "Cad_3"
        TreeNode13.Text = "Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
    " una frase"
        TreeNode14.Name = "root_Cad"
        TreeNode14.Text = "Cadenes"
        TreeNode15.Name = "Alt_1"
        TreeNode15.Text = "Transformar un numero enter"
        TreeNode16.Name = "Alt_2"
        TreeNode16.Text = "Fibornacci de n números"
        TreeNode17.Name = "Alt_3"
        TreeNode17.Text = "La taula de múltiplicar d’un número del 1 al n número indicat"
        TreeNode18.Name = "root_Alt"
        TreeNode18.Text = "Altres"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode14, TreeNode18})
        Me.TreeView.Size = New System.Drawing.Size(221, 322)
        Me.TreeView.TabIndex = 0
        '
        'Input1
        '
        Me.Input1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Input1.Location = New System.Drawing.Point(148, 65)
        Me.Input1.Name = "Input1"
        Me.Input1.Size = New System.Drawing.Size(159, 20)
        Me.Input1.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitToolStripMenuItem, Me.IncrementarEn1ToolStripMenuItem, Me.DecrementarEn1ToolStripMenuItem, Me.ToolStripSeparator1, Me.CopiarToolStripMenuItem, Me.TallarToolStripMenuItem, Me.EnganxarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 142)
        '
        'InitToolStripMenuItem
        '
        Me.InitToolStripMenuItem.Name = "InitToolStripMenuItem"
        Me.InitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.InitToolStripMenuItem.Text = "Inicialitzar a valor 0"
        '
        'IncrementarEn1ToolStripMenuItem
        '
        Me.IncrementarEn1ToolStripMenuItem.Name = "IncrementarEn1ToolStripMenuItem"
        Me.IncrementarEn1ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.IncrementarEn1ToolStripMenuItem.Text = "Incrementar en 1"
        '
        'DecrementarEn1ToolStripMenuItem
        '
        Me.DecrementarEn1ToolStripMenuItem.Name = "DecrementarEn1ToolStripMenuItem"
        Me.DecrementarEn1ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DecrementarEn1ToolStripMenuItem.Text = "Decrementar en 1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'TallarToolStripMenuItem
        '
        Me.TallarToolStripMenuItem.Name = "TallarToolStripMenuItem"
        Me.TallarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TallarToolStripMenuItem.Text = "Tallar"
        '
        'EnganxarToolStripMenuItem
        '
        Me.EnganxarToolStripMenuItem.Name = "EnganxarToolStripMenuItem"
        Me.EnganxarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EnganxarToolStripMenuItem.Text = "Enganxar"
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(0, 299)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 2
        Me.Close.Text = "Tancar"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.Location = New System.Drawing.Point(81, 299)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(75, 23)
        Me.Remove.TabIndex = 1
        Me.Remove.Text = "Borrar"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(232, 299)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(75, 23)
        Me.Result.TabIndex = 0
        Me.Result.Text = "Resultat"
        Me.Result.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(3, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(304, 37)
        Me.Title.TabIndex = 4
        Me.Title.Text = "Title"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_Input1
        '
        Me.Text_Input1.Location = New System.Drawing.Point(0, 65)
        Me.Text_Input1.Name = "Text_Input1"
        Me.Text_Input1.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input1.TabIndex = 5
        Me.Text_Input1.Text = "Text_Input1"
        Me.Text_Input1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Text_Input2
        '
        Me.Text_Input2.Location = New System.Drawing.Point(0, 102)
        Me.Text_Input2.Name = "Text_Input2"
        Me.Text_Input2.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input2.TabIndex = 7
        Me.Text_Input2.Text = "Text_Input2"
        Me.Text_Input2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Input2
        '
        Me.Input2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Input2.Location = New System.Drawing.Point(148, 102)
        Me.Input2.Name = "Input2"
        Me.Input2.Size = New System.Drawing.Size(159, 20)
        Me.Input2.TabIndex = 6
        '
        'ListBoxResult
        '
        Me.ListBoxResult.FormattingEnabled = True
        Me.ListBoxResult.Location = New System.Drawing.Point(148, 141)
        Me.ListBoxResult.Name = "ListBoxResult"
        Me.ListBoxResult.Size = New System.Drawing.Size(159, 95)
        Me.ListBoxResult.TabIndex = 8
        Me.ListBoxResult.Visible = False
        '
        'ResultText
        '
        Me.ResultText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ResultText.Location = New System.Drawing.Point(0, 254)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(304, 23)
        Me.ResultText.TabIndex = 9
        Me.ResultText.Text = "ResultText"
        Me.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Close)
        Me.Panel.Controls.Add(Me.ResultText)
        Me.Panel.Controls.Add(Me.Remove)
        Me.Panel.Controls.Add(Me.Title)
        Me.Panel.Controls.Add(Me.Result)
        Me.Panel.Controls.Add(Me.ListBoxResult)
        Me.Panel.Controls.Add(Me.Input1)
        Me.Panel.Controls.Add(Me.Text_Input2)
        Me.Panel.Controls.Add(Me.Text_Input1)
        Me.Panel.Controls.Add(Me.Input2)
        Me.Panel.Location = New System.Drawing.Point(240, 13)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(307, 322)
        Me.Panel.TabIndex = 2
        Me.Panel.Visible = False
        '
        'Form_vb06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 347)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.TreeView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_vb06"
        Me.ShowIcon = False
        Me.Text = "Pablo González Rubio"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView As TreeView
    Friend WithEvents Input1 As TextBox
    Friend WithEvents Close As Button
    Friend WithEvents Remove As Button
    Friend WithEvents Result As Button
    Friend WithEvents Text_Input1 As Label
    Friend WithEvents Title As Label
    Friend WithEvents ResultText As Label
    Friend WithEvents ListBoxResult As ListBox
    Friend WithEvents Text_Input2 As Label
    Friend WithEvents Input2 As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnganxarToolStripMenuItem As ToolStripMenuItem
End Class
