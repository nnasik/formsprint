Imports System.Drawing.Printing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Gen_185

    Dim folderPath As String = "C:\FormPrint\Config"
    Dim configDictionary As New Dictionary(Of String, String)()

    Dim doc_width As Integer
    Dim doc_height As Integer
    Dim x_offset As Integer
    Dim y_offset As Integer
    Dim establishment As String
    Dim establishment_x As Integer
    Dim establishment_y As Integer
    Dim date_format As String
    Dim date_x As Integer
    Dim date_y As Integer
    ' Page 1
    Dim page_1_line_height As Integer
    Dim page_1_name_x As Integer
    Dim page_1_name_y As Integer
    Dim page_1_increment_amount_x As Integer
    Dim page_1_increment_amount_y As Integer
    Dim page_1_date_x As Integer
    Dim page_1_date_y As Integer
    Dim page_1_basic_x As Integer
    Dim page_1_basic_y As Integer
    Dim page_1_increment_x As Integer
    Dim page_1_increment_y As Integer
    Dim page_1_basic_plus_increment_x As Integer
    Dim page_1_basic_plus_increment_y As Integer
    ' Page 2
    Dim page_2_line_height As Integer
    Dim page_2_name_x As Integer
    Dim page_2_name_y As Integer
    Dim page_2_increment_amount_x As Integer
    Dim page_2_increment_amount_y As Integer
    Dim page_2_date_x As Integer
    Dim page_2_date_y As Integer
    Dim page_2_basic_x As Integer
    Dim page_2_basic_y As Integer
    Dim page_2_increment_x As Integer
    Dim page_2_increment_y As Integer
    Dim page_2_basic_plus_increment_x As Integer
    Dim page_2_basic_plus_increment_y As Integer
    Private Sub Form_Gen_185_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate the ComboBox with installed printers
        For Each printer As String In PrinterSettings.InstalledPrinters
            cb_printers.Items.Add(printer)
        Next

        ' Set the ComboBox to the default printer
        cb_printers.SelectedItem = (New PrinterSettings()).PrinterName

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

        doc_width = Val(configDictionary("Document Width"))
        doc_height = Val(configDictionary("Document Height"))
        x_offset = Val(configDictionary("X Offset"))
        y_offset = Val(configDictionary("Y Offset"))
        establishment = configDictionary("Establishment")
        txt_establishment.Text = establishment
        establishment_x = Val(configDictionary("Establishment X"))
        establishment_y = Val(configDictionary("Establishment Y"))
        date_format = configDictionary("Date Format")
        date_x = Val(configDictionary("Date X"))
        date_y = Val(configDictionary("Date Y"))
        ' Page 1
        page_1_line_height = Val(configDictionary("Page 1 Line Height"))
        page_1_name_x = Val(configDictionary("Page 1 Name X"))
        page_1_name_y = Val(configDictionary("Page 1 Name Y"))
        page_1_increment_amount_x = Val(configDictionary("Page 1 Increment Amount X"))
        page_1_increment_amount_y = Val(configDictionary("Page 1 Increment Amount Y"))
        page_1_date_x = Val(configDictionary("Page 1 Date X"))
        page_1_date_y = Val(configDictionary("Page 1 Date Y"))
        page_1_basic_x = Val(configDictionary("Page 1 Basic X"))
        page_1_basic_y = Val(configDictionary("Page 1 Basic Y"))
        page_1_increment_x = Val(configDictionary("Page 1 Increment X"))
        page_1_increment_y = Val(configDictionary("Page 1 Increment Y"))
        page_1_basic_plus_increment_x = Val(configDictionary("Page 1 Basic + Increment X"))
        page_1_basic_plus_increment_y = Val(configDictionary("Page 1 Basic + Increment Y"))
        ' Page 2
        page_2_line_height = Val(configDictionary("Page 2 Line Height"))
        page_2_name_x = Val(configDictionary("Page 2 Name X"))
        page_2_name_y = Val(configDictionary("Page 2 Name Y"))
        page_2_increment_amount_x = Val(configDictionary("Page 2 Increment Amount X"))
        page_2_increment_amount_y = Val(configDictionary("Page 2 Increment Amount Y"))
        page_2_date_x = Val(configDictionary("Page 2 Date X"))
        page_2_date_y = Val(configDictionary("Page 2 Date Y"))
        page_2_basic_x = Val(configDictionary("Page 2 Basic X"))
        page_2_basic_y = Val(configDictionary("Page 2 Basic Y"))
        page_2_increment_x = Val(configDictionary("Page 2 Increment X"))
        page_2_increment_y = Val(configDictionary("Page 2 Increment Y"))
        page_2_basic_plus_increment_x = Val(configDictionary("Page 2 Basic + Increment X"))
        page_2_basic_plus_increment_y = Val(configDictionary("Page 2 Basic + Increment Y"))

    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim name As String = InputBox("Officer Name & Designation :")
        Dim basic_salary As Single = InputBox("Basic Salary :")
        Dim increment As Single = InputBox("Incement Amount :")
        Dim increment_date As String = InputBox("Incement Date :")

        Dim root = New TreeNode(name + " ; " + increment.ToString("N2") + " ; " + increment_date)
        root.Nodes.Add("Basic Salary : " + basic_salary.ToString("N2"))
        root.Nodes.Add("Increment : " + increment.ToString("N2"))
        root.Nodes.Add("Salary + Increment : " + (basic_salary + increment).ToString("N2"))
        tw_contents.Nodes.Add(root)

        tw_contents.ExpandAll()

    End Sub

    Private Sub btn_rem_Click(sender As Object, e As EventArgs) Handles btn_rem.Click
        If tw_contents.SelectedNode IsNot Nothing Then
            ' Remove the selected node
            Dim rootNode As TreeNode = GetRootNode(tw_contents.SelectedNode)
            ' Remove the root node
            tw_contents.Nodes.Remove(rootNode)
        Else
            MessageBox.Show("Please select a node to remove.", "No node selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Function to get the top-level parent node (root node)
    Private Function GetRootNode(node As TreeNode) As TreeNode
        ' Traverse up to the top-level parent node
        While node.Parent IsNot Nothing
            node = node.Parent
        End While
        Return node
    End Function

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If cb_printers.SelectedItem IsNot Nothing Then
            ' Set the printer to the selected printer from the ComboBox
            PrintDocument1.PrinterSettings.PrinterName = cb_printers.SelectedItem.ToString()

            ' Check if the selected printer is valid
            If PrintDocument1.PrinterSettings.IsValid Then
                ' Call the Print method to start the printing process
                Dim paperSize As New PaperSize("Custom", 671, 880)
                PrintDocument1.DefaultPageSettings.PaperSize = paperSize

                PrintDocument1.Print()
            Else
                MessageBox.Show("The selected printer is not valid.", "Invalid Printer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a printer from the list.", "No Printer Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Event handler() For the PrintPage Event
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Define the font to use
        Dim printFont As New Font("Times New Roman", 12)

        ' Define the text to print



        ' Draw the text on the print document
        ' Printing Establishment Name
        Dim establishment_name As String = txt_establishment.Text
        e.Graphics.DrawString(establishment_name, printFont, Brushes.Black, 60, 260)

        ' Printing Date
        Dim print_date As String = dtp_date.Value.ToString(date_format)
        e.Graphics.DrawString(print_date, printFont, Brushes.Black, 120, 320)

        Dim node_count As Integer = 0
        Dim rootNodeCount As Integer = tw_contents.Nodes.Count
        For Each rootNode As TreeNode In tw_contents.Nodes
            Dim result As String() = rootNode.Text.Split(";")
            ' Officer Name
            e.Graphics.DrawString((node_count + 1).ToString + ") " + result(0), printFont, Brushes.Black, page_1_name_x + x_offset, node_count * page_1_line_height + page_1_name_y + y_offset)
            ' Increment Amount
            e.Graphics.DrawString(result(1), printFont, Brushes.Black, page_1_increment_amount_x + x_offset, node_count * page_1_line_height + page_1_increment_amount_y + y_offset)
            ' Increment Date
            e.Graphics.DrawString(result(2), printFont, Brushes.Black, page_1_date_x + x_offset, node_count * page_1_line_height + page_1_date_y + y_offset)

            ' Basic Salary Text
            e.Graphics.DrawString("   Basic Salary", printFont, Brushes.Black, page_1_name_x + x_offset, node_count * page_1_line_height + page_1_basic_y + y_offset)
            ' Basic Salary Amount


            ' Increment Text
            e.Graphics.DrawString("   Increment", printFont, Brushes.Black, page_1_name_x + x_offset, node_count * page_1_line_height + page_1_increment_amount_y + y_offset)


            ' Salary + Increment
            e.Graphics.DrawString("   Salary + Increment", printFont, Brushes.Black, page_1_name_x + x_offset, node_count * page_1_line_height + page_1_basic_plus_increment_y + y_offset)

            ' copies

            node_count += 1
        Next
    End Sub

    Private Sub MeasurementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeasurementToolStripMenuItem.Click
        Form_Gen_185_Config.Show()
        Me.Close()

    End Sub
End Class