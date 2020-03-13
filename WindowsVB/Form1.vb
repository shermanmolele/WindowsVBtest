Imports System.Data.SqlClient

Public Class Form1

    Dim MyConnection As SqlConnection = New SqlConnection("Data Source=DESKTOP-D6Q6V6I\SQLEXPRESS;Initial Catalog=bikeStore;Integrated Security=True")
    Dim adapter As New SqlDataAdapter()
    Dim dataSet As DataSet = New DataSet()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.BikeStoreDataSet.products)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adapter.SelectCommand = New SqlCommand()
        adapter.SelectCommand.Connection = MyConnection
        adapter.SelectCommand.CommandText = "Select first_name From sales.staffs WHERE first_name ='" & TextBox1.Text & "'"

        MyConnection.Open()
        Dim results As String

        results = adapter.SelectCommand.ExecuteScalar()
        MyConnection.Close()





        If results = TextBox1.Text Then
            MsgBox("you're loggen in")
            Dim products = ProductsForm
            products.Show()
            Me.Hide()
        Else
            MsgBox("wrong credentials")


        End If


    End Sub
End Class
