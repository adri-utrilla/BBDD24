<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        tcF1 = New TabControl()
        TabPage1 = New TabPage()
        lbListados = New Label()
        btnGPs = New Button()
        btnEscuderias = New Button()
        btnPilotos = New Button()
        btnPaises = New Button()
        lbTablas = New Label()
        lbTitulo = New Label()
        TabPage2 = New TabPage()
        btnBorrarPais = New Button()
        btnModiPais = New Button()
        btnAnaPais = New Button()
        lstPaises = New ListBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        lblHabPais = New Label()
        lblNombrePais = New Label()
        lblIdPais = New Label()
        TabPage3 = New TabPage()
        tcF1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' tcF1
        ' 
        tcF1.Controls.Add(TabPage1)
        tcF1.Controls.Add(TabPage2)
        tcF1.Controls.Add(TabPage3)
        tcF1.Location = New Point(12, 12)
        tcF1.Name = "tcF1"
        tcF1.SelectedIndex = 0
        tcF1.Size = New Size(1171, 426)
        tcF1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(254), CByte(255), CByte(153))
        TabPage1.Controls.Add(lbListados)
        TabPage1.Controls.Add(btnGPs)
        TabPage1.Controls.Add(btnEscuderias)
        TabPage1.Controls.Add(btnPilotos)
        TabPage1.Controls.Add(btnPaises)
        TabPage1.Controls.Add(lbTablas)
        TabPage1.Controls.Add(lbTitulo)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1163, 393)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Inicio"
        ' 
        ' lbListados
        ' 
        lbListados.AutoSize = True
        lbListados.Location = New Point(869, 64)
        lbListados.Name = "lbListados"
        lbListados.Size = New Size(66, 20)
        lbListados.TabIndex = 7
        lbListados.Text = "Listados:"
        ' 
        ' btnGPs
        ' 
        btnGPs.Location = New Point(52, 263)
        btnGPs.Name = "btnGPs"
        btnGPs.Size = New Size(118, 29)
        btnGPs.TabIndex = 5
        btnGPs.Text = "GPs"
        btnGPs.UseVisualStyleBackColor = True
        ' 
        ' btnEscuderias
        ' 
        btnEscuderias.Location = New Point(52, 205)
        btnEscuderias.Name = "btnEscuderias"
        btnEscuderias.Size = New Size(118, 29)
        btnEscuderias.TabIndex = 4
        btnEscuderias.Text = "ESCUDERIAS"
        btnEscuderias.UseVisualStyleBackColor = True
        ' 
        ' btnPilotos
        ' 
        btnPilotos.Location = New Point(52, 152)
        btnPilotos.Name = "btnPilotos"
        btnPilotos.Size = New Size(118, 29)
        btnPilotos.TabIndex = 3
        btnPilotos.Text = "PILOTOS"
        btnPilotos.UseVisualStyleBackColor = True
        ' 
        ' btnPaises
        ' 
        btnPaises.Location = New Point(52, 101)
        btnPaises.Name = "btnPaises"
        btnPaises.Size = New Size(118, 29)
        btnPaises.TabIndex = 2
        btnPaises.Text = "PAISES"
        btnPaises.UseVisualStyleBackColor = True
        ' 
        ' lbTablas
        ' 
        lbTablas.AutoSize = True
        lbTablas.Location = New Point(37, 64)
        lbTablas.Name = "lbTablas"
        lbTablas.Size = New Size(133, 20)
        lbTablas.TabIndex = 1
        lbTablas.Text = "Administrar tablas:"
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Segoe UI", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbTitulo.Location = New Point(437, 3)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(322, 81)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Formula 1"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(254), CByte(255), CByte(153))
        TabPage2.Controls.Add(btnBorrarPais)
        TabPage2.Controls.Add(btnModiPais)
        TabPage2.Controls.Add(btnAnaPais)
        TabPage2.Controls.Add(lstPaises)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Controls.Add(TextBox1)
        TabPage2.Controls.Add(lblHabPais)
        TabPage2.Controls.Add(lblNombrePais)
        TabPage2.Controls.Add(lblIdPais)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1163, 393)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' btnBorrarPais
        ' 
        btnBorrarPais.Location = New Point(429, 151)
        btnBorrarPais.Name = "btnBorrarPais"
        btnBorrarPais.Size = New Size(94, 29)
        btnBorrarPais.TabIndex = 9
        btnBorrarPais.Text = "Borrar"
        btnBorrarPais.UseVisualStyleBackColor = True
        ' 
        ' btnModiPais
        ' 
        btnModiPais.Location = New Point(429, 90)
        btnModiPais.Name = "btnModiPais"
        btnModiPais.Size = New Size(94, 29)
        btnModiPais.TabIndex = 8
        btnModiPais.Text = "Modificar"
        btnModiPais.UseVisualStyleBackColor = True
        ' 
        ' btnAnaPais
        ' 
        btnAnaPais.Location = New Point(429, 25)
        btnAnaPais.Name = "btnAnaPais"
        btnAnaPais.Size = New Size(94, 29)
        btnAnaPais.TabIndex = 7
        btnAnaPais.Text = "Añadir"
        btnAnaPais.UseVisualStyleBackColor = True
        ' 
        ' lstPaises
        ' 
        lstPaises.FormattingEnabled = True
        lstPaises.Location = New Point(258, 16)
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(150, 164)
        lstPaises.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(127, 153)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(127, 92)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(127, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 3
        ' 
        ' lblHabPais
        ' 
        lblHabPais.AutoSize = True
        lblHabPais.Location = New Point(25, 160)
        lblHabPais.Name = "lblHabPais"
        lblHabPais.Size = New Size(84, 20)
        lblHabPais.TabIndex = 2
        lblHabPais.Text = "Habitantes:"
        ' 
        ' lblNombrePais
        ' 
        lblNombrePais.AutoSize = True
        lblNombrePais.Location = New Point(25, 99)
        lblNombrePais.Name = "lblNombrePais"
        lblNombrePais.Size = New Size(96, 20)
        lblNombrePais.TabIndex = 1
        lblNombrePais.Text = "Nombre Pais:"
        ' 
        ' lblIdPais
        ' 
        lblIdPais.AutoSize = True
        lblIdPais.Location = New Point(25, 34)
        lblIdPais.Name = "lblIdPais"
        lblIdPais.Size = New Size(90, 20)
        lblIdPais.TabIndex = 0
        lblIdPais.Text = "Codigo Pais:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1163, 393)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1195, 450)
        Controls.Add(tcF1)
        Name = "Form1"
        Text = "Form1"
        tcF1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tcF1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbTitulo As Label
    Friend WithEvents lbTablas As Label
    Friend WithEvents btnPilotos As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnGPs As Button
    Friend WithEvents btnEscuderias As Button
    Friend WithEvents lbListados As Label
    Friend WithEvents lblIdPais As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblHabPais As Label
    Friend WithEvents lblNombrePais As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnBorrarPais As Button
    Friend WithEvents btnModiPais As Button
    Friend WithEvents btnAnaPais As Button
    Friend WithEvents lstPaises As ListBox

End Class
