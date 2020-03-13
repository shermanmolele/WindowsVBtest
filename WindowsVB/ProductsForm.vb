Imports System.Data.SqlClient
Public Class ProductsForm
    Dim MyConnection As SqlConnection = New SqlConnection("Data Source=DESKTOP-D6Q6V6I\SQLEXPRESS;Initial Catalog=bikeStore;Integrated Security=True")
    Dim adapter As New SqlDataAdapter()
    Dim dataSet As DataSet = New DataSet()
    Dim reader As SqlDataReader


    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim insertquery As String
        insertquery = "select Max(product_id) from production.products"
        Dim cmd As New SqlCommand(insertquery, MyConnection)
        MyConnection.Open()

        reader = cmd.ExecuteReader

        If (reader.Read) Then
            If (IsDBNull(reader(0))) Then
                TextproductId.Text = "1"
            Else
                TextproductId.Text = reader(0) + 1
            End If
            TextProductName.Clear()
            TextBandId.Clear()
            TextcategoryId.Clear()
            TextListPrice.Clear()
            TextModelYear.Clear()
        End If
        MyConnection.Close()

    End Sub


    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet1.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.BikeStoreDataSet1.products)
        DataGridView1.EditMode = False
        Dim MyConnection As SqlConnection = New SqlConnection("Data Source=DESKTOP-D6Q6V6I\SQLEXPRESS;Initial Catalog=bikeStore;Integrated Security=True")
        MyConnection.Open()


    End Sub

    Private Sub loadGrid()
        Dim access As String
        access = "select * from production.products"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(access, MyConnection)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim cmd As New SqlCommand("delete from production.products where product_id=" & TextproductId.Text & " ", MyConnection)
        MyConnection.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record is deleted")
        loadGrid()
        TextProductName.Clear()
        TextproductId.Clear()
        TextBandId.Clear()
        TextcategoryId.Clear()
        TextListPrice.Clear()
        TextModelYear.Clear()
        MyConnection.Close()

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim updatequery As String
        updatequery = "UPDATE production.products SET product_name = '" & TextProductName.Text & "', brand_id ='" & TextBandId.Text & "' , category_id ='" & TextcategoryId.Text & " ', model_year ='" & TextModelYear.Text & "', list_price ='" & TextListPrice.Text & "' where product_id =" & TextproductId.Text & ""
        Dim cmd As New SqlCommand(updatequery, MyConnection)
        MyConnection.Open()
        cmd.ExecuteNonQuery()
        loadGrid()

        TextproductId.Clear()
        TextProductName.Clear()
        TextBandId.Clear()
        TextcategoryId.Clear()
        TextListPrice.Clear()
        TextModelYear.Clear()
        MyConnection.Close()

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        Try
            TextproductId.Text = DataGridView1.Item(0, i).Value
            TextProductName.Text = DataGridView1.Item(1, i).Value
            TextBandId.Text = DataGridView1.Item(2, i).Value
            TextcategoryId.Text = DataGridView1.Item(3, i).Value
            TextModelYear.Text = DataGridView1.Item(4, i).Value
            TextListPrice.Text = DataGridView1.Item(5, i).Value
            MyConnection.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim insertquery As String
        insertquery = "SET IDENTITY_INSERT production.products ON insert into production.products(product_id,product_name,brand_id,category_id,model_year,list_price) Values('" & TextproductId.Text.Trim() & " ', '" & TextProductName.Text.Trim() & "','" & TextBandId.Text.Trim() & "','" & TextcategoryId.Text.Trim() & "','" & TextModelYear.Text.Trim() & "', '" & TextListPrice.Text.Trim() & "')"
        Dim cmd As New SqlCommand(insertquery, MyConnection)
        cmd.Connection = MyConnection
        cmd.CommandText = insertquery
        MyConnection.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record Successfully Saved")
        loadGrid()
        TextproductId.Clear()
        TextProductName.Clear()
        TextBandId.Clear()
        TextcategoryId.Clear()
        TextListPrice.Clear()
        TextModelYear.Clear()
        MyConnection.Close()


    End Sub
End Class