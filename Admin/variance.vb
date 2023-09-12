Imports MySql.Data.MySqlClient
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Public Class variance
    Private Sub variance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductSummary()
    End Sub
    Private Sub LoadProductSummary()
        Try
            Dim query As String = "SELECT * FROM ProductSummary"
            Dim dt As New DataTable()

            connect = connector()
            Using connect
                connect.Open()

                Using adapter As New MySqlDataAdapter(query, connect)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Add the 'Variances' column and calculate values
            dt.Columns.Add("Variances", GetType(Integer))
            For Each row As DataRow In dt.Rows
                Dim stockLevel As Integer = Convert.ToInt32(row("Stock Level"))
                Dim stockCount As Integer = Convert.ToInt32(row("Stock Count"))

                Dim variances As Integer = stockCount - stockLevel
                row("Variances") = variances
            Next

            dgvvar.DataSource = dt

            ' Set columns as read-only
            For Each column As DataGridViewColumn In dgvvar.Columns
                column.ReadOnly = True
            Next

            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tnPdf_Click(sender As Object, e As EventArgs) Handles tnPdf.Click

        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.Title = "Save PDF File"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim pdfPath As String = saveFileDialog.FileName
                Dim pdfDocument As New PdfDocument()
                Dim pdfPage As PdfPage = pdfDocument.AddPage()

                pdfPage.Orientation = PageOrientation.Landscape

                Dim gfx As XGraphics = XGraphics.FromPdfPage(pdfPage)
                Dim font As New XFont("Arial", 12)

                Dim headerFont As New XFont("Arial", 18, XFontStyle.Bold)
                Dim headerText As String = "Group 3 sub 11 - Inventory and Report Variance"
                Dim headerSize = gfx.MeasureString(headerText, headerFont)
                Dim headerX = (pdfPage.Width.Point - headerSize.Width) / 2
                gfx.DrawString(headerText, headerFont, XBrushes.Black, headerX, 10)

                Dim xPosition As Double = 10
                Dim yPosition As Double = 50

                For Each column As DataGridViewColumn In dgvvar.Columns
                    gfx.DrawString(column.HeaderText, font, XBrushes.Black, xPosition, yPosition)
                    xPosition += 100
                Next

                yPosition += 20

                For Each row As DataGridViewRow In dgvvar.Rows
                    xPosition = 10

                    For Each cell As DataGridViewCell In row.Cells
                        gfx.DrawString(cell.Value.ToString(), font, XBrushes.Black, xPosition, yPosition)
                        xPosition += 100
                    Next

                    yPosition += 20
                Next

                pdfDocument.Save(pdfPath)
                pdfDocument.Close()

                MessageBox.Show("Data exported to PDF successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


End Class