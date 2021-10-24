Public Class Busqueda

    Dim Marca = {"Honda", "Hyundai", "Mitsubishi", "BMW", "Mercedes Benz", "Audi", "Land Rover", "Volvo", "KIA", "Lexus"}
    Dim Ano = {"1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"}

    Public listaVehiculo As New List(Of Vehiculo)

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Try
            Dim tabla As New DataTable
            Dim marca = CmbMarca.Text
            Dim ano = CmbAno.Text


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

            Dim ListaFiltrada As New List(Of Vehiculo)
            If marca <> "" And ano <> "" Then
                ListaFiltrada = listaVehiculo.Where(Function(veh) veh.marca = marca And veh.ano = ano).ToList()


            ElseIf marca <> "" Then

                ListaFiltrada = listaVehiculo.Where(Function(veh) veh.marca = marca).ToList()

            ElseIf ano <> "" Then

                ListaFiltrada = listaVehiculo.Where(Function(veh) veh.ano = ano).ToList()

            End If


            If ListaFiltrada.Count > 0 Then

                For Each objeto As Vehiculo In ListaFiltrada
                    tabla.Rows.Add(objeto.marca, objeto.modelo, objeto.cilindraje, objeto.estilo, objeto.ano, objeto.precio, objeto.color, objeto.combustible, objeto.trasmision, objeto.kilometraje)

                Next

                gridVehiculos.DataSource = tabla
                gridVehiculos.Visible = True


            Else
                tabla.Rows.Clear()
                gridVehiculos.Visible = False
                MessageBox.Show("No hay vehiculos con esos criterios de busqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbMarca.Items.AddRange(Marca)
        CmbAno.Items.AddRange(Ano)

    End Sub
End Class