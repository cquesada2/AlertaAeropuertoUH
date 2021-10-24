<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantenimientoVehiculo
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
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblEstilo = New System.Windows.Forms.Label()
        Me.LblCilindraje = New System.Windows.Forms.Label()
        Me.LblCombustible = New System.Windows.Forms.Label()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.LblKilometraje = New System.Windows.Forms.Label()
        Me.LblTrasmision = New System.Windows.Forms.Label()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.CmbEstilo = New System.Windows.Forms.ComboBox()
        Me.CmbAno = New System.Windows.Forms.ComboBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.CmbCombustible = New System.Windows.Forms.ComboBox()
        Me.CmbTrasmision = New System.Windows.Forms.ComboBox()
        Me.TxtCilindraje = New System.Windows.Forms.TextBox()
        Me.TxtKilometraje = New System.Windows.Forms.TextBox()
        Me.LlbEjemploModelo = New System.Windows.Forms.Label()
        Me.LblCc = New System.Windows.Forms.Label()
        Me.LblColones = New System.Windows.Forms.Label()
        Me.LblKms = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.gridVehiculos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.BtnBusqueda = New System.Windows.Forms.Button()
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(50, 93)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(58, 17)
        Me.LblModelo.TabIndex = 1
        Me.LblModelo.Text = "Modelo:"
        '
        'LblEstilo
        '
        Me.LblEstilo.AutoSize = True
        Me.LblEstilo.Location = New System.Drawing.Point(50, 172)
        Me.LblEstilo.Name = "LblEstilo"
        Me.LblEstilo.Size = New System.Drawing.Size(46, 17)
        Me.LblEstilo.TabIndex = 3
        Me.LblEstilo.Text = "Estilo:"
        '
        'LblCilindraje
        '
        Me.LblCilindraje.AutoSize = True
        Me.LblCilindraje.Location = New System.Drawing.Point(50, 135)
        Me.LblCilindraje.Name = "LblCilindraje"
        Me.LblCilindraje.Size = New System.Drawing.Size(70, 17)
        Me.LblCilindraje.TabIndex = 2
        Me.LblCilindraje.Text = "Cilindraje:"
        '
        'LblCombustible
        '
        Me.LblCombustible.AutoSize = True
        Me.LblCombustible.Location = New System.Drawing.Point(50, 321)
        Me.LblCombustible.Name = "LblCombustible"
        Me.LblCombustible.Size = New System.Drawing.Size(89, 17)
        Me.LblCombustible.TabIndex = 7
        Me.LblCombustible.Text = "Combustible:"
        '
        'LblColor
        '
        Me.LblColor.AutoSize = True
        Me.LblColor.Location = New System.Drawing.Point(50, 284)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(45, 17)
        Me.LblColor.TabIndex = 6
        Me.LblColor.Text = "Color:"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(50, 246)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(71, 17)
        Me.LblPrecio.TabIndex = 5
        Me.LblPrecio.Text = "Precio (Ȼ)"
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.Location = New System.Drawing.Point(50, 209)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(37, 17)
        Me.LblAno.TabIndex = 4
        Me.LblAno.Text = "Año:"
        '
        'LblKilometraje
        '
        Me.LblKilometraje.AutoSize = True
        Me.LblKilometraje.Location = New System.Drawing.Point(50, 397)
        Me.LblKilometraje.Name = "LblKilometraje"
        Me.LblKilometraje.Size = New System.Drawing.Size(90, 17)
        Me.LblKilometraje.TabIndex = 9
        Me.LblKilometraje.Text = "Kilomentraje:"
        '
        'LblTrasmision
        '
        Me.LblTrasmision.AutoSize = True
        Me.LblTrasmision.Location = New System.Drawing.Point(50, 360)
        Me.LblTrasmision.Name = "LblTrasmision"
        Me.LblTrasmision.Size = New System.Drawing.Size(81, 17)
        Me.LblTrasmision.TabIndex = 8
        Me.LblTrasmision.Text = "Trasmisión:"
        '
        'CmbMarca
        '
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(137, 60)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(192, 24)
        Me.CmbMarca.TabIndex = 1
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(137, 91)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(192, 22)
        Me.TxtModelo.TabIndex = 2
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(137, 246)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(105, 22)
        Me.TxtPrecio.TabIndex = 6
        '
        'CmbEstilo
        '
        Me.CmbEstilo.FormattingEnabled = True
        Me.CmbEstilo.Location = New System.Drawing.Point(137, 172)
        Me.CmbEstilo.Name = "CmbEstilo"
        Me.CmbEstilo.Size = New System.Drawing.Size(192, 24)
        Me.CmbEstilo.TabIndex = 4
        '
        'CmbAno
        '
        Me.CmbAno.FormattingEnabled = True
        Me.CmbAno.Location = New System.Drawing.Point(137, 209)
        Me.CmbAno.Name = "CmbAno"
        Me.CmbAno.Size = New System.Drawing.Size(105, 24)
        Me.CmbAno.TabIndex = 5
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(137, 284)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(105, 22)
        Me.TxtColor.TabIndex = 7
        '
        'CmbCombustible
        '
        Me.CmbCombustible.FormattingEnabled = True
        Me.CmbCombustible.Location = New System.Drawing.Point(137, 321)
        Me.CmbCombustible.Name = "CmbCombustible"
        Me.CmbCombustible.Size = New System.Drawing.Size(105, 24)
        Me.CmbCombustible.TabIndex = 8
        '
        'CmbTrasmision
        '
        Me.CmbTrasmision.FormattingEnabled = True
        Me.CmbTrasmision.Location = New System.Drawing.Point(137, 360)
        Me.CmbTrasmision.Name = "CmbTrasmision"
        Me.CmbTrasmision.Size = New System.Drawing.Size(105, 24)
        Me.CmbTrasmision.TabIndex = 9
        '
        'TxtCilindraje
        '
        Me.TxtCilindraje.Location = New System.Drawing.Point(137, 130)
        Me.TxtCilindraje.Name = "TxtCilindraje"
        Me.TxtCilindraje.Size = New System.Drawing.Size(105, 22)
        Me.TxtCilindraje.TabIndex = 3
        '
        'TxtKilometraje
        '
        Me.TxtKilometraje.Location = New System.Drawing.Point(137, 394)
        Me.TxtKilometraje.Name = "TxtKilometraje"
        Me.TxtKilometraje.Size = New System.Drawing.Size(105, 22)
        Me.TxtKilometraje.TabIndex = 10
        '
        'LlbEjemploModelo
        '
        Me.LlbEjemploModelo.AutoSize = True
        Me.LlbEjemploModelo.Location = New System.Drawing.Point(332, 93)
        Me.LlbEjemploModelo.Name = "LlbEjemploModelo"
        Me.LlbEjemploModelo.Size = New System.Drawing.Size(201, 17)
        Me.LlbEjemploModelo.TabIndex = 14
        Me.LlbEjemploModelo.Text = "(ejemplo: Mirage, Lancer, etc.)"
        '
        'LblCc
        '
        Me.LblCc.AutoSize = True
        Me.LblCc.Location = New System.Drawing.Point(244, 135)
        Me.LblCc.Name = "LblCc"
        Me.LblCc.Size = New System.Drawing.Size(30, 17)
        Me.LblCc.TabIndex = 21
        Me.LblCc.Text = "c.c."
        '
        'LblColones
        '
        Me.LblColones.AutoSize = True
        Me.LblColones.Location = New System.Drawing.Point(244, 251)
        Me.LblColones.Name = "LblColones"
        Me.LblColones.Size = New System.Drawing.Size(59, 17)
        Me.LblColones.TabIndex = 22
        Me.LblColones.Text = "Colones"
        '
        'LblKms
        '
        Me.LblKms.AutoSize = True
        Me.LblKms.Location = New System.Drawing.Point(244, 400)
        Me.LblKms.Name = "LblKms"
        Me.LblKms.Size = New System.Drawing.Size(39, 17)
        Me.LblKms.TabIndex = 23
        Me.LblKms.Text = "Kms."
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(53, 436)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(137, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'gridVehiculos
        '
        Me.gridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVehiculos.Location = New System.Drawing.Point(12, 480)
        Me.gridVehiculos.Name = "gridVehiculos"
        Me.gridVehiculos.RowHeadersWidth = 51
        Me.gridVehiculos.RowTemplate.Height = 24
        Me.gridVehiculos.Size = New System.Drawing.Size(548, 150)
        Me.gridVehiculos.TabIndex = 13
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(50, 60)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(51, 17)
        Me.LblMarca.TabIndex = 0
        Me.LblMarca.Text = "Marca:"
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.Location = New System.Drawing.Point(206, 436)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(137, 23)
        Me.BtnBusqueda.TabIndex = 25
        Me.BtnBusqueda.Text = "Busqueda"
        Me.BtnBusqueda.UseVisualStyleBackColor = True
        '
        'MantenimientoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 656)
        Me.Controls.Add(Me.BtnBusqueda)
        Me.Controls.Add(Me.gridVehiculos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblKms)
        Me.Controls.Add(Me.LblColones)
        Me.Controls.Add(Me.LblCc)
        Me.Controls.Add(Me.LlbEjemploModelo)
        Me.Controls.Add(Me.TxtKilometraje)
        Me.Controls.Add(Me.TxtCilindraje)
        Me.Controls.Add(Me.CmbTrasmision)
        Me.Controls.Add(Me.CmbCombustible)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.CmbAno)
        Me.Controls.Add(Me.CmbEstilo)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtModelo)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.LblKilometraje)
        Me.Controls.Add(Me.LblTrasmision)
        Me.Controls.Add(Me.LblCombustible)
        Me.Controls.Add(Me.LblColor)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblAno)
        Me.Controls.Add(Me.LblEstilo)
        Me.Controls.Add(Me.LblCilindraje)
        Me.Controls.Add(Me.LblModelo)
        Me.Controls.Add(Me.LblMarca)
        Me.Name = "MantenimientoVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantenimientoVehiculos"
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblEstilo As Label
    Friend WithEvents LblCilindraje As Label
    Friend WithEvents LblCombustible As Label
    Friend WithEvents LblColor As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblAno As Label
    Friend WithEvents LblKilometraje As Label
    Friend WithEvents LblTrasmision As Label
    Friend WithEvents CmbMarca As ComboBox
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents CmbEstilo As ComboBox
    Friend WithEvents CmbAno As ComboBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents CmbCombustible As ComboBox
    Friend WithEvents CmbTrasmision As ComboBox
    Friend WithEvents TxtCilindraje As TextBox
    Friend WithEvents TxtKilometraje As TextBox
    Friend WithEvents LlbEjemploModelo As Label
    Friend WithEvents LblCc As Label
    Friend WithEvents LblColones As Label
    Friend WithEvents LblKms As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents gridVehiculos As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LblMarca As Label
    Friend WithEvents BtnBusqueda As Button
End Class
