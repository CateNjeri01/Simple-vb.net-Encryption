Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Timers
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Data.OleDb
Public Class frm_Initial
    Dim conncheck As Boolean = False

    Dim con As New SqlConnection

    Dim con_oledb As New OleDbConnection

    Dim com_oledb As New OleDbCommand

    Dim com As New SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

    Dim oledb_insert_DR As OleDbDataReader

    Dim constr As String = initialnetworktester()

    Dim user_id As Integer = 1

    Dim connection As String = "Provider=Microsoft.Jet.OleDB.4.0; Data Source=|DataDirectory|\infinitum.mdb; Jet OLEDB:Database Password=kagumo;"

    Private Sub frm_Initial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Getting the mdf connection using OLEDB
    Sub oledbdbConnect(ByVal comstr As String)

        Try

            con_oledb = New OleDbConnection(connection)
            com_oledb = New OleDbCommand(comstr, con_oledb)

        Catch ex As Exception

            Dim error_log As String = "Error retrieving oledb:::   " & ex.Message

        End Try

    End Sub
    'Getting sql connection 
    Sub dbConnect(ByVal comstr As String)

        Try
            Dim constr As String = initialnetworktester()

            con = New SqlConnection(constr)

            com = New SqlCommand(comstr, con)

        Catch ex As Exception

            Dim error_log As String = "Error sql  connector:::   " & ex.Message

        End Try

    End Sub

    Dim s_name, u_name, pass, catalog, serverconstring As String
    'setting sql connection from the infinitum mdf
    Public Sub setconnector()

        Try
            Dim id As String = "1"

            Dim m_com_string As String = "select server_name, user_name, user_password, initial_catalog from tblconn where ID =" + "'" + id + "'" + ""

            oledbdbConnect(m_com_string)

            con_oledb.Open()

            oledb_insert_DR = com_oledb.ExecuteReader

            While oledb_insert_DR.Read()

                s_name = oledb_insert_DR.GetValue(0).ToString

                u_name = oledb_insert_DR.GetValue(1).ToString

                pass = oledb_insert_DR.GetValue(2).ToString

                catalog = oledb_insert_DR.GetValue(3).ToString

                serverconstring = "Data Source=" + s_name + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + u_name + "; Password=" + pass + ""

                ' mic_events_logger(serverconstring)

            End While

            oledb_insert_DR.Close()

            con_oledb.Close()

        Catch ex As Exception

        End Try

    End Sub
    'getting the initial connector of the database
    Dim retrievedconnector As String
    Dim testednetworkconnector As String
    Public Function initialnetworktester()

        Try
            setconnector()

            retrievedconnector = serverconstring

            Using sqlconnector As New SqlConnection(retrievedconnector)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then

                    conncheck = True
                    testednetworkconnector = retrievedconnector

                Else
                    conncheck = False
                End If

            End Using

        Catch ex As Exception
            conncheck = False

        Finally
            con.Close()
        End Try

        Return retrievedconnector

    End Function


    'Routine to insert the plaintext and cipher text to sql database
    Public Sub inferclass()

        Dim comstr As String = testednetworkconnector
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty

        Try


            conn = New SqlConnection(comstr)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO dbo.tbl_encryption (  plaintext, ciphertext) Values (  @plaintext, @ciphertext)"

            cmd.Parameters.Add("@plaintext", SqlDbType.NVarChar).Value = txt_plainTest
            cmd.Parameters.Add("@ciphertext", SqlDbType.NVarChar).Value = txt_encryptedText

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()

        Catch ex As Exception

            MsgBox(" error Inserting to db", ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        inferclass()
    End Sub



    'function to encrypt the text
    Function encrypt(ByVal key As String, ByVal plaintext As String)
        Dim cipherText As String = ""
        Dim currpos As Integer = 0
        Dim length, skip As Integer

        Do
            length = plaintext.Length()


            skip = CInt(Math.Ceiling(Rnd() * 3))

            currpos += skip

            cipherText = plaintext.Substring(0, currpos) + key + plaintext.Substring(currpos)
            currpos += key.Length()

            plaintext = cipherText

        Loop While (currpos < (length - 1))

        Return plaintext
    End Function
    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        Dim plainText As String = txt_plainTest.Text
        txt_encryptedText.Text = encrypt("PIX", plainText)
    End Sub
    'function to decrypt text
    Function decrypt(ByVal decryptedtext As String)
        Dim ciphertext As String = txt_encryptedText.Text

        decryptedtext = ciphertext.Replace("PIX", "")
        Return decryptedtext
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_decryptedtext.Text = decrypt(txt_encryptedText.Text)
    End Sub
End Class
