Imports System.IO
Imports System.Xml

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits System.Windows.Forms.Form

    Dim XmlPath As String = Environment.CurrentDirectory & "\Clientes.xml"

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
        Me.TrvXML = New System.Windows.Forms.TreeView()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtIdade = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TrvXML
        '
        Me.TrvXML.Location = New System.Drawing.Point(12, 12)
        Me.TrvXML.Name = "TrvXML"
        Me.TrvXML.Size = New System.Drawing.Size(217, 280)
        Me.TrvXML.TabIndex = 0
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(261, 38)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(261, 101)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(230, 20)
        Me.TxtNome.TabIndex = 2
        '
        'TxtIdade
        '
        Me.TxtIdade.Location = New System.Drawing.Point(261, 170)
        Me.TxtIdade.Name = "TxtIdade"
        Me.TxtIdade.Size = New System.Drawing.Size(230, 20)
        Me.TxtIdade.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(258, 12)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(40, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Código"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(258, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(35, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "Nome"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(258, 142)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(34, 13)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "Idade"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(261, 220)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdicionar.TabIndex = 7
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Location = New System.Drawing.Point(416, 220)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlterar.TabIndex = 8
        Me.BtnAlterar.Text = "Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'BtnRemover
        '
        Me.BtnRemover.Location = New System.Drawing.Point(261, 269)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemover.TabIndex = 9
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(416, 269)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 10
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 307)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnRemover)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.TxtIdade)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TrvXML)
        Me.Name = "Form1"
        Me.Text = "XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrvXML As TreeView
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtIdade As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnLimpar As Button

    Private Sub CarregaTreeView()

        TrvXML.Nodes.Add("Clientes")
        Dim root As TreeNode = TrvXML.Nodes(0)
        Dim subNo As TreeNode
        Dim xmlReader As XmlTextReader

        Try
            xmlReader = New XmlTextReader(XmlPath)
            While (xmlReader.Read())
                If (xmlReader.HasAttributes) Then
                    subNo = New TreeNode()
                    While (xmlReader.MoveToNextAttribute())
                        Select Case xmlReader.Name
                            Case "id"
                                subNo.Text = xmlReader.Value & " - "
                            Case "nome"
                                subNo.Text &= xmlReader.Value & " - "
                            Case "idade"
                                subNo.Text &= xmlReader.Value
                        End Select
                    End While
                    If subNo.Text.Trim().Length > 0 Then
                        root.Nodes.Add(subNo)
                    End If
                End If
            End While
            xmlReader.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregaTreeView()
    End Sub

    Private Sub AdicionarCliente()
        Dim xmlDoc As New XmlDocument()
        Dim codigo, nome, idade As String
        codigo = TxtCodigo.Text
        nome = TxtNome.Text
        idade = TxtIdade.Text

        Try
            xmlDoc.Load(XmlPath)
            Dim root As XmlNode = xmlDoc.SelectSingleNode("/clientes")

            Dim elemento As XmlElement = xmlDoc.CreateElement("cliente")

            Dim atributoId As XmlAttribute = xmlDoc.CreateAttribute("id")
            atributoId.Value = codigo

            Dim atributoNome As XmlAttribute = xmlDoc.CreateAttribute("nome")
            atributoNome.Value = nome

            Dim atributoIdade As XmlAttribute = xmlDoc.CreateAttribute("idade")
            atributoIdade.Value = idade

            elemento.Attributes.Append(atributoId)
            elemento.Attributes.Append(atributoNome)
            elemento.Attributes.Append(atributoIdade)

            root.AppendChild(elemento)

            xmlDoc.Save(XmlPath)

            MessageBox.Show("Cliente adicionado com sucesso!")

            TrvXML.Nodes.Clear()
            CarregaTreeView()
            TrvXML.ExpandAll()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        AdicionarCliente()
    End Sub
End Class

