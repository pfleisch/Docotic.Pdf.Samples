Imports System.Diagnostics
Imports System.Drawing
Imports System.IO

Imports BitMiracle.Docotic.Pdf

Namespace BitMiracle.Docotic.Pdf.Samples
    Public NotInheritable Class SetXmpProperties
        Public Shared Sub Main()
            ' NOTE: 
            ' When used in trial mode, the library imposes some restrictions.
            ' Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            ' for more information.

            Using pdf As New PdfDocument()
                pdf.Metadata.DublinCore.Creators = New XmpArray(XmpArrayType.Ordered)
                pdf.Metadata.DublinCore.Creators.Values.Add(New XmpString("me"))
                pdf.Metadata.DublinCore.Creators.Values.Add(New XmpString("Docotic.Pdf"))

                pdf.Metadata.DublinCore.Format = New XmpString("application/pdf")

                pdf.Metadata.Pdf.Producer = New XmpString("me too!")

                Dim pathToFile As String = "SetXmpProperties.pdf"
                pdf.Save(pathToFile)
                Process.Start(pathToFile)
            End Using
        End Sub
    End Class
End Namespace
