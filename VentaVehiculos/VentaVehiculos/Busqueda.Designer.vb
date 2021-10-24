<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda
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
        Me.CmbAno = New System.Windows.Forms.ComboBox()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.gridVehiculos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbAno
        '
        Me.CmbAno.FormattingEnabled = True
        Me.CmbAno.Location = New System.Drawing.Point(99, 84)
        Me.CmbAno.Name = "CmbAno"
        Me.CmbAno.Size = New System.Drawing.Size(105, 24)
        Me.CmbAno.TabIndex = 9
        '
        'CmbMarca
        '
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(99, 40)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(192, 24)
        Me.CmbMarca.TabIndex = 7
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.Location = New System.Drawing.Point(12, 84)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(37, 17)
        Me.LblAno.TabIndex = 8
        Me.LblAno.Text = "Año:"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(12, 40)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(51, 17)
        Me.LblMarca.TabIndex = 6
        Me.LblMarca.Text = "Marca:"
        '
        'gridVehiculos
        '
        Me.gridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVehiculos.Location = New System.Drawing.Point(12, 127)
        Me.gridVehiculos.Name = "gridVehiculos"
        Me.gridVehiculos.RowHeadersWidth = 51
        Me.gridVehiculos.RowTemplate.Height = 24
        Me.gridVehiculos.Size = New System.Drawing.Size(536, 150)
        Me.gridVehiculos.TabIndex = 14
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(352, 56)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 15
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 299)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.gridVehiculos)
        Me.Controls.Add(Me.CmbAno)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.LblAno)
        Me.Controls.Add(Me.LblMarca)
        Me.Name = "Busqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbAno As ComboBox
    Friend WithEvents CmbMarca As ComboBox
    Friend WithEvents LblAno As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents gridVehiculos As DataGridView
    Friend WithEvents BtnBuscar As Button
End Class
