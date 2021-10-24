Public Class MantenimientoVehiculo
    Dim Marca = {"Honda", "Hyundai", "Mitsubishi", "BMW", "Mercedes Benz", "Audi", "Land Rover", "Volvo", "KIA", "Lexus"}
    Dim Estilo = {"Urbano", "Subcompacto", "Familiar", "Compacto", "Sedán", "Coupe", "Descapotable", "Deportivo", "4x4"}
    Dim Ano = {"1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"}
    Dim Combustible = {"Gasolina", "Diesel", "Gas LP", "Electrico"}
    Dim Trasmision = {"Manual", "Automatica"}
    Dim listaVehiculo As New List(Of Vehiculo)

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
    
            Dim marca = CmbMarca.Text
            Dim modelo = TxtModelo.Text
            Dim cilindraje = TxtCilindraje.Text
            Dim estilo = CmbEstilo.Text
            Dim ano = CmbAno.Text
            Dim precio = TxtPrecio.Text
            Dim color = TxtColor.Text
            Dim combustible = CmbCombustible.Text
            Dim trasmision = CmbTrasmision.Text
            Dim kilometraje = TxtKilometraje.Text


            If String.IsNullOrEmpty(marca) Then
                MessageBox.Show("Debe colocar una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim objVehiculo As New Vehiculo
                objVehiculo.marca = marca
                objVehiculo.modelo = modelo
                objVehiculo.cilindraje = cilindraje
                objVehiculo.estilo = estilo
                objVehiculo.ano = ano
                objVehiculo.precio = precio
                objVehiculo.color = color
                objVehiculo.combustible = combustible
                objVehiculo.trasmision = trasmision
                objVehiculo.kilometraje = kilometraje


                listaVehiculo.Add(objVehiculo)


                CargarTabla()

            End If

        Catch ex As Exception

            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CargarTabla()
        Try
            Dim tabla As New DataTable


            tabla.Columns.Add("Marca")
            tabla.Columns.Add("Modelo")
            tabla.Columns.Add("Cilindraje")
            tabla.Columns.Add("Estilo")
            tabla.Columns.Add("Año")
            tabla.Columns.Add("Precio")
            tabla.Columns.Add("Color")
            tabla.Columns.Add("Combustible")
            tabla.Columns.Add("Trasmisión")
            tabla.Columns.Add("Kilometraje")

            If listaVehiculo.Count > 0 Then

                For Each objeto As Vehiculo In listaVehiculo
                    tabla.Rows.Add(objeto.marca, objeto.modelo, objeto.cilindraje, objeto.estilo, objeto.ano, objeto.precio, objeto.color, objeto.combustible, objeto.trasmision, objeto.kilometraje)

                Next

                gridVehiculos.DataSource = tabla
                gridVehiculos.Visible = True


            Else
                tabla.Rows.Clear()
                gridVehiculos.Visible = False
                MessageBox.Show("No hay valores en la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MantenimientoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbMarca.Items.AddRange(Marca)
        CmbMarca.SelectedIndex = 0

        CmbEstilo.Items.AddRange(Estilo)
        CmbEstilo.SelectedIndex = 0

        CmbAno.Items.AddRange(Ano)
        CmbAno.SelectedIndex = 0

        CmbCombustible.Items.AddRange(Combustible)
        CmbCombustible.SelectedIndex = 0

        CmbTrasmision.Items.AddRange(Trasmision)
        CmbTrasmision.SelectedIndex = 0


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBusqueda.Click

        Busqueda.listaVehiculo = listaVehiculo
        Busqueda.ShowDialog()


    End Sub
End Class