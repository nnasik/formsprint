Imports System.ComponentModel
Imports System.IO

Public Class Form_Gen_185_Config
    Dim folderPath As String = "C:\FormPrint\Config"
    Dim configDictionary As New Dictionary(Of String, String)()

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Create the folder if it does not exist
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim configData As String = "Document Width=" & num_doc_width.Value.ToString & vbNewLine &
            "Document Height=" & num_doc_height.Value.ToString & vbNewLine &
            "X Offset=" & num_x_offset.Value.ToString & vbNewLine &
            "Y Offset=" & num_y_offset.Value.ToString & vbNewLine &
            "Establishment=" & txt_establishment.Text & vbNewLine &
            "Establishment X=" & num_establishment_x.Value.ToString & vbNewLine &
            "Establishment Y=" & num_establishment_y.Value.ToString & vbNewLine &
            "Date Format=" & txt_date_format.Text & vbNewLine &
            "Date X=" & num_date_x.Value & vbNewLine &
            "Date Y=" & num_date_y.Value & vbNewLine &
            "Page 1 Line Height=" & num_page_1_line_height.Value & vbNewLine &
            "Page 1 Name X=" & num_page_1_name_x.Value & vbNewLine &
            "Page 1 Name Y=" & num_page_1_name_y.Value & vbNewLine &
            "Page 1 Increment Amount X=" & num_page_1_increment_amount_x.Value & vbNewLine &
            "Page 1 Increment Amount Y=" & num_page_1_increment_amount_y.Value & vbNewLine &
            "Page 1 Date X=" & num_page_1_date_x.Value & vbNewLine &
            "Page 1 Date Y=" & num_page_1_date_y.Value & vbNewLine &
            "Page 1 Basic X=" & num_page_1_basic_x.Value & vbNewLine &
            "Page 1 Basic Y=" & num_page_1_basic_y.Value & vbNewLine &
            "Page 1 Increment X=" & num_page_1_increment_x.Value & vbNewLine &
            "Page 1 Increment Y=" & num_page_1_increment_y.Value & vbNewLine &
            "Page 1 Basic + Increment X=" & num_page_1_basic_plus_increment_x.Value & vbNewLine &
            "Page 1 Basic + Increment Y=" & num_page_1_basic_plus_increment_y.Value & vbNewLine &
            "Page 2 Line Height=" & num_page_2_line_height.Value & vbNewLine &
            "Page 2 Name X=" & num_page_2_name_x.Value & vbNewLine &
            "Page 2 Name Y=" & num_page_2_name_y.Value & vbNewLine &
            "Page 2 Increment Amount X=" & num_page_2_increment_amount_x.Value & vbNewLine &
            "Page 2 Increment Amount Y=" & num_page_2_increment_amount_y.Value & vbNewLine &
            "Page 2 Date X=" & num_page_2_date_x.Value & vbNewLine &
            "Page 2 Date Y=" & num_page_2_date_y.Value & vbNewLine &
            "Page 2 Basic X=" & num_page_2_basic_x.Value & vbNewLine &
            "Page 2 Basic Y=" & num_page_2_basic_y.Value & vbNewLine &
            "Page 2 Increment X=" & num_page_2_increment_x.Value & vbNewLine &
            "Page 2 Increment Y=" & num_page_2_increment_y.Value & vbNewLine &
            "Page 2 Basic + Increment X=" & num_page_2_basic_plus_increment_x.Value & vbNewLine &
            "Page 2 Basic + Increment Y=" & num_page_2_basic_plus_increment_x.Value & vbNewLine

        Dim configFilePath As String = Path.Combine(folderPath, "config_gen_185.txt")

        Try
            ' Save the configuration data to the file
            File.WriteAllText(configFilePath, configData)
            Form_Gen_185.Show()
            Me.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form_Gen_185_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim configFilePath As String = Path.Combine(folderPath, "config_gen_185.txt")
        ' Check if the configuration file exists
        ' Check if the configuration file exists
        If File.Exists(configFilePath) Then
            ' Read all lines from the configuration file
            Dim configLines As String() = File.ReadAllLines(configFilePath)

            ' Process each line
            For Each line As String In configLines
                Dim settingParts As String() = line.Split("="c)
                If settingParts.Length = 2 Then
                    Dim settingName As String = settingParts(0).Trim()
                    Dim settingValue As String = settingParts(1).Trim()

                    ' Load the settings into appropriate controls or variables
                    ' Example: Display the settings in a ListBox (you can change this as needed)
                    configDictionary.Add(settingName, settingValue)
                End If
            Next
        Else
            MessageBox.Show("Configuration file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        num_doc_width.Value = Val(configDictionary("Document Width"))
        num_doc_height.Value = Val(configDictionary("Document Height"))
        num_x_offset.Value = Val(configDictionary("X Offset"))
        num_y_offset.Value = Val(configDictionary("Y Offset"))
        txt_establishment.Text = configDictionary("Establishment")
        num_establishment_x.Value = Val(configDictionary("Establishment X"))
        num_establishment_y.Value = Val(configDictionary("Establishment Y"))
        txt_date_format.Text = configDictionary("Date Format")
        num_date_x.Value = Val(configDictionary("Date X"))
        num_date_y.Value = Val(configDictionary("Date Y"))
        ' Page 1
        num_page_1_line_height.Value = Val(configDictionary("Page 1 Line Height"))
        num_page_1_name_x.Value = Val(configDictionary("Page 1 Name X"))
        num_page_1_name_y.Value = Val(configDictionary("Page 1 Name Y"))
        num_page_1_increment_amount_x.Value = Val(configDictionary("Page 1 Increment Amount X"))
        num_page_1_increment_amount_y.Value = Val(configDictionary("Page 1 Increment Amount Y"))
        num_page_1_date_x.Value = Val(configDictionary("Page 1 Date X"))
        num_page_1_date_y.Value = Val(configDictionary("Page 1 Date Y"))
        num_page_1_basic_x.Value = Val(configDictionary("Page 1 Basic X"))
        num_page_1_basic_y.Value = Val(configDictionary("Page 1 Basic Y"))
        num_page_1_increment_x.Value = Val(configDictionary("Page 1 Increment X"))
        num_page_1_increment_y.Value = Val(configDictionary("Page 1 Increment Y"))
        num_page_1_basic_plus_increment_x.Value = Val(configDictionary("Page 1 Basic + Increment X"))
        num_page_1_basic_plus_increment_y.Value = Val(configDictionary("Page 1 Basic + Increment Y"))
        ' Page 2
        num_page_2_line_height.Value = Val(configDictionary("Page 2 Line Height"))
        num_page_2_name_x.Value = Val(configDictionary("Page 2 Name X"))
        num_page_2_name_y.Value = Val(configDictionary("Page 2 Name Y"))
        num_page_2_increment_amount_x.Value = Val(configDictionary("Page 2 Increment Amount X"))
        num_page_2_increment_amount_y.Value = Val(configDictionary("Page 2 Increment Amount Y"))
        num_page_2_date_x.Value = Val(configDictionary("Page 2 Date X"))
        num_page_2_date_y.Value = Val(configDictionary("Page 2 Date Y"))
        num_page_2_basic_x.Value = Val(configDictionary("Page 2 Basic X"))
        num_page_2_basic_y.Value = Val(configDictionary("Page 2 Basic Y"))
        num_page_2_increment_x.Value = Val(configDictionary("Page 2 Increment X"))
        num_page_2_increment_y.Value = Val(configDictionary("Page 2 Increment Y"))
        num_page_2_basic_plus_increment_x.Value = Val(configDictionary("Page 2 Basic + Increment X"))
        num_page_2_basic_plus_increment_y.Value = Val(configDictionary("Page 2 Basic + Increment Y"))



    End Sub

    Private Sub Form_Gen_185_Config_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form_Gen_185.Show()

    End Sub
End Class